Public Class FRMsigles
    Dim TabTraduc(9) As String     'tableau pour la traduction des 10 sigles

    Private Sub FRMsigles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Liste de sigles"
        LBLsigles.Text = "Sigles informatiques :"
        BTNquitter.Text = "Quitter"

        LSTsigles.Items.Clear()
        LSTsigles.TabIndex = 0   'Le 1er élément de la liste porte l'index 0

        'Liste des sigles
        'ATTENTION mettre une LIstBox et non une ListView sinon cela no fonctionne pas !
        LSTsigles.Items.Add("Pichatte Fieu")       'Sigle1  (index0)
        LSTsigles.Items.Add("Fri")       'Sigle2  (index1)
        LSTsigles.Items.Add("Mingia Pè")       'Sigle3  (index2)
        LSTsigles.Items.Add("OUFTI")       'Sigle4  (index3)
        LSTsigles.Items.Add("Inwane")       'Sigle5  (index4)
        LSTsigles.Items.Add("MILF")       'Sigle6  (index5)
        LSTsigles.Items.Add("Tout Dit Pareil")       'Sigle7  (index6)
        LSTsigles.Items.Add("Techti Fieu")       'Sigle8  (index7)
        LSTsigles.Items.Add("T'es s'tun Baraki")    'Sigle9  (index8)
        LSTsigles.Items.Add("Inga Ti")       'Sigle10  (index9)

        'Tableau de traduction
        TabTraduc(0) = "Mort De Rire" + vbNewLine
        TabTraduc(0) = TabTraduc(0) + "Lorsque quelque chose vous fait rire"
        TabTraduc(1) = "Frère" + vbNewLine
        TabTraduc(1) = TabTraduc(1) + "Fils de votre papounet"
        TabTraduc(2) = "Oh là" + vbNewLine
        TabTraduc(2) = TabTraduc(2) + "Réaction lorsque quelque chose vous étonne"
        TabTraduc(3) = "Oh là" + vbNewLine
        TabTraduc(3) = TabTraduc(3) + "Réaction lorsque quelque chose vous étonne"
        TabTraduc(4) = "Mensonge" + vbNewLine
        TabTraduc(4) = TabTraduc(4) + "Mensonge, invention, connerie"
        TabTraduc(5) = "Mother I Like To Fuck" + vbNewLine
        TabTraduc(5) = TabTraduc(5) + "Très très très jolie maman"
        TabTraduc(6) = "Toujours Le même" + vbNewLine
        TabTraduc(6) = TabTraduc(6) + "Pas besoin d'explication supp."
        TabTraduc(7) = "Arrête un peu" + vbNewLine
        TabTraduc(7) = TabTraduc(7) + "Lorsqu'un ami vous raconte une débilité"
        TabTraduc(8) = "Tu n'es pas très malin" + vbNewLine
        TabTraduc(8) = TabTraduc(8) + "Tu es même très con"
        TabTraduc(9) = "Oh purée" + vbNewLine
        TabTraduc(9) = TabTraduc(9) + "Oh punaire, what happened?"
    End Sub


    Private Sub LSTsigles_DoubleClick1(sender As Object, e As EventArgs) Handles LSTsigles.DoubleClick
        'Code associé au choix d'un sigle
        FRMtraduction.LBLtraduction.Text = LSTsigles.Text    'L'étiquette reprend le nom du sigle à traduire

        Dim numero As Byte     'numero de l'élément sélectionné dans la liste
        numero = LSTsigles.Items.IndexOf(LSTsigles.Text)
        FRMtraduction.TXTtraduction.Text = TabTraduc(numero)   'La zone de texte reprend la traduction du sigle

        FRMtraduction.Show()   'On autorise l'affichage de la feuille Traduction
    End Sub

    Private Sub BTNquitter_Click(sender As Object, e As EventArgs) Handles BTNquitter.Click
        FRMtraduction.Close()    'fermeture de la feuille traduction
        Me.Close()               'fermeture de la feuille sigles

    End Sub



    Private Sub LSTsigles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSTsigles.SelectedIndexChanged

    End Sub
End Class
