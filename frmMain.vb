Imports System.ComponentModel
Imports System.IO.Ports

Public Class frmMain

    Private value As String = String.Empty
    Private valueTemp As String = String.Empty
    Private counting As Int16 = 0

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        closeSerialPort(SerialPort1)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            If Not SerialPort1.IsOpen Then
                openSerialPort(SerialPort1)
                If rbtnStable.Checked Then
                    Timer1.Start()
                End If
                btnConnect.Text = "Disconnect"

                rbtnStable.Enabled = False
                rbtnStream.Enabled = False
            Else
                closeSerialPort(SerialPort1)
                If rbtnStable.Checked Then
                    Timer1.Stop()
                End If
                btnConnect.Text = "Connect"
                resetValues()

                rbtnStable.Enabled = True
                rbtnStream.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Serial Port")
        End Try
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        closeSerialPort(SerialPort1)
        Dim frmSetting As New frmSetting
        frmSetting.ShowDialog()
    End Sub

    Private Sub openSerialPort(ByVal serialport As SerialPort)
        Try
            If serialport.IsOpen Then
                serialport.Close()
            End If
            serialport.Open()
        Catch ex As IO.IOException
            Throw New Exception(ex.Message)
        Catch ex As Exception
            Throw New Exception()
        End Try
    End Sub

    Private Sub closeSerialPort(ByVal serialport As SerialPort)
        Try
            If serialport.IsOpen Then
                serialport.Close()
            End If
        Catch ex As IO.IOException
            Throw New Exception(ex.Message)
        Catch ex As Exception
            Throw New Exception()
        End Try
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim readStr As String = SerialPort1.ReadLine
            If Not String.IsNullOrEmpty(readStr) Then
                value = readStr
                removeOtherValue(value)

                If rbtnStream.Checked Then
                    SetText(lblValue, value)
                End If
                SetText(txtMultiLine, value)
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Delegate Sub SetTextCallback(ByRef control As Control, ByRef value As String)
    Private Sub SetText(ByRef control As Control, ByRef value As String)
        If control.InvokeRequired Then
            Me.Invoke(New SetTextCallback(AddressOf SetText), New Object() {control, value})
        Else
            control.Text = value
        End If
    End Sub

    Private Sub removeOtherValue(ByRef value As String)
        value = value.Replace(vbCr, String.Empty)
        value = value.Replace(vbNewLine, String.Empty)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If value.Trim.Equals(valueTemp.Trim) Then
            counting += 1
            If counting = 3 Then
                SetText(lblValue, value)
            End If
        Else
            valueTemp = value
            counting = 0
        End If
    End Sub

    Private Sub resetValues()
        value = String.Empty
        valueTemp = String.Empty
        counting = 0
        lblValue.Text = "0"
        txtMultiLine.Clear()
    End Sub

    Private Sub sendToAS400()
        SendKeys.Send("EiEi")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        sendToAS400()
    End Sub

End Class
