Public Class frmmdpChange
    Dim reponse, reponse2 As Integer
    Dim filereader As String
    Private Sub mdpChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMdp.Hide()
        My.Settings.Reload()

        lblPw1.Text = "Nouveau MDP:"
        lblPw2.Text = "Confirmation:"

        edtPw1.Enabled = True
        edtPw1.Focus()
        edtPw2.Enabled = False

        edtPw1.PasswordChar = frmMdp.pwchar
        edtPw2.PasswordChar = frmMdp.pwchar

        btnShow.Enabled = True
        btnShow.Text = "Montrer"
        btnConfirm.Text = "OK"
        btnConfirm.Enabled = False

    End Sub

    Private Sub edtPw1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edtPw1.KeyPress
        If e.KeyChar = Chr(13) Then
            edtPw1.Enabled = False
            edtPw2.Enabled = True
            edtPw2.Focus()
        End If
    End Sub

    Private Sub edtPw2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edtPw2.KeyPress
        If e.KeyChar = Chr(13) Then
            edtPw2.Enabled = False
            btnConfirm.Enabled = True
            btnConfirm.Focus()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If edtPw1.Text = edtPw2.Text Then
            reponse = MessageBox.Show("Mot de passe modifié avec succès!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
            Select Case reponse
                Case DialogResult.OK
                    My.Computer.FileSystem.WriteAllText("mdp.txt", edtPw1.Text, False)
                    filereader = My.Computer.FileSystem.ReadAllText("mdp.txt")
                    My.Settings.Mdp = filereader
                    My.Settings.Save()
                    Init()
                    MyBase.Hide()
                    frmMdp.Show()
            End Select
        Else
            reponse2 = MessageBox.Show("Les deux mdp ne sont pas identiques!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Select Case reponse2
                Case DialogResult.OK
                    Init()
            End Select
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Static Dim show As Boolean
        If show Then
            edtPw1.PasswordChar = frmMdp.pwchar
            edtPw2.PasswordChar = frmMdp.pwchar
            show = False
            btnShow.Text = "Montrer"
        Else
            edtPw1.PasswordChar = ""
            edtPw2.PasswordChar = ""
            show = True
            btnShow.Text = "Cacher"
        End If
    End Sub

    Private Function Init()
        edtPw1.Enabled = True
        edtPw1.Focus()
        edtPw2.Enabled = False
        edtPw1.Clear()
        edtPw2.Clear()

        btnShow.Enabled = True
        btnConfirm.Enabled = False
    End Function

End Class