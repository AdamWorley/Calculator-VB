Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim num1 As Double
    Dim num2 As Double
    Dim operation

    ' Operator handling
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        txtDisplay.Text = ""
    End Sub

    Private Sub plusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        operation = "+"
        Double.TryParse(txtDisplay.Text, num1)
        txtDisplay.Text = ""
    End Sub

    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        operation = "-"
        Double.TryParse(txtDisplay.Text, num1)
        txtDisplay.Text = ""
    End Sub

    Private Sub multbtn_Click(sender As Object, e As EventArgs) Handles multbtn.Click
        operation = "*"
        Double.TryParse(txtDisplay.Text, num1)
        txtDisplay.Text = ""
    End Sub

    Private Sub divideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click
        operation = "/"
        Double.TryParse(txtDisplay.Text, num1)
        txtDisplay.Text = ""
    End Sub

    Private Sub periodBtn_Click(sender As Object, e As EventArgs) Handles periodBtn.Click
        If Not Regex.IsMatch(txtDisplay.Text, "[\.]") Then
            txtDisplay.Text = txtDisplay.Text & "."
        End If
    End Sub

    Private Sub negativeBtn_Click(sender As Object, e As EventArgs) Handles negativeBtn.Click
        Dim number
        Double.TryParse(txtDisplay.Text, number)
        txtDisplay.Text = number * -1
    End Sub

    Private Sub equalsBtn_Click(sender As Object, e As EventArgs) Handles equalsBtn.Click
        If txtDisplay.Text IsNot Nothing Then
            Double.TryParse(txtDisplay.Text, num2)
            If operation Is "+" Then
                txtDisplay.Text = num1 + num2
            ElseIf operation Is "-" Then
                txtDisplay.Text = num1 - num2
            ElseIf operation Is "*" Then
                txtDisplay.Text = num1 * num2
            ElseIf operation Is "/" Then
                If num2 = 0 Then
                    txtDisplay.Text = "Error"
                Else
                    txtDisplay.Text = num1 / num2
                End If

            End If
            operation = ""
        End If

    End Sub


    ' Number button handling
    Private Sub zeroBtn_Click(sender As Object, e As EventArgs) Handles zeroBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 0
    End Sub


    Private Sub oneBtn_Click(sender As Object, e As EventArgs) Handles oneBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 1
    End Sub

    Private Sub twoBtn_Click(sender As Object, e As EventArgs) Handles twoBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 2
    End Sub

    Private Sub threeBtn_Click(sender As Object, e As EventArgs) Handles threeBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 3
    End Sub

    Private Sub fourBtn_Click(sender As Object, e As EventArgs) Handles fourBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 4
    End Sub

    Private Sub fiveBtn_Click(sender As Object, e As EventArgs) Handles fiveBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 5
    End Sub

    Private Sub sixBtn_Click(sender As Object, e As EventArgs) Handles sixBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 6
    End Sub

    Private Sub sevenBtn_Click(sender As Object, e As EventArgs) Handles sevenBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 7
    End Sub

    Private Sub eightBtn_Click(sender As Object, e As EventArgs) Handles eightBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 8
    End Sub

    Private Sub nineBtn_Click(sender As Object, e As EventArgs) Handles nineBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        txtDisplay.Text = txtDisplay.Text & 9
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sqrBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        Dim sqr
        Double.TryParse(txtDisplay.Text, sqr)
        txtDisplay.Text = sqr * sqr
    End Sub

    Private Sub sqrtBtn_Click(sender As Object, e As EventArgs) Handles sqrtBtn.Click
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        End If
        Dim sqrrt
        Double.TryParse(txtDisplay.Text, sqrrt)
        txtDisplay.Text = sqrrt ^ 0.5
    End Sub


End Class
