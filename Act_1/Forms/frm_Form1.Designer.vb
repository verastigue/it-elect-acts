<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_Back = New Button()
        btn_Login = New Button()
        txt_Username = New TextBox()
        txt_Password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btn_Exit = New Button()
        SuspendLayout()
        ' 
        ' btn_Back
        ' 
        btn_Back.Location = New Point(26, 37)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(75, 23)
        btn_Back.TabIndex = 0
        btn_Back.Text = "Back"
        btn_Back.UseVisualStyleBackColor = True
        ' 
        ' btn_Login
        ' 
        btn_Login.Location = New Point(306, 244)
        btn_Login.Name = "btn_Login"
        btn_Login.Size = New Size(100, 23)
        btn_Login.TabIndex = 1
        btn_Login.Text = "Login"
        btn_Login.UseVisualStyleBackColor = True
        ' 
        ' txt_Username
        ' 
        txt_Username.Location = New Point(306, 127)
        txt_Username.Name = "txt_Username"
        txt_Username.Size = New Size(100, 23)
        txt_Username.TabIndex = 2
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(306, 197)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(100, 23)
        txt_Password.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(306, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 4
        Label1.Text = "username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(306, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "password"
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(667, 37)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(100, 23)
        btn_Exit.TabIndex = 6
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' frm_Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Exit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_Password)
        Controls.Add(txt_Username)
        Controls.Add(btn_Login)
        Controls.Add(btn_Back)
        Name = "frm_Form1"
        Text = "frm_Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Login As Button
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Exit As Button
End Class
