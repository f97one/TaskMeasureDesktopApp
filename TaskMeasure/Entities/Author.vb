﻿Imports Newtonsoft.Json

Namespace Entities
    Public Class Author
        <JsonProperty("id")>
        Public Property Id() As Integer
        <JsonProperty("name")>
        Public Property Name() As String
    End Class
End Namespace