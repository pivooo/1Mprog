Public Class frmChrono
    Dim D1 As Date
    Dim D2 As Date
    Dim diff As UInteger
    Dim TimerOn As Boolean
    Dim timeDisplay As String

    Private Sub frmChrono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Chrono"
        Me.BackgroundImage = Global.Chrono.My.Resources.Resources.ob_642057_chrono

        lblStart.Text = "Temps initial:"
        lblEnd.Text = "Temps final:"
        lblDuration.Text = "Durée:"

        btnSwitch.Text = "Start"
        btnSwitch.Focus()
        btnInit.Text = "Réinitialiser"
        btnInit.Enabled = False
        btnQuitter.Text = "Quitter"

        edtStart.Enabled = True
        edtEnd.Enabled = True
        edtDuration.Enabled = True
        edtStart.ReadOnly = True
        edtEnd.ReadOnly = True
        edtDuration.ReadOnly = True

        TimerOn = False

        timeDisplay = "HH:mm:ss"
    End Sub

    Private Function duration(ByVal timelapse As UInteger) As String
        Dim N As Byte
        Dim hour, min, sec As String
        N = timelapse / 3600
        hour = N.ToString("00")
        timelapse = timelapse - 3600 * N
        N = timelapse / 60
        min = N.ToString("00")
        N = timelapse Mod 60
        sec = N.ToString("00")
        Return hour & ":" & min & ":" & sec
    End Function

    Private Sub btnSwitch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSwitch.Click
        If (TimerOn) Then
            TimerOn = False
            btnSwitch.Text = "Start"
            D2 = Now
            edtEnd.Text = Format(D2, timeDisplay)
            diff = DateDiff(DateInterval.Second, D1, D2, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
            edtDuration.Text = duration(diff)
        Else
            TimerOn = True
            btnSwitch.Text = "Stop"
            D1 = Now
            edtStart.Text = Format(D1, timeDisplay)
            edtEnd.Clear()
            edtDuration.Clear()
            btnInit.Enabled = True
        End If

    End Sub

    Private Sub btnInit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInit.Click
        TimerOn = False
        btnSwitch.Text = "Start"
        btnInit.Enabled = False

        edtStart.Clear()
        edtEnd.Clear()
        edtDuration.Clear()
    End Sub

    Private Sub btnQuitter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        End
    End Sub

End Class