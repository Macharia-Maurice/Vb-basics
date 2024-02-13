Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class Form2
    ' Assume txtSample is the name of your TextBox control

    Private Sub Garamond_CheckedChanged(sender As Object, e As EventArgs) Handles garamond.CheckedChanged
        If garamond.Checked Then
            txtSample.Font = New Font("Garamond", 12, FontStyle.Regular)
        End If
    End Sub

    Private Sub Magneto_CheckedChanged(sender As Object, e As EventArgs) Handles magneto.CheckedChanged
        If magneto.Checked Then
            txtSample.Font = New Font("Magneto", 12, FontStyle.Regular)
        End If
    End Sub

    Private Sub Tahoma_CheckedChanged(sender As Object, e As EventArgs) Handles Tahoma.CheckedChanged
        If Tahoma.Checked Then
            txtSample.Font = New Font("Tahoma", 12, FontStyle.Regular)
        End If
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        ' Close or hide Form2
        Me.Close() ' or Me.Hide()

        ' Create an instance of Form1 and show it
        Dim form1Instance As New Form1()
        form1Instance.Show()
    End Sub

    Private Sub UploadBtn_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select an Image File"
        openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            pic_area.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub Italic_CheckedChanged(sender As Object, e As EventArgs) Handles italic.CheckedChanged
        ' Get the existing font from the TextBox
        Dim existingFont As Font = txtSample.Font

        ' Determine the new font style based on the checkbox state
        Dim newFontStyle As FontStyle
        If italic.Checked Then
            ' If checkbox is checked, make it bold
            newFontStyle = FontStyle.Italic
        Else
            ' If checkbox is unchecked, use regular style
            newFontStyle = FontStyle.Regular
        End If

        ' Update the font style for the TextBox
        txtSample.Font = New Font(existingFont.FontFamily, existingFont.Size, newFontStyle)
    End Sub

    Private Sub Bold_CheckedChanged(sender As Object, e As EventArgs) Handles bold.CheckedChanged
        ' Get the existing font from the TextBox
        Dim existingFont As Font = txtSample.Font

        ' Determine the new font style based on the checkbox state
        Dim newFontStyle As FontStyle
        If bold.Checked Then
            ' If checkbox is checked, make it bold
            newFontStyle = FontStyle.Bold
        Else
            ' If checkbox is unchecked, use regular style
            newFontStyle = FontStyle.Regular
        End If

        ' Update the font style for the TextBox
        txtSample.Font = New Font(existingFont.FontFamily, existingFont.Size, newFontStyle)
    End Sub

    Private Sub Bold_italic_CheckedChanged(sender As Object, e As EventArgs) Handles bold_italic.CheckedChanged
        ' Get the existing font from the TextBox
        Dim existingFont As Font = txtSample.Font

        ' Determine the new font style based on the checkbox state
        Dim newFontStyle As FontStyle
        If bold_italic.Checked Then
            ' If checkbox is checked, make it bold
            newFontStyle = FontStyle.Bold Or FontStyle.Italic
        Else
            ' If checkbox is unchecked, use regular style
            newFontStyle = FontStyle.Regular
        End If

        ' Update the font style for the TextBox
        txtSample.Font = New Font(existingFont.FontFamily, existingFont.Size, newFontStyle)
    End Sub

    Private Sub Green_CheckedChanged(sender As Object, e As EventArgs) Handles green.CheckedChanged
        ' Update the text color for the TextBox based on CheckBox1 state
        txtSample.ForeColor = If(green.Checked, Color.Green, SystemColors.ControlText)
    End Sub

    Private Sub Glue_CheckedChanged(sender As Object, e As EventArgs) Handles blue.CheckedChanged
        ' Update the text color for the TextBox based on CheckBox1 state
        txtSample.ForeColor = If(blue.Checked, Color.Blue, SystemColors.ControlText)
    End Sub

    Private Sub Red_CheckedChanged(sender As Object, e As EventArgs) Handles red.CheckedChanged
        ' Update the text color for the TextBox based on CheckBox1 state
        txtSample.ForeColor = If(red.Checked, Color.Red, SystemColors.ControlText)
    End Sub
End Class
