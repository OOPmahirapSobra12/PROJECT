<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblschestud = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.dvgsearchStud = New System.Windows.Forms.DataGridView()
        Me.cboSearchStud = New System.Windows.Forms.ComboBox()
        Me.txtsearchsched = New System.Windows.Forms.Button()
        Me.txtsearchRoomStud = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnrequest = New System.Windows.Forms.Button()
        CType(Me.dvgsearchStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblschestud
        '
        Me.lblschestud.AutoSize = True
        Me.lblschestud.BackColor = System.Drawing.Color.Transparent
        Me.lblschestud.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblschestud.ForeColor = System.Drawing.Color.White
        Me.lblschestud.Location = New System.Drawing.Point(6, 9)
        Me.lblschestud.Name = "lblschestud"
        Me.lblschestud.Size = New System.Drawing.Size(275, 46)
        Me.lblschestud.TabIndex = 0
        Me.lblschestud.Text = "SCHEDULES"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Transparent
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(1160, 650)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(86, 40)
        Me.btnback.TabIndex = 1
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'dvgsearchStud
        '
        Me.dvgsearchStud.AllowUserToAddRows = False
        Me.dvgsearchStud.AllowUserToDeleteRows = False
        Me.dvgsearchStud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgsearchStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgsearchStud.Location = New System.Drawing.Point(38, 201)
        Me.dvgsearchStud.Name = "dvgsearchStud"
        Me.dvgsearchStud.ReadOnly = True
        Me.dvgsearchStud.RowHeadersWidth = 62
        Me.dvgsearchStud.RowTemplate.Height = 28
        Me.dvgsearchStud.Size = New System.Drawing.Size(861, 445)
        Me.dvgsearchStud.TabIndex = 2
        '
        'cboSearchStud
        '
        Me.cboSearchStud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSearchStud.FormattingEnabled = True
        Me.cboSearchStud.Location = New System.Drawing.Point(161, 158)
        Me.cboSearchStud.Name = "cboSearchStud"
        Me.cboSearchStud.Size = New System.Drawing.Size(33, 28)
        Me.cboSearchStud.TabIndex = 4
        '
        'txtsearchsched
        '
        Me.txtsearchsched.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsearchsched.BackColor = System.Drawing.Color.Transparent
        Me.txtsearchsched.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchsched.Location = New System.Drawing.Point(38, 152)
        Me.txtsearchsched.Name = "txtsearchsched"
        Me.txtsearchsched.Size = New System.Drawing.Size(107, 41)
        Me.txtsearchsched.TabIndex = 5
        Me.txtsearchsched.Text = "Search"
        Me.txtsearchsched.UseVisualStyleBackColor = False
        '
        'txtsearchRoomStud
        '
        Me.txtsearchRoomStud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsearchRoomStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchRoomStud.Location = New System.Drawing.Point(326, 158)
        Me.txtsearchRoomStud.Multiline = True
        Me.txtsearchRoomStud.Name = "txtsearchRoomStud"
        Me.txtsearchRoomStud.Size = New System.Drawing.Size(91, 28)
        Me.txtsearchRoomStud.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1011, 438)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 30)
        Me.TextBox2.TabIndex = 40
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(1011, 508)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(123, 30)
        Me.DateTimePicker2.TabIndex = 39
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"BUILDING 1", "BUILDING 2"})
        Me.ComboBox4.Location = New System.Drawing.Point(1009, 356)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(125, 33)
        Me.ComboBox4.TabIndex = 38
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"ELIDA", "YANGA", "MARCIANO", "ELEM"})
        Me.ComboBox3.Location = New System.Drawing.Point(1009, 264)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(125, 33)
        Me.ComboBox3.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1044, 480)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 25)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Date"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1004, 328)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Building Name"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1016, 410)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 25)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Room TIme "
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1006, 236)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 25)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Room Name"
        '
        'btnrequest
        '
        Me.btnrequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnrequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrequest.Location = New System.Drawing.Point(1021, 554)
        Me.btnrequest.Name = "btnrequest"
        Me.btnrequest.Size = New System.Drawing.Size(105, 40)
        Me.btnrequest.TabIndex = 32
        Me.btnrequest.Text = "Request"
        Me.btnrequest.UseVisualStyleBackColor = True
        '
        'ScheduleStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1258, 712)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnrequest)
        Me.Controls.Add(Me.txtsearchRoomStud)
        Me.Controls.Add(Me.txtsearchsched)
        Me.Controls.Add(Me.cboSearchStud)
        Me.Controls.Add(Me.dvgsearchStud)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lblschestud)
        Me.DoubleBuffered = True
        Me.Name = "ScheduleStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Student"
        CType(Me.dvgsearchStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblschestud As Label
    Friend WithEvents btnback As Button
    Friend WithEvents dvgsearchStud As DataGridView
    Friend WithEvents cboSearchStud As ComboBox
    Friend WithEvents txtsearchsched As Button
    Friend WithEvents txtsearchRoomStud As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnrequest As Button
End Class
