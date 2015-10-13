Public Class frmEpargne
    Dim CalcDone As Boolean
    Dim Counter As Byte
    Dim CIni As UInteger
    Dim CFin As Double
    Dim i As Single
    Dim n As Byte

    Private Sub frmEpargne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Epargne sans filtrage ni validation"

        btnCalc.Text = "Calculer"
        btnCalc.Enabled = False
        btnQuit.Text = "Quitter"

        edtCapIni.Enabled = True
        edtCapIni.Focus()
        edtCapIni.Tag = 1
        edtPourc.Enabled = False
        edtPourc.Tag = 2
        edtDuration.Enabled = False
        edtDuration.Tag = 3
        edtCapFin.Enabled = False
        edtCapFin.Tag = 4
        edtCapFin.ReadOnly = True

        lblCapIni.Text = "Capital initial =>"
        lblCapIni.Tag = 5
        lblPourc.Text = "Pourcentage :"
        lblPourc.Tag = 6
        lblDuration.Text = "Durée :"
        lblDuration.Tag = 7
        lblCapFin.Text = "Capital final :"
        lblCapFin.Tag = 8

        CalcDone = False
    End Sub
    'Private Sub edt_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtCapIni.KeyPress, edtPourc.KeyPress, edtDuration.KeyPress, edtCapFin.KeyPress
    'Dim edtPointer As TextBox = CType(sender, TextBox)
    ' Dim lblPointer1 As Label
    ' Dim lblPointer2 As Label
    '    If e.KeyChar = Chr(13) Then

    '    End If
    ' End Sub
    Private Sub edtCapIni_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtCapIni.KeyPress
        If e.KeyChar = Chr(13) Then
            CIni = Val(edtCapIni.Text)
            lblCapIni.Text = Strings.Left(lblCapIni.Text, lblCapIni.Text.Length - 3) & " :"
            lblPourc.Text = Strings.Left(lblPourc.Text, lblPourc.Text.Length - 2) & " =>"
            edtCapIni.Enabled = False
            edtPourc.Enabled = True
            edtPourc.Focus()
        End If
    End Sub
    Private Sub edtPourc_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtPourc.KeyPress
        If e.KeyChar = Chr(13) Then
            i = Val(edtPourc.Text) / 100
            lblPourc.Text = Strings.Left(lblPourc.Text, lblPourc.Text.Length - 3) & " :"
            lblDuration.Text = Strings.Left(lblDuration.Text, lblDuration.Text.Length - 2) & " =>"
            edtPourc.Enabled = False
            edtDuration.Enabled = True
            edtDuration.Focus()
        End If
    End Sub
    Private Sub edtDuration_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtDuration.KeyPress
        If e.KeyChar = Chr(13) Then
            n = Val(edtDuration.Text)
            lblDuration.Text = Strings.Left(lblDuration.Text, lblDuration.Text.Length - 3) & " :"
            edtDuration.Enabled = False
            btnCalc.Enabled = True
            btnCalc.Focus()
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
    Private Function Calcul(ByVal Ini As UInteger, ByVal Inte As Single, ByVal duree As Byte)
        Return Ini * (1 + Inte) ^ duree
    End Function
    Private Function InitEpargne()
        btnCalc.Text = "Calculer"
        btnCalc.Enabled = False

        edtCapIni.Enabled = True
        edtCapIni.Focus()
        edtCapIni.Clear()
        edtPourc.Clear()
        edtDuration.Clear()
        edtCapFin.Clear()

        lblCapIni.Text = Strings.Left(lblCapIni.Text, lblCapIni.Text.Length - 2) & " =>"

        CalcDone = False
    End Function
    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If CalcDone = False Then
            CFin = Calcul(CIni, i, n)
            edtCapFin.Text = Format(CFin, "0.00")
            btnCalc.Text = "Réinitialiser"
            CalcDone = True
        Else
            InitEpargne()
        End If
    End Sub
End Class

'c=C(1+i)^n

