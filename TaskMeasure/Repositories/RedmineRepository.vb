Imports System.Security.Policy
Imports Newtonsoft.Json
Imports RestSharp
Imports TaskMeasure.Entities

Namespace Repositories
    Public Class RedmineRepository

        Public Function GetProjects() As List(Of RedmineProject)
            Dim content As String = GetContentFromApi("projects", Method.GET, New Dictionary(Of String, String))

            Dim proj = JsonConvert.DeserializeObject(Of ProjectsEntity)(content)

            Return proj.Projects
        End Function

        Public Function GetIssues(project As RedmineProject) As List(Of RedmineIssue)
            Dim params As New Dictionary(Of String, String)
            params.Add("project_id", project.Id.ToString())

            Dim content As String = GetContentFromApi("issues", Method.GET, params)

            Dim issues = JsonConvert.DeserializeObject(Of IssuesEntity)(content)

            Return issues.Issues
        End Function

        Private Function GetClient(endpoint As String) As RestClient
            Dim clt As New RestClient()
            Dim urlStr As String = String.Format("{0}/{1}.json", My.Settings.RedmineUrl, endpoint)
            clt.BaseUrl = New Uri(urlStr)

            Return clt
        End Function

        Private Function GetRequest(method As Method) As RestRequest
            Dim req As New RestRequest()
            req.Method = method
            req.AddHeader("X-Redmine-API-Key", My.Settings.UserApiKey)

            Return req
        End Function

        Private Function GetContentFromApi(endpoint As String, method As Method, params As IDictionary(Of String, String)) As String
            Dim clt As RestClient = GetClient(endpoint)
            Dim req As RestRequest = GetRequest(method)

            For Each kvp In params
                req.AddParameter(kvp.Key, kvp.Value, ParameterType.GetOrPost)
            Next

            Dim response As RestResponse = clt.Execute(req)

            Return response.Content
        End Function

    End Class
End Namespace