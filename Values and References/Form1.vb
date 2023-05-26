Public Class Form1
    Private Sub cmdCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalculate.Click
        'this subroutine uses Heron's formula to calculate the area of a triangle
        'http://en.wikipedia.org/wiki/Heron%27s_formula
        lstOutput1.Items.Add(HeronFormula(txtA.Text, txtB.Text, txtC.Text))
    End Sub
    Private Function HeronFormula(a As Integer, b As Integer, c As Integer) As Single
        Dim s As Single
        s = (a + b + c) / 2
        Return Math.Sqrt(s * (s - a) * (s - b) * (s - c))
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