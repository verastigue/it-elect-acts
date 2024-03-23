Imports System.Linq

Module UsersData
    Private _users As New List(Of User)()

    Public session As User

    Public Property Users As List(Of User)
        Get
            Return _users
        End Get
        Set(value As List(Of User))
            _users = value
        End Set
    End Property

    Public Sub AddUser(newUser As User)
        _users.Add(newUser)
    End Sub
End Module
