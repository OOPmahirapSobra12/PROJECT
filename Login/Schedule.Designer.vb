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
        Me.cboBuildingLetter = New System.Windows.Forms.ComboBox()
        Me.txtRoomTime = New System.Windows.Forms.TextBox()
        Me.cboRoomDay = New System.Windows.Forms.ComboBox()
        Me.dtpRoomDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRoomCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSchedID = New System.Windows.Forms.TextBox()
        Me.lblSchedID = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(372, 62)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 748)
        Me.DataGridView1.TabIndex = 0
        '
        'txtRoomName
        '
        Me.txtRoomName.Location = New System.Drawing.Point(142, 334)
        Me.txtRoomName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(148, 26)
        Me.txtRoomName.TabIndex = 1
        '
        'cboBuildingLetter
        '
        Me.cboBuildingLetter.FormattingEnabled = True
        Me.cboBuildingLetter.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboBuildingLetter.Location = New System.Drawing.Point(142, 517)
        Me.cboBuildingLetter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboBuildingLetter.Name = "cboBuildingLetter"
        Me.cboBuildingLetter.Size = New System.Drawing.Size(180, 28)
        Me.cboBuildingLetter.TabIndex = 2
        '
        'txtRoomTime
        '
        Me.txtRoomTime.Location = New System.Drawing.Point(142, 448)
        Me.txtRoomTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRoomTime.Name = "txtRoomTime"
        Me.txtRoomTime.Size = New System.Drawing.Size(148, 26)
        Me.txtRoomTime.TabIndex = 3
        '
        'cboRoomDay
        '
        Me.cboRoomDay.FormattingEnabled = True
        Me.cboRoomDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cboRoomDay.Location = New System.Drawing.Point(142, 611)
        Me.cboRoomDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRoomDay.Name = "cboRoomDay"
        Me.cboRoomDay.Size = New System.Drawing.Size(180, 28)
        Me.cboRoomDay.TabIndex = 4
        '
        'dtpRoomDate
        '
        Me.dtpRoomDate.Location = New System.Drawing.Point(8, 709)
        Me.dtpRoomDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpRoomDate.Name = "dtpRoomDate"
        Me.dtpRoomDate.Size = New System.Drawing.Size(298, 26)
        Me.dtpRoomDate.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(18, 118)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 35)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Shedule"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(18, 163)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(159, 35)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update Schedule"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(18, 208)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(159, 35)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete Schedule"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(18, 252)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(159, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear Schedule"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 338)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Room Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 448)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Room TIme : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 522)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Building Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 623)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Day :"
        '
        'txtRoomCode
        '
        Me.txtRoomCode.Location = New System.Drawing.Point(142, 392)
        Me.txtRoomCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRoomCode.Name = "txtRoomCode"
        Me.txtRoomCode.Size = New System.Drawing.Size(148, 26)
        Me.txtRoomCode.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 397)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Room Code : "
        '
        'txtSchedID
        '
        Me.txtSchedID.Location = New System.Drawing.Point(142, 565)
        Me.txtSchedID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSchedID.Name = "txtSchedID"
        Me.txtSchedID.Size = New System.Drawing.Size(180, 26)
        Me.txtSchedID.TabIndex = 16
        '
        'lblSchedID
        '
        Me.lblSchedID.AutoSize = True
        Me.lblSchedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedID.Location = New System.Drawing.Point(3, 575)
        Me.lblSchedID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchedID.Name = "lblSchedID"
        Me.lblSchedID.Size = New System.Drawing.Size(92, 20)
        Me.lblSchedID.TabIndex = 17
        Me.lblSchedID.Text = "Sched ID:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(8, 755)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 35)
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
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1382, 57)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SCHEDULE MANAGEMENT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1382, 809)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSchedID)
        Me.Controls.Add(Me.txtSchedID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRoomCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpRoomDate)
        Me.Controls.Add(Me.cboRoomDay)
        Me.Controls.Add(Me.txtRoomTime)
        Me.Controls.Add(Me.cboBuildingLetter)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtRoomName As TextBox
    Friend WithEvents cboBuildingLetter As ComboBox
    Friend WithEvents txtRoomTime As TextBox
    Friend WithEvents cboRoomDay As ComboBox
    Friend WithEvents dtpRoomDate As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRoomCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSchedID As TextBox
    Friend WithEvents lblSchedID As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class
