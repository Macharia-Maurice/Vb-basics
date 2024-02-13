Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Select an Image File"
        openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"


        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            pic_area.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

End Class