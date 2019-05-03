Imports System.Net
Imports System.Text
Imports TaskMeasure.Entities
Imports TaskMeasure.Repositories

Public Class TaskMeasureForm

    Public Property PreForm() As Form

    Private Property CurrentIssue() As RedmineIssue
    Private Property Paused() As Boolean

    Private stopWatch As New Stopwatch()

    Public Sub New()
        MyBase.New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        CurrentIssue = Nothing
        Paused = False
    End Sub

    Public Sub New(issue As RedmineIssue)
        Me.New()
        CurrentIssue = issue
    End Sub

    Private Function BuildTimeLabel(timeSpan As TimeSpan) As String
        Dim tm As Double = Math.Round(timeSpan.TotalHours, 2, MidpointRounding.AwayFromZero)
        Return String.Format("{0} H ({1}時間{2}分)", tm, Math.Floor(timeSpan.TotalHours), timeSpan.Minutes)
    End Function

    Private Function BuildTimeLabel(t As Double) As String
        Dim ts As TimeSpan = TimeSpan.FromHours(t)

        Dim tm As Double = Math.Round(t, 2, MidpointRounding.AwayFromZero)
        Return String.Format("{0} H ({1}時間{2}分)", tm, Math.Floor(ts.TotalHours), ts.Minutes)
    End Function

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        If Paused Then
            stopWatch.Start()
        Else
            stopWatch.Stop()
        End If

        ' ボタンのチェックを反転させる
        PauseBtn.Checked = Not PauseBtn.Checked
        Paused = Not Paused
    End Sub

    Private Sub CommentTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CommentTextBox.KeyDown
        ' Enterの入力は無効にする
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            e.Handled = True

            If My.Settings.ImmediateMesureOnPressEnter AndAlso Not ElapsedTimer1.Enabled Then
                StartStopButton.PerformClick()
            End If

        End If
    End Sub

    Private Sub TaskMeasureForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim repo As New RedmineRepository()
            Dim act As List(Of TimeEntryActivity) = repo.GetTimeEntryActivities()
            TimeEntryComboBox.DataSource = act
        Catch ex As ApiAccessException
            MessageBox.Show("作業分類を取得できませんでした。")
            StartStopButton.Enabled = False
            PauseBtn.Enabled = False
        End Try

        TicketNameLabel.Text = CurrentIssue.Subject
        EstimatedHoursLabel.Text = BuildTimeLabel(CurrentIssue.EstimatedHours)
        ElapsedHoursLabel.Text = BuildTimeLabel(0.0D)

        Dim tip As String = IIf(My.Settings.ImmediateMesureOnPressEnter, "Enterキーを押すと即座に計測を始めます。", "計測を始めるには「Start」ボタンを押します。")
        CommentsToolTip1.SetToolTip(CommentTextBox, tip)
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If ElapsedTimer1.Enabled Then
            StopCount()

            Dim repo As New RedmineRepository()

            Dim tea As TimeEntryActivity = TimeEntryComboBox.SelectedItem
            Dim respEnt = repo.CreateTimeEntry(CurrentIssue, stopWatch.Elapsed.TotalHours, tea.Id, CommentTextBox.Text)
            If respEnt.StatusCode = HttpStatusCode.Created Then
                MessageBox.Show("正常登録されました。", "経過時間登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Dim b As New StringBuilder()
                b.Append("登録に失敗しました。").Append(Environment.NewLine).Append("理由 : ").Append(respEnt.Reason)
                b.Append(Environment.NewLine).Append("再送しますか？")
                Dim dr As DialogResult = MessageBox.Show(b.ToString(), "経過時間登録", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

                If dr = DialogResult.Yes Then
                    respEnt = repo.CreateTimeEntry(CurrentIssue, stopWatch.Elapsed.TotalHours, tea.Id, CommentTextBox.Text)
                    If respEnt.StatusCode = HttpStatusCode.Created Then
                        MessageBox.Show("正常登録されました。", "経過時間登録")
                        Me.Close()
                    Else
                        Dim builder As New StringBuilder
                        builder.Append("登録できませんでした。").Append(Environment.NewLine).Append("理由 : ").Append(respEnt.Reason)
                        MessageBox.Show(builder.ToString(), "経過時間登録", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                Else
                    Me.Close()
                End If
            End If
        Else
            StartCount()
        End If
    End Sub

    Private Sub StartCount()
        TimeEntryComboBox.Enabled = False
        PauseBtn.Enabled = True
        CommentTextBox.Enabled = False
        StartStopButton.Text = "Stop"

        stopWatch.Restart()
        ElapsedTimer1.Start()
        Paused = False
    End Sub

    Private Sub StopCount()
        stopWatch.Stop()
        ElapsedTimer1.Stop()
        Paused = True

        TimeEntryComboBox.Enabled = True
        PauseBtn.Enabled = False
        CommentTextBox.Enabled = True
        StartStopButton.Text = "Start"
    End Sub

    Private Sub ElapsedTimer1_Tick(sender As Object, e As EventArgs) Handles ElapsedTimer1.Tick
        Dim ts = stopWatch.Elapsed
        If Not Paused Then
            ElapsedHoursLabel.Text = BuildTimeLabel(ts)
        End If

        If ts.TotalHours > CurrentIssue.EstimatedHours Then
            ElapsedHoursLabel.ForeColor = Color.Red
        Else
            ElapsedHoursLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TaskMeasureForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ElapsedTimer1.Enabled Then
            Dim msg As String = "時間計測中です。" + Environment.NewLine + "計測を中止しますか？(時間登録はされません)"
            Dim result As DialogResult = MessageBox.Show(msg, "中止確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                StopCount()
                PreForm.Show()
            Else
                ' 中止しないので以後のイベントをキャンセル
                e.Cancel = True
            End If
        Else
            PreForm.Show()
        End If
    End Sub

    Private Sub TaskMeasureForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' 念のため参照を切る目的でnullにする
        PreForm = Nothing
    End Sub
End Class