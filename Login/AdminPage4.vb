Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class AdminPage4
    Dim choice As String
    Private Sub Admin_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        DbConnect()
        choice = Nothing
    End Sub

    Private Sub buttonback_Click(sender As Object, e As EventArgs) Handles buttonback.Click
        choice = Nothing
        AdminPage3.Show()
        Me.Hide()
    End Sub

    Private Sub crystalbtnroomlist_Click(sender As Object, e As EventArgs) Handles crystalbtnroomlist.Click
        choice = Nothing
        crystalreportviewer.Show()
        'get the crystal report
        crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.Roomlistreport1
    End Sub

    Private Sub crystalbtnaccountlist_Click(sender As Object, e As EventArgs) Handles crystalbtnaccountlist.Click
        choice = Nothing
        btnoption1.Text = "Admin List"
        btnoption2.Text = "Staff List"
        btnoption3.Text = "Student List"
        btnoption1.Visible = True
        btnoption2.Visible = True
        btnoption3.Visible = True
        choice = "accounts"
    End Sub

    Private Sub btnoption1_Click(sender As Object, e As EventArgs) Handles btnoption1.Click
        If choice = "accounts" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.AdminListReport1
        ElseIf choice = "requests" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.CurrentRequests1
        ElseIf choice = "schedules" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.ScheduleListReport1
        ElseIf choice = "login" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.roomloginhistory1
        ElseIf choice = "feedbackreport" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.feedbackshistory1
        ElseIf choice = "coursesectionsubject" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.CourseSectionReport1
        End If
    End Sub

    Private Sub btnoption3_Click(sender As Object, e As EventArgs) Handles btnoption3.Click
        If choice = "accounts" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.StaffListReport1
        ElseIf choice = "requests" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.AcceptedRequestReport1
        ElseIf choice = "login" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.System_LogsReport1
        End If
    End Sub

    Private Sub btnoption2_Click(sender As Object, e As EventArgs) Handles btnoption2.Click
        If choice = "accounts" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.StudentListReport1
        ElseIf choice = "schedules" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.tempScheduleListReport1
        ElseIf choice = "requests" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.DeniedRequestForm1
        ElseIf choice = "login" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.StaffAccessingAdminlogs1
        ElseIf choice = "feedbackreport" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.reportshistory1
        ElseIf choice = "coursesectionsubject" Then
            crystalreportviewer.Show()
            crystalreportviewer.CrystalReportViewer1.ReportSource = crystalreportviewer.subjectlist1
        End If
    End Sub

    Private Sub crystalbtnrequestlogs_Click(sender As Object, e As EventArgs) Handles crystalbtnrequestlogs.Click
        choice = Nothing
        btnoption1.Text = "Current Requests"
        btnoption2.Text = "Accepted Requests"
        btnoption3.Text = "Denied Requests"
        btnoption1.Visible = True
        btnoption2.Visible = True
        btnoption3.Visible = True
        choice = "requests"
    End Sub

    Private Sub crystalbtnschedulelogs_Click(sender As Object, e As EventArgs) Handles crystalbtnschedulelogs.Click
        choice = Nothing
        btnoption1.Text = "Normal Schedules"
        btnoption2.Text = "Temporary Schedules"
        btnoption1.Visible = True
        btnoption2.Visible = True
        choice = "schedules"
    End Sub

    Private Sub crystalbtnlogin_Click(sender As Object, e As EventArgs) Handles crystalbtnlogin.Click
        choice = Nothing
        btnoption1.Text = "Room Logs"
        btnoption2.Text = "System Logs"
        btnoption3.Text = "Staff Special Logs"
        btnoption1.Visible = True
        btnoption2.Visible = True
        btnoption3.Visible = True
        choice = "login"
    End Sub

    Private Sub crystalbtnfeedbackreport_Click(sender As Object, e As EventArgs) Handles crystalbtnfeedbackreport.Click
        choice = Nothing
        btnoption1.Text = "Feedback History"
        btnoption2.Text = "Report History"
        btnoption1.Visible = True
        btnoption2.Visible = True
        choice = "feedbackreport"
    End Sub

    Private Sub crystalbtncoursesectionsubject_Click(sender As Object, e As EventArgs) Handles crystalbtncoursesectionsubject.Click
        choice = Nothing
        btnoption1.Text = "Course and Section List"
        btnoption2.Text = "Subject List"
        btnoption1.Visible = True
        btnoption2.Visible = True
        choice = "coursesectionsubject"
    End Sub
End Class