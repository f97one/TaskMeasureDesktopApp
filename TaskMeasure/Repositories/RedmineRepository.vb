Imports System.Security.Policy
Imports Newtonsoft.Json
Imports RestSharp
Imports TaskMeasure.Entities

Namespace Repositories
    Public Class RedmineRepository

        Public Function GetProjects() As List(Of RedmineProject)
            Dim params As New Dictionary(Of String, String)
            Dim resp As RestResponse = ExecuteRequest("projects", Method.GET, params)

            If resp.ResponseStatus = ResponseStatus.Completed Then
                Dim proj = JsonConvert.DeserializeObject(Of ProjectsEntity)(resp.Content)

                Return proj.Projects
            Else
                Throw New ApiAccessException(resp.StatusCode, resp.ResponseStatus)
            End If
        End Function

        Public Function GetIssues(project As RedmineProject) As List(Of RedmineIssue)
            Dim params As New Dictionary(Of String, String)
            params.Add("project_id", project.Id.ToString())
            Dim resp As RestResponse = ExecuteRequest("issues", Method.GET, params)

            If resp.ResponseStatus = ResponseStatus.Completed Then
                Dim issues = JsonConvert.DeserializeObject(Of IssuesEntity)(resp.Content)
                Return issues.Issues
            Else
                Throw New ApiAccessException(resp.StatusCode, resp.ResponseStatus)
            End If
        End Function

        Public Function CreateTimeEntry(issue As RedmineIssue, elapsedTime As Double) As RedmineResponseEntity
            Dim timeEntry As TimeEntry = New TimeEntry(issue, elapsedTime)
            Dim param = JsonConvert.SerializeObject(timeEntry)

            Dim clt As RestClient = GetClient("time_entry")
            Dim req As RestRequest = GetRequest(Method.POST)
            req.AddParameter("time_entry", param)

            Dim response As RestResponse = clt.Execute(req)

            Return New RedmineResponseEntity(response.StatusCode, response.Content)
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

        Private Function ExecuteRequest(endpoint As String, method As Method, params As IDictionary(Of String, String)) As RestResponse
            Dim clt As RestClient = GetClient(endpoint)
            Dim req As RestRequest = GetRequest(method)

            For Each kvp In params
                req.AddParameter(kvp.Key, kvp.Value, ParameterType.GetOrPost)
            Next

            Return clt.Execute(req)
        End Function

    End Class
End Namespace