<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomListForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomListForm))
        Me.dgvRoomList = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdateRoomStatus = New System.Windows.Forms.Button()
        Me.cmbRoomStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoomList
        '
        Me.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomList.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRoomList.Location = New System.Drawing.Point(0, 65)
        Me.dgvRoomList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRoomList.Name = "dgvRoomList"
        Me.dgvRoomList.RowHeadersWidth = 62
        Me.dgvRoomList.Size = New System.Drawing.Size(1200, 568)
        Me.dgvRoomList.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(399, 638)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 35)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Location = New System.Drawing.Point(1022, 642)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 35)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnUpdateRoomStatus
        '
        Me.btnUpdateRoomStatus.Location = New System.Drawing.Point(33, 638)
        Me.btnUpdateRoomStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdateRoomStatus.Name = "btnUpdateRoomStatus"
        Me.btnUpdateRoomStatus.Size = New System.Drawing.Size(128, 35)
        Me.btnUpdateRoomStatus.TabIndex = 4
        Me.btnUpdateRoomStatus.Text = "Update Status"
        Me.btnUpdateRoomStatus.UseVisualStyleBackColor = True
        '
        'cmbRoomStatus
        '
        Me.cmbRoomStatus.FormattingEnabled = True
        Me.cmbRoomStatus.Items.AddRange(New Object() {"Occupied", "Not Occupied", "Closed"})
        Me.cmbRoomStatus.Location = New System.Drawing.Point(186, 642)
        Me.cmbRoomStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbRoomStatus.Name = "cmbRoomStatus"
        Me.cmbRoomStatus.Size = New System.Drawing.Size(180, 28)
        Me.cmbRoomStatus.TabIndex = 5
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
        Me.Label1.Size = New System.Drawing.Size(1200, 60)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ROOM LIST"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(375, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BUILDING NAME :"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboType.Location = New System.Drawing.Point(568, 18)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(204, 28)
        Me.cboType.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(783, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ROOM :"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(890, 17)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(265, 26)
        Me.txtsearch.TabIndex = 10
        '
        'RoomListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1200, 692)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RoomListForm"
        Me.Text = "RoomListForm"
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRoomList As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdateRoomStatus As Button
    Friend WithEvents cmbRoomStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearch As TextBox
End Class
