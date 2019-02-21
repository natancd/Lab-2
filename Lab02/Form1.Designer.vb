<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterGrades
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
        Me.components = New System.ComponentModel.Container()
        Me.semesterGradesTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtGradeFour = New System.Windows.Forms.TextBox()
        Me.txtGradeFive = New System.Windows.Forms.TextBox()
        Me.txtGradeSix = New System.Windows.Forms.TextBox()
        Me.txtGradeThree = New System.Windows.Forms.TextBox()
        Me.txtGradeTwo = New System.Windows.Forms.TextBox()
        Me.txtGradeOne = New System.Windows.Forms.TextBox()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.lblSemesterGrade = New System.Windows.Forms.Label()
        Me.lblGradeSix = New System.Windows.Forms.Label()
        Me.lblGradeFive = New System.Windows.Forms.Label()
        Me.lblGradeTwo = New System.Windows.Forms.Label()
        Me.lblGradeThree = New System.Windows.Forms.Label()
        Me.lblGradeFour = New System.Windows.Forms.Label()
        Me.lblGradeOne = New System.Windows.Forms.Label()
        Me.lblValidationMessage = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "E&xit"
        Me.semesterGradesTips.SetToolTip(Me.btnExit, "Exits application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(139, 443)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.semesterGradesTips.SetToolTip(Me.btnReset, "Resets the form to its original state")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 443)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.semesterGradesTips.SetToolTip(Me.btnCalculate, "Calculates the average of all grades")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtGradeFour
        '
        Me.txtGradeFour.Location = New System.Drawing.Point(108, 121)
        Me.txtGradeFour.Name = "txtGradeFour"
        Me.txtGradeFour.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeFour.TabIndex = 10
        Me.txtGradeFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeFour, "Please enter the grade for Course 4")
        '
        'txtGradeFive
        '
        Me.txtGradeFive.Location = New System.Drawing.Point(108, 156)
        Me.txtGradeFive.Name = "txtGradeFive"
        Me.txtGradeFive.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeFive.TabIndex = 13
        Me.txtGradeFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeFive, "Please enter the grade for Course 5")
        '
        'txtGradeSix
        '
        Me.txtGradeSix.Location = New System.Drawing.Point(108, 191)
        Me.txtGradeSix.Name = "txtGradeSix"
        Me.txtGradeSix.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeSix.TabIndex = 16
        Me.txtGradeSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeSix, "Please enter the grade for Course 6")
        '
        'txtGradeThree
        '
        Me.txtGradeThree.Location = New System.Drawing.Point(108, 86)
        Me.txtGradeThree.Name = "txtGradeThree"
        Me.txtGradeThree.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeThree.TabIndex = 7
        Me.txtGradeThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeThree, "Please enter the grade for Course 3")
        '
        'txtGradeTwo
        '
        Me.txtGradeTwo.Location = New System.Drawing.Point(108, 51)
        Me.txtGradeTwo.Name = "txtGradeTwo"
        Me.txtGradeTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeTwo.TabIndex = 4
        Me.txtGradeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeTwo, "Please enter the grade for Course 2")
        '
        'txtGradeOne
        '
        Me.txtGradeOne.Location = New System.Drawing.Point(108, 16)
        Me.txtGradeOne.Name = "txtGradeOne"
        Me.txtGradeOne.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeOne.TabIndex = 1
        Me.txtGradeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.semesterGradesTips.SetToolTip(Me.txtGradeOne, "Please enter the grade for Course 1")
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverage.Location = New System.Drawing.Point(108, 226)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterAverage.TabIndex = 19
        Me.lblSemesterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblSemesterAverage, "Displays the semester average")
        '
        'lblSemesterGrade
        '
        Me.lblSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterGrade.Location = New System.Drawing.Point(223, 226)
        Me.lblSemesterGrade.Name = "lblSemesterGrade"
        Me.lblSemesterGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblSemesterGrade.TabIndex = 20
        Me.lblSemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblSemesterGrade, "Displays the semester's average letter grade")
        '
        'lblGradeSix
        '
        Me.lblGradeSix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeSix.Location = New System.Drawing.Point(223, 191)
        Me.lblGradeSix.Name = "lblGradeSix"
        Me.lblGradeSix.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeSix.TabIndex = 17
        Me.lblGradeSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeSix, "Displays the letter grade of Course 6")
        '
        'lblGradeFive
        '
        Me.lblGradeFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeFive.Location = New System.Drawing.Point(223, 156)
        Me.lblGradeFive.Name = "lblGradeFive"
        Me.lblGradeFive.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeFive.TabIndex = 14
        Me.lblGradeFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeFive, "Displays the letter grade of Course 5")
        '
        'lblGradeTwo
        '
        Me.lblGradeTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeTwo.Location = New System.Drawing.Point(223, 51)
        Me.lblGradeTwo.Name = "lblGradeTwo"
        Me.lblGradeTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeTwo.TabIndex = 5
        Me.lblGradeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeTwo, "Displays the letter grade of Course 2")
        '
        'lblGradeThree
        '
        Me.lblGradeThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeThree.Location = New System.Drawing.Point(223, 86)
        Me.lblGradeThree.Name = "lblGradeThree"
        Me.lblGradeThree.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeThree.TabIndex = 8
        Me.lblGradeThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeThree, "Displays the letter grade of Course 3")
        '
        'lblGradeFour
        '
        Me.lblGradeFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeFour.Location = New System.Drawing.Point(223, 121)
        Me.lblGradeFour.Name = "lblGradeFour"
        Me.lblGradeFour.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeFour.TabIndex = 11
        Me.lblGradeFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeFour, "Displays the letter grade of Course 4")
        '
        'lblGradeOne
        '
        Me.lblGradeOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeOne.Location = New System.Drawing.Point(223, 16)
        Me.lblGradeOne.Name = "lblGradeOne"
        Me.lblGradeOne.Size = New System.Drawing.Size(100, 23)
        Me.lblGradeOne.TabIndex = 2
        Me.lblGradeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.semesterGradesTips.SetToolTip(Me.lblGradeOne, "Displays the letter grade of Course 1")
        '
        'lblValidationMessage
        '
        Me.lblValidationMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValidationMessage.Location = New System.Drawing.Point(13, 265)
        Me.lblValidationMessage.Name = "lblValidationMessage"
        Me.lblValidationMessage.Size = New System.Drawing.Size(333, 159)
        Me.lblValidationMessage.TabIndex = 21
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(36, 226)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(57, 23)
        Me.lblSemester.TabIndex = 18
        Me.lblSemester.Text = "&Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(36, 191)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseSix.TabIndex = 15
        Me.lblCourseSix.Text = "Course &6:"
        Me.lblCourseSix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(36, 86)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseThree.TabIndex = 6
        Me.lblCourseThree.Text = "Course &3:"
        Me.lblCourseThree.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Location = New System.Drawing.Point(36, 51)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course &2:"
        Me.lblCourseTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(36, 121)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseFour.TabIndex = 9
        Me.lblCourseFour.Text = "Course &4:"
        Me.lblCourseFour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(36, 156)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseFive.TabIndex = 12
        Me.lblCourseFive.Text = "Course &5:"
        Me.lblCourseFive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(36, 16)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(57, 23)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course &1:"
        Me.lblCourseOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(359, 482)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtGradeFour)
        Me.Controls.Add(Me.txtGradeFive)
        Me.Controls.Add(Me.txtGradeSix)
        Me.Controls.Add(Me.txtGradeThree)
        Me.Controls.Add(Me.txtGradeTwo)
        Me.Controls.Add(Me.txtGradeOne)
        Me.Controls.Add(Me.lblValidationMessage)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblSemesterGrade)
        Me.Controls.Add(Me.lblGradeSix)
        Me.Controls.Add(Me.lblGradeFive)
        Me.Controls.Add(Me.lblGradeTwo)
        Me.Controls.Add(Me.lblGradeThree)
        Me.Controls.Add(Me.lblGradeFour)
        Me.Controls.Add(Me.lblGradeOne)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseOne)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents semesterGradesTips As ToolTip
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtGradeFour As TextBox
    Friend WithEvents txtGradeFive As TextBox
    Friend WithEvents txtGradeSix As TextBox
    Friend WithEvents txtGradeThree As TextBox
    Friend WithEvents txtGradeTwo As TextBox
    Friend WithEvents txtGradeOne As TextBox
    Friend WithEvents lblValidationMessage As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents lblSemesterGrade As Label
    Friend WithEvents lblGradeSix As Label
    Friend WithEvents lblGradeFive As Label
    Friend WithEvents lblGradeTwo As Label
    Friend WithEvents lblGradeThree As Label
    Friend WithEvents lblGradeFour As Label
    Friend WithEvents lblGradeOne As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseOne As Label
End Class
