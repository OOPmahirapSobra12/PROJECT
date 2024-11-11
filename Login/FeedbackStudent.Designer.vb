<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedbackstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(feedbackstudent))
        Me.lblroomstud = New System.Windows.Forms.Label()
        Me.cbofeedbackstud = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblfeedbackstud = New System.Windows.Forms.Label()
        Me.txtfeedbackstud = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblroomstud
        '
        Me.lblroomstud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblroomstud.AutoSize = True
        Me.lblroomstud.BackColor = System.Drawing.Color.Transparent
        Me.lblroomstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroomstud.ForeColor = System.Drawing.Color.White
        Me.lblroomstud.Location = New System.Drawing.Point(294, 204)
        Me.lblroomstud.Name = "lblroomstud"
        Me.lblroomstud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblroomstud.Size = New System.Drawing.Size(103, 32)
        Me.lblroomstud.TabIndex = 0
        Me.lblroomstud.Text = "Room:"
        '
        'cbofeedbackstud
        '
        Me.cbofeedbackstud.BackColor = System.Drawing.Color.White
        Me.cbofeedbackstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofeedbackstud.FormattingEnabled = True
        Me.cbofeedbackstud.Items.AddRange(New Object() {"201", "202", "203", "204", "205"})
        Me.cbofeedbackstud.Location = New System.Drawing.Point(417, 204)
        Me.cbofeedbackstud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbofeedbackstud.Name = "cbofeedbackstud"
        Me.cbofeedbackstud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbofeedbackstud.Size = New System.Drawing.Size(149, 33)
        Me.cbofeedbackstud.TabIndex = 1
        Me.cbofeedbackstud.Text = "Select Room"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(165, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(232, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Feedback Type:"
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(14, 16)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 30)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Comment"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(142, 15)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 30)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Report"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(403, 250)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(257, 55)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblfeedbackstud
        '
        Me.lblfeedbackstud.AutoSize = True
        Me.lblfeedbackstud.BackColor = System.Drawing.Color.Transparent
        Me.lblfeedbackstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeedbackstud.ForeColor = System.Drawing.Color.White
        Me.lblfeedbackstud.Location = New System.Drawing.Point(202, 348)
        Me.lblfeedbackstud.Name = "lblfeedbackstud"
        Me.lblfeedbackstud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblfeedbackstud.Size = New System.Drawing.Size(148, 32)
        Me.lblfeedbackstud.TabIndex = 6
        Me.lblfeedbackstud.Text = "Feedback"
        '
        'txtfeedbackstud
        '
        Me.txtfeedbackstud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfeedbackstud.Location = New System.Drawing.Point(171, 391)
        Me.txtfeedbackstud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfeedbackstud.Multiline = True
        Me.txtfeedbackstud.Name = "txtfeedbackstud"
        Me.txtfeedbackstud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtfeedbackstud.Size = New System.Drawing.Size(807, 224)
        Me.txtfeedbackstud.TabIndex = 7
        '
        'btnclear
        '
        Me.btnclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(882, 403)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnclear.Size = New System.Drawing.Size(82, 40)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsubmit
        '
        Me.btnsubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(851, 631)
        Me.btnsubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnsubmit.Size = New System.Drawing.Size(113, 48)
        Me.btnsubmit.TabIndex = 9
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(734, 631)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnexit.Size = New System.Drawing.Size(111, 48)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 46)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "FEEDBACK"
        '
        'feedbackstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1221, 724)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtfeedbackstud)
        Me.Controls.Add(Me.lblfeedbackstud)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbofeedbackstud)
        Me.Controls.Add(Me.lblroomstud)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "feedbackstudent"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Feedback Form Student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblroomstud As Label
    Friend WithEvents cbofeedbackstud As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblfeedbackstud As Label
    Friend WithEvents txtfeedbackstud As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label2 As Label
End Class
