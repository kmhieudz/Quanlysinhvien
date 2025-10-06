Public Class frmMain
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Dim f As New frmStudents
        f.ShowDialog()
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        Dim f As New frmCourses
        f.ShowDialog()
    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        Dim f As New frmGrades
        f.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim f As New frmReports
        f.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class