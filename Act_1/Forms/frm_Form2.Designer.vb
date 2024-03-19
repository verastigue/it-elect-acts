<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Form2
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
        btn_Exit = New Button()
        btn_Back = New Button()
        btn_Welcome = New Button()
        btn_Hello = New Button()
        SuspendLayout()
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(693, 58)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(75, 23)
        btn_Exit.TabIndex = 7
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_Back
        ' 
        btn_Back.Location = New Point(39, 58)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(75, 23)
        btn_Back.TabIndex = 6
        btn_Back.Text = "Back"
        btn_Back.UseVisualStyleBackColor = True
        ' 
        ' btn_Welcome
        ' 
        btn_Welcome.Location = New Point(348, 238)
        btn_Welcome.Name = "btn_Welcome"
        btn_Welcome.Size = New Size(75, 23)
        btn_Welcome.TabIndex = 5
        btn_Welcome.Text = "Welcome"
        btn_Welcome.UseVisualStyleBackColor = True
        ' 
        ' btn_Hello
        ' 
        btn_Hello.Location = New Point(348, 181)
        btn_Hello.Name = "btn_Hello"
        btn_Hello.Size = New Size(75, 23)
        btn_Hello.TabIndex = 4
        btn_Hello.Text = "Hello"
        btn_Hello.UseVisualStyleBackColor = True
        ' 
        ' frm_Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Exit)
        Controls.Add(btn_Back)
        Controls.Add(btn_Welcome)
        Controls.Add(btn_Hello)
        Name = "frm_Form2"
        Text = "frm_Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Welcome As Button
    Friend WithEvents btn_Hello As Button
End Class
