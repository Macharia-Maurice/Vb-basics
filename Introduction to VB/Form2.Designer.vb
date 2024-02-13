<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
        garamond = New RadioButton()
        magneto = New RadioButton()
        italic = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Tahoma = New RadioButton()
        RichTextBox8 = New RichTextBox()
        GroupBox3 = New GroupBox()
        bold = New CheckBox()
        bold_italic = New CheckBox()
        GroupBox4 = New GroupBox()
        green = New RadioButton()
        blue = New RadioButton()
        red = New RadioButton()
        upload = New Button()
        Exitbtn = New Button()
        pic_area = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(pic_area, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(13, 25)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(141, 48)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = "Sample Text"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(162, 25)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(141, 48)
        RichTextBox2.TabIndex = 1
        RichTextBox2.Text = ""
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(15, 25)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(141, 48)
        RichTextBox3.TabIndex = 2
        RichTextBox3.Text = ""
        ' 
        ' garamond
        ' 
        garamond.AutoSize = True
        garamond.Font = New Font("Segoe UI", 11F)
        garamond.Location = New Point(29, 37)
        garamond.Name = "garamond"
        garamond.Size = New Size(97, 24)
        garamond.TabIndex = 6
        garamond.TabStop = True
        garamond.Text = "Garamond"
        garamond.UseVisualStyleBackColor = True
        ' 
        ' magneto
        ' 
        magneto.AutoSize = True
        magneto.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        magneto.Location = New Point(179, 37)
        magneto.Name = "magneto"
        magneto.Size = New Size(87, 24)
        magneto.TabIndex = 7
        magneto.TabStop = True
        magneto.Text = "Magneto"
        magneto.UseVisualStyleBackColor = True
        ' 
        ' italic
        ' 
        italic.AutoSize = True
        italic.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        italic.Location = New Point(56, 45)
        italic.Name = "italic"
        italic.Size = New Size(60, 24)
        italic.TabIndex = 11
        italic.Text = "Italic"
        italic.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(393, 281)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(89, 21)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "CheckBox2"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(393, 340)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(89, 21)
        CheckBox3.TabIndex = 13
        CheckBox3.Text = "CheckBox3"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RichTextBox1)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Location = New Point(22, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 95)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Tahoma)
        GroupBox2.Controls.Add(RichTextBox8)
        GroupBox2.Controls.Add(garamond)
        GroupBox2.Controls.Add(RichTextBox3)
        GroupBox2.Controls.Add(magneto)
        GroupBox2.Controls.Add(RichTextBox2)
        GroupBox2.Location = New Point(236, 35)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(478, 109)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' Tahoma
        ' 
        Tahoma.AutoSize = True
        Tahoma.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Tahoma.Location = New Point(323, 37)
        Tahoma.Name = "Tahoma"
        Tahoma.Size = New Size(79, 24)
        Tahoma.TabIndex = 16
        Tahoma.TabStop = True
        Tahoma.Text = "Tahoma"
        Tahoma.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox8
        ' 
        RichTextBox8.Location = New Point(309, 25)
        RichTextBox8.Name = "RichTextBox8"
        RichTextBox8.Size = New Size(141, 48)
        RichTextBox8.TabIndex = 3
        RichTextBox8.Text = ""
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(bold)
        GroupBox3.Controls.Add(bold_italic)
        GroupBox3.Controls.Add(italic)
        GroupBox3.Location = New Point(359, 188)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(153, 226)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' bold
        ' 
        bold.AutoSize = True
        bold.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bold.Location = New Point(56, 93)
        bold.Name = "bold"
        bold.Size = New Size(51, 19)
        bold.TabIndex = 13
        bold.Text = "Bold"
        bold.UseVisualStyleBackColor = True
        ' 
        ' bold_italic
        ' 
        bold_italic.AutoSize = True
        bold_italic.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        bold_italic.Location = New Point(56, 152)
        bold_italic.Name = "bold_italic"
        bold_italic.Size = New Size(85, 19)
        bold_italic.TabIndex = 12
        bold_italic.Text = "Bold Italic"
        bold_italic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(green)
        GroupBox4.Controls.Add(blue)
        GroupBox4.Controls.Add(red)
        GroupBox4.Location = New Point(545, 188)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(169, 226)
        GroupBox4.TabIndex = 17
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' green
        ' 
        green.AutoSize = True
        green.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        green.Location = New Point(44, 45)
        green.Name = "green"
        green.Size = New Size(66, 24)
        green.TabIndex = 10
        green.TabStop = True
        green.Text = "Green"
        green.UseVisualStyleBackColor = True
        ' 
        ' blue
        ' 
        blue.AutoSize = True
        blue.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        blue.Location = New Point(44, 93)
        blue.Name = "blue"
        blue.Size = New Size(56, 24)
        blue.TabIndex = 9
        blue.TabStop = True
        blue.Text = "Blue"
        blue.UseVisualStyleBackColor = True
        ' 
        ' red
        ' 
        red.AutoSize = True
        red.Location = New Point(44, 151)
        red.Name = "red"
        red.Size = New Size(104, 21)
        red.TabIndex = 8
        red.TabStop = True
        red.Text = "RadioButton3"
        red.UseVisualStyleBackColor = True
        ' 
        ' upload
        ' 
        upload.FlatAppearance.BorderColor = Color.Black
        upload.FlatAppearance.BorderSize = 3
        upload.FlatStyle = FlatStyle.Popup
        upload.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        upload.Location = New Point(85, 467)
        upload.Name = "upload"
        upload.Size = New Size(137, 46)
        upload.TabIndex = 18
        upload.Text = "Load Picture"
        upload.TextAlign = ContentAlignment.TopLeft
        upload.UseVisualStyleBackColor = True
        ' 
        ' Exitbtn
        ' 
        Exitbtn.FlatAppearance.BorderColor = Color.Black
        Exitbtn.FlatAppearance.BorderSize = 3
        Exitbtn.FlatStyle = FlatStyle.Popup
        Exitbtn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Exitbtn.Location = New Point(624, 478)
        Exitbtn.Name = "Exitbtn"
        Exitbtn.Size = New Size(62, 35)
        Exitbtn.TabIndex = 19
        Exitbtn.Text = "Exit"
        Exitbtn.TextAlign = ContentAlignment.TopLeft
        Exitbtn.UseVisualStyleBackColor = True
        ' 
        ' pic_area
        ' 
        pic_area.BorderStyle = BorderStyle.FixedSingle
        pic_area.InitialImage = Nothing
        pic_area.Location = New Point(35, 196)
        pic_area.Name = "pic_area"
        pic_area.Size = New Size(259, 218)
        pic_area.SizeMode = PictureBoxSizeMode.AutoSize
        pic_area.TabIndex = 20
        pic_area.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(390, 495)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 50)
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 567)
        Controls.Add(PictureBox2)
        Controls.Add(pic_area)
        Controls.Add(Exitbtn)
        Controls.Add(upload)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        ShowIcon = False
        Tag = ""
        Text = "Object Demonstrations"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(pic_area, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents garamond As RadioButton
    Friend WithEvents magneto As RadioButton
    Friend WithEvents italic As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBox8 As RichTextBox
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bold As CheckBox
    Friend WithEvents bold_italic As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents green As RadioButton
    Friend WithEvents blue As RadioButton
    Friend WithEvents red As RadioButton
    Friend WithEvents upload As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents pic_area As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
