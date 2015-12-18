<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Exercice_9
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
        Me.BTNreservation = New System.Windows.Forms.Button()
        Me.BTNquitter = New System.Windows.Forms.Button()
        Me.LBLdestination = New System.Windows.Forms.Label()
        Me.LBLsiege = New System.Windows.Forms.Label()
        Me.LBLrepas = New System.Windows.Forms.Label()
        Me.LBOXdestination = New System.Windows.Forms.ListBox()
        Me.CMBsiege = New System.Windows.Forms.ComboBox()
        Me.CMBrepas = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTNreservation
        '
        Me.BTNreservation.Location = New System.Drawing.Point(68, 153)
        Me.BTNreservation.Name = "BTNreservation"
        Me.BTNreservation.Size = New System.Drawing.Size(205, 23)
        Me.BTNreservation.TabIndex = 3
        Me.BTNreservation.Text = "Button1"
        Me.BTNreservation.UseVisualStyleBackColor = True
        '
        'BTNquitter
        '
        Me.BTNquitter.Location = New System.Drawing.Point(141, 204)
        Me.BTNquitter.Name = "BTNquitter"
        Me.BTNquitter.Size = New System.Drawing.Size(75, 23)
        Me.BTNquitter.TabIndex = 4
        Me.BTNquitter.Text = "Button2"
        Me.BTNquitter.UseVisualStyleBackColor = True
        '
        'LBLdestination
        '
        Me.LBLdestination.AutoSize = True
        Me.LBLdestination.Location = New System.Drawing.Point(13, 13)
        Me.LBLdestination.Name = "LBLdestination"
        Me.LBLdestination.Size = New System.Drawing.Size(39, 13)
        Me.LBLdestination.TabIndex = 5
        Me.LBLdestination.Text = "Label1"
        '
        'LBLsiege
        '
        Me.LBLsiege.AutoSize = True
        Me.LBLsiege.Location = New System.Drawing.Point(128, 13)
        Me.LBLsiege.Name = "LBLsiege"
        Me.LBLsiege.Size = New System.Drawing.Size(39, 13)
        Me.LBLsiege.TabIndex = 6
        Me.LBLsiege.Text = "Label2"
        '
        'LBLrepas
        '
        Me.LBLrepas.AutoSize = True
        Me.LBLrepas.Location = New System.Drawing.Point(248, 13)
        Me.LBLrepas.Name = "LBLrepas"
        Me.LBLrepas.Size = New System.Drawing.Size(39, 13)
        Me.LBLrepas.TabIndex = 7
        Me.LBLrepas.Text = "Label3"
        '
        'LBOXdestination
        '
        Me.LBOXdestination.FormattingEnabled = True
        Me.LBOXdestination.Location = New System.Drawing.Point(16, 30)
        Me.LBOXdestination.Name = "LBOXdestination"
        Me.LBOXdestination.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LBOXdestination.Size = New System.Drawing.Size(94, 95)
        Me.LBOXdestination.TabIndex = 8
        '
        'CMBsiege
        '
        Me.CMBsiege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBsiege.FormattingEnabled = True
        Me.CMBsiege.Location = New System.Drawing.Point(131, 30)
        Me.CMBsiege.Name = "CMBsiege"
        Me.CMBsiege.Size = New System.Drawing.Size(93, 21)
        Me.CMBsiege.TabIndex = 9
        '
        'CMBrepas
        '
        Me.CMBrepas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CMBrepas.FormattingEnabled = True
        Me.CMBrepas.Location = New System.Drawing.Point(251, 30)
        Me.CMBrepas.Name = "CMBrepas"
        Me.CMBrepas.Size = New System.Drawing.Size(93, 111)
        Me.CMBrepas.TabIndex = 10
        '
        'FRM_Exercice_9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 262)
        Me.Controls.Add(Me.CMBrepas)
        Me.Controls.Add(Me.CMBsiege)
        Me.Controls.Add(Me.LBOXdestination)
        Me.Controls.Add(Me.LBLrepas)
        Me.Controls.Add(Me.LBLsiege)
        Me.Controls.Add(Me.LBLdestination)
        Me.Controls.Add(Me.BTNquitter)
        Me.Controls.Add(Me.BTNreservation)
        Me.Name = "FRM_Exercice_9"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNreservation As System.Windows.Forms.Button
    Friend WithEvents BTNquitter As System.Windows.Forms.Button
    Friend WithEvents LBLdestination As System.Windows.Forms.Label
    Friend WithEvents LBLsiege As System.Windows.Forms.Label
    Friend WithEvents LBLrepas As System.Windows.Forms.Label
    Friend WithEvents LBOXdestination As System.Windows.Forms.ListBox
    Friend WithEvents CMBsiege As System.Windows.Forms.ComboBox
    Friend WithEvents CMBrepas As System.Windows.Forms.ComboBox

End Class
