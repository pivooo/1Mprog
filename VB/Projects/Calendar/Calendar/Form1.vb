Public Class frmCalendar
    Dim TimerOn As Boolean

    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calendrier"

        btnPause.Text = "Pause"
        btnQuit.Text = "Quitter"
        btnQuit.Focus()

        edtDayS.Enabled = True
        edtDayN.Enabled = True
        edtMonth.Enabled = True
        edtYear.Enabled = True
        edtTime.Enabled = True

        edtDayS.ReadOnly = True
        edtDayN.ReadOnly = True
        edtMonth.ReadOnly = True
        edtYear.ReadOnly = True
        edtTime.ReadOnly = True

        tmrRefresh.Interval = 1000

        displayTime(Now)
        tmrRefresh.Enabled = True
        TimerOn = True
    End Sub

    Private Sub tmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick
        displayTime(Now)
    End Sub

    Private Function displayTime(ByVal Mnt As Date)
        edtDayS.Text = Format(Mnt, "dddd")
        edtDayN.Text = Format(Mnt, "dd")
        edtMonth.Text = Format(Mnt, "MMMM")
        edtYear.Text = Format(Mnt, "yyyy")
        edtTime.Text = Format(Mnt, "HH:mm:ss")
    End Function

    Private Sub btnQuit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If (TimerOn) Then
            tmrRefresh.Enabled = False
            TimerOn = False
            btnPause.Text = "Unpause"
        Else
            displayTime(Now)
            tmrRefresh.Enabled = True
            TimerOn = True
            btnPause.Text = "Pause"
        End If
    End Sub

End Class
