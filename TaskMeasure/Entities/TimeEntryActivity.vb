Imports Newtonsoft.Json

Namespace Entities
    <JsonObject("time_entry_activity")>
    Public Class TimeEntryActivity
        <JsonProperty("id")>
        Public Property Id() As Integer
        <JsonProperty("name")>
        Public Property Name() As String
        <JsonProperty("is_default")>
        Public Property IsDefault() As Boolean = False
    End Class
End Namespace