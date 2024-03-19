<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Form3
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
        btn_Exit = New Button()
        btn_ShowAll = New Button()
        btn_HideAll = New Button()
        btn_Button = New Button()
        chk_CheckBox = New CheckBox()
        opt_RadioButton = New RadioButton()
        SuspendLayout()
        ' 
        ' btn_Back
        ' 
        btn_Back.Location = New Point(81, 47)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(75, 23)
        btn_Back.TabIndex = 0
        btn_Back.Text = "Back"
        btn_Back.UseVisualStyleBackColor = True
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(651, 47)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(75, 23)
        btn_Exit.TabIndex = 1
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_ShowAll
        ' 
        btn_ShowAll.Location = New Point(81, 327)
        btn_ShowAll.Name = "btn_ShowAll"
        btn_ShowAll.Size = New Size(75, 23)
        btn_ShowAll.TabIndex = 2
        btn_ShowAll.Text = "Show all"
        btn_ShowAll.UseVisualStyleBackColor = True
        ' 
        ' btn_HideAll
        ' 
        btn_HideAll.Location = New Point(651, 327)
        btn_HideAll.Name = "btn_HideAll"
        btn_HideAll.Size = New Size(75, 23)
        btn_HideAll.TabIndex = 3
        btn_HideAll.Text = "Hide all"
        btn_HideAll.UseVisualStyleBackColor = True
        ' 
        ' btn_Button
        ' 
        btn_Button.Location = New Point(369, 124)
        btn_Button.Name = "btn_Button"
        btn_Button.Size = New Size(75, 23)
        btn_Button.TabIndex = 4
        btn_Button.Text = "Button"
        btn_Button.UseVisualStyleBackColor = True
        ' 
        ' chk_CheckBox
        ' 
        chk_CheckBox.AutoSize = True
        chk_CheckBox.Location = New Point(369, 167)
        chk_CheckBox.Name = "chk_CheckBox"
        chk_CheckBox.Size = New Size(79, 19)
        chk_CheckBox.TabIndex = 5
        chk_CheckBox.Text = "CheckBox"
        chk_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' opt_RadioButton
        ' 
        opt_RadioButton.AutoSize = True
        opt_RadioButton.Location = New Point(369, 205)
        opt_RadioButton.Name = "opt_RadioButton"
        opt_RadioButton.Size = New Size(91, 19)
        opt_RadioButton.TabIndex = 6
        opt_RadioButton.TabStop = True
        opt_RadioButton.Text = "RadioButton"
        opt_RadioButton.UseVisualStyleBackColor = True
        ' 
        ' frm_Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(opt_RadioButton)
        Controls.Add(chk_CheckBox)
        Controls.Add(btn_Button)
        Controls.Add(btn_HideAll)
        Controls.Add(btn_ShowAll)
        Controls.Add(btn_Exit)
        Controls.Add(btn_Back)
        Name = "frm_Form3"
        Text = "frm_Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_ShowAll As Button
    Friend WithEvents btn_HideAll As Button
    Friend WithEvents btn_Button As Button
    Friend WithEvents chk_CheckBox As CheckBox
    Friend WithEvents opt_RadioButton As RadioButton
End Class
