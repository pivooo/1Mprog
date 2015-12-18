<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMtraduction
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
        Me.BTNquitter2 = New System.Windows.Forms.Button()
        Me.LBLtraduction = New System.Windows.Forms.Label()
        Me.TXTtraduction = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNquitter2
        '
        Me.BTNquitter2.Location = New System.Drawing.Point(119, 224)
        Me.BTNquitter2.Name = "BTNquitter2"
        Me.BTNquitter2.Size = New System.Drawing.Size(75, 23)
        Me.BTNquitter2.TabIndex = 0
        Me.BTNquitter2.Text = "Button1"
        Me.BTNquitter2.UseVisualStyleBackColor = True
        '
        'LBLtraduction
        '
        Me.LBLtraduction.AutoSize = True
        Me.LBLtraduction.Location = New System.Drawing.Point(25, 19)
        Me.LBLtraduction.Name = "LBLtraduction"
        Me.LBLtraduction.Size = New System.Drawing.Size(39, 13)
        Me.LBLtraduction.TabIndex = 1
        Me.LBLtraduction.Text = "Label1"
        '
        'TXTtraduction
        '
        Me.TXTtraduction.Location = New System.Drawing.Point(28, 59)
        Me.TXTtraduction.Multiline = True
        Me.TXTtraduction.Name = "TXTtraduction"
        Me.TXTtraduction.Size = New System.Drawing.Size(233, 124)
        Me.TXTtraduction.TabIndex = 2
        '
        'FRMtraduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TXTtraduction)
        Me.Controls.Add(Me.LBLtraduction)
        Me.Controls.Add(Me.BTNquitter2)
        Me.Name = "FRMtraduction"
        Me.Text = "Traduction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNquitter2 As System.Windows.Forms.Button
    Friend WithEvents LBLtraduction As System.Windows.Forms.Label
    Friend WithEvents TXTtraduction As System.Windows.Forms.TextBox
End Class
