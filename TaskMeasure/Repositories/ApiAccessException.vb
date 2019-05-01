Imports System.Net
Imports RestSharp

Namespace Repositories
    Public Class ApiAccessException
        Inherits Exception

        Private _StatusCode As HttpStatusCode
        Private _ResponseStatus As ResponseStatus

        Public Property StatusCode() As HttpStatusCode
            Get
                Return _StatusCode
            End Get
            Private Set
                _StatusCode = Value
            End Set
        End Property

        Public Property ResponseStatus() As ResponseStatus
            Get
                Return _ResponseStatus
            End Get
            Private Set
                _ResponseStatus = Value
            End Set
        End Property

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(statusCode As HttpStatusCode)
            MyBase.New()
            _statusCode = statusCode
        End Sub

        Public Sub New(statusCode As HttpStatusCode, responseStatus As ResponseStatus)
            MyBase.New()
            _StatusCode = statusCode
            _ResponseStatus = responseStatus
        End Sub

    End Class
End Namespace