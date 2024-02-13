Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        toolTip1.SetToolTip(Button1, "Click to display Object Demonstrations")
        toolTip1.SetToolTip(Button2, "Click to exit the application")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of Form2
        Dim form2Instance As New Form2()

        ' Show Form2
        form2Instance.Show()

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
End Class
