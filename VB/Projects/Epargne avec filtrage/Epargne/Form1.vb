Public Class frmEpargne
    Dim CalcDone As Boolean
    Dim Counter As Byte
    Dim CIni As Single
    Dim CFin As Double
    Dim i As Single
    Dim n As Byte
    Dim deuxPoints As String
    Dim fleche As String

    Private Sub frmEpargne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Epargne avec filtrage"

        btnCalc.Text = "Calculer"
        btnCalc.Enabled = False
        btnQuit.Text = "Quitter"

        edtCapIni.Enabled = True
        edtCapIni.Focus()
        edtPourc.Enabled = False
        edtDuration.Enabled = False
        edtCapFin.Enabled = False
        edtCapFin.ReadOnly = True

        lblCapIni.Text = "Capital initial =>"
        lblPourc.Text = "Pourcentage :"
        lblDuration.Text = "Durée :"
        lblCapFin.Text = "Capital final :"

        CalcDone = False
        deuxPoints = " :"
        fleche = " =>"
    End Sub
    Private Sub edt_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtCapIni.KeyPress, edtPourc.KeyPress, edtDuration.KeyPress, edtCapFin.KeyPress
        Dim edtPointer As TextBox = DirectCast(sender, TextBox)
        Static Dim nCounter, nComa As Byte, Coma As Boolean
        If e.KeyChar = Chr(13) Then
            If edtPointer.Text = "" Then
                edtPointer.Focus()
            Else
                Select Case CInt(edtPointer.TabIndex)
                    Case 4
                        CIni = edtKeypress(edtPointer, edtPourc, lblCapIni, lblPourc)
                        nCounter = 0
                        nComa = 0
                        Coma = False
                    Case 5
                        i = edtKeypress(edtPourc, edtDuration, lblPourc, lblDuration)
                        nCounter = 0
                        nComa = 0
                        Coma = False
                    Case 6
                        n = edtKeypress(edtDuration, edtCapIni, lblDuration, lblCapIni)
                        nCounter = 0
                        nComa = 0
                        Coma = False
                        edtCapIni.Enabled = False
                        btnCalc.Enabled = True
                        btnCalc.Focus()
                End Select

            End If
        ElseIf IsNumeric(e.KeyChar) Then
            nCounter = nCounter + 1
        ElseIf e.KeyChar = Chr(46) Then
            If Coma = True Then
                Beep()
                e.Handled = True
            ElseIf nCounter = 0 Then
                Beep()
                e.Handled = True
            Else
                Coma = True
                nCounter = nCounter + 1
                nComa = nCounter
            End If
        ElseIf e.KeyChar = Chr(8) Then
            If nCounter > 0 Then
                nCounter = nCounter - 1
                If nCounter < nComa Then
                    Coma = False
                    nComa = 0
                End If
            End If       
        Else
            Beep()
            e.Handled = True
        End If
    End Sub
  

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
    Private Function edtKeypress(ByVal edt1 As TextBox, ByVal edt2 As TextBox, ByVal lbl1 As Label, ByVal lbl2 As Label)
        lbl1.Text = Strings.Left(lbl1.Text, lbl1.Text.Length - fleche.Length) & deuxPoints
        lbl2.Text = Strings.Left(lbl2.Text, lbl2.Text.Length - deuxPoints.Length) & fleche
        edt1.Enabled = False
        edt2.Enabled = True
        edt2.Focus()
        Return Val(edt1.Text)
    End Function
    Private Function Calcul(ByVal Ini As Single, ByVal Inte As Single, ByVal duree As Byte)
        Return Ini * (1 + Inte / 100) ^ duree
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

        CalcDone = False
    End Function
    Private Sub btnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        If CalcDone = False Then
            CFin = Calcul(CIni, i, n)
            edtCapFin.Text = Format(CFin, "0.00") & " €"
            btnCalc.Text = "Réinitialiser"
            CalcDone = True
        Else
            InitEpargne()
        End If
    End Sub
End Class

'c=C(1+i)^n

