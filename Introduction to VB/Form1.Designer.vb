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
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ContextMenuStrip2 = New ContextMenuStrip(components)
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(128, 191)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(171, 47)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = "Load Object Demo"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox2.ForeColor = SystemColors.InfoText
        RichTextBox2.Location = New Point(377, 191)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(171, 47)
        RichTextBox2.TabIndex = 4
        RichTextBox2.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 527)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Name = "Form1"
        Text = "Welcome Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox

End Class
