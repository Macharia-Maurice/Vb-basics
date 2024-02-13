<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 3
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(145, 206)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 41)
        Button1.TabIndex = 5
        Button1.Text = "Load Object Demo"
        Button1.TextAlign = ContentAlignment.TopLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.BorderSize = 3
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(367, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 41)
        Button2.TabIndex = 6
        Button2.Text = "EXIT"
        Button2.TextAlign = ContentAlignment.TopLeft
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 527)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        ShowIcon = False
        Text = "Welcome Form"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
