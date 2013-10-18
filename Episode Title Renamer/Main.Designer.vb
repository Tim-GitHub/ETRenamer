<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimMcEnteecomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XBMCorgForumsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenCSV = New System.Windows.Forms.OpenFileDialog()
        Me.BrowseCSV = New System.Windows.Forms.Button()
        Me.PathCSV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PathEpisodes = New System.Windows.Forms.TextBox()
        Me.BrowseEpisodes = New System.Windows.Forms.Button()
        Me.OpenEpisodes = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckboxMove = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PathNewpath = New System.Windows.Forms.TextBox()
        Me.BrowseNewpath = New System.Windows.Forms.Button()
        Me.OpenNewpath = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonClearlog = New System.Windows.Forms.Button()
        Me.ButtonClearall = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SeriesName = New System.Windows.Forms.TextBox()
        Me.OutputLog = New System.Windows.Forms.TextBox()
        Me.ButtonCopylog = New System.Windows.Forms.Button()
        Me.ButtonPreview = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.MenuClear, Me.ToolStripMenuItem1, Me.MenuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'MenuClear
        '
        Me.MenuClear.Name = "MenuClear"
        Me.MenuClear.Size = New System.Drawing.Size(118, 22)
        Me.MenuClear.Text = "&Clear All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(115, 6)
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(118, 22)
        Me.MenuExit.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionsToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimMcEnteecomToolStripMenuItem, Me.XBMCorgForumsToolStripMenuItem})
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'TimMcEnteecomToolStripMenuItem
        '
        Me.TimMcEnteecomToolStripMenuItem.Name = "TimMcEnteecomToolStripMenuItem"
        Me.TimMcEnteecomToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TimMcEnteecomToolStripMenuItem.Text = "TimMcEntee.com"
        '
        'XBMCorgForumsToolStripMenuItem
        '
        Me.XBMCorgForumsToolStripMenuItem.Name = "XBMCorgForumsToolStripMenuItem"
        Me.XBMCorgForumsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.XBMCorgForumsToolStripMenuItem.Text = "XBMC.org Forums"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'BrowseCSV
        '
        Me.BrowseCSV.Location = New System.Drawing.Point(551, 57)
        Me.BrowseCSV.Name = "BrowseCSV"
        Me.BrowseCSV.Size = New System.Drawing.Size(75, 23)
        Me.BrowseCSV.TabIndex = 3
        Me.BrowseCSV.Text = "Browse..."
        Me.BrowseCSV.UseVisualStyleBackColor = True
        '
        'PathCSV
        '
        Me.PathCSV.Location = New System.Drawing.Point(101, 57)
        Me.PathCSV.Name = "PathCSV"
        Me.PathCSV.Size = New System.Drawing.Size(444, 20)
        Me.PathCSV.TabIndex = 2
        Me.PathCSV.Text = "C:\LooneyTunes.csv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Path to CSV file:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Path to episodes:"
        '
        'PathEpisodes
        '
        Me.PathEpisodes.Location = New System.Drawing.Point(101, 83)
        Me.PathEpisodes.Name = "PathEpisodes"
        Me.PathEpisodes.Size = New System.Drawing.Size(444, 20)
        Me.PathEpisodes.TabIndex = 4
        Me.PathEpisodes.Text = "C:\"
        '
        'BrowseEpisodes
        '
        Me.BrowseEpisodes.Location = New System.Drawing.Point(551, 83)
        Me.BrowseEpisodes.Name = "BrowseEpisodes"
        Me.BrowseEpisodes.Size = New System.Drawing.Size(75, 23)
        Me.BrowseEpisodes.TabIndex = 5
        Me.BrowseEpisodes.Text = "Browse..."
        Me.BrowseEpisodes.UseVisualStyleBackColor = True
        '
        'CheckboxMove
        '
        Me.CheckboxMove.AutoSize = True
        Me.CheckboxMove.Location = New System.Drawing.Point(11, 107)
        Me.CheckboxMove.Name = "CheckboxMove"
        Me.CheckboxMove.Size = New System.Drawing.Size(174, 17)
        Me.CheckboxMove.TabIndex = 6
        Me.CheckboxMove.Text = "Move episodes after renaming?"
        Me.CheckboxMove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "New path:"
        '
        'PathNewpath
        '
        Me.PathNewpath.Enabled = False
        Me.PathNewpath.Location = New System.Drawing.Point(101, 130)
        Me.PathNewpath.Name = "PathNewpath"
        Me.PathNewpath.Size = New System.Drawing.Size(444, 20)
        Me.PathNewpath.TabIndex = 7
        '
        'BrowseNewpath
        '
        Me.BrowseNewpath.Enabled = False
        Me.BrowseNewpath.Location = New System.Drawing.Point(551, 130)
        Me.BrowseNewpath.Name = "BrowseNewpath"
        Me.BrowseNewpath.Size = New System.Drawing.Size(75, 23)
        Me.BrowseNewpath.TabIndex = 8
        Me.BrowseNewpath.Text = "Browse..."
        Me.BrowseNewpath.UseVisualStyleBackColor = True
        '
        'ButtonRename
        '
        Me.ButtonRename.Location = New System.Drawing.Point(201, 165)
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRename.TabIndex = 10
        Me.ButtonRename.Text = "Rename"
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonClearlog
        '
        Me.ButtonClearlog.Location = New System.Drawing.Point(282, 165)
        Me.ButtonClearlog.Name = "ButtonClearlog"
        Me.ButtonClearlog.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearlog.TabIndex = 11
        Me.ButtonClearlog.Text = "Clear Log"
        Me.ButtonClearlog.UseVisualStyleBackColor = True
        '
        'ButtonClearall
        '
        Me.ButtonClearall.Location = New System.Drawing.Point(363, 165)
        Me.ButtonClearall.Name = "ButtonClearall"
        Me.ButtonClearall.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearall.TabIndex = 12
        Me.ButtonClearall.Text = "Clear All"
        Me.ButtonClearall.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Series Name:"
        '
        'SeriesName
        '
        Me.SeriesName.Location = New System.Drawing.Point(101, 31)
        Me.SeriesName.Name = "SeriesName"
        Me.SeriesName.Size = New System.Drawing.Size(444, 20)
        Me.SeriesName.TabIndex = 1
        Me.SeriesName.Text = "Looney Tunes"
        '
        'OutputLog
        '
        Me.OutputLog.BackColor = System.Drawing.SystemColors.Window
        Me.OutputLog.Location = New System.Drawing.Point(12, 203)
        Me.OutputLog.Multiline = True
        Me.OutputLog.Name = "OutputLog"
        Me.OutputLog.ReadOnly = True
        Me.OutputLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutputLog.Size = New System.Drawing.Size(615, 302)
        Me.OutputLog.TabIndex = 14
        '
        'ButtonCopylog
        '
        Me.ButtonCopylog.Location = New System.Drawing.Point(444, 165)
        Me.ButtonCopylog.Name = "ButtonCopylog"
        Me.ButtonCopylog.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCopylog.TabIndex = 13
        Me.ButtonCopylog.Text = "Copy Log"
        Me.ButtonCopylog.UseVisualStyleBackColor = True
        '
        'ButtonPreview
        '
        Me.ButtonPreview.Location = New System.Drawing.Point(120, 165)
        Me.ButtonPreview.Name = "ButtonPreview"
        Me.ButtonPreview.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPreview.TabIndex = 9
        Me.ButtonPreview.Text = "Preview"
        Me.ButtonPreview.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 517)
        Me.Controls.Add(Me.ButtonPreview)
        Me.Controls.Add(Me.ButtonCopylog)
        Me.Controls.Add(Me.OutputLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SeriesName)
        Me.Controls.Add(Me.ButtonClearall)
        Me.Controls.Add(Me.ButtonClearlog)
        Me.Controls.Add(Me.ButtonRename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PathNewpath)
        Me.Controls.Add(Me.BrowseNewpath)
        Me.Controls.Add(Me.CheckboxMove)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PathEpisodes)
        Me.Controls.Add(Me.BrowseEpisodes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PathCSV)
        Me.Controls.Add(Me.BrowseCSV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = " Episode Title Renamer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenCSV As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BrowseCSV As System.Windows.Forms.Button
    Friend WithEvents PathCSV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PathEpisodes As System.Windows.Forms.TextBox
    Friend WithEvents BrowseEpisodes As System.Windows.Forms.Button
    Friend WithEvents OpenEpisodes As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CheckboxMove As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PathNewpath As System.Windows.Forms.TextBox
    Friend WithEvents BrowseNewpath As System.Windows.Forms.Button
    Friend WithEvents OpenNewpath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ButtonRename As System.Windows.Forms.Button
    Friend WithEvents ButtonClearlog As System.Windows.Forms.Button
    Friend WithEvents ButtonClearall As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SeriesName As System.Windows.Forms.TextBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputLog As System.Windows.Forms.TextBox
    Friend WithEvents TimMcEnteecomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XBMCorgForumsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonCopylog As System.Windows.Forms.Button
    Friend WithEvents ButtonPreview As System.Windows.Forms.Button

End Class
