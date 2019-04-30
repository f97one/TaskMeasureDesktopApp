Public Class NewTaskForm

    Dim stopWatch As New Stopwatch()

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        TaskCountUpTimer1.Enabled = True
        stopWatch.Start()
    End Sub

    Private Sub TaskCountUpTimer1_Tick(sender As Object, e As EventArgs) Handles TaskCountUpTimer1.Tick
        ElaspedTimeLabel.Text = stopWatch.Elapsed.Hours.ToString("00") &
                                ":" &
                                stopWatch.Elapsed.Minutes.ToString("00") &
                                ":" &
                                stopWatch.Elapsed.Seconds.ToString("00")
    End Sub

    Private Sub NewTaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'EstimatedTimePicker1.Value = 
    End Sub
End Class
