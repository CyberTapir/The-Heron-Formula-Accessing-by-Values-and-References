<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdDouble = New System.Windows.Forms.Button()
        Me.lstOutput1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(13, 29)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(13, 56)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(13, 83)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 2
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(12, 201)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 3
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(15, 109)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 4
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdDouble
        '
        Me.cmdDouble.Location = New System.Drawing.Point(12, 227)
        Me.cmdDouble.Name = "cmdDouble"
        Me.cmdDouble.Size = New System.Drawing.Size(75, 23)
        Me.cmdDouble.TabIndex = 5
        Me.cmdDouble.Text = "Double"
        Me.cmdDouble.UseVisualStyleBackColor = True
        '
        'lstOutput1
        '
        Me.lstOutput1.FormattingEnabled = True
        Me.lstOutput1.Location = New System.Drawing.Point(126, 38)
        Me.lstOutput1.Name = "lstOutput1"
        Me.lstOutput1.Size = New System.Drawing.Size(161, 212)
        Me.lstOutput1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "A, B and C respectivly"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Output"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstOutput1)
        Me.Controls.Add(Me.cmdDouble)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents cmdDouble As System.Windows.Forms.Button
    Friend WithEvents lstOutput1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
