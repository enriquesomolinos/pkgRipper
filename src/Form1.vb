Imports System.Net
Imports System.IO
Imports System.IO.Compression

Public Class Form1

    

    Private Property contentId As String
    Private Property titleId As String
    Private Property title As String
    Private Property version As String
    Private Property fullPath As String
    Private Property fullPathXMLFile As String
    Private Property versions As XElement()


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        goEnabled()


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.TextPkg.Text = OpenFileDialog1.FileName
        If (OpenFileDialog1.FileName.Equals("")) Then
            Return

        End If
        hideElements()


        Dim shellOutput As String
        shellOutput = ShellRun("orbis-pub-cmd.exe img_info """ + Me.TextPkg.Text + """", False, True, False)
        'TextConsole.Text = TextConsole.Text & shellOutput
        CalculateGameData(shellOutput)
        Dim files As ObjectModel.ReadOnlyCollection(Of String)
        files = My.Computer.FileSystem.GetFiles("patches")
        ComboGame.Items.Clear()
        For Each file In files
            'ComboGame.Visible = True
            fullPath = file
            file = Trim(file.Split("\")(file.Split("\").Length - 1)).Replace(".xml", "")

            ComboGame.Items.Add(file)
            If (file.Equals(contentId)) Then

                ComboGame.SelectedItem = file
                fullPathXMLFile = fullPath

                Exit For
            End If
        Next
        If (ComboGame.SelectedItem = Nothing) Then
            MessageBox.Show("At this moment there is no patch available for this game. Check https://github.com/enriquesomolinos/pkgripper-patches or create a new patch file. ContentId selected was:" + contentId,
                      "Patch for game not exists")
            ConsoleOutput("No Patch files detected")

            Return
        End If
        ConsoleOutput("Game detected")


        Label6.Visible = True



        ComboVersion.Visible = True
        ComboVersion.Items.Clear()
        Dim versionsLength As Integer
        versionsLength = 0
        versions = New XElement(100) {}


        Dim xml As XElement

        xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(fullPathXMLFile))
        For Each patch In xml.<patches>.<patch>
            If (version.Equals(patch.@pkg_required_version)) Then

                Dim patchVersionDesc = patch.@description
                If (patch.@update_version_required.Equals(version) = False) Then
                    patchVersionDesc = "REQUIRES UPDATE " + patch.@update_version_required + ":" + patchVersionDesc
                End If
                ComboVersion.Items.Add(patchVersionDesc)
                versions(versionsLength) = patch
                versionsLength = versionsLength + 1
            End If


        Next
        ConsoleOutput("Patch files detected correctly")

        goEnabled()



    End Sub
    Private Sub ConsoleOutput(ByVal value As String)
        TextConsole.Text = TextConsole.Text & value & vbCrLf
    End Sub




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

            End If


        Next


    End Sub
    Public Function ShellRunGp4(ByVal sCmd As String, Optional ByVal live As Boolean = True, Optional ByVal withTimer As Boolean = False) As String
        blockElements()
        'Run a shell command, returning the output as a string

        Dim oShell As Object
        oShell = CreateObject("WScript.Shell")

        'run(Command)
        Dim oExec As Object
        Dim oOutput As Object
        oExec = oShell.Exec(sCmd)
        oOutput = oExec.StdOut

        '        handle the results as they are written to and read from the StdOut object
        Dim s As String
        Dim sLine As String
        While Not oOutput.AtEndOfStream
            sLine = oOutput.ReadLine
            If sLine <> "" Then s = s & sLine & vbCrLf
        End While
        enableElements()
        ShellRunGp4 = s

    End Function
    Public Function ShellRun(ByVal sCmd As String, Optional ByVal live As Boolean = True, Optional ByVal withTimer As Boolean = False, Optional ByVal noRead As Boolean = False) As String

        blockElements()

        If withTimer Then
            TimerShell.Enabled = True
            TimerShell.Start()
        End If
        Dim proc As New Process
        proc.StartInfo.FileName = Application.StartupPath + "\" + sCmd.Split(" ")(0)
        proc.StartInfo.Arguments = Trim(sCmd.Replace(sCmd.Split(" ")(0), ""))
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.CreateNoWindow = True

        proc.StartInfo.RedirectStandardOutput = True
        proc.Start()
        Dim output() As String
        Dim outputString As String
        outputString = ""
        Dim strline As String
        proc.StartInfo.RedirectStandardOutput = True
        Do While proc.HasExited = False
            If noRead Then
                Try
                    Dim ascci As Integer
                    ascci = proc.StandardOutput.BaseStream.ReadByte()
                    If (ascci = 10) Then
                        strline = vbLf
                    Else
                        strline = Chr(ascci)
                    End If
                    TextConsole.Text = TextConsole.Text + (strline)
                    TextConsole.SelectionStart = TextConsole.Text.Length
                    TextConsole.ScrollToCaret()
                Catch ex As Exception

                End Try


            End If
            Application.DoEvents()
        Loop

        'proc.WaitForExit()

        output = proc.StandardOutput.ReadToEnd.Split(CChar(vbLf))
        For Each ln As String In output
            If (live) Then
                TextConsole.AppendText(ln)

            End If
            outputString = outputString & ln & vbNewLine
        Next

        If withTimer Then
            TimerShell.Stop()
            TimerShell.Enabled = False
        End If
        enableElements()
        ShellRun = outputString

        'Run a shell command, returning the output as a string

        ' Dim oShell As Object
        'oShell = CreateObject("WScript.Shell")

        'run command
        'Dim oExec As Object
        'Dim oOutput As Object
        'oExec = oShell.Exec(sCmd)
        'oOutput = oExec.StdOut

        'handle the results as they are written to and read from the StdOut object
        ' Dim s As String
        ' Dim sLine As String
        ' While Not oOutput.AtEndOfStream
        'sLine = oOutput.ReadLine
        'If sLine <> "" Then s = s & sLine & vbCrLf
        'End While

        'ShellRun = s

    End Function

    Public Sub blockElements()
        GoButton.Enabled = False
        ComboVersion.Enabled = False
        Button1.Enabled = False
        TextPkg.Enabled = False
        TextBoxRemmary.Enabled = False
        remarryButton.Enabled = False

    End Sub
    Public Sub enableElements()
        GoButton.Enabled = True
        ComboVersion.Enabled = True
        Button1.Enabled = True
        TextPkg.Enabled = True
        TextBoxRemmary.Enabled = True
        remarryButton.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        TextConsole.Text = ""

        For Each selectedPatch In ComboVersion.SelectedItems
            If (selectedPatch.ToString.Contains("REQUIRES")) Then
                MessageBox.Show("You are going to apply a patch that requires you to have a fixed update. If you don't have this update the final pkg file will not work!!",
                       "Version required")
            End If
        Next

        Dim shellOutput As String
        Dim gameFolder = "temp/" + contentId



        My.Computer.FileSystem.CreateDirectory(gameFolder)
        If (My.Computer.FileSystem.GetFiles(gameFolder).Count > 0 Or My.Computer.FileSystem.GetDirectories(gameFolder).Count > 0) Then
            MessageBox.Show(gameFolder + " will be cleaned",
                        "Temp directory not empty!!")

            If (My.Computer.FileSystem.GetFiles(gameFolder).Count > 0) Then
                FileSystem.Kill(gameFolder + "\*.*")
            End If
            For Each path In My.Computer.FileSystem.GetDirectories(gameFolder)
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)


            Next


        End If
        Dim gameAppFolder = gameFolder + "/" + titleId + "-app"
        Dim gamePatchFolder = gameFolder + "/" + titleId + "-patch"

        Dim gameGp4 = gameFolder + "/" + titleId + "-app.gp4"
        Dim gamePatchGp4 = gameFolder + "/" + titleId + "-patch.gp4"

        If (version.Equals("01.00")) Then

            ConsoleOutput("Extracting pkg")

            My.Computer.FileSystem.CreateDirectory(gameFolder)
            shellOutput = ShellRun("orbis-pub-cmd.exe img_extract --passcode 00000000000000000000000000000000 """ + Me.TextPkg.Text + """" + " " + gameFolder, True, True, False)
            My.Computer.FileSystem.CopyDirectory(gameFolder + "/Sc0", gameFolder + "/Image0/sce_sys", True)

            ConsoleOutput(vbNewLine & "Pkg extracted correctly")
            Application.DoEvents()

            ConsoleOutput("Patching files")
            Application.DoEvents()

            'apply patch
            For Each selectedPatch In ComboVersion.SelectedItems
                For Each versionPatch In versions
                    If (IsNothing(versionPatch) = False) Then
                        Dim selectedPatchString As String
                        selectedPatchString = selectedPatch.ToString.Split(":")(selectedPatch.ToString.Split(":").Length - 1)
                        If selectedPatchString.Equals(versionPatch.@description) Then
                            For Each file In versionPatch.<file>

                                Dim fileStream As IO.StreamWriter
                                If (file.@path = "") Then
                                    Continue For
                                End If
                                If My.Computer.FileSystem.GetFileInfo(gameFolder + "/Image0/" + file.@path).Attributes = FileAttributes.Directory Then
                                    For Each fileDir In My.Computer.FileSystem.GetFiles(gameFolder + "/Image0/" + Trim(file.@path), FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                        fileStream = My.Computer.FileSystem.OpenTextFileWriter(fileDir, False)
                                        fileStream.Write("")
                                        fileStream.Dispose()
                                    Next
                                Else
                                    fileStream = My.Computer.FileSystem.OpenTextFileWriter(gameFolder + "/Image0/" + Trim(file.@path), False)
                                    fileStream.Write("")
                                    fileStream.Dispose()
                                End If
                                
                            Next
                            Continue For
                        End If
                    End If
                Next

            Next
            ConsoleOutput("Patches applied successfully")
            Application.DoEvents()

            My.Computer.FileSystem.CreateDirectory("output/" + contentId)


            My.Computer.FileSystem.CreateDirectory(gameAppFolder)
            My.Computer.FileSystem.MoveDirectory(gameFolder + "/Image0", gameAppFolder)
            'My.Computer.FileSystem.RenameDirectory(gameFolder + "/Image0", titleId + "-app")
            shellOutput = ShellRunGp4("gengp4_app.exe " + gameAppFolder, True, True)
            Application.DoEvents()

            IO.File.WriteAllText(gameGp4, IO.File.ReadAllText(gameGp4).Replace("temp/" + contentId + "/", ""))

            shellOutput = ShellRun("orbis-pub-cmd.exe img_create --oformat pkg " + """" + gameGp4 + """" + " output/" + contentId, True, False, True)

            If (My.Computer.FileSystem.GetFiles(gameFolder).Count > 0) Then
                FileSystem.Kill(gameFolder + "\*.*")
            End If

            For Each path In My.Computer.FileSystem.GetDirectories(gameFolder)
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)


            Next

            MessageBox.Show("",
                       "Image created")
        Else

            ConsoleOutput("Extracting pkg")

            My.Computer.FileSystem.CreateDirectory(gameFolder)
            shellOutput = ShellRun("orbis-pub-cmd.exe img_extract --passcode 00000000000000000000000000000000 """ + Me.TextPkg.Text + """" + " " + gameFolder, False, True, False)
            My.Computer.FileSystem.CopyDirectory(gameFolder + "/Sc0", gameFolder + "/Image0/sce_sys", True)
            If My.Computer.FileSystem.FileExists(gameFolder + "/Image0/sce_sys/app/playgo-chunk.dat") Then
                My.Computer.FileSystem.CopyFile(gameFolder + "/Image0/sce_sys/app/playgo-chunk.dat", gameFolder + "/Image0/sce_sys/playgo-chunk.dat", True)
                My.Computer.FileSystem.DeleteDirectory(gameFolder + "/Image0/sce_sys/app/", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            ConsoleOutput(vbNewLine & "Pkg extracted correctly")
            Application.DoEvents()

            ConsoleOutput("Patching files")
            Application.DoEvents()

            'apply patch
            For Each selectedPatch In ComboVersion.SelectedItems
                For Each versionPatch In versions
                    If (IsNothing(versionPatch) = False) Then
                        Dim selectedPatchString As String
                        selectedPatchString = selectedPatch.ToString.Split(":")(selectedPatch.ToString.Split(":").Length - 1)
                        If selectedPatchString.Equals(versionPatch.@description) Then
                            For Each file In versionPatch.<file>

                                Dim fileStream As IO.StreamWriter
                                If My.Computer.FileSystem.GetFileInfo(gameFolder + "/Image0/" + file.@path).Attributes = FileAttributes.Directory Then
                                    For Each fileDir In My.Computer.FileSystem.GetFiles(gameFolder + "/Image0/" + Trim(file.@path), FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                        fileStream = My.Computer.FileSystem.OpenTextFileWriter(fileDir, False)
                                        fileStream.Write("")
                                        fileStream.Dispose()
                                    Next
                                Else
                                    fileStream = My.Computer.FileSystem.OpenTextFileWriter(gameFolder + "/Image0/" + Trim(file.@path), False)
                                    fileStream.Write("")
                                    fileStream.Dispose()
                                End If
                            Next
                            Continue For
                        End If
                    End If
                Next

            Next

            ConsoleOutput("Patches applied successfully")
            Application.DoEvents()

            My.Computer.FileSystem.CreateDirectory("output/" + contentId)


            My.Computer.FileSystem.CreateDirectory(gamePatchFolder)
            My.Computer.FileSystem.MoveDirectory(gameFolder + "/Image0", gamePatchFolder)
            shellOutput = ShellRunGp4("gengp4_app.exe " + gamePatchFolder, True, True)


            IO.File.WriteAllText(gamePatchGp4, IO.File.ReadAllText(gamePatchGp4).Replace("temp/" + contentId + "/", ""))
            Dim Xml As XElement
            Application.DoEvents()
            IO.File.WriteAllText(gamePatchGp4, IO.File.ReadAllText(gamePatchGp4).Replace("<?xml version=""1.1""", "<?xml version=""1.0"""))
            Xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(gamePatchGp4))
            Xml.<volume>.<package>.@app_path = TextBoxRemmary.Text
            Xml.Save(gamePatchGp4)
            IO.File.WriteAllText(gamePatchGp4, IO.File.ReadAllText(gamePatchGp4).Replace("<?xml version=""1.0""", "<?xml version=""1.1"""))

            shellOutput = ShellRun("orbis-pub-cmd.exe img_create --oformat pkg " + """" + gamePatchGp4 + """" + " output/" + contentId, True, False, True)

            If (My.Computer.FileSystem.GetFiles(gameFolder).Count > 0) Then
                FileSystem.Kill(gameFolder + "\*.*")
            End If

            For Each path In My.Computer.FileSystem.GetDirectories(gameFolder)
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)


            Next

            MessageBox.Show("Image created",
                       "Image created")

        End If

    End Sub

    Private Sub goEnabled()
        If version.Equals("01.00") Then
            If (ComboVersion.SelectedIndex > -1) Then
                GoButton.Enabled = True
            Else
                GoButton.Enabled = False
            End If

        ElseIf (ComboVersion.SelectedIndex > -1 And TextBoxRemmary.Text.Length > 0) Then
            GoButton.Enabled = True
        Else
            GoButton.Enabled = False
        End If

    End Sub


    Private Sub ComboPatches_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboVersion.Visible = True
        ComboVersion.Items.Clear()
        Dim versionsLength As Integer
        versionsLength = 0
        versions = New XElement(100) {}

        Dim Xml As XElement

        Xml = XElement.Parse(My.Computer.FileSystem.ReadAllText(fullPathXMLFile))
        For Each patch In Xml.<patches>.<patch>
            If (version.Equals(patch.@pkg_required_version)) Then

                ComboVersion.Items.Add(patch.@update_version_required + ":" + patch.@description)
                versions(versionsLength) = patch
                versionsLength = versionsLength + 1
            End If


        Next
        goEnabled()


    End Sub

    Private Sub ComboVersion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboVersion.SelectedIndexChanged
        goEnabled()
        If version.Equals("01.00") = False Then
            remarryButton.Visible = True
            TextBoxRemmary.Visible = True
            LabelRemarry.Visible = True
        End If


    End Sub
    Public Sub ExtractFileToDirectory(ByVal zipFileName As String, ByVal outputDirectory As String)
        Dim zip As ZipFile

        zip = ZipFile.Read(zipFileName)
        Directory.CreateDirectory(outputDirectory)
        For Each e In zip
            If (e.FileName.Contains("xml")) Then
                e.Extract(outputDirectory, ExtractExistingFileAction.OverwriteSilently)
            End If
        Next
        If (My.Computer.FileSystem.DirectoryExists("patches/pkgripper-patches-master/")) Then
            My.Computer.FileSystem.MoveDirectory("patches/pkgripper-patches-master/", "patches", True)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (My.Computer.FileSystem.FileExists("gengp4_app.exe") = False Or My.Computer.FileSystem.FileExists("orbis-pub-cmd.exe") = False) Then
            MessageBox.Show("gengp4_app.exe or orbis-pub-cmd.exe not detected at " + Application.StartupPath + ". Please install Fake Pkg Tools directly in the Pkgripper path",
                       "Fake pkg Tools not detected")
            Application.Exit()
        End If
        updatePatches()

    End Sub
    Private Sub updatePatches()
        Dim remoteUri As String = "https://codeload.github.com/enriquesomolinos/pkgripper-patches/zip/refs/heads/master"
        My.Computer.FileSystem.CreateDirectory("temp")
        Dim fileName As String = "temp/tempPatches.zip"

        Try
            Using client As New WebClient()

                ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                client.DownloadFile(remoteUri, fileName)

            End Using
            ExtractFileToDirectory("temp/tempPatches.zip", "patches")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Download Error", _
                MessageBoxButtons.OK, _
                    MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub TimerShell_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerShell.Tick
        TextConsole.AppendText(".")
    End Sub

    Private Sub remarryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remarryButton.Click
        Dim path As String
        If contentId Is Nothing Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/output")
            Dim info As IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath + "/output")

            Path = info.FullName

        Else
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/output/" + contentId)

            Dim info As IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath + "/output/" + contentId)
             path = info.FullName

        End If
        OpenFileDialog2.InitialDirectory = path
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        TextBoxRemmary.Text = OpenFileDialog2.FileName
        goEnabled()

        If (OpenFileDialog2.FileName.Equals("")) Then
            Return

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If contentId Is Nothing Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/output")
            Dim info As IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath + "/output")
            Dim path As String
            path = info.FullName
            Process.Start("explorer.exe", path)
        Else
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "/output/" + contentId)

            Dim info As IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath + "/output/" + contentId)
            Dim path As String
            path = info.FullName
            Process.Start("explorer.exe", path)
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim webAddress As String = "https://paypal.me/esomolinos?locale.x=es_ES"
        Process.Start(webAddress)
    End Sub

    Public Sub hideElements()
        ComboVersion.Items.Clear()
        ComboVersion.Visible = False
        Label6.Visible = False
        LabelRemarry.Visible = False
        remarryButton.Visible = False
        TextBoxRemmary.Visible = False
    End Sub

    Private Sub ListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListToolStripMenuItem.Click
        Dim box = New patches
        box.Show()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolStripMenuItem.Click
        Dim box = New PatchCreator

        box.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
