Public Class FRM_Exercice_9

    Dim Information As Integer
    Dim BonVoyage As Integer

    Private Sub FRM_Exercice_9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Voyage aérien"

        LBLdestination.Text = "Destination :"
        LBLsiege.Text = "Siège :"
        LBLrepas.Text = "Repas :"
        BTNreservation.Text = "Réservation"
        BTNquitter.Text = "Quitter"

        'Liste des destinations possibles
        LBOXdestination.Items.Clear()   'Viderla liste de tout contenu préalable
        LBOXdestination.Sorted = True   'Classement de la liste par ordre alphabétique
        LBOXdestination.Items.Add("Pékin")
        LBOXdestination.Items.Add("Paris")
        LBOXdestination.Items.Add("Londres")
        LBOXdestination.Items.Add("Rome")
        LBOXdestination.Items.Add("ChtouliVille")
        LBOXdestination.SelectedIndex = 0    'au départ, on place la sélection à la 1ère destination

        'Liste des emplacements possibles
        CMBsiege.Items.Clear()     'vider la liste de tout contenu préalable
        CMBsiege.Items.Add("Hulblot")
        CMBsiege.Items.Add("Allée")
        CMBsiege.Items.Add("Ailes")
        CMBsiege.Items.Add("Avant")
        CMBsiege.Items.Add("Arrière")
        CMBsiege.SelectedIndex = 0  'au départ on place la sélection au 1er emplacement

        'Liste des menus possibles
        CMBrepas.Items.Clear()
        CMBrepas.Items.Add("Ordinaire")
        CMBrepas.Items.Add("Végétarien")
        CMBrepas.Items.Add("Sans sel")
        CMBrepas.Items.Add("Sans sucre")
        CMBrepas.Items.Add("Halal")
        CMBrepas.SelectedIndex = 0
    End Sub


    Private Sub LBLdestination_Click(sender As Object, e As EventArgs) Handles LBLdestination.Click
        LBOXdestination.Enabled = False
        BTNreservation.Enabled = False
        CMBsiege.Enabled = True
    End Sub



    Private Sub CMBrepas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBrepas.SelectedIndexChanged
        BTNreservation.Enabled = True
        BTNreservation.Focus()
    End Sub


    Private Sub BTNreservation_Click(sender As Object, e As EventArgs) Handles BTNreservation.Click
        Dim Message As String

        Message = "Destination : " & LBOXdestination.Text & vbCr
        Message = Message & "Emplacement du siège : " & CMBsiege.Text & vbCr
        Message = Message & "Repas du passager : " & CMBrepas.Text & vbCr
        Information = MessageBox.Show(Message, "Choix du passager", MessageBoxButtons.OK)

        Select Case Information
            Case DialogResult.OK
                BonVoyage = MessageBox.Show("Bon voyage Baccala", ":)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Select Case BonVoyage
                    Case DialogResult.OK
                        End
                End Select

                End

        End Select
        LBOXdestination.SelectedIndex = 0
        CMBsiege.SelectedIndex = 0
        CMBrepas.SelectedIndex = 0
        BTNreservation.Enabled = False
        LBOXdestination.Enabled = True
    End Sub


    Private Sub BTNquitter_Click(sender As Object, e As EventArgs) Handles BTNquitter.Click
        End
    End Sub
End Class
