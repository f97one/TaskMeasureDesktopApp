Public Class ConfigForm
    Private Sub UrlTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UrlTextBox.Validating
        If Not (UrlTextBox.Text.StartsWith("https://")) And Not (UrlTextBox.Text.StartsWith("http://")) Then
            ToolStripStatusLabel1.Text = "URLがhttp://, またはhttp://で始まっていません"
            e.Cancel = True
        End If
    End Sub

    Private Sub ApiKeyTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ApiKeyTextBox.Validating
        If String.IsNullOrWhiteSpace(ApiKeyTextBox.Text) Then
            ToolStripStatusLabel1.Text = "API Keyは必須です"
            e.Cancel = True
        End If
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UrlTextBox.Text = My.Settings.RedmineUrl
        ApiKeyTextBox.Text = My.Settings.UserApiKey
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        My.Settings.RedmineUrl = UrlTextBox.Text
        My.Settings.UserApiKey = ApiKeyTextBox.Text
        My.Settings.Save()
        Close()
    End Sub

End Class