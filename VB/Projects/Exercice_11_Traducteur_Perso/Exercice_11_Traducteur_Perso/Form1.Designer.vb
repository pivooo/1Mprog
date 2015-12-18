<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMsigles
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
        Me.LBLsigles = New System.Windows.Forms.Label()
        Me.BTNquitter = New System.Windows.Forms.Button()
        Me.LSTsigles = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LBLsigles
        '
        Me.LBLsigles.AutoSize = True
        Me.LBLsigles.Location = New System.Drawing.Point(40, 23)
        Me.LBLsigles.Name = "LBLsigles"
        Me.LBLsigles.Size = New System.Drawing.Size(39, 13)
        Me.LBLsigles.TabIndex = 0
        Me.LBLsigles.Text = "Label1"
        '
        'BTNquitter
        '
        Me.BTNquitter.Location = New System.Drawing.Point(106, 218)
        Me.BTNquitter.Name = "BTNquitter"
        Me.BTNquitter.Size = New System.Drawing.Size(75, 23)
        Me.BTNquitter.TabIndex = 2
        Me.BTNquitter.Text = "Button1"
        Me.BTNquitter.UseVisualStyleBackColor = True
        '
        'LSTsigles
        '
        Me.LSTsigles.FormattingEnabled = True
        Me.LSTsigles.Location = New System.Drawing.Point(22, 49)
        Me.LSTsigles.Name = "LSTsigles"
        Me.LSTsigles.Size = New System.Drawing.Size(250, 160)
        Me.LSTsigles.TabIndex = 3
        '
        'FRMsigles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LSTsigles)
        Me.Controls.Add(Me.BTNquitter)
        Me.Controls.Add(Me.LBLsigles)
        Me.Name = "FRMsigles"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLsigles As System.Windows.Forms.Label
    Friend WithEvents BTNquitter As System.Windows.Forms.Button
    Friend WithEvents LSTsigles As System.Windows.Forms.ListBox

End Class
