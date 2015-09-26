<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExemple
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
        Me.btnInit = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblNombre1 = New System.Windows.Forms.Label()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblNombre3 = New System.Windows.Forms.Label()
        Me.lblSomme = New System.Windows.Forms.Label()
        Me.edtNombre1 = New System.Windows.Forms.TextBox()
        Me.edtNombre2 = New System.Windows.Forms.TextBox()
        Me.edtNombre3 = New System.Windows.Forms.TextBox()
        Me.edtSomme = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(70, 224)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Button1"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(325, 224)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 1
        Me.btnQuitter.Text = "Button2"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblNombre1
        '
        Me.lblNombre1.AutoSize = True
        Me.lblNombre1.Location = New System.Drawing.Point(67, 63)
        Me.lblNombre1.Name = "lblNombre1"
        Me.lblNombre1.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre1.TabIndex = 2
        Me.lblNombre1.Text = "Label1"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Location = New System.Drawing.Point(67, 89)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre2.TabIndex = 3
        Me.lblNombre2.Text = "Label2"
        '
        'lblNombre3
        '
        Me.lblNombre3.AutoSize = True
        Me.lblNombre3.Location = New System.Drawing.Point(67, 115)
        Me.lblNombre3.Name = "lblNombre3"
        Me.lblNombre3.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre3.TabIndex = 4
        Me.lblNombre3.Text = "Label3"
        '
        'lblSomme
        '
        Me.lblSomme.AutoSize = True
        Me.lblSomme.Location = New System.Drawing.Point(67, 141)
        Me.lblSomme.Name = "lblSomme"
        Me.lblSomme.Size = New System.Drawing.Size(39, 13)
        Me.lblSomme.TabIndex = 5
        Me.lblSomme.Text = "Label4"
        '
        'edtNombre1
        '
        Me.edtNombre1.Location = New System.Drawing.Point(300, 60)
        Me.edtNombre1.Name = "edtNombre1"
        Me.edtNombre1.Size = New System.Drawing.Size(100, 20)
        Me.edtNombre1.TabIndex = 6
        '
        'edtNombre2
        '
        Me.edtNombre2.Location = New System.Drawing.Point(300, 86)
        Me.edtNombre2.Name = "edtNombre2"
        Me.edtNombre2.Size = New System.Drawing.Size(100, 20)
        Me.edtNombre2.TabIndex = 7
        '
        'edtNombre3
        '
        Me.edtNombre3.Location = New System.Drawing.Point(300, 112)
        Me.edtNombre3.Name = "edtNombre3"
        Me.edtNombre3.Size = New System.Drawing.Size(100, 20)
        Me.edtNombre3.TabIndex = 8
        '
        'edtSomme
        '
        Me.edtSomme.Location = New System.Drawing.Point(300, 138)
        Me.edtSomme.Name = "edtSomme"
        Me.edtSomme.Size = New System.Drawing.Size(100, 20)
        Me.edtSomme.TabIndex = 9
        '
        'frmExemple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 329)
        Me.Controls.Add(Me.edtSomme)
        Me.Controls.Add(Me.edtNombre3)
        Me.Controls.Add(Me.edtNombre2)
        Me.Controls.Add(Me.edtNombre1)
        Me.Controls.Add(Me.lblSomme)
        Me.Controls.Add(Me.lblNombre3)
        Me.Controls.Add(Me.lblNombre2)
        Me.Controls.Add(Me.lblNombre1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnInit)
        Me.Name = "frmExemple"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents lblNombre1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre3 As System.Windows.Forms.Label
    Friend WithEvents lblSomme As System.Windows.Forms.Label
    Friend WithEvents edtNombre1 As System.Windows.Forms.TextBox
    Friend WithEvents edtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents edtNombre3 As System.Windows.Forms.TextBox
    Friend WithEvents edtSomme As System.Windows.Forms.TextBox

End Class
