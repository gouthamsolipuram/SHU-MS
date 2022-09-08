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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateGrossPay = New System.Windows.Forms.Button()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbldisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gross Pay Earned"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No of Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hourly Pay Rate"
        '
        'btnCalculateGrossPay
        '
        Me.btnCalculateGrossPay.Location = New System.Drawing.Point(21, 208)
        Me.btnCalculateGrossPay.Name = "btnCalculateGrossPay"
        Me.btnCalculateGrossPay.Size = New System.Drawing.Size(115, 23)
        Me.btnCalculateGrossPay.TabIndex = 3
        Me.btnCalculateGrossPay.Text = "Calculate Gross Pay"
        Me.btnCalculateGrossPay.UseVisualStyleBackColor = True
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(151, 33)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 4
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(151, 81)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayRate.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(167, 210)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 21)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lbldisplay
        '
        Me.lbldisplay.Location = New System.Drawing.Point(151, 138)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(75, 23)
        Me.lbldisplay.TabIndex = 7
        Me.lbldisplay.Text = "$0.00"
        Me.lbldisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 273)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.btnCalculateGrossPay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculateGrossPay As Button
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lbldisplay As Button
End Class
