Public Class frmChiffre
    Dim intro, phrase, endPh, message, mois(11), de(1) As String
    Dim CA As Double

    Private Sub frmChiffre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intro = "Vous n'avez que 2 possibilités:" & vbCr & "- Presser OK autorise la saisie de la suite des résultats mensuels" & vbCr & "- Presser Annuler termine immédiatement l'application"
        phrase = "Entrez le chiffre d'affaires du mois"
        mois = {"janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre"}
        endPh = ":"
        de = {" de ", " d'"}

        lblCa.Text = "Chiffre d'affaires annuel:"
        btnQuit.Text = "Quitter"
        edtCa.ReadOnly = True

        CA = 0
        prgmLoop()

    End Sub

    Private Function prgmLoop()
        Dim reponse As Byte
        reponse = MessageBox.Show(intro, "Aide à l'utilisateur", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Select Case reponse
            Case DialogResult.OK

            Case DialogResult.Cancel
                End
        End Select
        For i As Byte = 0 To 11 Step 1
            If i = 3 Or i = 7 Or i = 9 Then
                message = phrase & de(1) & mois(i) & endPh
            Else
                message = phrase & de(0) & mois(i) & endPh
            End If
            CA = CA + getCM(message)
        Next
        edtCa.Text = Format(Val(CA), "0.00" & " €")
    End Function
    Private Function getCM(ByVal message As String) As Double
        Dim temp As String
        Dim nCounter As Integer
        Do
            nCounter = 0
            Do
                temp = InputBox(message, "CA mensuel", "")
                For i As Integer = 1 To temp.Length Step 1
                    If Strings.Mid(temp, i, 1) = "." Then
                        nCounter = nCounter + 1
                    ElseIf Strings.Mid(temp, i, 1) = "," Then
                        nCounter = nCounter + 2
                    End If
                Next

                If nCounter > 1 Or IsNumeric(temp) = 0 Then
                    MessageBox.Show("Entrée incorrecte !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Loop Until (IsNumeric(temp) And IsDBNull(temp) = False)
        Loop While nCounter > 1

        Return Val(temp)
    End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class
