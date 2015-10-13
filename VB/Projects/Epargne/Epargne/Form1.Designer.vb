<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEpargne
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
        Me.lblCapIni = New System.Windows.Forms.Label()
        Me.lblPourc = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblCapFin = New System.Windows.Forms.Label()
        Me.edtCapIni = New System.Windows.Forms.TextBox()
        Me.edtPourc = New System.Windows.Forms.TextBox()
        Me.edtDuration = New System.Windows.Forms.TextBox()
        Me.edtCapFin = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCapIni
        '
        Me.lblCapIni.AutoSize = True
        Me.lblCapIni.Location = New System.Drawing.Point(30, 34)
        Me.lblCapIni.Name = "lblCapIni"
        Me.lblCapIni.Size = New System.Drawing.Size(39, 13)
        Me.lblCapIni.TabIndex = 0
        Me.lblCapIni.Text = "Label1"
        '
        'lblPourc
        '
        Me.lblPourc.AutoSize = True
        Me.lblPourc.Location = New System.Drawing.Point(30, 72)
        Me.lblPourc.Name = "lblPourc"
        Me.lblPourc.Size = New System.Drawing.Size(39, 13)
        Me.lblPourc.TabIndex = 1
        Me.lblPourc.Text = "Label2"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(30, 112)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(39, 13)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Label3"
        '
        'lblCapFin
        '
        Me.lblCapFin.AutoSize = True
        Me.lblCapFin.Location = New System.Drawing.Point(30, 146)
        Me.lblCapFin.Name = "lblCapFin"
        Me.lblCapFin.Size = New System.Drawing.Size(39, 13)
        Me.lblCapFin.TabIndex = 3
        Me.lblCapFin.Text = "Label4"
        '
        'edtCapIni
        '
        Me.edtCapIni.Location = New System.Drawing.Point(153, 31)
        Me.edtCapIni.Name = "edtCapIni"
        Me.edtCapIni.Size = New System.Drawing.Size(100, 20)
        Me.edtCapIni.TabIndex = 4
        '
        'edtPourc
        '
        Me.edtPourc.Location = New System.Drawing.Point(153, 69)
        Me.edtPourc.Name = "edtPourc"
        Me.edtPourc.Size = New System.Drawing.Size(100, 20)
        Me.edtPourc.TabIndex = 5
        '
        'edtDuration
        '
        Me.edtDuration.Location = New System.Drawing.Point(153, 109)
        Me.edtDuration.Name = "edtDuration"
        Me.edtDuration.Size = New System.Drawing.Size(100, 20)
        Me.edtDuration.TabIndex = 6
        '
        'edtCapFin
        '
        Me.edtCapFin.Location = New System.Drawing.Point(153, 143)
        Me.edtCapFin.Name = "edtCapFin"
        Me.edtCapFin.Size = New System.Drawing.Size(100, 20)
        Me.edtCapFin.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(167, 200)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Button1"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(33, 200)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Button2"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmEpargne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.edtCapFin)
        Me.Controls.Add(Me.edtDuration)
        Me.Controls.Add(Me.edtPourc)
        Me.Controls.Add(Me.edtCapIni)
        Me.Controls.Add(Me.lblCapFin)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblPourc)
        Me.Controls.Add(Me.lblCapIni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEpargne"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCapIni As System.Windows.Forms.Label
    Friend WithEvents lblPourc As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblCapFin As System.Windows.Forms.Label
    Friend WithEvents edtCapIni As System.Windows.Forms.TextBox
    Friend WithEvents edtPourc As System.Windows.Forms.TextBox
    Friend WithEvents edtDuration As System.Windows.Forms.TextBox
    Friend WithEvents edtCapFin As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
