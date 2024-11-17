<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnfeedbackstud = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnroomlist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncreate
        '
        Me.btncreate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncreate.AutoSize = True
        Me.btncreate.BackColor = System.Drawing.Color.Transparent
        Me.btncreate.BackgroundImage = CType(resources.GetObject("btncreate.BackgroundImage"), System.Drawing.Image)
        Me.btncreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.SystemColors.Control
        Me.btncreate.Location = New System.Drawing.Point(65, 258)
        Me.btncreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(420, 230)
        Me.btncreate.TabIndex = 21
        Me.btncreate.Text = " Schedule"
        Me.btncreate.UseVisualStyleBackColor = False
        '
        'btnfeedbackstud
        '
        Me.btnfeedbackstud.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnfeedbackstud.BackColor = System.Drawing.Color.Transparent
        Me.btnfeedbackstud.BackgroundImage = CType(resources.GetObject("btnfeedbackstud.BackgroundImage"), System.Drawing.Image)
        Me.btnfeedbackstud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfeedbackstud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfeedbackstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeedbackstud.ForeColor = System.Drawing.SystemColors.Control
        Me.btnfeedbackstud.Location = New System.Drawing.Point(65, 500)
        Me.btnfeedbackstud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnfeedbackstud.Name = "btnfeedbackstud"
        Me.btnfeedbackstud.Size = New System.Drawing.Size(420, 236)
        Me.btnfeedbackstud.TabIndex = 23
        Me.btnfeedbackstud.Text = "Feedbacks"
        Me.btnfeedbackstud.UseVisualStyleBackColor = False
        '
        'btnsignout
        '
        Me.btnsignout.AutoSize = True
        Me.btnsignout.BackColor = System.Drawing.Color.Transparent
        Me.btnsignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignout.ForeColor = System.Drawing.SystemColors.Control
        Me.btnsignout.Location = New System.Drawing.Point(1232, 716)
        Me.btnsignout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsignout.Name = "btnsignout"
        Me.btnsignout.Size = New System.Drawing.Size(108, 37)
        Me.btnsignout.TabIndex = 24
        Me.btnsignout.Text = "Sign-Out"
        Me.btnsignout.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Button4.Location = New System.Drawing.Point(1, 1)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 52)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = ":"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnroomlist
        '
        Me.btnroomlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnroomlist.AutoSize = True
        Me.btnroomlist.BackColor = System.Drawing.Color.Transparent
        Me.btnroomlist.BackgroundImage = CType(resources.GetObject("btnroomlist.BackgroundImage"), System.Drawing.Image)
        Me.btnroomlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnroomlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnroomlist.ForeColor = System.Drawing.SystemColors.Control
        Me.btnroomlist.Location = New System.Drawing.Point(65, 30)
        Me.btnroomlist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnroomlist.Name = "btnroomlist"
        Me.btnroomlist.Size = New System.Drawing.Size(420, 214)
        Me.btnroomlist.TabIndex = 26
        Me.btnroomlist.Text = "Room List"
        Me.btnroomlist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(706, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 60)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "WELCOME DYCIAN!"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.Login.My.Resources.Resources.FB_IMG_1729211691620
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 768)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnroomlist)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsignout)
        Me.Controls.Add(Me.btnfeedbackstud)
        Me.Controls.Add(Me.btncreate)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncreate As Button
    Friend WithEvents btnfeedbackstud As Button
    Friend WithEvents btnsignout As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnroomlist As Button
    Friend WithEvents Label1 As Label
End Class
