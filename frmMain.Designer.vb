<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rbtnStable = New System.Windows.Forms.RadioButton()
        Me.rbtnStream = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMultiLine = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'lblValue
        '
        Me.lblValue.BackColor = System.Drawing.SystemColors.Window
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblValue.Location = New System.Drawing.Point(15, 19)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(130, 54)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "0"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(24, 207)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(94, 24)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnSetting
        '
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSetting.Location = New System.Drawing.Point(142, 207)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(94, 24)
        Me.btnSetting.TabIndex = 2
        Me.btnSetting.Text = "Setting"
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'rbtnStable
        '
        Me.rbtnStable.AutoSize = True
        Me.rbtnStable.Checked = True
        Me.rbtnStable.Location = New System.Drawing.Point(16, 21)
        Me.rbtnStable.Name = "rbtnStable"
        Me.rbtnStable.Size = New System.Drawing.Size(55, 17)
        Me.rbtnStable.TabIndex = 4
        Me.rbtnStable.TabStop = True
        Me.rbtnStable.Text = "Stable"
        Me.rbtnStable.UseVisualStyleBackColor = True
        '
        'rbtnStream
        '
        Me.rbtnStream.AutoSize = True
        Me.rbtnStream.Location = New System.Drawing.Point(16, 47)
        Me.rbtnStream.Name = "rbtnStream"
        Me.rbtnStream.Size = New System.Drawing.Size(58, 17)
        Me.rbtnStream.TabIndex = 5
        Me.rbtnStream.Text = "Stream"
        Me.rbtnStream.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnStream)
        Me.GroupBox1.Controls.Add(Me.rbtnStable)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 75)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode"
        '
        'txtMultiLine
        '
        Me.txtMultiLine.BackColor = System.Drawing.Color.White
        Me.txtMultiLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMultiLine.Location = New System.Drawing.Point(15, 98)
        Me.txtMultiLine.Name = "txtMultiLine"
        Me.txtMultiLine.ReadOnly = True
        Me.txtMultiLine.Size = New System.Drawing.Size(231, 96)
        Me.txtMultiLine.TabIndex = 7
        Me.txtMultiLine.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 286)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMultiLine)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblValue)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VBCom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblValue As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnSetting As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rbtnStable As RadioButton
    Friend WithEvents rbtnStream As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMultiLine As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
End Class
