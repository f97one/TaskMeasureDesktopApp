Public Class ConfigForm

    Public Property Canceled() As Boolean = False

    Private Sub UrlTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UrlTextBox.Validating
        If Not (UrlTextBox.Text.StartsWith("https://")) And Not (UrlTextBox.Text.StartsWith("http://")) AndAlso ActiveControl IsNot UrlTextBox Then
            Dim errMsg = "URLがhttp://, またはhttp://で始まっていません"
            ErrorProvider1.SetError(UrlTextBox, errMsg)
            ToolStripStatusLabel1.Text = errMsg
            e.Cancel = True
        End If
    End Sub

    Private Sub ApiKeyTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ApiKeyTextBox.Validating
        If String.IsNullOrWhiteSpace(ApiKeyTextBox.Text) AndAlso ActiveControl IsNot ApiKeyTextBox Then
            Dim errMsg = "API Keyは必須です"
            ErrorProvider1.SetError(ApiKeyTextBox, errMsg)
            ToolStripStatusLabel1.Text = errMsg
            e.Cancel = True
        End If
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UrlTextBox.Text = My.Settings.RedmineUrl
        ApiKeyTextBox.Text = My.Settings.UserApiKey
        ImmediateMesureCheckBox.Checked = My.Settings.ImmediateMesureOnPressEnter
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        My.Settings.RedmineUrl = UrlTextBox.Text
        My.Settings.UserApiKey = ApiKeyTextBox.Text
        My.Settings.ImmediateMesureOnPressEnter = ImmediateMesureCheckBox.Checked
        My.Settings.Save()
        Close()
    End Sub

    Private Sub ConfigForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim redmineUrl = My.Settings.RedmineUrl
        Dim apikey = My.Settings.UserApiKey

        If String.IsNullOrWhiteSpace(redmineUrl) OrElse String.IsNullOrWhiteSpace(apikey) Then
            Dim result As DialogResult = MessageBox.Show("設定が完了していませんが終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Canceled = True
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub UrlTextBox_Validated(sender As Object, e As EventArgs) Handles UrlTextBox.Validated
        ErrorProvider1.SetError(UrlTextBox, "")
    End Sub

    Private Sub ApiKeyTextBox_Validated(sender As Object, e As EventArgs) Handles ApiKeyTextBox.Validated
        ErrorProvider1.SetError(ApiKeyTextBox, "")
    End Sub
End Class