<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmdpChange
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
        Me.lblPw1 = New System.Windows.Forms.Label()
        Me.lblPw2 = New System.Windows.Forms.Label()
        Me.edtPw1 = New System.Windows.Forms.TextBox()
        Me.edtPw2 = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPw1
        '
        Me.lblPw1.AutoSize = True
        Me.lblPw1.Location = New System.Drawing.Point(33, 39)
        Me.lblPw1.Name = "lblPw1"
        Me.lblPw1.Size = New System.Drawing.Size(39, 13)
        Me.lblPw1.TabIndex = 0
        Me.lblPw1.Text = "Label1"
        '
        'lblPw2
        '
        Me.lblPw2.AutoSize = True
        Me.lblPw2.Location = New System.Drawing.Point(33, 73)
        Me.lblPw2.Name = "lblPw2"
        Me.lblPw2.Size = New System.Drawing.Size(39, 13)
        Me.lblPw2.TabIndex = 1
        Me.lblPw2.Text = "Label2"
        '
        'edtPw1
        '
        Me.edtPw1.Location = New System.Drawing.Point(178, 32)
        Me.edtPw1.Name = "edtPw1"
        Me.edtPw1.Size = New System.Drawing.Size(100, 20)
        Me.edtPw1.TabIndex = 2
        '
        'edtPw2
        '
        Me.edtPw2.Location = New System.Drawing.Point(178, 70)
        Me.edtPw2.Name = "edtPw2"
        Me.edtPw2.Size = New System.Drawing.Size(100, 20)
        Me.edtPw2.TabIndex = 3
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(107, 145)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Button1"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(107, 116)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Button1"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmmdpChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 180)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.edtPw2)
        Me.Controls.Add(Me.edtPw1)
        Me.Controls.Add(Me.lblPw2)
        Me.Controls.Add(Me.lblPw1)
        Me.Name = "frmmdpChange"
        Me.Text = "mdpChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPw1 As System.Windows.Forms.Label
    Friend WithEvents lblPw2 As System.Windows.Forms.Label
    Friend WithEvents edtPw1 As System.Windows.Forms.TextBox
    Friend WithEvents edtPw2 As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
