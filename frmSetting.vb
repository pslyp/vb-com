Public Class frmSetting

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each name As String In My.Computer.Ports.SerialPortNames
            cmbPortName.Items.Add(name)
        Next
        cmbPortName.SelectedIndex = 0
    End Sub

End Class