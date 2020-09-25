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
        Me.lblCat = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblExam = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtAssignment = New System.Windows.Forms.TextBox()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.lblTotal2 = New System.Windows.Forms.Label()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.lblRemarks2 = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(40, 30)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(29, 17)
        Me.lblCat.TabIndex = 0
        Me.lblCat.Text = "Cat"
        '
        'lblAssignment
        '
        Me.lblAssignment.AutoSize = True
        Me.lblAssignment.Location = New System.Drawing.Point(40, 88)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(81, 17)
        Me.lblAssignment.TabIndex = 0
        Me.lblAssignment.Text = "Assignment"
        '
        'lblExam
        '
        Me.lblExam.AutoSize = True
        Me.lblExam.Location = New System.Drawing.Point(40, 142)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.Size = New System.Drawing.Size(42, 17)
        Me.lblExam.TabIndex = 0
        Me.lblExam.Text = "Exam"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(40, 195)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 17)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total "
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(40, 253)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(48, 17)
        Me.lblGrade.TabIndex = 0
        Me.lblGrade.Text = "Grade"
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(40, 307)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(64, 17)
        Me.lblRemarks.TabIndex = 0
        Me.lblRemarks.Text = "Remarks"
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(211, 30)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(100, 22)
        Me.txtCat.TabIndex = 1
        '
        'txtAssignment
        '
        Me.txtAssignment.Location = New System.Drawing.Point(211, 88)
        Me.txtAssignment.Name = "txtAssignment"
        Me.txtAssignment.Size = New System.Drawing.Size(100, 22)
        Me.txtAssignment.TabIndex = 1
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(211, 142)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(100, 22)
        Me.txtExam.TabIndex = 1
        '
        'lblTotal2
        '
        Me.lblTotal2.AutoSize = True
        Me.lblTotal2.Location = New System.Drawing.Point(208, 195)
        Me.lblTotal2.Name = "lblTotal2"
        Me.lblTotal2.Size = New System.Drawing.Size(0, 17)
        Me.lblTotal2.TabIndex = 0
        '
        'lblGrade2
        '
        Me.lblGrade2.AutoSize = True
        Me.lblGrade2.Location = New System.Drawing.Point(208, 253)
        Me.lblGrade2.Name = "lblGrade2"
        Me.lblGrade2.Size = New System.Drawing.Size(0, 17)
        Me.lblGrade2.TabIndex = 0
        '
        'lblRemarks2
        '
        Me.lblRemarks2.AutoSize = True
        Me.lblRemarks2.Location = New System.Drawing.Point(208, 307)
        Me.lblRemarks2.Name = "lblRemarks2"
        Me.lblRemarks2.Size = New System.Drawing.Size(0, 17)
        Me.lblRemarks2.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(171, 384)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(100, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 450)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtExam)
        Me.Controls.Add(Me.txtAssignment)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.lblRemarks2)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblExam)
        Me.Controls.Add(Me.lblGrade2)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblAssignment)
        Me.Controls.Add(Me.lblTotal2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCat As Label
    Friend WithEvents lblAssignment As Label
    Friend WithEvents lblExam As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtCat As TextBox
    Friend WithEvents txtAssignment As TextBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents lblTotal2 As Label
    Friend WithEvents lblGrade2 As Label
    Friend WithEvents lblRemarks2 As Label
    Friend WithEvents btnCompute As Button
End Class
