<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiffre
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
        Me.lblCa = New System.Windows.Forms.Label()
        Me.edtCa = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCa
        '
        Me.lblCa.AutoSize = True
        Me.lblCa.Location = New System.Drawing.Point(104, 28)
        Me.lblCa.Name = "lblCa"
        Me.lblCa.Size = New System.Drawing.Size(39, 13)
        Me.lblCa.TabIndex = 0
        Me.lblCa.Text = "Label1"
        '
        'edtCa
        '
        Me.edtCa.Location = New System.Drawing.Point(107, 44)
        Me.edtCa.Name = "edtCa"
        Me.edtCa.Size = New System.Drawing.Size(100, 20)
        Me.edtCa.TabIndex = 1
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(117, 88)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Button1"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmChiffre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 123)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.edtCa)
        Me.Controls.Add(Me.lblCa)
        Me.Name = "frmChiffre"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCa As System.Windows.Forms.Label
    Friend WithEvents edtCa As System.Windows.Forms.TextBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
