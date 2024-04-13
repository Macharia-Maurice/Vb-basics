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
        GradeCalculator = New GroupBox()
        Subject1TextBox = New TextBox()
        Subject2TextBox = New TextBox()
        Subject3TextBox = New TextBox()
        Subject4TextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        GradeCalculator.SuspendLayout()
        SuspendLayout()
        ' 
        ' GradeCalculator
        ' 
        GradeCalculator.Controls.Add(Button1)
        GradeCalculator.Controls.Add(Label4)
        GradeCalculator.Controls.Add(Label3)
        GradeCalculator.Controls.Add(Label1)
        GradeCalculator.Controls.Add(Label2)
        GradeCalculator.Controls.Add(Subject4TextBox)
        GradeCalculator.Controls.Add(Subject3TextBox)
        GradeCalculator.Controls.Add(Subject2TextBox)
        GradeCalculator.Controls.Add(Subject1TextBox)
        GradeCalculator.Location = New Point(31, 29)
        GradeCalculator.Name = "GradeCalculator"
        GradeCalculator.Size = New Size(814, 528)
        GradeCalculator.TabIndex = 0
        GradeCalculator.TabStop = False
        GradeCalculator.Text = "Grade Calculator"
        ' 
        ' Subject1TextBox
        ' 
        Subject1TextBox.BorderStyle = BorderStyle.FixedSingle
        Subject1TextBox.Location = New Point(181, 80)
        Subject1TextBox.Name = "Subject1TextBox"
        Subject1TextBox.Size = New Size(188, 31)
        Subject1TextBox.TabIndex = 0
        ' 
        ' Subject2TextBox
        ' 
        Subject2TextBox.BorderStyle = BorderStyle.FixedSingle
        Subject2TextBox.Location = New Point(181, 151)
        Subject2TextBox.Name = "Subject2TextBox"
        Subject2TextBox.Size = New Size(188, 31)
        Subject2TextBox.TabIndex = 1
        ' 
        ' Subject3TextBox
        ' 
        Subject3TextBox.BorderStyle = BorderStyle.FixedSingle
        Subject3TextBox.Location = New Point(181, 232)
        Subject3TextBox.Name = "Subject3TextBox"
        Subject3TextBox.Size = New Size(188, 31)
        Subject3TextBox.TabIndex = 2
        ' 
        ' Subject4TextBox
        ' 
        Subject4TextBox.BorderStyle = BorderStyle.FixedSingle
        Subject4TextBox.Location = New Point(181, 317)
        Subject4TextBox.Name = "Subject4TextBox"
        Subject4TextBox.Size = New Size(188, 31)
        Subject4TextBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 25)
        Label1.TabIndex = 1
        Label1.Text = "Subject1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 25)
        Label2.TabIndex = 4
        Label2.Text = "Subject2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 25)
        Label3.TabIndex = 5
        Label3.Text = "Subject3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 323)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 25)
        Label4.TabIndex = 6
        Label4.Text = "Subject4"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(181, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 46)
        Button1.TabIndex = 7
        Button1.Text = "Grade"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(904, 569)
        Controls.Add(GradeCalculator)
        Name = "Form1"
        Text = "Form1"
        GradeCalculator.ResumeLayout(False)
        GradeCalculator.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GradeCalculator As GroupBox
    Friend WithEvents Subject4TextBox As TextBox
    Friend WithEvents Subject3TextBox As TextBox
    Friend WithEvents Subject2TextBox As TextBox
    Friend WithEvents Subject1TextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
