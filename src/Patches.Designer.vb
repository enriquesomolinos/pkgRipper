<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patches
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.pkgVersion = New System.Windows.Forms.TextBox()
        Me.updateRequiredVersion = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 53)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(433, 527)
        Me.TreeView1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(523, 176)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(538, 404)
        Me.ListBox1.TabIndex = 2
        '
        'pkgVersion
        '
        Me.pkgVersion.Location = New System.Drawing.Point(745, 81)
        Me.pkgVersion.Name = "pkgVersion"
        Me.pkgVersion.Size = New System.Drawing.Size(100, 22)
        Me.pkgVersion.TabIndex = 3
        '
        'updateRequiredVersion
        '
        Me.updateRequiredVersion.Location = New System.Drawing.Point(745, 109)
        Me.updateRequiredVersion.Name = "updateRequiredVersion"
        Me.updateRequiredVersion.Size = New System.Drawing.Size(100, 22)
        Me.updateRequiredVersion.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(523, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(520, 114)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(161, 17)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "Update required version"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(522, 86)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(139, 17)
        Me.Label30.TabIndex = 28
        Me.Label30.Text = "Pkg required version"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(520, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 17)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Patch description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(522, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Contents to be removed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Available patches"
        '
        'patches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 652)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.updateRequiredVersion)
        Me.Controls.Add(Me.pkgVersion)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "patches"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available patches"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents pkgVersion As System.Windows.Forms.TextBox
    Friend WithEvents updateRequiredVersion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
