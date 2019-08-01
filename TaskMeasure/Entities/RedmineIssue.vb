Imports Newtonsoft.Json

Namespace Entities
    Public Class RedmineIssue
        <JsonProperty("id")>
        Public Property Id() As Integer
        <JsonProperty("project")>
        Public Property Project() As RedmineProject
        <JsonProperty("tracker")>
        Public Property Tracker() As Tracker
        <JsonProperty("status")>
        Public Property Status() As Status
        <JsonProperty("priority")>
        Public Property Priority() As Priority
        <JsonProperty("author")>
        Public Property Author() As Author
        <JsonProperty("assigned_to")>
        Public Property AssignedTo() As AssignedTo
        <JsonProperty("subject")>
        Public Property Subject() As String
        <JsonProperty("description")>
        Public Property Description() As String
        <JsonProperty("start_date")>
        Public Property StartDate() As DateTime
        <JsonProperty("due_date")>
        Public Property DueDate() As Nullable(Of DateTime)
        <JsonProperty("done_rate")>
        Public Property DoneRate() As Integer
        <JsonProperty("estimated_hours")>
        Public Property EstimatedHours() As Nullable(Of Double)
        <JsonProperty("created_on")>
        Public Property CreatedOn() As DateTime
        <JsonProperty("updated_on")>
        Public Property UpdatedOn() As DateTime
    End Class
End Namespace