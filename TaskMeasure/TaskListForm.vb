﻿Imports TaskMeasure.Entities
Imports TaskMeasure.Repositories

Public Class TaskListForm

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        RaiseConfig()
    End Sub

    Private Sub CloseAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAppToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TaskListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim redmineUrl = My.Settings.RedmineUrl
        Dim apikey = My.Settings.UserApiKey

        If (String.IsNullOrWhiteSpace(redmineUrl)) Then
            MessageBox.Show("Redmine URL を設定してください。")
            RaiseConfig()
        ElseIf String.IsNullOrWhiteSpace(apikey) Then
            MessageBox.Show("ユーザーの API アクセスキーを設定してください。")
            RaiseConfig()
        ElseIf Not (redmineUrl.StartsWith("http://")) And Not (redmineUrl.StartsWith("https://")) Then
            MessageBox.Show("Redmine URL を設定してください。")
            RaiseConfig()
        End If

        Try
            Dim repo As New RedmineRepository()
            Dim projects As List(Of RedmineProject) = repo.GetProjects()
            ProjectsComboBox.DataSource = projects
        Catch ex As ApiAccessException
            MessageBox.Show("プロジェクト一覧を取得できませんでした。")
        End Try
    End Sub

    Private Sub RaiseConfig()
        Dim f As New ConfigForm()
        f.ShowDialog(Me)
        f.Dispose()
    End Sub

    Private Sub ProjectsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProjectsComboBox.SelectedIndexChanged
        Dim proj As RedmineProject = ProjectsComboBox.SelectedItem

        Try
            Dim repo As New RedmineRepository()
            Dim issues As List(Of RedmineIssue) = repo.GetIssues(proj)

            TicketsGrid.DataSource = issues
        Catch ex As ApiAccessException
            MessageBox.Show("チケット一覧を取得できませんでした。")
        End Try
    End Sub

    Private Sub TicketsGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TicketsGrid.CellDoubleClick
        Dim row As RedmineIssue = TicketsGrid.CurrentRow.DataBoundItem
        Me.Hide()
        'Dim f As New IssueMeasureForm(row, True)
        'f.Show()

    End Sub
End Class