Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Xml

Public Class Form1
    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        Dim a, b, c As Single
        a = CSng(txtA.Text)
        b = CSng(txtB.Text)
        c = CSng(txtC.Text)
        If checkIfTriangle(a, b, c) Then
            lstOutput1.Items.Add(HeronFormula(txtA.Text, txtB.Text, txtC.Text))
        Else
            lstOutput1.Items.Add("Not a triangle")
        End If
    End Sub
    Private Function HeronFormula(a As Integer, b As Integer, c As Integer) As Single
        Dim s As Single
        s = (a + b + c) / 2
        Return Math.Sqrt(s * (s - a) * (s - b) * (s - c))
    End Function
    Private Function checkIfTriangle(a As Integer, b As Integer, c As Integer) As Boolean
        Dim outputVal As Boolean = False
        If (a + b) > c And (a + c) > b And (b + c) > a Then
            outputVal = True
        End If
        Return outputVal
    End Function

    Private Function fnDouble(ByVal x As Integer) As Integer
        fnDouble = x * 2
        Return fnDouble
    End Function

    Private Sub subDoubleReference(ByRef x As Integer, ByRef y As Integer)
        y = x * 2

    End Sub

    Private Sub cmdDouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDouble.Click
        Dim x, y As Integer
        x = txtX.Text
        subDoubleReference(x, 1)

    End Sub
End Class