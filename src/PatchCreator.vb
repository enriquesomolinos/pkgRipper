Imports System.Text.RegularExpressions



Public Class PatchCreator

    Private Property contentId As String
    Private Property titleId As String
    Private Property title As String
    Private Property version As String
    Private Sub CalculateGameData(ByVal shellOutput As String)
        Dim titleArray As String()
        titleArray = shellOutput.Split(vbCrLf)
        For Each line In titleArray
            If (line.IndexOf("Content ID") > -1) Then
                contentId = Trim(line.ToString().Split(":")(1))
                Label2.Text = "Content ID: " + contentId

            ElseIf (line.IndexOf("Title ID") > -1) Then
                titleId = Trim(line.ToString().Split(":")(1))
                Label3.Text = "Title ID: " + titleId

            ElseIf (line.IndexOf("Title Name (default)") > -1) Then
                title = Trim(line.ToString().Split(":")(1))
                Label4.Text = "Title Name: " + title

            ElseIf (line.IndexOf("Application Version(APP_VER)") > -1) Then
                version = Trim(line.ToString().Split(":")(1))
                Label5.Text = "Version: " + version
                pkgVersion.Text = version
                updateRequiredVersion.Text = version

            End If


        Next


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        updateRequiredVersion.Text = ""

        Me.TextPkg.Text = OpenFileDialog1.FileName
        If (OpenFileDialog1.FileName.Equals("")) Then
            Return

        End If

        Dim shellOutput As String
        shellOutput = ShellRun("orbis-pub-cmd.exe img_info """ + Me.TextPkg.Text + """")
        'TextConsole.Text = TextConsole.Text & shellOutput
        CalculateGameData(shellOutput)

        shellOutput = ShellRun("orbis-pub-cmd.exe img_file_list --passcode 00000000000000000000000000000000 --oformat long """ + Me.TextPkg.Text + """")
        TreeView2.Nodes.Clear()
        For Each line In shellOutput.Split(vbLf)
            Dim lineArray As String()
            Dim lineArray2 As String()
            lineArray = line.Split(" ")
            If line.Contains("Image0") Then
                lineArray2 = Regex.Split(line, "Image0")
                line = Trim("Image0" + lineArray2.Last()).Replace(vbCr, "")
                lineArray = lineArray2(0).Split(" ")
            End If
            If line.Contains("Sc0") Then
                lineArray2 = Regex.Split(line, "Sc0")
                line = Trim("Sc0" + lineArray2.Last()).Replace(vbCr, "")
                lineArray = lineArray2(0).Split(" ")
            End If



            If line.Contains("/") = False And line.Equals("") = False Then
                Dim node As TreeNode
                node = TreeView2.Nodes.Add(line, line)

            Else
                'remove last name
                Dim pathParts As String()
                pathParts = line.Split("/")
                For index As Integer = pathParts.Length - 1 To 0 Step -1
                    Dim currentPath As String
                    currentPath = ""
                    For index2 As Integer = 0 To index
                        If currentPath.Equals("") Then
                            currentPath = pathParts(index2)
                        Else
                            currentPath = currentPath + "/" + pathParts(index2)
                        End If
                    Next

                    Dim findNode As TreeNode()
                    findNode = TreeView2.Nodes.Find(currentPath, True)
                    If findNode.Length = 0 Then

                    Else
                        Dim size As Double
                        Dim sizeString As String
                        sizeString = ""
                        If lineArray(0).Equals("F") Then
                            If (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024 * 1024 * 1024) Then
                                size = Convert.ToInt64(lineArray(lineArray.Length - 4)) / (1024 * 1024 * 1024)
                                sizeString = Math.Round(size, 1).ToString + " GB"
                            ElseIf (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024 * 1024) Then
                                size = (Convert.ToInt64(lineArray(lineArray.Length - 4))) / (1024 * 1024)
                                sizeString = Math.Round(size, 1).ToString + " MB"
                            ElseIf (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024) Then
                                size = (Convert.ToInt64(lineArray(lineArray.Length - 4))) / (1024)
                                sizeString = Math.Round(size, 1).ToString + " KB"
                            Else
                                size = (Convert.ToInt64(lineArray(lineArray.Length - 4)))
                                sizeString = Math.Round(size, 1).ToString + " B"
                            End If
                        End If

                        findNode(0).Nodes.Add(line, line.Replace(currentPath + "/", "") + " " + sizeString)
                        Exit For

                    End If
                Next
            End If



            ' If line.Contains("sce_sys") Or line.Contains("prx") Or line.Contains("Sc0") Or line.Contains(".") = False Or line.Contains("/") = False Then
            '
            '  Else
            ' ListBox2.Items.Add(line)
            ' End If

        Next

        MoveButton.Enabled = True
        UndoSelected.Enabled = True
        Button2.Enabled = True


    End Sub
    Public Function ShellRun(ByVal sCmd As String) As String

        Dim oShell As Object
        oShell = CreateObject("WScript.Shell")

        'run command
        Dim oExec As Object
        Dim oOutput As Object
        oExec = oShell.Exec(sCmd)
        oOutput = oExec.StdOut

        'handle the results as they are written to and read from the StdOut object
        Dim s As String
        Dim sLine As String
        While Not oOutput.AtEndOfStream
            sLine = oOutput.ReadLine
            If sLine <> "" Then s = s & sLine & vbCrLf
        End While

        ShellRun = s

    End Function

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub


    Private Sub reloadSavedSpace()
        Dim total As Double
        total = 0.0
        For Each item In ListBox1.Items

            Dim parts As String()
            parts = item.ToString.Split(" ")
            If (parts(parts.Length - 1) = "MB") Then
                total = total + parts(parts.Length - 2)
            ElseIf (parts(parts.Length - 1) = "GB") Then
                total = total + parts(parts.Length - 2) * 1024
            ElseIf (parts(parts.Length - 1) = "KB") Then
                total = total + parts(parts.Length - 2) / 1024
            ElseIf (parts(parts.Length - 1) = "B") Then
                total = total + parts(parts.Length - 2) / 1024 / 1024
            Else
                'directory
                Dim node As TreeNode
                node = SearchTreeViewElement(TreeView2.Nodes.Item(0), item.ToString())
                If (node IsNot Nothing) Then
                    Dim sum As Double
                    sum = 0.0
                    CalculateSum(node, sum)
                    total = total + sum
                End If
            End If


        Next
        Label1.Text = "Uncompressed saved space:" + total.ToString("0.00") + " MB"


    End Sub
    Private Sub CalculateSum(ByVal node As TreeNode, ByRef sum As Double)
        For Each Childnode As TreeNode In node.Nodes
            If Childnode.Nodes.Count > 0 Then
                CalculateSum(Childnode, sum)
            Else
                Dim parts As String()
                parts = Childnode.Text.ToString.Split(" ")
                If (parts(parts.Length - 1) = "MB") Then
                    sum = sum + parts(parts.Length - 2)
                ElseIf (parts(parts.Length - 1) = "GB") Then
                    sum = sum + parts(parts.Length - 2) * 1024
                ElseIf (parts(parts.Length - 1) = "KB") Then
                    sum = sum + parts(parts.Length - 2) / 1024
                ElseIf (parts(parts.Length - 1) = "B") Then
                    sum = sum + parts(parts.Length - 2) / 1024 / 1024
                End If
            End If
        Next

    End Sub
    Private Function SearchTreeViewElement(ByVal node As TreeNode, ByVal element As String) As TreeNode
        For Each Childnode As TreeNode In node.Nodes
            If Childnode.Name = Trim("Image0/" + element) Then
                Return Childnode
            End If
            If Childnode.Nodes.Count > 0 Then
                Dim result As TreeNode
                result = SearchTreeViewElement(Childnode, element)
                If (result IsNot Nothing) Then
                    Return result
                End If
            End If
        Next

    End Function


    Private Sub MoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveButton.Click


        Dim elements As ArrayList
        elements = New ArrayList()
        GetCheckedElements(TreeView2.Nodes.Item(0), elements)
        For Each element In elements
            element = element.ToString.Replace("Image0\", "").Replace(" \", "/").Replace(" \", "/")
            If ListBox1.Items.Contains(element) = False Then
                ListBox1.Items.Add(element)
            End If

        Next
        reloadSavedSpace()
    End Sub

    Private Sub GetCheckedElements(ByVal node As TreeNode, ByRef elements As ArrayList)
        For Each Childnode As TreeNode In node.Nodes
            If Childnode.Checked Then
                elements.Add(Childnode.FullPath)
            End If
            If Childnode.Nodes.Count > 0 Then
                GetCheckedElements(Childnode, elements)
            End If
        Next

    End Sub


    Private Sub UndoSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoSelected.Click
        For i As Integer = 0 To ListBox1.SelectedIndices.Count - 1
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Next
        reloadSavedSpace()
    End Sub

    Private Sub CreatePatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePatch.Click

        
        Dim finalFile As String
        finalFile = "patches/" + contentId + ".xml"


        Dim files(ListBox1.Items.Count) As XElement
        Dim i As Integer
        i = 0
        For Each item In ListBox1.Items
            Dim items As String()
            items = item.split(" ")
            item = ""
            If (items.Length < 3) Then
                item = items(0)
            Else
                For index As Integer = 0 To items.Length - 3
                    item = item + " " + items(index)
                Next
            End If
            files(i) = New XElement("file", New XAttribute("path", Trim(item)))
            i = i + 1

        Next
        Dim patchXml As New XElement("patch", _
                                New XAttribute("description", TextBox1.Text), _
                                New XAttribute("pkg_required_version", pkgVersion.Text), _
                                New XAttribute("update_version_required", updateRequiredVersion.Text), _
                                files _
                   )
        If My.Computer.FileSystem.FileExists(finalFile) Then
            Dim xml As XElement
            xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(finalFile))
            Dim xmlPatches As XElement
            xmlPatches = xml.<patches>(0)


            Dim found As Boolean
            found = False
            For Each patch In xml.<patches>.<patch>
                If (TextBox1.Text.Equals(patch.@description)) Then
                    found = True
                    Dim answer As Integer

                    answer = MsgBox("A patch with description " + TextBox1.Text + " was found. Do you want to overwrite it?", vbQuestion + vbYesNo + vbDefaultButton2, "Patch exists!")
                    If answer = vbYes Then
                        patch.Remove()
                    Else
                        Return
                    End If
                End If


            Next
            xmlPatches.Add(patchXml)
            xml.Save(finalFile)
        Else
            Dim xml1 As New XDocument(New XDeclaration("1.0", "UTF-8", "yes"), _
                    New XElement("pkgpatch", _
                    New XAttribute("id", 1), _
                    New XAttribute("year", 2004), _
                    New XAttribute("salar", "1")))

            Dim rootXml As New XDocument(New XDeclaration("1.0", "UTF-8", "yes"), _
                       New XElement("pkgpatch", _
                                    New XElement("patchInfo", _
                                                New XAttribute("description", ""), _
                                                New XAttribute("title_id", titleId), _
                                                New XAttribute("content_id", contentId)), _
                                    New XElement("patches", _
                                                   patchXml _
                                                ) _
                       ))

            rootXml.Save(finalFile)

        End If
        MessageBox.Show("The patch has been added to your patches directory. Now you can apply to your fpkg",
                       "Patch added")



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()

    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        If (OpenFileDialog2.FileName.Equals("")) Then
            Return

        End If

        Dim shellOutput As String
        shellOutput = ShellRun("orbis-pub-cmd.exe img_info """ + OpenFileDialog2.FileName + """")
        'TextConsole.Text = TextConsole.Text & shellOutput
        Dim titleArray As String()

        titleArray = shellOutput.Split(vbCrLf)
        For Each line In titleArray
            If (line.IndexOf("Application Version(APP_VER)") > -1) Then
                version = Trim(line.ToString().Split(":")(1))
                updateRequiredVersion.Text = version
                TextBox1.Text = "Duplicated Content from update " + version
            End If


        Next


        shellOutput = ShellRun("orbis-pub-cmd.exe img_file_list --passcode 00000000000000000000000000000000 --oformat long   """ + OpenFileDialog2.FileName + """")
        For Each line In shellOutput.Split(vbLf)
            Dim lineArray As String()
            Dim lineArray2 As String()
            lineArray = line.Split(" ")
            If line.Contains("Image0") Then
                lineArray2 = Regex.Split(line, "Image0")
                line = Trim("Image0" + lineArray2.Last()).Replace(vbCr, "")
                lineArray = lineArray2(0).Split(" ")
            End If
            If line.Contains("Sc0") Then
                lineArray2 = Regex.Split(line, "Sc0")
                line = Trim("Sc0" + lineArray2.Last()).Replace(vbCr, "")
                lineArray = lineArray2(0).Split(" ")
            End If


            If IsNothing(TreeView2.Nodes.Find(line, True)) = False And TreeView2.Nodes.Find(line, True).Length > 0 Then
                If TreeView2.Nodes.Find(line, True)(0).Nodes.Count = 0 Then
                    If line.Contains("sce_sys") Or line.Contains(".prx") Or line.StartsWith("Image0/sce") Or _
                      line.Contains("eboot.bin") Or line.Contains("Sc0") Or line.Contains(".sce") Or line.Contains("sce_modules") Then
                    Else
                        line = line.Replace("Image0/", "").Replace("Image0\", "")
                        If ListBox1.Items.Contains(line) Then
                        Else
                            Dim size As Double
                            Dim sizeString As String
                            sizeString = ""
                            If lineArray(0).Equals("F") Then
                                If (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024 * 1024 * 1024) Then
                                    size = Convert.ToInt64(lineArray(lineArray.Length - 4)) / (1024 * 1024 * 1024)
                                    sizeString = Math.Round(size, 1).ToString + " GB"
                                ElseIf (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024 * 1024) Then
                                    size = (Convert.ToInt64(lineArray(lineArray.Length - 4))) / (1024 * 1024)
                                    sizeString = Math.Round(size, 1).ToString + " MB"
                                ElseIf (Convert.ToInt64(lineArray(lineArray.Length - 4)) > 1024) Then
                                    size = (Convert.ToInt64(lineArray(lineArray.Length - 4))) / (1024)
                                    sizeString = Math.Round(size, 1).ToString + " KB"
                                Else
                                    size = (Convert.ToInt64(lineArray(lineArray.Length - 4)))
                                    sizeString = Math.Round(size, 1).ToString + " B"
                                End If
                            End If
                            ListBox1.Items.Add(line + " " + sizeString)
                        End If
                    End If
                End If


            End If

        Next
        CreatePatch.Enabled = True
        reloadSavedSpace()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        CreatePatch.Enabled = True
    End Sub
End Class