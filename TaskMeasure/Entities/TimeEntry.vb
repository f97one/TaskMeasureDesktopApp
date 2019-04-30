﻿Imports Newtonsoft.Json

Namespace Entities
    Public Class TimeEntry
        <JsonProperty("issue_id ")>
        Public Property IssueId() As Integer
        <JsonProperty("spent_on")>
        Public Property SpentOn() As DateTime
        <JsonProperty("hours")>
        Public Property Hours() As Double
        <JsonProperty("comments")>
        Public Property Comments() As String

        Public Sub New(issue As RedmineIssue, elapsedTime As Double)
            Me.SpentOn = DateTime.Now
            Me.IssueId = issue.Id
            Me.Hours = elapsedTime
            Me.Comments = "Auto-generated by TaskMeasure."
        End Sub

    End Class
End Namespace