<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtRoomName = New System.Windows.Forms.TextBox()
        Me.cmbBuildingLetter = New System.Windows.Forms.ComboBox()
        Me.cmbRoomDay = New System.Windows.Forms.ComboBox()
        Me.dtpRoomDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRoomCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShedID = New System.Windows.Forms.TextBox()
        Me.lblSchedID = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpRoomTimeIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpRoomTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(661, 486)
        Me.DataGridView1.TabIndex = 0
        '
        'txtRoomName
        '
        Me.txtRoomName.Location = New System.Drawing.Point(100, 156)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomName.TabIndex = 1
        '
        'cmbBuildingLetter
        '
        Me.cmbBuildingLetter.FormattingEnabled = True
        Me.cmbBuildingLetter.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmbBuildingLetter.Location = New System.Drawing.Point(100, 227)
        Me.cmbBuildingLetter.Name = "cmbBuildingLetter"
        Me.cmbBuildingLetter.Size = New System.Drawing.Size(121, 21)
        Me.cmbBuildingLetter.TabIndex = 2
        '
        'cmbRoomDay
        '
        Me.cmbRoomDay.FormattingEnabled = True
        Me.cmbRoomDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cmbRoomDay.Location = New System.Drawing.Point(100, 289)
        Me.cmbRoomDay.Name = "cmbRoomDay"
        Me.cmbRoomDay.Size = New System.Drawing.Size(121, 21)
        Me.cmbRoomDay.TabIndex = 4
        '
        'dtpRoomDate
        '
        Me.dtpRoomDate.Location = New System.Drawing.Point(5, 465)
        Me.dtpRoomDate.Name = "dtpRoomDate"
        Me.dtpRoomDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpRoomDate.TabIndex = 5
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSchedule.Location = New System.Drawing.Point(12, 51)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(106, 23)
        Me.btnAddSchedule.TabIndex = 6
        Me.btnAddSchedule.Text = "Add Shedule"
        Me.btnAddSchedule.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(12, 80)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 23)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update Schedule"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(12, 109)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete Schedule"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Room Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Building Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Day :"
        '
        'txtRoomCode
        '
        Me.txtRoomCode.Location = New System.Drawing.Point(100, 191)
        Me.txtRoomCode.Name = "txtRoomCode"
        Me.txtRoomCode.Size = New System.Drawing.Size(100, 20)
        Me.txtRoomCode.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Room Code : "
        '
        'txtShedID
        '
        Me.txtShedID.Location = New System.Drawing.Point(100, 257)
        Me.txtShedID.Name = "txtShedID"
        Me.txtShedID.Size = New System.Drawing.Size(121, 20)
        Me.txtShedID.TabIndex = 16
        '
        'lblSchedID
        '
        Me.lblSchedID.AutoSize = True
        Me.lblSchedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedID.Location = New System.Drawing.Point(6, 257)
        Me.lblSchedID.Name = "lblSchedID"
        Me.lblSchedID.Size = New System.Drawing.Size(64, 13)
        Me.lblSchedID.TabIndex = 17
        Me.lblSchedID.Text = "Sched ID:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(5, 491)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.Login.My.Resources.Resources.image_removebg_preview2
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(921, 37)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SCHEDULE MANAGEMENT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 437)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Select Room Date:"
        '
        'dtpRoomTimeIn
        '
        Me.dtpRoomTimeIn.CustomFormat = "hh:mm tt"
        Me.dtpRoomTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRoomTimeIn.Location = New System.Drawing.Point(5, 344)
        Me.dtpRoomTimeIn.Name = "dtpRoomTimeIn"
        Me.dtpRoomTimeIn.ShowUpDown = True
        Me.dtpRoomTimeIn.Size = New System.Drawing.Size(200, 20)
        Me.dtpRoomTimeIn.TabIndex = 21
        '
        'dtpRoomTimeOut
        '
        Me.dtpRoomTimeOut.CustomFormat = "hh:mm tt"
        Me.dtpRoomTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRoomTimeOut.Location = New System.Drawing.Point(5, 401)
        Me.dtpRoomTimeOut.Name = "dtpRoomTimeOut"
        Me.dtpRoomTimeOut.ShowUpDown = True
        Me.dtpRoomTimeOut.Size = New System.Drawing.Size(200, 20)
        Me.dtpRoomTimeOut.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Room Time IN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Room Time OUT"
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(921, 526)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpRoomTimeOut)
        Me.Controls.Add(Me.dtpRoomTimeIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSchedID)
        Me.Controls.Add(Me.txtShedID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRoomCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddSchedule)
        Me.Controls.Add(Me.dtpRoomDate)
        Me.Controls.Add(Me.cmbRoomDay)
        Me.Controls.Add(Me.cmbBuildingLetter)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtRoomName As TextBox
    Friend WithEvents cmbBuildingLetter As ComboBox
    Friend WithEvents cmbRoomDay As ComboBox
    Friend WithEvents dtpRoomDate As DateTimePicker
    Friend WithEvents btnAddSchedule As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRoomCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtShedID As TextBox
    Friend WithEvents lblSchedID As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpRoomTimeIn As DateTimePicker
    Friend WithEvents dtpRoomTimeOut As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
