Imports Newtonsoft.Json

Namespace Entities
    Public Class IssuesEntity
        Inherits BaseEntity

        <JsonProperty("issues")>
        Public Property Issues() As List(Of RedmineIssue)
    End Class
End Namespace