Public Class FRMtraduction

    Private Sub FRMtraduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Traduction"
        LBLtraduction.Text = "Jargon traduit :"
        BTNquitter2.Text = "Quitter"
    End Sub


    Private Sub BTNquitter2_Click(sender As Object, e As EventArgs) Handles BTNquitter2.Click
        Me.Hide()   'Le formulaire traduction est caché
    End Sub
End Class