Imports Newtonsoft.Json

Namespace Entities
    Public Class TimeEntryActivities
        <JsonProperty("time_entry_activities")>
        Public Property TimeEntryActivities() As List(Of TimeEntryActivity)
    End Class
End Namespace