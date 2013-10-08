Public Class Settings

    Dim Original As String

    Public Sub Settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Original = InvalidCharsList.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Original = InvalidCharsList.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Settings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        InvalidCharsList.Clear()
        InvalidCharsList.AppendText(Original)
    End Sub
End Class