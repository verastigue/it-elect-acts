Imports Guna.UI2.WinForms

Module Functions
    'CHECK THE TEXTBOX IF EMPTY
    Function IsEmpty(textbox As Guna2TextBox) As Boolean
        Return textbox.Text.Trim() = ""
    End Function

    Function UsernameExists(username As String) As Boolean
        For Each user As User In UsersData.Users
            If user.Username = username Then
                Return True
            End If
        Next
        Return False
    End Function

    Function EmailExists(email As String) As Boolean
        For Each user As User In UsersData.Users
            If user.Email = email Then
                Return True
            End If
        Next
        Return False
    End Function

    Function Login(username As String, password As String) As User
        For Each user As User In UsersData.Users
            If user.Username = username AndAlso user.Password = password Then
                Return user
            End If
        Next
        Return Nothing
    End Function

    Function IsRecoverAccount(username As String, email As String) As Boolean
        For Each user As User In UsersData.Users
            If user.Username = username AndAlso user.Email = email Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub UpdatePassword(username As String, newPassword As String)
        For Each user As User In UsersData.Users
            If user.Username = username Then
                user.Password = newPassword
            End If
        Next
    End Sub
End Module
