Imports System.Net
Imports System.Text
Imports System.Web.Configuration
Imports TaskMeasure.Entities
Imports TaskMeasure.Repositories

Public Class IssueMeasureForm

    Private Property ImmediateStart() As Boolean
    Private Property CurrentIssue() As RedmineIssue
    Private Property Paused() As Boolean

    Private stopWatch As New Stopwatch()

    Public Sub New(issue As RedmineIssue, immediateStart As Boolean)
        Me.ImmediateStart = immediateStart
        Me.CurrentIssue = issue
        Me.Paused = False
    End Sub

    Private Sub IssueMeasureForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicketNameLabel.Text = CurrentIssue.Subject
        EstimatedHoursLabel.Text = BuildTimeLabel(CurrentIssue.EstimatedHours)
        ElapsedHoursLabel.Text = BuildTimeLabel(0.0D)

        If ImmediateStart Then
            StartCount()
        End If

    End Sub

    Private Function BuildTimeLabel(timeSpan As TimeSpan) As String
        Return String.Format("{0} H ({1}時間{2}分)", timeSpan.TotalHours, Math.Floor(timeSpan.TotalHours), timeSpan.Minutes)
    End Function

    Private Function BuildTimeLabel(t As Double) As String
        Dim ts As TimeSpan = TimeSpan.FromHours(t)
        Return String.Format("{0} H ({1}時間{2}分)", t, Math.Floor(ts.TotalHours), ts.Minutes)
    End Function

    Private Sub StartCount()
        stopWatch.Restart()
        ElapsedTimer1.Start()
        Paused = False

        StartStopButton.Text = "Stop"
    End Sub

    Private Sub StopCount()
        stopWatch.Stop()
        ElapsedTimer1.Stop()
        Paused = True

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

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        If ElapsedTimer1.Enabled Then
            StopCount()

            Dim repo As New RedmineRepository()
            Dim respEnt = repo.CreateTimeEntry(CurrentIssue, stopWatch.Elapsed.TotalHours)
            If respEnt.StatusCode = HttpStatusCode.Created Then
                MessageBox.Show("正常登録されました。", "経過時間登録", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                Dim b As New StringBuilder()
                b.Append("登録に失敗しました。").Append(Environment.NewLine).Append("理由 : ").Append(respEnt.Reason)
                b.Append(Environment.NewLine).Append("再送しますか？")
                Dim dr As DialogResult = MessageBox.Show(b.ToString(), "経過時間登録", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

                If dr = DialogResult.Yes Then
                    respEnt = repo.CreateTimeEntry(CurrentIssue, stopWatch.Elapsed.TotalHours)
                    If respEnt.StatusCode = HttpStatusCode.Created Then
                        MessageBox.Show("正常登録されました。", "経過時間登録")
                        Me.Close()
                    Else
                        Dim builder As New StringBuilder
                        builder.Append("登録できませんでした。").Append(Environment.NewLine).Append("理由 : ").Append(respEnt.Reason)
                        MessageBox.Show(builder.ToString(), "経過時間登録", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End If
            End If
        Else
            StartCount()
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        If Paused Then
            stopWatch.Start()
        Else
            stopWatch.Stop()
        End If

        ' フラグを反転させる
        Paused = Not (Me.Paused)
    End Sub
End Class