Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class InfoDBContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=InfoDBContext")
    End Sub

    Public Overridable Property Infoes As DbSet(Of Info)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
