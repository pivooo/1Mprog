Public Class frmMdp
    Dim reponse, reponse1 As Integer
    Dim compte As Byte
    Private Sub frmMdp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmmdpChange.Hide()
        Me.Text = "Mot de passe"
        lblMdp.Text = "Entrez votre mot de passe"
        edtMdp.PasswordChar = "*"
        edtMdp.Tag = "lol"
        compte = 3
    End Sub

    Private Sub edtMdp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edtMdp.KeyPress
        If e.KeyChar = Chr(13) Then
            If edtMdp.Text = edtMdp.Tag Then
                reponse1 = MessageBox.Show("Changer de mdp?", "Que faire?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                Select Case reponse1
                    Case DialogResult.Yes
                        frmmdpChange.Show()
                    Case DialogResult.No
                        MessageBox.Show("Accès autorisé", "Mot de passe correct", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmStat.Show()
                    Case DialogResult.Cancel
                        End
                End Select

            Else
                reponse = MessageBox.Show("Incorrect password", "Access denied", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Select Case reponse
                    Case DialogResult.Retry
                        edtMdp.Clear()
                        edtMdp.Focus()
                        compte = compte - 1
                        If compte = 0 Then
                            End
                        End If
                    Case DialogResult.Cancel
                        End
                End Select
            End If
        End If
    End Sub

End Class