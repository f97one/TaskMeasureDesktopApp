Imports System.Net

Namespace Entities
    Public Class RedmineResponseEntity
        Private _StatusCode As Integer
        Private _Reason As String

        Public Property StatusCode() As HttpStatusCode
            Get
                Return _StatusCode
            End Get
            Private Set
                _StatusCode = Value
            End Set
        End Property

        Public Property Reason() As String
            Get
                Return _Reason
            End Get
            Private Set
                _Reason = Value
            End Set
        End Property

        Public Sub New(statusCode As HttpStatusCode, reason As String)
            Me.StatusCode = statusCode
            Me.Reason = reason
        End Sub
    End Class
End Namespace