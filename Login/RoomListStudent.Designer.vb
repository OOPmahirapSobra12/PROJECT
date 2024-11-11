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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvRoomList = New System.Windows.Forms.DataGridView()
        Me.lblroomlist = New System.Windows.Forms.Label()
        Me.btnbackstud = New System.Windows.Forms.Button()
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(536, 91)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(120, 26)
        Me.txtsearch.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(432, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ROOM :"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboType.Location = New System.Drawing.Point(256, 91)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(147, 28)
        Me.cboType.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "BUILDING NAME :"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1255, 787)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 52)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvRoomList
        '
        Me.dgvRoomList.AllowUserToAddRows = False
        Me.dgvRoomList.AllowUserToDeleteRows = False
        Me.dgvRoomList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomList.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvRoomList.Location = New System.Drawing.Point(22, 129)
        Me.dgvRoomList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRoomList.Name = "dgvRoomList"
        Me.dgvRoomList.ReadOnly = True
        Me.dgvRoomList.RowHeadersWidth = 62
        Me.dgvRoomList.Size = New System.Drawing.Size(1243, 527)
        Me.dgvRoomList.TabIndex = 11
        '
        'lblroomlist
        '
        Me.lblroomlist.AutoSize = True
        Me.lblroomlist.BackColor = System.Drawing.Color.Transparent
        Me.lblroomlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroomlist.ForeColor = System.Drawing.Color.White
        Me.lblroomlist.Location = New System.Drawing.Point(12, 9)
        Me.lblroomlist.Name = "lblroomlist"
        Me.lblroomlist.Size = New System.Drawing.Size(247, 46)
        Me.lblroomlist.TabIndex = 21
        Me.lblroomlist.Text = "ROOM LIST"
        '
        'btnbackstud
        '
        Me.btnbackstud.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbackstud.BackColor = System.Drawing.Color.Transparent
        Me.btnbackstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbackstud.Location = New System.Drawing.Point(1163, 717)
        Me.btnbackstud.Name = "btnbackstud"
        Me.btnbackstud.Size = New System.Drawing.Size(103, 40)
        Me.btnbackstud.TabIndex = 32
        Me.btnbackstud.Text = "BACK"
        Me.btnbackstud.UseVisualStyleBackColor = False
        '
        'roomstud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1278, 769)
        Me.Controls.Add(Me.btnbackstud)
        Me.Controls.Add(Me.lblroomlist)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvRoomList)
        Me.Name = "roomstud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room List student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvRoomList As DataGridView
    Friend WithEvents lblroomlist As Label
    Friend WithEvents btnbackstud As Button
End Class
