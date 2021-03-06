﻿Public Class Main

    'Specify additional forms
    Dim Settings As New Settings
    'Specify global variables
    Dim InvalidChars As String

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Imports the invalid characters specified in the Settings window (form)
        InvalidChars = Settings.InvalidCharsList.Text
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        'Updates the invalid characters if they are changed
        If Settings.ShowDialog = DialogResult.OK Then
            InvalidChars = Settings.InvalidCharsList.Text
        End If
    End Sub

    Private Sub MenuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClear.Click
        'Clears all fields
        SeriesName.Clear()
        PathCSV.Clear()
        PathEpisodes.Clear()
        PathNewpath.Clear()
        OutputLog.Clear()
    End Sub

    Private Sub MenuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetDataObject(CType(ActiveControl, TextBox).SelectedText)
        If CType(ActiveControl, TextBox) IsNot OutputLog Then
            CType(ActiveControl, TextBox).SelectedText = String.Empty
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetDataObject(CType(ActiveControl, TextBox).SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim oDataObject As IDataObject
        oDataObject = Clipboard.GetDataObject()
        If oDataObject.GetDataPresent(DataFormats.Text) Then
            CType(ActiveControl, TextBox).SelectedText = CType(oDataObject.GetData(DataFormats.Text), String)
        End If
    End Sub

    Private Sub TimMcEnteecomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimMcEnteecomToolStripMenuItem.Click
        Process.Start("http://timmcentee.com")
    End Sub

    Private Sub XBMCorgForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XBMCorgForumsToolStripMenuItem.Click
        Process.Start("http://forum.xbmc.org")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        If About.ShowDialog = DialogResult.OK Then
        End If
    End Sub

    Private Sub BrowseCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseCSV.Click
        OpenCSV.Title = "Choose the CSV file you created"
        OpenCSV.InitialDirectory = "C:\"
        OpenCSV.Filter = "Comma Separated Values File|*.csv|All Files|*.*"
        If OpenCSV.ShowDialog() = DialogResult.OK Then
            PathCSV.Clear()
            PathCSV.AppendText(OpenCSV.FileName)
        End If
    End Sub

    Private Sub BrowseEpisodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseEpisodes.Click
        OpenEpisodes.Description = "Choose the directory containing your episodes."
        If OpenEpisodes.ShowDialog = DialogResult.OK Then
            PathEpisodes.Clear()
            PathEpisodes.AppendText(OpenEpisodes.SelectedPath)
        End If
    End Sub

    Private Sub CheckboxMove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckboxMove.CheckedChanged
        'Enables or disables the 'New Path' field
        If CheckboxMove.Checked Then
            BrowseNewpath.Enabled = True
            PathNewpath.Enabled = True
        Else
            BrowseNewpath.Enabled = False
            PathNewpath.Enabled = False
        End If
    End Sub

    Private Sub BrowseNewpath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseNewpath.Click
        OpenNewpath.Description = "Choose the directory you would like the episodes moved to."
        If OpenNewpath.ShowDialog = DialogResult.OK Then
            PathNewpath.Clear()
            PathNewpath.AppendText(OpenNewpath.SelectedPath)
        End If
    End Sub

    Private Sub ButtonClearlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearlog.Click
        OutputLog.Clear()
    End Sub

    Private Sub ButtonClearall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearall.Click
        'Clears all fields
        SeriesName.Clear()
        PathCSV.Clear()
        PathEpisodes.Clear()
        PathNewpath.Clear()
        OutputLog.Clear()
    End Sub

    Private Sub ButtonCopylog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCopylog.Click
        'Copies the complete contents of the OutputLog
        If String.IsNullOrEmpty(OutputLog.Text) Then
            MsgBox("Unable to copy an empty log.")
        Else
            Clipboard.SetDataObject(OutputLog.Text)
            MsgBox("Log contents copied to clipboard successfully!")
        End If
    End Sub

    Private Function CleanString(ByRef s) As String
        'Removes any invalid characters defined on the settings string from a string
        CleanString = s
        Dim CharsArray() As String = InvalidChars.Split(" ")
        Dim i As Integer = CharsArray.GetLength(0)
        While i > 0
            CleanString = CleanString.Replace(CharsArray(i - 1), "")
            i = i - 1
        End While
    End Function

    Private Sub ScanRename(ByVal rename)
        'Using 'Try' to prevent application crashes. At the end of this sub messages are displayed
        Try
            'Ensure that all the fields are populated with at least one character.
            If String.IsNullOrEmpty(SeriesName.Text) Then
                OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                MsgBox("Series Name field is blank. Please provide a series name before renaming.")
                Exit Sub
            ElseIf String.IsNullOrEmpty(PathCSV.Text) Then
                OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                MsgBox("CSV field is blank. Please provide the path to a CSV file before renaming.")
                Exit Sub
            ElseIf String.IsNullOrEmpty(PathEpisodes.Text) Then
                OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                MsgBox("Episode path is blank. Please provide a path to your episodes before renaming.")
                Exit Sub
            ElseIf CheckboxMove.Checked Then
                If String.IsNullOrEmpty(PathNewpath.Text) Then
                    OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                    MsgBox("New path is blank. Either uncheck the box to move after renaming, or provide a valid path before renaming.")
                    Exit Sub
                ElseIf Not GetChar(PathNewpath.Text, PathNewpath.TextLength) = "\" Then
                    OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                    MsgBox("New path must be a valid path and end in the \ character.")
                    Exit Sub
                ElseIf Not System.IO.Directory.Exists(PathNewpath.Text) Then
                    OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
                    MsgBox("New path does not exist. Please create the new path before renaming.")
                    Exit Sub
                End If
            End If
            'Determine the path where files will be moved if option is enabled while renaming
            Dim NewPath As String
            If CheckboxMove.Checked = True Then
                NewPath = PathNewpath.Text
            Else
                NewPath = PathEpisodes.Text
            End If
            'Loop through all files in directory specified
            For Each Episode In System.IO.Directory.GetFiles(PathEpisodes.Text)
                'Output each file as found includig path
                OutputLog.AppendText(vbNewLine & Episode)
                'Split filename from path
                Dim EpisodeFilename As String = Episode.Substring(PathEpisodes.Text.Length).ToLower()
                'Split file extension from filename
                Dim FileExt As String = Episode.Substring(Episode.Length - 4)
                'Begin scan through CSV file
                Dim result As String = "0"
                Using csvreader As New FileIO.TextFieldParser(PathCSV.Text)
                    csvreader.TextFieldType = FileIO.FieldType.Delimited
                    csvreader.SetDelimiters(",")
                    Dim Line() As String
                    While Not csvreader.EndOfData
                        Line = csvreader.ReadFields()
                        If CleanString(EpisodeFilename).Contains(CleanString((Line(1).ToLower))) Then
                            Dim SnEn() As String = Line(0).Split(" x ")
                            Dim SxEx As String = "S" & SnEn(0).PadLeft(2, "0") & "E" & SnEn(2).PadLeft(2, "0")
                            'Combine the path (new or original), series name, season and episode number, episode name from CSV and the file extension
                            result = NewPath & CleanString(SeriesName.Text & " " & SxEx & " " & Line(1) & FileExt)
                        End If
                    End While
                End Using
                If result = "0" Then
                    'No match was found, so do nothing
                    result = "Unable to locate match, please rename manually."
                ElseIf rename = False Then
                    'If testing then do not rename
                Else
                    'Perform rename here
                    System.IO.File.Move(Episode, result)
                End If
                OutputLog.AppendText(vbNewLine & "    >>> " & result)
            Next
            'In the event any of the fields were invalid, these errors will be given
        Catch ex As System.IO.FileNotFoundException
            MsgBox("File not found. Please check your file path and try again." & vbNewLine & vbNewLine & "Error101: " & ex.Message)
        Catch ex As System.IO.DirectoryNotFoundException
            MsgBox("Directory not found. Please check you path and try again." & vbNewLine & vbNewLine & "Error102: " & ex.Message)
        Catch ex As System.ArgumentNullException
            MsgBox("File path is blank, please provide a valid path and try again." & vbNewLine & vbNewLine & "Error104: " & ex.Message)
        Catch ex As System.ArgumentException
            MsgBox("Directory Path is blank, please provide a valid path and try again." & vbNewLine & vbNewLine & "Error103: " & ex.Message)
        Catch ex As Exception
            MsgBox("Unkown Error. Please provide this entire message when requesting support." & vbNewLine & vbNewLine & "Error100: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPreview.Click
        OutputLog.AppendText("Preview Started at " & TimeOfDay)
        OutputLog.AppendText(vbNewLine & "FILES WILL NOT BE RENAMED UNTIL YOU PRESS THE RENAME BUTTON")
        'Running as False so that the log will output all changes without actually making them
        ScanRename(False)
        OutputLog.AppendText(vbNewLine & "FILES WILL NOT BE RENAMED UNTIL YOU PRESS THE RENAME BUTTON")
        OutputLog.AppendText(vbNewLine & "Preview Completed at " & TimeOfDay & vbNewLine)
    End Sub

    Private Sub ButtonRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRename.Click
        OutputLog.AppendText("Rename Started at " & TimeOfDay)
        'Running as True so that files will be renamed when output to the log
        ScanRename(True)
        OutputLog.AppendText(vbNewLine & "Rename Completed at " & TimeOfDay & vbNewLine)
    End Sub
End Class
