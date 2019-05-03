Imports System.Net
Imports System.Security.Policy
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports RestSharp
Imports TaskMeasure.Entities

Namespace Repositories
    Public Class RedmineRepository

        Public Enum AccessType
            Json
            Xml
        End Enum

        Public Function GetProjects() As List(Of RedmineProject)
            Dim params As New Dictionary(Of String, String)
            Dim resp As RestResponse = ExecuteRequest("projects", Method.GET, params)

            If resp.ResponseStatus = ResponseStatus.Completed Then
                Dim proj = JsonConvert.DeserializeObject(Of ProjectsEntity)(resp.Content, New IsoDateTimeConverter())

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
                Dim issues = JsonConvert.DeserializeObject(Of IssuesEntity)(resp.Content, New IsoDateTimeConverter())
                Return issues.Issues
            Else
                Throw New ApiAccessException(resp.StatusCode, resp.ResponseStatus)
            End If
        End Function

        Public Function CreateTimeEntry(issue As RedmineIssue, elapsedTime As Double, activityId As Integer, comment As String) As RedmineResponseEntity
            Dim timeEntry = New TimeEntries(issue, elapsedTime, activityId, comment)
            Dim cnv As New IsoDateTimeConverter()
            cnv.DateTimeFormat = "yyyy-MM-dd"
            Dim param = JsonConvert.SerializeObject(timeEntry, cnv)

            Dim clt As RestClient = GetClient("time_entries")
            Dim req As RestRequest = GetRequest(Method.POST)
            req.AddJsonBody(param)

            Dim response As RestResponse = clt.Execute(req)

            Return New RedmineResponseEntity(response.StatusCode, response.Content)
        End Function

        Public Function GetTimeEntryActivities() As List(Of TimeEntryActivity)
            Dim params As New Dictionary(Of String, String)
            Dim resp As RestResponse = ExecuteRequest("enumerations/time_entry_activities", Method.GET, params)

            If resp.ResponseStatus = ResponseStatus.Completed AndAlso resp.StatusCode = HttpStatusCode.OK Then
                Dim timeEntryActivities = JsonConvert.DeserializeObject(Of TimeEntryActivities)(resp.Content, New IsoDateTimeConverter())
                Return timeEntryActivities.TimeEntryActivities
            Else
                Throw New ApiAccessException(resp.StatusCode, resp.ResponseStatus)
            End If
        End Function

        Private Function GetClient(endpoint As String) As RestClient
            Return GetClient(endpoint, AccessType.Json)
        End Function

        Private Function GetClient(endpoint As String, accessType As AccessType) As RestClient
            Dim t As String = IIf(accessType = AccessType.Json, "json", "xml")
            Dim clt As New RestClient()
            Dim urlStr As String = String.Format("{0}/{1}.{2}", My.Settings.RedmineUrl, endpoint, t)
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