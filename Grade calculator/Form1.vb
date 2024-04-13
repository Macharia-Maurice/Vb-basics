Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Initialize variables to store subject grades
        Dim subject1Grade, subject2Grade, subject3Grade, subject4Grade As Double

        ' Parse input from TextBox controls and validate
        If Not Double.TryParse(Subject1TextBox.Text, subject1Grade) Then
            MessageBox.Show("Invalid input for Subject 1 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(Subject2TextBox.Text, subject2Grade) Then
            MessageBox.Show("Invalid input for Subject 2 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(Subject3TextBox.Text, subject3Grade) Then
            MessageBox.Show("Invalid input for Subject 3 grade. Please enter a valid number.")
            Return
        End If

        If Not Double.TryParse(Subject4TextBox.Text, subject4Grade) Then
            MessageBox.Show("Invalid input for Subject 4 grade. Please enter a valid number.")
            Return
        End If

        ' Calculate average
        Dim averageGrade As Double = (subject1Grade + subject2Grade + subject3Grade + subject4Grade) / 4

        ' Determine grade based on average
        Dim grade As String = ""
        If averageGrade < 50 Then
            grade = "Fail"
        ElseIf averageGrade < 65 Then
            grade = "C"
        ElseIf averageGrade < 75 Then
            grade = "B"
        Else
            grade = "A"
        End If

        ' Display grade in a MessageBox
        MessageBox.Show("Average Grade: " & averageGrade.ToString("F2") & vbCrLf & "Grade: " & grade)

        ' Clear all inputs
        Subject1TextBox.Text = ""
        Subject2TextBox.Text = ""
        Subject3TextBox.Text = ""
        Subject4TextBox.Text = ""

    End Sub

End Class
