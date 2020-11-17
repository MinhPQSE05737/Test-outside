Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Info")>
Partial Public Class Info
    Public Property id As Integer

    <Required>
    <StringLength(50)>
    Public Property name As String

    Public Property age As Integer
End Class
