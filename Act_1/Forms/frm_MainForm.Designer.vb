<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MainForm
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
        btn_Form1 = New Button()
        btn_Form2 = New Button()
        btn_Form3 = New Button()
        btn_Form4 = New Button()
        btn_Exit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_Form1
        ' 
        btn_Form1.Location = New Point(262, 154)
        btn_Form1.Name = "btn_Form1"
        btn_Form1.Size = New Size(75, 23)
        btn_Form1.TabIndex = 0
        btn_Form1.Text = "Form 1"
        btn_Form1.UseVisualStyleBackColor = True
        ' 
        ' btn_Form2
        ' 
        btn_Form2.Location = New Point(262, 220)
        btn_Form2.Name = "btn_Form2"
        btn_Form2.Size = New Size(75, 23)
        btn_Form2.TabIndex = 1
        btn_Form2.Text = " Form 2"
        btn_Form2.UseVisualStyleBackColor = True
        ' 
        ' btn_Form3
        ' 
        btn_Form3.Location = New Point(429, 154)
        btn_Form3.Name = "btn_Form3"
        btn_Form3.Size = New Size(75, 23)
        btn_Form3.TabIndex = 2
        btn_Form3.Text = "Form 3"
        btn_Form3.UseVisualStyleBackColor = True
        ' 
        ' btn_Form4
        ' 
        btn_Form4.Location = New Point(429, 220)
        btn_Form4.Name = "btn_Form4"
        btn_Form4.Size = New Size(75, 23)
        btn_Form4.TabIndex = 3
        btn_Form4.Text = "Form 4"
        btn_Form4.UseVisualStyleBackColor = True
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Location = New Point(352, 294)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(75, 23)
        btn_Exit.TabIndex = 4
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 30)
        Label1.TabIndex = 5
        Label1.Text = "Main Form"
        ' 
        ' frm_MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btn_Exit)
        Controls.Add(btn_Form4)
        Controls.Add(btn_Form3)
        Controls.Add(btn_Form2)
        Controls.Add(btn_Form1)
        Name = "frm_MainForm"
        Text = "frm_MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Form1 As Button
    Friend WithEvents btn_Form2 As Button
    Friend WithEvents btn_Form3 As Button
    Friend WithEvents btn_Form4 As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Label1 As Label
End Class
