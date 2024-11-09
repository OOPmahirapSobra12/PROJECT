<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roomstud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(roomstud))
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRoomStatus = New System.Windows.Forms.ComboBox()
        Me.btnUpdateRoomStatus = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvRoomList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(890, 48)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(265, 26)
        Me.txtsearch.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(783, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ROOM :"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboType.Location = New System.Drawing.Point(568, 49)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(204, 28)
        Me.cboType.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(375, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "BUILDING NAME :"
        '
        'cmbRoomStatus
        '
        Me.cmbRoomStatus.FormattingEnabled = True
        Me.cmbRoomStatus.Items.AddRange(New Object() {"Occupied", "Not Occupied", "Closed"})
        Me.cmbRoomStatus.Location = New System.Drawing.Point(186, 673)
        Me.cmbRoomStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbRoomStatus.Name = "cmbRoomStatus"
        Me.cmbRoomStatus.Size = New System.Drawing.Size(180, 28)
        Me.cmbRoomStatus.TabIndex = 15
        '
        'btnUpdateRoomStatus
        '
        Me.btnUpdateRoomStatus.Location = New System.Drawing.Point(33, 669)
        Me.btnUpdateRoomStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateRoomStatus.Name = "btnUpdateRoomStatus"
        Me.btnUpdateRoomStatus.Size = New System.Drawing.Size(128, 35)
        Me.btnUpdateRoomStatus.TabIndex = 14
        Me.btnUpdateRoomStatus.Text = "Update Status"
        Me.btnUpdateRoomStatus.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Location = New System.Drawing.Point(1022, 673)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 35)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(399, 669)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 35)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvRoomList
        '
        Me.dgvRoomList.AllowUserToAddRows = False
        Me.dgvRoomList.AllowUserToDeleteRows = False
        Me.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomList.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRoomList.Location = New System.Drawing.Point(0, 98)
        Me.dgvRoomList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRoomList.Name = "dgvRoomList"
        Me.dgvRoomList.ReadOnly = True
        Me.dgvRoomList.RowHeadersWidth = 62
        Me.dgvRoomList.Size = New System.Drawing.Size(1200, 566)
        Me.dgvRoomList.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1203, 60)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ROOM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'roomstud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.ClientSize = New System.Drawing.Size(1203, 739)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRoomStatus)
        Me.Controls.Add(Me.btnUpdateRoomStatus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvRoomList)
        Me.Name = "roomstud"
        Me.Text = "Room List student"
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbRoomStatus As ComboBox
    Friend WithEvents btnUpdateRoomStatus As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvRoomList As DataGridView
End Class
