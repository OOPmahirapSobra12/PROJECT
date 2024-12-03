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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnrequestreload = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGVrequest = New System.Windows.Forms.DataGridView()
        Me.requestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timerequest_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timerequest_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requesttext = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DGVrequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel6.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.63386!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.61209!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75405!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(924, 526)
        Me.TableLayoutPanel1.TabIndex = 3
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(23, 456)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(878, 46)
        Me.TableLayoutPanel2.TabIndex = 2
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
        Me.btnadd.Size = New System.Drawing.Size(350, 40)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Aprove"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnback.Location = New System.Drawing.Point(715, 3)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(160, 40)
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
        Me.btndelete.Location = New System.Drawing.Point(359, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(350, 40)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete/Deny"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.87671!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(878, 65)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.61009!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnrequestreload, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(872, 59)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnrequestreload
        '
        Me.btnrequestreload.AutoSize = True
        Me.btnrequestreload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnrequestreload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrequestreload.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnrequestreload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrequestreload.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrequestreload.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnrequestreload.Location = New System.Drawing.Point(3, 3)
        Me.btnrequestreload.Name = "btnrequestreload"
        Me.btnrequestreload.Size = New System.Drawing.Size(866, 53)
        Me.btnrequestreload.TabIndex = 12
        Me.btnrequestreload.Text = "Requests"
        Me.btnrequestreload.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.DGVrequest, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(23, 94)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.29214!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.70786!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(878, 356)
        Me.TableLayoutPanel5.TabIndex = 5
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
        Me.DGVrequest.Location = New System.Drawing.Point(3, 61)
        Me.DGVrequest.Name = "DGVrequest"
        Me.DGVrequest.ReadOnly = True
        Me.DGVrequest.Size = New System.Drawing.Size(872, 292)
        Me.DGVrequest.TabIndex = 12
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
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.41711!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.58289!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.8877!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.1123!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnsearch, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtsearchbox, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cbosearch, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(872, 52)
        Me.TableLayoutPanel6.TabIndex = 11
        '
        'btnsearch
        '
        Me.btnsearch.AutoSize = True
        Me.btnsearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnsearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnsearch.Location = New System.Drawing.Point(724, 3)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(145, 46)
        Me.btnsearch.TabIndex = 0
        Me.btnsearch.Text = "btnsearch"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtsearchbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.txtsearchbox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtsearchbox.Location = New System.Drawing.Point(438, 3)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(280, 31)
        Me.txtsearchbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Box:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cbosearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cbosearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Choose:", "Request ID", "Request Type", "Requester", "Date Requested", "Time Requested", "Room Requested", "Time-In", "Time-Out", "Request Message"})
        Me.cbosearch.Location = New System.Drawing.Point(276, 3)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(156, 33)
        Me.cbosearch.TabIndex = 3
        '
        'requestapproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources._467460386_1064088022134846_6079649981189841706_n
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 526)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "requestapproval"
        Me.Text = "Request Approval"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.DGVrequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnadd As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnrequestreload As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DGVrequest As DataGridView
    Friend WithEvents requestID As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents requesterID As DataGridViewTextBoxColumn
    Friend WithEvents requestdate As DataGridViewTextBoxColumn
    Friend WithEvents requesttime As DataGridViewTextBoxColumn
    Friend WithEvents room As DataGridViewTextBoxColumn
    Friend WithEvents timerequest_in As DataGridViewTextBoxColumn
    Friend WithEvents timerequest_out As DataGridViewTextBoxColumn
    Friend WithEvents requesttext As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearchbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbosearch As ComboBox
End Class
