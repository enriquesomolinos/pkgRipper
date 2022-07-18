<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatchCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextPkg = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.updateRequiredVersion = New System.Windows.Forms.TextBox()
        Me.pkgVersion = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MoveButton = New System.Windows.Forms.Button()
        Me.UndoSelected = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreatePatch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView2
        '
        Me.TreeView2.CheckBoxes = True
        Me.TreeView2.Location = New System.Drawing.Point(22, 228)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(433, 354)
        Me.TreeView2.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextPkg
        '
        Me.TextPkg.Location = New System.Drawing.Point(22, 43)
        Me.TextPkg.Name = "TextPkg"
        Me.TextPkg.Size = New System.Drawing.Size(316, 22)
        Me.TextPkg.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(595, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 22)
        Me.TextBox1.TabIndex = 16
        '
        'updateRequiredVersion
        '
        Me.updateRequiredVersion.Location = New System.Drawing.Point(783, 107)
        Me.updateRequiredVersion.Name = "updateRequiredVersion"
        Me.updateRequiredVersion.Size = New System.Drawing.Size(134, 22)
        Me.updateRequiredVersion.TabIndex = 14
        '
        'pkgVersion
        '
        Me.pkgVersion.Location = New System.Drawing.Point(783, 78)
        Me.pkgVersion.Name = "pkgVersion"
        Me.pkgVersion.Size = New System.Drawing.Size(134, 22)
        Me.pkgVersion.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(600, 169)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(474, 388)
        Me.ListBox1.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AddExtension = False
        Me.OpenFileDialog1.Filter = "PS4 pkg files|*.pkg"
        Me.OpenFileDialog1.InitialDirectory = "./"
        '
        'MoveButton
        '
        Me.MoveButton.Enabled = False
        Me.MoveButton.Location = New System.Drawing.Point(484, 254)
        Me.MoveButton.Name = "MoveButton"
        Me.MoveButton.Size = New System.Drawing.Size(94, 37)
        Me.MoveButton.TabIndex = 20
        Me.MoveButton.Text = ">>"
        Me.MoveButton.UseVisualStyleBackColor = True
        '
        'UndoSelected
        '
        Me.UndoSelected.Enabled = False
        Me.UndoSelected.Location = New System.Drawing.Point(484, 311)
        Me.UndoSelected.Name = "UndoSelected"
        Me.UndoSelected.Size = New System.Drawing.Size(94, 37)
        Me.UndoSelected.TabIndex = 21
        Me.UndoSelected.Text = "<<"
        Me.UndoSelected.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(597, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Contents to be removed"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(595, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 17)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Patch description"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(595, 83)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(139, 17)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "Pkg required version"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(595, 112)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(161, 17)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "Update required version"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 83)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(433, 134)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Version:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Title Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Content Id:"
        '
        'CreatePatch
        '
        Me.CreatePatch.Enabled = False
        Me.CreatePatch.Location = New System.Drawing.Point(661, 597)
        Me.CreatePatch.Name = "CreatePatch"
        Me.CreatePatch.Size = New System.Drawing.Size(349, 37)
        Me.CreatePatch.TabIndex = 27
        Me.CreatePatch.Text = "Create Patch File"
        Me.CreatePatch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(484, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 108)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = ">> Duplicates from update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.AddExtension = False
        Me.OpenFileDialog2.Filter = "PS4 pkg files|*.pkg"
        Me.OpenFileDialog2.InitialDirectory = "./"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(597, 565)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Uncompressed space saved:"
        '
        'PatchCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 646)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CreatePatch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.UndoSelected)
        Me.Controls.Add(Me.MoveButton)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextPkg)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.updateRequiredVersion)
        Me.Controls.Add(Me.pkgVersion)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "PatchCreator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patch Creator"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextPkg As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents updateRequiredVersion As System.Windows.Forms.TextBox
    Friend WithEvents pkgVersion As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MoveButton As System.Windows.Forms.Button
    Friend WithEvents UndoSelected As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreatePatch As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
