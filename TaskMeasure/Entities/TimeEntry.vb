Imports Newtonsoft.Json

Namespace Entities

    Public Class TimeEntries
        <JsonProperty("time_entry")>
        Public Property TimeEntry() As TimeEntry

        Public Sub New(issue As RedmineIssue, elapsedTime As Double, activityId As Integer, comment As String)
            TimeEntry = New TimeEntry(issue, elapsedTime, activityId, comment)
        End Sub

    End Class

    Public Class TimeEntry
        Private _Hours As Double

        <JsonProperty("project_id")>
        Public Property ProjectId() As Integer
        <JsonProperty("issue_id")>
        Public Property IssueId() As Integer
        <JsonProperty("spent_on")>
        Public Property SpentOn() As Date
        <JsonProperty("hours")>
        Public Property Hours() As Double
            Get
                ' 小数点二けたで四捨五入した値を返す
                Return Math.Round(_Hours, 2, MidpointRounding.AwayFromZero)
            End Get
            Set
                _Hours = Value
            End Set
        End Property

        <JsonProperty("activity_id")>
        Public Property ActivityId() As Integer
        <JsonProperty("comments")>
        Public Property Comments() As String

        Public Sub New(issue As RedmineIssue, elapsedTime As Double, activityId As Integer, comment As String)
            Me.SpentOn = DateTime.Now
            ProjectId = issue.Project.Id
            Me.IssueId = issue.Id
            Me.Hours = elapsedTime
            Me.ActivityId = activityId
            Me.Comments = comment
        End Sub

    End Class
End Namespace