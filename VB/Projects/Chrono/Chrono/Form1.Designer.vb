<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChrono
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
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.edtStart = New System.Windows.Forms.TextBox()
        Me.edtEnd = New System.Windows.Forms.TextBox()
        Me.edtDuration = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSwitch
        '
        Me.btnSwitch.Location = New System.Drawing.Point(23, 97)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(75, 23)
        Me.btnSwitch.TabIndex = 0
        Me.btnSwitch.Text = "Button 1"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(179, 97)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 1
        Me.btnInit.Text = "Button2"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(96, 137)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Button3"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(41, 15)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(39, 13)
        Me.lblStart.TabIndex = 3
        Me.lblStart.Text = "Label1"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(41, 41)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(39, 13)
        Me.lblEnd.TabIndex = 4
        Me.lblEnd.Text = "Label2"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(41, 67)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(39, 13)
        Me.lblDuration.TabIndex = 5
        Me.lblDuration.Text = "Label3"
        '
        'edtStart
        '
        Me.edtStart.Location = New System.Drawing.Point(167, 12)
        Me.edtStart.Name = "edtStart"
        Me.edtStart.Size = New System.Drawing.Size(100, 20)
        Me.edtStart.TabIndex = 6
        '
        'edtEnd
        '
        Me.edtEnd.Location = New System.Drawing.Point(167, 38)
        Me.edtEnd.Name = "edtEnd"
        Me.edtEnd.Size = New System.Drawing.Size(100, 20)
        Me.edtEnd.TabIndex = 7
        '
        'edtDuration
        '
        Me.edtDuration.Location = New System.Drawing.Point(167, 64)
        Me.edtDuration.Name = "edtDuration"
        Me.edtDuration.Size = New System.Drawing.Size(100, 20)
        Me.edtDuration.TabIndex = 8
        '
        'frmChrono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 182)
        Me.Controls.Add(Me.edtDuration)
        Me.Controls.Add(Me.edtEnd)
        Me.Controls.Add(Me.edtStart)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnSwitch)
        Me.Name = "frmChrono"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSwitch As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents edtStart As System.Windows.Forms.TextBox
    Friend WithEvents edtEnd As System.Windows.Forms.TextBox
    Friend WithEvents edtDuration As System.Windows.Forms.TextBox

End Class
