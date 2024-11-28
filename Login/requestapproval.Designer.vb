<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class requestapproval
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.DGVrequest = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnrequestreload = New System.Windows.Forms.Button()
        Me.requestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timerequest_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timerequest_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesttext = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DGVrequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DGVrequest, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.7824!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.45966!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75795!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnadd, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnback, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btndelete, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 388)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(754, 38)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(591, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(160, 32)
        Me.btnback.TabIndex = 0
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btndelete.Location = New System.Drawing.Point(297, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(288, 32)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnadd.Location = New System.Drawing.Point(3, 3)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(288, 32)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add/Modify"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'DGVrequest
        '
        Me.DGVrequest.AllowUserToAddRows = False
        Me.DGVrequest.AllowUserToDeleteRows = False
        Me.DGVrequest.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVrequest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.requestID, Me.type, Me.requesterID, Me.requestdate, Me.requesttime, Me.room, Me.timerequest_in, Me.timerequest_out, Me.requesttext})
        Me.DGVrequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVrequest.GridColor = System.Drawing.Color.MidnightBlue
        Me.DGVrequest.Location = New System.Drawing.Point(23, 108)
        Me.DGVrequest.Name = "DGVrequest"
        Me.DGVrequest.ReadOnly = True
        Me.DGVrequest.Size = New System.Drawing.Size(754, 274)
        Me.DGVrequest.TabIndex = 8
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnrequestreload, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12329!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.87671!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(754, 79)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'btnrequestreload
        '
        Me.btnrequestreload.AutoSize = True
        Me.btnrequestreload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnrequestreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrequestreload.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnrequestreload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrequestreload.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrequestreload.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnrequestreload.Location = New System.Drawing.Point(3, 24)
        Me.btnrequestreload.Name = "btnrequestreload"
        Me.btnrequestreload.Size = New System.Drawing.Size(748, 52)
        Me.btnrequestreload.TabIndex = 11
        Me.btnrequestreload.Text = "Request Schedules"
        Me.btnrequestreload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnrequestreload.UseVisualStyleBackColor = False
        '
        'requestID
        '
        Me.requestID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.requestID.FillWeight = 20.30457!
        Me.requestID.HeaderText = "Request ID"
        Me.requestID.Name = "requestID"
        Me.requestID.ReadOnly = True
        '
        'type
        '
        Me.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.type.HeaderText = "Request Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'requesterID
        '
        Me.requesterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.requesterID.FillWeight = 20.30457!
        Me.requesterID.HeaderText = "Requester"
        Me.requesterID.Name = "requesterID"
        Me.requesterID.ReadOnly = True
        Me.requesterID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'requestdate
        '
        Me.requestdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.requestdate.FillWeight = 20.30457!
        Me.requestdate.HeaderText = "Date Requested"
        Me.requestdate.Name = "requestdate"
        Me.requestdate.ReadOnly = True
        '
        'requesttime
        '
        Me.requesttime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.requesttime.FillWeight = 20.30457!
        Me.requesttime.HeaderText = "Time"
        Me.requesttime.Name = "requesttime"
        Me.requesttime.ReadOnly = True
        '
        'room
        '
        Me.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.room.FillWeight = 20.30457!
        Me.room.HeaderText = "Room Requested"
        Me.room.Name = "room"
        Me.room.ReadOnly = True
        '
        'timerequest_in
        '
        Me.timerequest_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.timerequest_in.FillWeight = 20.30457!
        Me.timerequest_in.HeaderText = "Time-In"
        Me.timerequest_in.Name = "timerequest_in"
        Me.timerequest_in.ReadOnly = True
        '
        'timerequest_out
        '
        Me.timerequest_out.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.timerequest_out.FillWeight = 20.30457!
        Me.timerequest_out.HeaderText = "Time-Out"
        Me.timerequest_out.Name = "timerequest_out"
        Me.timerequest_out.ReadOnly = True
        '
        'requesttext
        '
        Me.requesttext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.requesttext.FillWeight = 657.868!
        Me.requesttext.HeaderText = "Request Message"
        Me.requesttext.MinimumWidth = 200
        Me.requesttext.Name = "requesttext"
        Me.requesttext.ReadOnly = True
        '
        'requestapproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "requestapproval"
        Me.Text = "requestapproval"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DGVrequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnback As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents DGVrequest As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnrequestreload As Button
    Friend WithEvents requestID As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents requesterID As DataGridViewTextBoxColumn
    Friend WithEvents requestdate As DataGridViewTextBoxColumn
    Friend WithEvents requesttime As DataGridViewTextBoxColumn
    Friend WithEvents room As DataGridViewTextBoxColumn
    Friend WithEvents timerequest_in As DataGridViewTextBoxColumn
    Friend WithEvents timerequest_out As DataGridViewTextBoxColumn
    Friend WithEvents requesttext As DataGridViewTextBoxColumn
End Class
