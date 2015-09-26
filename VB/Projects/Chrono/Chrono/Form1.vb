Public Class frmChrono
    Dim D1 As Date
    Dim D2 As Date
    Dim diff As Long
    Dim TimerOn As Boolean

    Private Sub frmChrono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Chrono"
        lblStart.Text = "Temps initial:"
        lblEnd.Text = "Temps final:"
        lblDuration.Text = "Durée:"

        btnSwitch.Text = "Start"
        btnSwitch.Focus()
        btnInit.Text = "Réinitialiser"
        btnQuitter.Text = "Quitter"

        edtStart.Enabled = False
        edtEnd.Enabled = False
        edtDuration.Enabled = False

        TimerOn = False
    End Sub

    Private Function duration(ByVal timelapse As Long) As String
        Dim N As Long
        Dim hour As String
        Dim min As String
        Dim sec As String
        N = timelapse \ 3600
        hour = Str(N)
        timelapse = timelapse - 3600 * N
        N = timelapse \ 60
        min = Str(N)
        N = timelapse Mod 60
        sec = Str(N)
        Return hour + ":" + min + ":" + sec

    End Function

    Private Sub btnSwitch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSwitch.Click
        If (TimerOn) Then
            TimerOn = False
            btnSwitch.Text = "Start"
            D2 = Now
            edtEnd.Text = Format(D2, "hh:mm:ss")
            diff = DateDiff(DateInterval.Second, D1, D2, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
            edtDuration.Text = duration(diff)
        Else
            TimerOn = True
            btnSwitch.Text = "Stop"
            D1 = Now
            edtStart.Text = Format(D1, "hh:mm:ss")
            edtEnd.Clear()
            edtDuration.Clear()
        End If

    End Sub

    Private Sub btnInit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInit.Click
        TimerOn = False
        btnSwitch.Text = "Start"
        edtStart.Clear()
        edtEnd.Clear()
        edtDuration.Clear()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        End
    End Sub

End Class
