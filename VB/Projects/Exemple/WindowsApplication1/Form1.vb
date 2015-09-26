Public Class frmExemple
    Dim N1 As Single
    Dim N2 As Single
    Dim N3 As Single
    Dim S As Single

    Private Sub frmExemple_Load(sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Exemple"
        lblNombre1.Text = "Nombre1:"
        lblNombre2.Text = "Nombre2:"
        lblNombre3.Text = "Nombre3:"
        lblSomme.Text = "Somme:"

        btnInit.Text = "Réinitialiser"
        btnQuitter.Text = "Quitter"

        edtNombre1.Enabled = True
        edtNombre1.Focus()
        edtNombre2.Enabled = False
        edtNombre3.Enabled = False
        edtSomme.Enabled = False
    End Sub

    Private Sub edtNombre1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles edtNombre1.DoubleClick
        edtNombre1.Enabled = False
        edtNombre2.Enabled = True
        edtNombre2.Focus()

        N1 = Val(edtNombre1.Text)
    End Sub

    Private Sub edtNombre2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles edtNombre2.DoubleClick
        edtNombre2.Enabled = False
        edtNombre3.Enabled = True
        edtNombre3.Focus()

        N2 = Val(edtNombre2.Text)
    End Sub

    Private Sub edtNombre3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles edtNombre3.DoubleClick
        edtNombre3.Enabled = False

        N3 = Val(edtNombre3.Text)
        S = N1 + N2 + N3
        edtSomme.Text = Str(S)

        btnInit.Focus()
    End Sub

    Private Sub btnInit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInit.Click
        edtNombre1.Clear()
        edtNombre2.Clear()
        edtNombre3.Clear()
        edtSomme.Clear()

        edtNombre1.Enabled = True
        edtNombre1.Focus()
        edtNombre2.Enabled = False
        edtNombre3.Enabled = False
        edtSomme.Enabled = False
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        End
    End Sub
End Class
