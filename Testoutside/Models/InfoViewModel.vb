Imports System.ComponentModel.DataAnnotations

Public Class InfoViewModel

    Public Property id As Integer

    <Required>
    <StringLength(50)>
    Public Property name As String

    Public Property age As Integer
End Class
