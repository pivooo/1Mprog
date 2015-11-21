Public Class frmMdp
    Dim reponse, reponse1 As Integer
    Dim maxTrial As Byte
    Friend Const pwchar As String = "•"
    Private Sub frmMdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        frmmdpChange.Hide()
        Me.Text = "Mot de passe"
        lblMdp.Text = "Entrez votre mot de passe"
        edtMdp.PasswordChar = pwchar
        edtMdp.Tag = "lol"
        maxTrial = 3
    End Sub

    Private Sub edtMdp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edtMdp.KeyPress
        Static compte As Byte
        If e.KeyChar = Chr(13) Then
            If edtMdp.Text = My.Settings.Mdp Then
                reponse1 = MessageBox.Show("Changer de mdp?", "Que faire?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                Select Case reponse1
                    Case DialogResult.Yes
                        frmmdpChange.Show()
                        MyBase.Hide()
                    Case DialogResult.No
                        MessageBox.Show("Accès autorisé", "Mot de passe correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmStat.Show()
                        MyBase.Hide()
                    Case DialogResult.Cancel
                        End
                End Select

            Else
                reponse = MessageBox.Show("Incorrect password", "Access denied", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Select Case reponse
                    Case DialogResult.Retry
                        edtMdp.Clear()
                        edtMdp.Focus()
                        compte = compte + 1
                        If compte = maxTrial Then
                            End
                        End If
                    Case DialogResult.Cancel
                        End
                End Select
            End If
        End If
    End Sub

End Class