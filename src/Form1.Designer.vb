<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelRemarry = New System.Windows.Forms.Label()
        Me.TextConsole = New System.Windows.Forms.TextBox()
        Me.TextBoxRemmary = New System.Windows.Forms.TextBox()
        Me.remarryButton = New System.Windows.Forms.Button()
        Me.ComboVersion = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboGame = New System.Windows.Forms.ComboBox()
        Me.TextPkg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.TimerShell = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Patches = New System.Windows.Forms.MenuStrip()
        Me.PatchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Patches.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelRemarry)
        Me.GroupBox1.Controls.Add(Me.TextConsole)
        Me.GroupBox1.Controls.Add(Me.TextBoxRemmary)
        Me.GroupBox1.Controls.Add(Me.remarryButton)
        Me.GroupBox1.Controls.Add(Me.ComboVersion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboGame)
        Me.GroupBox1.Controls.Add(Me.TextPkg)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(964, 663)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelRemarry
        '
        Me.LabelRemarry.AutoSize = True
        Me.LabelRemarry.Location = New System.Drawing.Point(9, 401)
        Me.LabelRemarry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRemarry.Name = "LabelRemarry"
        Me.LabelRemarry.Size = New System.Drawing.Size(206, 17)
        Me.LabelRemarry.TabIndex = 13
        Me.LabelRemarry.Text = "Select base pkg to remarry with"
        Me.LabelRemarry.Visible = False
        '
        'TextConsole
        '
        Me.TextConsole.AcceptsTab = True
        Me.TextConsole.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextConsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextConsole.ForeColor = System.Drawing.SystemColors.Info
        Me.TextConsole.Location = New System.Drawing.Point(13, 489)
        Me.TextConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.TextConsole.Multiline = True
        Me.TextConsole.Name = "TextConsole"
        Me.TextConsole.ReadOnly = True
        Me.TextConsole.Size = New System.Drawing.Size(943, 164)
        Me.TextConsole.TabIndex = 1
        '
        'TextBoxRemmary
        '
        Me.TextBoxRemmary.Location = New System.Drawing.Point(13, 421)
        Me.TextBoxRemmary.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRemmary.Name = "TextBoxRemmary"
        Me.TextBoxRemmary.Size = New System.Drawing.Size(643, 22)
        Me.TextBoxRemmary.TabIndex = 12
        Me.TextBoxRemmary.Visible = False
        '
        'remarryButton
        '
        Me.remarryButton.Location = New System.Drawing.Point(679, 421)
        Me.remarryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.remarryButton.Name = "remarryButton"
        Me.remarryButton.Size = New System.Drawing.Size(100, 28)
        Me.remarryButton.TabIndex = 11
        Me.remarryButton.Text = "Browse"
        Me.remarryButton.UseVisualStyleBackColor = True
        Me.remarryButton.Visible = False
        '
        'ComboVersion
        '
        Me.ComboVersion.FormattingEnabled = True
        Me.ComboVersion.ItemHeight = 16
        Me.ComboVersion.Location = New System.Drawing.Point(12, 273)
        Me.ComboVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboVersion.Name = "ComboVersion"
        Me.ComboVersion.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ComboVersion.Size = New System.Drawing.Size(941, 116)
        Me.ComboVersion.TabIndex = 10
        Me.ComboVersion.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(503, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Select patches to apply (be sure you don't pick two or more language patches)"
        Me.Label6.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 105)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(940, 134)
        Me.GroupBox2.TabIndex = 6
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pkg file to apply patch"
        '
        'ComboGame
        '
        Me.ComboGame.Enabled = False
        Me.ComboGame.FormattingEnabled = True
        Me.ComboGame.Location = New System.Drawing.Point(13, 457)
        Me.ComboGame.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboGame.Name = "ComboGame"
        Me.ComboGame.Size = New System.Drawing.Size(531, 24)
        Me.ComboGame.TabIndex = 2
        Me.ComboGame.Visible = False
        '
        'TextPkg
        '
        Me.TextPkg.Location = New System.Drawing.Point(8, 47)
        Me.TextPkg.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPkg.Name = "TextPkg"
        Me.TextPkg.Size = New System.Drawing.Size(355, 22)
        Me.TextPkg.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 47)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AddExtension = False
        Me.OpenFileDialog1.Filter = "PS4 pkg files|*.pkg"
        Me.OpenFileDialog1.InitialDirectory = "./"
        '
        'GoButton
        '
        Me.GoButton.Enabled = False
        Me.GoButton.Location = New System.Drawing.Point(991, 578)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(131, 64)
        Me.GoButton.TabIndex = 3
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TimerShell
        '
        Me.TimerShell.Interval = 2000
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(991, 653)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(991, 482)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 89)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Open Destiation Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.AddExtension = False
        Me.OpenFileDialog2.Filter = "PS4 pkg files|*.pkg"
        Me.OpenFileDialog2.InitialDirectory = "./"
        '
        'Patches
        '
        Me.Patches.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatchesToolStripMenuItem})
        Me.Patches.Location = New System.Drawing.Point(0, 0)
        Me.Patches.Name = "Patches"
        Me.Patches.Size = New System.Drawing.Size(1135, 28)
        Me.Patches.Stretch = False
        Me.Patches.TabIndex = 16
        Me.Patches.Text = "Menu"
        '
        'PatchesToolStripMenuItem
        '
        Me.PatchesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.CreateToolStripMenuItem})
        Me.PatchesToolStripMenuItem.Name = "PatchesToolStripMenuItem"
        Me.PatchesToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.PatchesToolStripMenuItem.Text = "Patches"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 709)
        Me.Controls.Add(Me.Patches)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PkgRipper by Somo  v2.5.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Patches.ResumeLayout(False)
        Me.Patches.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextPkg As System.Windows.Forms.TextBox
    Friend WithEvents TextConsole As System.Windows.Forms.TextBox
    Friend WithEvents ComboGame As System.Windows.Forms.ComboBox
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboVersion As System.Windows.Forms.ListBox
    Friend WithEvents TimerShell As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LabelRemarry As System.Windows.Forms.Label
    Friend WithEvents TextBoxRemmary As System.Windows.Forms.TextBox
    Friend WithEvents remarryButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Patches As System.Windows.Forms.MenuStrip
    Friend WithEvents PatchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
