<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.edtDayS = New System.Windows.Forms.TextBox()
        Me.edtDayN = New System.Windows.Forms.TextBox()
        Me.edtMonth = New System.Windows.Forms.TextBox()
        Me.edtYear = New System.Windows.Forms.TextBox()
        Me.edtTime = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        '
        'edtDayS
        '
        Me.edtDayS.Location = New System.Drawing.Point(63, 35)
        Me.edtDayS.Name = "edtDayS"
        Me.edtDayS.Size = New System.Drawing.Size(84, 20)
        Me.edtDayS.TabIndex = 0
        '
        'edtDayN
        '
        Me.edtDayN.Location = New System.Drawing.Point(153, 35)
        Me.edtDayN.Name = "edtDayN"
        Me.edtDayN.Size = New System.Drawing.Size(68, 20)
        Me.edtDayN.TabIndex = 1
        '
        'edtMonth
        '
        Me.edtMonth.Location = New System.Drawing.Point(227, 35)
        Me.edtMonth.Name = "edtMonth"
        Me.edtMonth.Size = New System.Drawing.Size(100, 20)
        Me.edtMonth.TabIndex = 2
        '
        'edtYear
        '
        Me.edtYear.Location = New System.Drawing.Point(333, 35)
        Me.edtYear.Name = "edtYear"
        Me.edtYear.Size = New System.Drawing.Size(100, 20)
        Me.edtYear.TabIndex = 3
        '
        'edtTime
        '
        Me.edtTime.Location = New System.Drawing.Point(208, 100)
        Me.edtTime.Name = "edtTime"
        Me.edtTime.Size = New System.Drawing.Size(100, 20)
        Me.edtTime.TabIndex = 4
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(322, 191)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Button1"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(119, 191)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 6
        Me.btnPause.Text = "Button1"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 261)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.edtTime)
        Me.Controls.Add(Me.edtYear)
        Me.Controls.Add(Me.edtMonth)
        Me.Controls.Add(Me.edtDayN)
        Me.Controls.Add(Me.edtDayS)
        Me.Name = "frmCalendar"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents edtDayS As System.Windows.Forms.TextBox
    Friend WithEvents edtDayN As System.Windows.Forms.TextBox
    Friend WithEvents edtMonth As System.Windows.Forms.TextBox
    Friend WithEvents edtYear As System.Windows.Forms.TextBox
    Friend WithEvents edtTime As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button

End Class
