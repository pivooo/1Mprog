Public Class frmStat
    Dim lastVal, sum, sqSum, moyenne, ecart As Double
    Dim nombre As Byte
    Private Sub frmStat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Statistique"

        btnNew.Text = "Nouvelle Suite"
        btnNew.Enabled = False
        btnQuit.Text = "Quitter"

        lblNombre.Text = "Nombre d'éléments:"
        lblElem.Text = "Valeurs proposées:"
        lblMoyenne.Text = "Moyenne:"
        lblEcart.Text = "Ecart type:"
        lblElemList.Text = ""
    End Sub

    Private Sub edtNombre_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtNombre.KeyPress
        Dim edtPointer As TextBox = DirectCast(sender, TextBox)
        If e.KeyChar = Chr(13) Then
            If Val(edtPointer.Text) < 2 Then
                edtPointer.Focus()
                Beep()
            Else
                nombre = Val(edtPointer.Text)
                edtPointer.ReadOnly = True
                edtElem.Enabled = True
                edtElem.Focus()
            End If
        ElseIf IsNumeric(e.KeyChar) Then
            Exit Sub
        ElseIf e.KeyChar = Chr(8) Then
            Exit Sub
        Else
            Beep()
            e.Handled = True
        End If
    End Sub
    Private Sub edtElem_Keypress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles edtElem.KeyPress
        Dim edtPointer As TextBox = DirectCast(sender, TextBox)
        Static Dim nCounter, nComa, elemCounter As Byte, Coma, notFirst As Boolean
            If e.KeyChar = Chr(13) Then
                If edtPointer.Text = "" Then
                    edtPointer.Focus()
                Else
                    lastVal = Val(edtPointer.Text)
                    edtPointer.Clear()
                    edtPointer.Focus()
                    sum = sum + lastVal
                    sqSum = sqSum + lastVal * lastVal
                    elemCounter = elemCounter + 1
                    nCounter = 0
                    nComa = 0
                    Coma = False
                    If notFirst = False Then
                        lblElemList.Text = Format(lastVal, "0.00")
                        notFirst = True

                    Else
                        lblElemList.Text = lblElemList.Text & " - " & Format(lastVal, "0.00")
                        If elemCounter = nombre Then
                            moyenne = moy(sum, nombre)
                            ecart = eType(sum, sqSum, nombre)
                        End If
                    End If
                End If
            ElseIf IsNumeric(e.KeyChar) Then
                nCounter = nCounter + 1
            ElseIf e.KeyChar = Chr(45) And nCounter = 0 Then
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
            If (elemCounter < nombre) Then
                Exit Sub
            End If
        elemCounter = 0
        notFirst = False
        edtPointer.ReadOnly = True
        edtMoyenne.Enabled = True
        edtMoyenne.ReadOnly = True
        edtEcart.Enabled = True
        edtEcart.ReadOnly = True
        btnNew.Enabled = True
        btnNew.Focus()
        edtMoyenne.Text = Format(moyenne, "0.00")
        edtEcart.Text = Format(ecart, "0.00")
    End Sub
    Private Function moy(ByVal somme As Double, ByVal nombre As Byte) As Double
        moy = somme / nombre
    End Function
    Private Function eType(ByVal somme As Double, ByVal sommeCarre As Double, ByVal nombre As Byte) As Double
        eType = (sommeCarre / nombre) - (somme * somme) / (nombre * nombre)
    End Function


    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        init()
    End Sub
    Private Function init()
        lastVal = 0
        sum = 0
        sqSum = 0
        moyenne = 0
        ecart = 0

        edtNombre.Enabled = True
        edtNombre.Focus()
        edtNombre.ReadOnly = False
        edtElem.Enabled = False
        edtElem.ReadOnly = False
        edtMoyenne.Enabled = False
        edtEcart.Enabled = False

        edtNombre.Clear()
        edtElem.Clear()
        edtMoyenne.Clear()
        edtEcart.Clear()
        lblElemList.Text = ""

        btnNew.Enabled = False

    End Function
End Class

