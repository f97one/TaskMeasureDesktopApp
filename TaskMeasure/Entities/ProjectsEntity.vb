Imports Newtonsoft.Json

Namespace Entities
    Public Class ProjectsEntity
        Inherits BaseEntity

        <JsonProperty("projects")>
        Public Property Projects() As List(Of RedmineProject)
    End Class
End Namespace