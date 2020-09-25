Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Cat As Integer
        Dim Assignment As Integer
        Dim Exam As Integer
        Dim Total As Integer
        Dim Grade As String
        Dim Remarks As String
        Cat = Val(txtCat.Text)
        Assignment = Val(txtAssignment.Text)
        Exam = Val(txtExam.Text)
        Total = (Cat + Assignment + Exam)
        If (Cat > 15) Then
            MessageBox.Show("CAT CANNOT BE GREATER THAN 15")
            txtCat.Text = ""
            Me.Close()
        ElseIf (Assignment > 15) Then
            MessageBox.Show("ASSIGNMENT CANNOT BE GREATER THEN 15")
            txtAssignment.Text = ""
            Me.Close()
        ElseIf (Exam > 70) Then
            MessageBox.Show("EXAM CANNOT BE MORE THAN 70")
            txtExam.Text = ""
            Me.Close()

            lblGrade.Text = lblGrade2.Text

            lblRemarks.Text = lblRemarks2.Text

        End If
        If (Total > 69) Then
            lblGrade2.Text = "A"
        ElseIf (Total > 59) Then
            lblGrade2.Text = "B"
        ElseIf (Total > 49) Then
            lblGrade2.Text = "C"
        ElseIf (Total > 39) Then
            lblGrade2.Text = "D"
        ElseIf (Total < 39) Then
            lblGrade2.Text = "E"
        End If
        If (Total > 39) Then
            lblRemarks2.Text = "PASS"
        Else
            lblRemarks2.Text = "FAIL"

        End If
        lblTotal2.Text = Total
    End Sub
End Class
