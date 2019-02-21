' **************************************************************************************************************************************************/
' * Lab 2: Semester Average
' * Program: Lab01       2                                    
' * Course: NET DEVELOPMENT I (NETD-2202)                                                                 
' * Author:      Natan Colavite Dellagiustina  - 100722419                                    
' * Date:        February 8th, 2019 
' *                                                                                
' * Description:                                                                    
' *              This program will prompt the user a form application, where the grades must be entered in every course text box, then calculate the 
' *              average Of the semester. Everytime the user enter a numeric grade and leave the textbox (by tabbing or clicking another textbox) the
' *              program will output, in the label right after the textbox, the letter of that grade (A+, A, A-, B, etc.). The same works for the
' *              average. Then the user will have the option to exit/end the application, clicking the exit button or the "X" in the top right 
' *              corner. If the user enter a non-numeric character or any number that is not an integer and that isn't in the range of 0 to 100 
' *              (the minimum and maximum grades), the bottom label will prompt an error message and move the focus back to the wrong value entered 
' *              and select it, making it possible just to retype the correct information. At any time, the user can reset the form by clicking the 
' *              reset button or pressing "Esc". By doing that, the program will reset to its default form and move the focus to the first text box.
' **************************************************************************************************************************************************/

Option Strict On
Public Class frmSemesterGrades
    ' DECLARATIONS
    ' CONSTANTS
    Const MINIMUM_GRADE As Double = 0.00
    Const MAXIMUM_GRADE As Double = 100.0
    Const MAXIMUM_COURSES As Integer = 6
    Const ERROR_MESSAGE As String = "Please ensure that what you input is a number between 0 and 100!"
    ' VARIABLES
    Dim userInput As Double ' The user input
    Dim userGrades(MAXIMUM_COURSES - 1) As Double ' Array with all user inputs
    Dim gradeLetter As String ' Variable of the function
    Dim gradeCounter As Integer ' Counter of the array 
    Dim sumOfTotal As Double ' Sum of total grades entered
    Dim semesterAverage As Double ' The average

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the program
        Me.Close()
    End Sub

    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Whenever the user clicks the Calculate Button, it will do the following:
        ' Check if any text box was left withot any value
        If txtGradeOne.Text = "" Or txtGradeTwo.Text = "" Or txtGradeThree.Text = "" Or txtGradeFour.Text = "" Or txtGradeFive.Text = "" Or txtGradeSix.Text = "" Then
            'If there's any text box without information, the program it will display an error header in the bottom label
            If txtGradeOne.Text = "" Or txtGradeTwo.Text = "" Or txtGradeThree.Text = "" Or txtGradeFour.Text = "" Or txtGradeFive.Text = "" Or txtGradeSix.Text = "" Then
                lblValidationMessage.Text = "ERROR(s)" & vbCrLf
            End If
            ' Still in the first If statement for empty text boxes, for every text box empty, there will be a specific error message accumulated in the bottom label,
            ' informing the user which course grade is missing. Also, the focus will move to the empty textbox.
            If txtGradeOne.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 1 is a number between 0 and 100!" & vbCrLf
                txtGradeOne.ReadOnly = False
                txtGradeOne.Focus()
            End If

            If txtGradeTwo.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 2 is a number between 0 and 100!" & vbCrLf
                txtGradeTwo.ReadOnly = False
                txtGradeTwo.Focus()
            End If

            If txtGradeThree.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 3 is a number between 0 and 100!" & vbCrLf
                txtGradeThree.ReadOnly = False
                txtGradeThree.Focus()
            End If
            If txtGradeFour.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 4 is a number between 0 and 100!" & vbCrLf
                txtGradeFour.ReadOnly = False
                txtGradeFour.Focus()
            End If

            If txtGradeFive.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 5 is a number between 0 and 100!" & vbCrLf
                txtGradeFive.ReadOnly = False
                txtGradeFive.Focus()
            End If

            If txtGradeSix.Text = "" Then
                lblValidationMessage.Text += "Please ensure that what you input in Course 6 is a number between 0 and 100!"
                txtGradeSix.ReadOnly = False
                txtGradeSix.Focus()
            End If

        Else
            ' After all grades have been filled in, the program will call the array and sum the values stored

            For gradeCounter As Integer = 0 To userGrades.Length - 1
                sumOfTotal += userGrades(gradeCounter)

            Next
            ' The program will make the text box as a read only and the button Enter will be disabled, so the user cannot enter any more information
            txtGradeOne.ReadOnly = True
            txtGradeTwo.ReadOnly = True
            txtGradeThree.ReadOnly = True
            txtGradeFour.ReadOnly = True
            txtGradeFive.ReadOnly = True
            txtGradeSix.ReadOnly = True
            btnCalculate.Enabled = False
            ' The program will calculate the average and display in the respective labels with two decimal places
            semesterAverage = sumOfTotal / MAXIMUM_COURSES
            lblSemesterAverage.Text = FormatNumber(semesterAverage.ToString, 2)
            userInput = semesterAverage ' Defines the last entered value as the semester average, to work for the label which display the letter
            lblSemesterGrade.Text = LetterGrade(gradeLetter)

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This button will reset everything to the default value
        txtGradeOne.Focus()
        btnCalculate.Enabled = True
        lblValidationMessage.Text = ""
        lblSemesterAverage.Text = ""
        lblSemesterGrade.Text = ""
        sumOfTotal = 0.0
        gradeCounter = 0
        semesterAverage = 0.0

        txtGradeOne.ReadOnly = False
        txtGradeTwo.ReadOnly = False
        txtGradeThree.ReadOnly = False
        txtGradeFour.ReadOnly = False
        txtGradeFive.ReadOnly = False
        txtGradeSix.ReadOnly = False

        txtGradeOne.ResetText()
        txtGradeTwo.ResetText()
        txtGradeThree.ResetText()
        txtGradeFour.ResetText()
        txtGradeFive.ResetText()
        txtGradeSix.ResetText()

        lblGradeOne.ResetText()
        lblGradeTwo.ResetText()
        lblGradeThree.ResetText()
        lblGradeFour.ResetText()
        lblGradeFive.ResetText()
        lblGradeSix.ResetText()


    End Sub

    Private Sub txtGradeOne_Leave(sender As Object, e As EventArgs) Handles txtGradeOne.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeOne.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeOne.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeOne.Focus()
                txtGradeOne.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeOne.Text = LetterGrade(gradeLetter)
                gradeCounter = 0
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""
            End If

        End If
    End Sub

    Private Sub txtGradeTwo_Leave(sender As Object, e As EventArgs) Handles txtGradeTwo.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeTwo.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeTwo.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeTwo.Focus()
                txtGradeTwo.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeTwo.Text = LetterGrade(gradeLetter)
                gradeCounter = 1
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""
            End If

        End If

    End Sub

    Private Sub txtGradeThree_Leave(sender As Object, e As EventArgs) Handles txtGradeThree.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeThree.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeThree.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeThree.Focus()
                txtGradeThree.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeThree.Text = LetterGrade(gradeLetter)
                gradeCounter = 2
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""

            End If
        End If


    End Sub

    Private Sub txtGradeFour_Leave(sender As Object, e As EventArgs) Handles txtGradeFour.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeFour.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeFour.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeFour.Focus()
                txtGradeFour.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeFour.Text = LetterGrade(gradeLetter)
                gradeCounter = 3
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""

            End If
        End If


    End Sub

    Private Sub txtGradeFive_Leave(sender As Object, e As EventArgs) Handles txtGradeFive.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeFive.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeFive.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeFive.Focus()
                txtGradeFive.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeFive.Text = LetterGrade(gradeLetter)
                gradeCounter = 4
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""

            End If
        End If

    End Sub

    Private Sub txtGradeSix_Leave(sender As Object, e As EventArgs) Handles txtGradeSix.Leave
        ' Calling the validation function
        userInput = ValidationNumber(txtGradeSix.Text)
        ' Loop to see if this text box is not empty (or have the return value from the function)
        If txtGradeSix.Text <> "" Then
            ' If it returned the "bad" value from the function, it will prompt an error message, select all the wrong input data and move the focus to this text box
            If userInput = -1 Then

                lblValidationMessage.Text = ERROR_MESSAGE
                txtGradeSix.Focus()
                txtGradeSix.SelectAll()

            Else
                ' If it return the "good" value from the function, it will call the letter conversion function in the label, start the counter for the array and store it 
                ' and clear any message that was in the bottom label
                lblGradeSix.Text = LetterGrade(gradeLetter)
                gradeCounter = 5
                userGrades(gradeCounter) = userInput
                lblValidationMessage.Text = ""
            End If
        End If
    End Sub

    ' VALIDATION FUNCTION
    Private Function ValidationNumber(ByVal userNumber As String) As Double
        ' DECLARATION
        ' VARIABLE
        Dim validNumber As Double ' Name for a return value for this function
        ' Loop to check if the input is a not a number or, if a number, it is outside the range
        If Double.TryParse(userNumber, validNumber) = False OrElse validNumber > MAXIMUM_GRADE Or validNumber < MINIMUM_GRADE Then
            ' If the input is not a number of not in the rage, it will return a number, to be used in the "main function"
            Return -1
        Else
            ' If the input is a number between the range, then it will return a variable
            Return validNumber
        End If

    End Function

    ' LETTER GRADE FUNCTION
    Private Function LetterGrade(ByVal gradeLetter As String) As String
        ' Loop to define the letter, according to the range
        If userInput >= 90 Then
            gradeLetter = "A+"
        ElseIf userInput >= 85 Then
            gradeLetter = "A"
        ElseIf userInput >= 80 Then
            gradeLetter = "A-"
        ElseIf userInput >= 77 Then
            gradeLetter = "B+"
        ElseIf userInput >= 73 Then
            gradeLetter = "B"
        ElseIf userInput >= 70 Then
            gradeLetter = "B-"
        ElseIf userInput >= 67 Then
            gradeLetter = "C+"
        ElseIf userInput >= 63 Then
            gradeLetter = "C"
        ElseIf userInput >= 60 Then
            gradeLetter = "C-"
        ElseIf userInput >= 57 Then
            gradeLetter = "D+"
        ElseIf userInput >= 53 Then
            gradeLetter = "D"
        ElseIf userInput >= 50 Then
            gradeLetter = "D-"
        ElseIf userInput < 50 Then
            gradeLetter = "F"

        End If
        ' Variable returned at the end of the function
        Return gradeLetter

    End Function
End Class