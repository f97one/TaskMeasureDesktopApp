Imports Newtonsoft.Json

Namespace Entities

    <JsonObject("project")>
    Public Class RedmineProject
        <JsonProperty("id")>
        Public Property Id() As Integer
        <JsonProperty("name")>
        Public Property Name() As String
        <JsonProperty("identifier")>
        Public Property Identifier() As String
        <JsonProperty("description")>
        Public Property Description() As String
        <JsonProperty("parent")>
        Public Property Parent() As RedmineProject
        <JsonProperty("status")>
        Public Property Status() As Integer
        <JsonProperty("is_public")>
        Public Property IsPublic() As Boolean
        <JsonProperty("created_on")>
        Public Property CreatedOn() As DateTime
        <JsonProperty("updated_on")>
        Public Property UpdatedOn() As DateTime
    End Class
End Namespace