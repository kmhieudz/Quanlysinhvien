<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnStudents = New Button()
        btnCourses = New Button()
        btnGrades = New Button()
        btnReports = New Button()
        SuspendLayout()
        ' 
        ' btnStudents
        ' 
        btnStudents.BackColor = Color.DodgerBlue
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Segoe UI", 14F)
        btnStudents.ForeColor = Color.White
        btnStudents.Image = My.Resources.Resources.Screenshot_2025_09_29_171501
        btnStudents.ImageAlign = ContentAlignment.MiddleLeft
        btnStudents.Location = New Point(61, 28)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(225, 138)
        btnStudents.TabIndex = 0
        btnStudents.Text = "        Student Records"
        btnStudents.TextAlign = ContentAlignment.MiddleRight
        btnStudents.UseVisualStyleBackColor = False
        ' 
        ' btnCourses
        ' 
        btnCourses.BackColor = Color.MediumSeaGreen
        btnCourses.Font = New Font("Segoe UI", 14F)
        btnCourses.ForeColor = Color.White
        btnCourses.Image = My.Resources.Resources.Screenshot_2025_09_29_171505
        btnCourses.ImageAlign = ContentAlignment.MiddleLeft
        btnCourses.Location = New Point(325, 28)
        btnCourses.Name = "btnCourses"
        btnCourses.Size = New Size(225, 138)
        btnCourses.TabIndex = 1
        btnCourses.Text = "          Courses"
        btnCourses.TextAlign = ContentAlignment.MiddleRight
        btnCourses.UseVisualStyleBackColor = False
        ' 
        ' btnGrades
        ' 
        btnGrades.BackColor = Color.Orange
        btnGrades.Font = New Font("Segoe UI", 14F)
        btnGrades.ForeColor = Color.White
        btnGrades.Image = My.Resources.Resources.Screenshot_2025_09_29_171513
        btnGrades.ImageAlign = ContentAlignment.MiddleLeft
        btnGrades.Location = New Point(61, 206)
        btnGrades.Name = "btnGrades"
        btnGrades.Size = New Size(225, 138)
        btnGrades.TabIndex = 2
        btnGrades.Text = "Grades"
        btnGrades.TextAlign = ContentAlignment.MiddleRight
        btnGrades.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.MediumSlateBlue
        btnReports.BackgroundImageLayout = ImageLayout.None
        btnReports.Font = New Font("Segoe UI", 14F)
        btnReports.ForeColor = Color.White
        btnReports.Image = My.Resources.Resources.Screenshot_2025_09_29_171516
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(325, 206)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(225, 138)
        btnReports.TabIndex = 3
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleRight
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(620, 381)
        Controls.Add(btnReports)
        Controls.Add(btnGrades)
        Controls.Add(btnCourses)
        Controls.Add(btnStudents)
        Font = New Font("Segoe UI", 10F)
        ForeColor = SystemColors.ControlText
        Name = "frmMain"
        Text = "Student Management System"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStudents As Button
    Friend WithEvents btnCourses As Button
    Friend WithEvents btnGrades As Button
    Friend WithEvents btnReports As Button

End Class
