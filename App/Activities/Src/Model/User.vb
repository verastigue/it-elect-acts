Imports Microsoft.VisualBasic.ApplicationServices

Public Class User
    Public Property Name As String
    Public Property Email As String
    Public Property Username As String
    Public Property Password As String

    Public Sub New(name As String, email As String, username As String, password As String)
        Me.Name = name
        Me.Email = email
        Me.Username = username
        Me.Password = password
    End Sub


End Class
