<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Form4
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
        components = New ComponentModel.Container()
        btn_Back = New Button()
        btn_Enable = New Button()
        btn_Disable = New Button()
        btn_ShowMessage = New Button()
        Button_Back1 = New Button_Back(components)
        Button_Back2 = New Button_Back(components)
        Button_Back3 = New Button_Back(components)
        Button_Back4 = New Button_Back(components)
        txt_Message = New TextBox()
        btn_Exit = New Button()
        SuspendLayout()
        ' 
        ' btn_Back
        ' 
        btn_Back.Location = New Point(60, 53)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(75, 23)
        btn_Back.TabIndex = 0
        btn_Back.Text = "Back"
        btn_Back.UseVisualStyleBackColor = True
        ' 
        ' btn_Enable
        ' 
        btn_Enable.Location = New Point(270, 216)
        btn_Enable.Name = "btn_Enable"
        btn_Enable.Size = New Size(75, 23)
        btn_Enable.TabIndex = 1
        btn_Enable.Text = "Enable"
        btn_Enable.UseVisualStyleBackColor = True
        ' 
        ' btn_Disable
        ' 
        btn_Disable.Location = New Point(270, 266)
        btn_Disable.Name = "btn_Disable"
        btn_Disable.Size = New Size(75, 23)
        btn_Disable.TabIndex = 2
        btn_Disable.Text = "Disable"
        btn_Disable.UseVisualStyleBackColor = True
        ' 
        ' btn_ShowMessage
        ' 
        btn_ShowMessage.Location = New Point(383, 216)
        btn_ShowMessage.Name = "btn_ShowMessage"
        btn_ShowMessage.Size = New Size(128, 23)
        btn_ShowMessage.TabIndex = 3
        btn_ShowMessage.Text = "Show Message"
        btn_ShowMessage.UseVisualStyleBackColor = True
        ' 
        ' txt_Message
        ' 
        txt_Message.Location = New Point(270, 114)
        txt_Message.Name = "txt_Message"
        txt_Message.Size = New Size(241, 23)
        txt_Message.TabIndex = 4
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(642, 53)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(75, 23)
        btn_Exit.TabIndex = 5
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' frm_Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Exit)
        Controls.Add(txt_Message)
        Controls.Add(btn_ShowMessage)
        Controls.Add(btn_Disable)
        Controls.Add(btn_Enable)
        Controls.Add(btn_Back)
        Name = "frm_Form4"
        Text = "frm_Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Enable As Button
    Friend WithEvents btn_Disable As Button
    Friend WithEvents btn_ShowMessage As Button
    Friend WithEvents Button_Back1 As Button_Back
    Friend WithEvents Button_Back2 As Button_Back
    Friend WithEvents Button_Back3 As Button_Back
    Friend WithEvents Button_Back4 As Button_Back
    Friend WithEvents txt_Message As TextBox
    Friend WithEvents btn_Exit As Button
End Class
