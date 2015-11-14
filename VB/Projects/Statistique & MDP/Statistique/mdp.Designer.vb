<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdp
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
        Me.edtMdp = New System.Windows.Forms.TextBox()
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'edtMdp
        '
        Me.edtMdp.Location = New System.Drawing.Point(107, 77)
        Me.edtMdp.Name = "edtMdp"
        Me.edtMdp.Size = New System.Drawing.Size(163, 20)
        Me.edtMdp.TabIndex = 0
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Location = New System.Drawing.Point(104, 39)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(39, 13)
        Me.lblMdp.TabIndex = 2
        Me.lblMdp.Text = "Label1"
        '
        'frmMdp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 257)
        Me.Controls.Add(Me.lblMdp)
        Me.Controls.Add(Me.edtMdp)
        Me.Name = "frmMdp"
        Me.Text = "frmMdp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents edtMdp As System.Windows.Forms.TextBox
    Friend WithEvents lblMdp As System.Windows.Forms.Label
End Class
