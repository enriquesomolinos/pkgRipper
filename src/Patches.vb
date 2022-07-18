Public Class patches

    Private Sub patches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        For Each file In My.Computer.FileSystem.GetFiles("patches")
            If file.Contains(".xml") Then
                Dim xml As XElement

                xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(file))
                Dim node As TreeNode
                node = TreeView1.Nodes.Add(xml.<patchInfo>.@content_id)


                For Each patch In xml.<patches>.<patch>

                        Dim patchVersionDesc = patch.@description
                        patchVersionDesc = patch.@update_version_required + ":" + patchVersionDesc

                    node.Nodes.Add(patchVersionDesc)
                Next


            End If


        Next
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If IsNothing(e.Node.Parent) = False Then

            ListBox1.Items.Clear()


            Dim file As String
            Dim patchName As String

            patchName = e.Node.Text.ToString.Split(":")(e.Node.Text.ToString.Split(":").Length - 1)
            file = "patches/" + e.Node.Parent.Text + ".xml"
            Dim xml As XElement

            xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(file))
            
            For Each patch In xml.<patches>.<patch>
                If patch.@description.Equals(patchName) Then

                    pkgVersion.Text = patch.@pkg_required_version
                    updateRequiredVersion.Text = patch.@update_version_required
                    For Each subfile In patch.<file>
                        ListBox1.Items.Add(subfile.@path)
                    Next

                End If
                
            Next
        End If


    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsNothing(TreeView1.SelectedNode.Parent) = True Then

            ListBox1.Items.Clear()



        End If
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
End Class