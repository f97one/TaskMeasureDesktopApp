Imports Newtonsoft.Json

Namespace Entities
    Public Class BaseEntity
        <JsonProperty("total_count")>
        Public Property TotalCount() As Integer
        <JsonProperty("offset")>
        Public Property Offset() As Integer
        <JsonProperty("limit")>
        Public Property Limit() As Integer
    End Class
End Namespace