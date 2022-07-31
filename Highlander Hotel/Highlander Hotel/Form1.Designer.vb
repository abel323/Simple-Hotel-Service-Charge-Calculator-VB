<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoNight = New System.Windows.Forms.TextBox()
        Me.txtNight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMSC = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtRoomservice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRoomcharge = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAdditionalCharge = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.lbltotalCharge = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Today's Date: "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(324, 71)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 17)
        Me.lblDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(324, 137)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 17)
        Me.lblTime.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoNight)
        Me.GroupBox1.Controls.Add(Me.txtNight)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 218)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'txtNoNight
        '
        Me.txtNoNight.Location = New System.Drawing.Point(138, 100)
        Me.txtNoNight.Name = "txtNoNight"
        Me.txtNoNight.Size = New System.Drawing.Size(129, 22)
        Me.txtNoNight.TabIndex = 3
        Me.txtNoNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNight
        '
        Me.txtNight.Location = New System.Drawing.Point(138, 33)
        Me.txtNight.Name = "txtNight"
        Me.txtNight.ShortcutsEnabled = False
        Me.txtNight.Size = New System.Drawing.Size(129, 22)
        Me.txtNight.TabIndex = 2
        Me.txtNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nightly Charge: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nights: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMSC)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomservice)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(427, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 218)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional charge"
        '
        'txtMSC
        '
        Me.txtMSC.Location = New System.Drawing.Point(132, 156)
        Me.txtMSC.Name = "txtMSC"
        Me.txtMSC.ShortcutsEnabled = False
        Me.txtMSC.Size = New System.Drawing.Size(129, 22)
        Me.txtMSC.TabIndex = 8
        Me.txtMSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(132, 100)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.ShortcutsEnabled = False
        Me.txtTelephone.Size = New System.Drawing.Size(129, 22)
        Me.txtTelephone.TabIndex = 7
        Me.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRoomservice
        '
        Me.txtRoomservice.Location = New System.Drawing.Point(132, 36)
        Me.txtRoomservice.Name = "txtRoomservice"
        Me.txtRoomservice.ShortcutsEnabled = False
        Me.txtRoomservice.Size = New System.Drawing.Size(129, 22)
        Me.txtRoomservice.TabIndex = 4
        Me.txtRoomservice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MSC: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Room Service: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Telephone: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbltotalCharge)
        Me.GroupBox3.Controls.Add(Me.lbltax)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblAdditionalCharge)
        Me.GroupBox3.Controls.Add(Me.lblRoomcharge)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 277)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charge"
        '
        'lblRoomcharge
        '
        Me.lblRoomcharge.AutoSize = True
        Me.lblRoomcharge.Location = New System.Drawing.Point(289, 32)
        Me.lblRoomcharge.Name = "lblRoomcharge"
        Me.lblRoomcharge.Size = New System.Drawing.Size(0, 17)
        Me.lblRoomcharge.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(184, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Total Charge: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Tax: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(205, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Sub Total: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(154, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Additional Charge: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(179, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Room Charge: "
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(47, 727)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 43)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(277, 727)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 43)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(511, 727)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 43)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAdditionalCharge
        '
        Me.lblAdditionalCharge.AutoSize = True
        Me.lblAdditionalCharge.Location = New System.Drawing.Point(289, 86)
        Me.lblAdditionalCharge.Name = "lblAdditionalCharge"
        Me.lblAdditionalCharge.Size = New System.Drawing.Size(0, 17)
        Me.lblAdditionalCharge.TabIndex = 6
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(289, 132)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(0, 17)
        Me.lblSubTotal.TabIndex = 7
        '
        'lbltax
        '
        Me.lbltax.AutoSize = True
        Me.lbltax.Location = New System.Drawing.Point(289, 174)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(0, 17)
        Me.lbltax.TabIndex = 8
        '
        'lbltotalCharge
        '
        Me.lbltotalCharge.AutoSize = True
        Me.lbltotalCharge.Location = New System.Drawing.Point(289, 223)
        Me.lbltotalCharge.Name = "lbltotalCharge"
        Me.lbltotalCharge.Size = New System.Drawing.Size(0, 17)
        Me.lbltotalCharge.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(800, 782)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "HighLander Hotel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoNight As TextBox
    Friend WithEvents txtNight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMSC As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomservice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblRoomcharge As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbltotalCharge As Label
    Friend WithEvents lbltax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblAdditionalCharge As Label
End Class
