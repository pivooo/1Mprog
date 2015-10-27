<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStat
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblElem = New System.Windows.Forms.Label()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.lblEcart = New System.Windows.Forms.Label()
        Me.lblElemList = New System.Windows.Forms.Label()
        Me.edtNombre = New System.Windows.Forms.TextBox()
        Me.edtElem = New System.Windows.Forms.TextBox()
        Me.edtMoyenne = New System.Windows.Forms.TextBox()
        Me.edtEcart = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(31, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Label1"
        '
        'lblElem
        '
        Me.lblElem.AutoSize = True
        Me.lblElem.Location = New System.Drawing.Point(31, 63)
        Me.lblElem.Name = "lblElem"
        Me.lblElem.Size = New System.Drawing.Size(40, 13)
        Me.lblElem.TabIndex = 1
        Me.lblElem.Text = "lblElem"
        '
        'lblMoyenne
        '
        Me.lblMoyenne.AutoSize = True
        Me.lblMoyenne.Location = New System.Drawing.Point(31, 99)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(39, 13)
        Me.lblMoyenne.TabIndex = 2
        Me.lblMoyenne.Text = "Label3"
        '
        'lblEcart
        '
        Me.lblEcart.AutoSize = True
        Me.lblEcart.Location = New System.Drawing.Point(31, 133)
        Me.lblEcart.Name = "lblEcart"
        Me.lblEcart.Size = New System.Drawing.Size(39, 13)
        Me.lblEcart.TabIndex = 3
        Me.lblEcart.Text = "Label4"
        '
        'lblElemList
        '
        Me.lblElemList.AutoSize = True
        Me.lblElemList.Location = New System.Drawing.Point(117, 82)
        Me.lblElemList.Name = "lblElemList"
        Me.lblElemList.Size = New System.Drawing.Size(39, 13)
        Me.lblElemList.TabIndex = 4
        Me.lblElemList.Text = "Label5"
        '
        'edtNombre
        '
        Me.edtNombre.Location = New System.Drawing.Point(166, 21)
        Me.edtNombre.Name = "edtNombre"
        Me.edtNombre.Size = New System.Drawing.Size(100, 20)
        Me.edtNombre.TabIndex = 5
        '
        'edtElem
        '
        Me.edtElem.Location = New System.Drawing.Point(166, 60)
        Me.edtElem.Name = "edtElem"
        Me.edtElem.Size = New System.Drawing.Size(100, 20)
        Me.edtElem.TabIndex = 6
        '
        'edtMoyenne
        '
        Me.edtMoyenne.Location = New System.Drawing.Point(166, 96)
        Me.edtMoyenne.Name = "edtMoyenne"
        Me.edtMoyenne.Size = New System.Drawing.Size(100, 20)
        Me.edtMoyenne.TabIndex = 7
        '
        'edtEcart
        '
        Me.edtEcart.Location = New System.Drawing.Point(166, 130)
        Me.edtEcart.Name = "edtEcart"
        Me.edtEcart.Size = New System.Drawing.Size(100, 20)
        Me.edtEcart.TabIndex = 8
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(103, 179)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "Button1"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(103, 208)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Button2"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 268)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.edtEcart)
        Me.Controls.Add(Me.edtMoyenne)
        Me.Controls.Add(Me.edtElem)
        Me.Controls.Add(Me.edtNombre)
        Me.Controls.Add(Me.lblElemList)
        Me.Controls.Add(Me.lblEcart)
        Me.Controls.Add(Me.lblMoyenne)
        Me.Controls.Add(Me.lblElem)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmStat"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblElem As System.Windows.Forms.Label
    Friend WithEvents lblMoyenne As System.Windows.Forms.Label
    Friend WithEvents lblEcart As System.Windows.Forms.Label
    Friend WithEvents lblElemList As System.Windows.Forms.Label
    Friend WithEvents edtNombre As System.Windows.Forms.TextBox
    Friend WithEvents edtElem As System.Windows.Forms.TextBox
    Friend WithEvents edtMoyenne As System.Windows.Forms.TextBox
    Friend WithEvents edtEcart As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
