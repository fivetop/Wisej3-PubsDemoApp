Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared






<Serializable>
Public Class ShowReportRequest

    Public GUID As String
    Public UserName As String
    Public ServerName As String
    Public DataBaseName As String
    Public Password As String
    Public AuthenticationMode As Integer
    Public ReportFileName As String
    Public ReportTitle As String
    Public ReportDescription As String
    Public RecordSelectionFormula As String
    Public ViewerWidth As Integer
    Public ViewerHeight As Integer


End Class

Public Class CrystalReportHelper
    Public UserName As String
    Public ServerName As String
    Public DataBaseName As String
    Public Password As String
    Public AuthenticationMode As Integer
    Public RecordSelectionFormula As String
    Public CrystalReportViewerPage As String
    Public Caller As Wisej.Web.Form
    Public ReportViewer As CrystalDecisions.Web.CrystalReportViewer
    Public ReportsPath As String

    Public Sub New()

    End Sub

    Public Sub RequestShowReport(ByVal Report As QBEReport)

        Dim ShowReportRequest = New ShowReportRequest
        ShowReportRequest.UserName = Me.UserName
        ShowReportRequest.ServerName = Me.ServerName
        ShowReportRequest.DataBaseName = Me.DataBaseName
        ShowReportRequest.Password = Me.Password
        ShowReportRequest.ReportFileName = Report.ReportFileName
        ShowReportRequest.ReportTitle = Report.ReportTitle
        ShowReportRequest.ReportDescription = Report.ReportDescription
        ShowReportRequest.AuthenticationMode = Me.AuthenticationMode
        ShowReportRequest.RecordSelectionFormula = Me.RecordSelectionFormula

        Application.Session.ShowReportRequest = ShowReportRequest



    End Sub


    Public Sub ShowReport(ByVal FileReport As String)

        Dim objReport As New ReportDocument
        Dim ReportFile As String = Application.StartupPath & ReportsPath & FileReport
        'Dim dbConfig As New BasicDAL.DbConfig
        Dim Where As String = ""
        Dim RecordSelectionFormula As String = ""

        'dbConfig = Me.DbObject.DbConfig


        If System.IO.File.Exists(ReportFile) = False Then
            Wisej.Web.MessageBox.Show("Errore nel report: " & FileReport & vbCrLf & "Il file " & ReportFile & " non esiste!", Wisej.Web.MessageBoxIcon.Error, Caller.Text)
            Return
        End If
        Try
            objReport.Load(ReportFile)
        Catch ex As Exception

            Wisej.Web.MessageBox.Show("Errore nel report: " & FileReport & vbCrLf & "Errore: " & ex.Message, Wisej.Web.MessageBoxIcon.Error, Caller.Text)
            Return
        End Try

        Dim connectionInfo As New ConnectionInfo()

        connectionInfo.DatabaseName = Me.DataBaseName
        connectionInfo.ServerName = Me.ServerName
        If Me.AuthenticationMode = 1 Then
            connectionInfo.IntegratedSecurity = True
        Else
            connectionInfo.IntegratedSecurity = False
            connectionInfo.UserID = Me.UserName
            connectionInfo.Password = Me.Password
            'objReport.SetDatabaseLogon(dbConfig.UserName, dbConfig.Password)
        End If

        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim CrTables As Tables = objReport.Database.Tables

        ' First we assign the connection to all tables in the main report
        For Each CrTable As Table In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = connectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next CrTable


        ' Now loop through all the sections and its objects to do the same for the subreports
        '
        For Each section As Section In objReport.ReportDefinition.Sections
            ' In each section we need to loop through all the reporting objects
            For Each reportObject As ReportObject In section.ReportObjects
                If reportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim subReport As SubreportObject = CType(reportObject, SubreportObject)
                    Dim subDocument As ReportDocument = subReport.OpenSubreport(subReport.SubreportName)

                    Dim xcrtableLogoninfos As New TableLogOnInfos()
                    Dim xcrtableLogoninfo As New TableLogOnInfo()
                    Dim xCrTables As Tables = objReport.Database.Tables

                    ' First we assign the connection to all tables in the main report
                    For Each xCrTable As Table In CrTables
                        xcrtableLogoninfo = xCrTable.LogOnInfo
                        xcrtableLogoninfo.ConnectionInfo = connectionInfo
                        xCrTable.ApplyLogOnInfo(crtableLogoninfo)
                    Next xCrTable


                End If
            Next reportObject
        Next section

        Try
            RecordSelectionFormula = Me.RecordSelectionFormula


            If objReport.RecordSelectionFormula <> "" Then
                RecordSelectionFormula = RecordSelectionFormula & " AND " & objReport.RecordSelectionFormula
            End If

            Me.ReportViewer.ReportSource = objReport
            Me.ReportViewer.SelectionFormula = RecordSelectionFormula




        Catch ex As Exception

            Wisej.Web.MessageBox.Show("Errore durante caricamento stampa." & vbCrLf & ex.Message, Wisej.Web.MessageBoxIcon.Error, Caller.Text)
            Exit Sub
        End Try




    End Sub

    Public Sub ShowReport(ByVal FileReport As String, ByVal DataTable As DataTable)

        Dim objReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim ReportFile As String = Application.StartupPath & ReportsPath & FileReport
        'Dim dbConfig As New BasicDAL.DbConfig
        Dim Where As String = ""
        Dim RecordSelectionFormula As String = ""

        'dbConfig = Me.DbObject.DbConfig
        objReport.Load(ReportFile)
        Dim connectionInfo As New ConnectionInfo()
        connectionInfo.DatabaseName = Me.DataBaseName
        connectionInfo.ServerName = Me.ServerName
        If Me.AuthenticationMode = 1 Then
            connectionInfo.IntegratedSecurity = True
        Else
            connectionInfo.UserID = Me.UserName
            connectionInfo.Password = Me.Password
            'objReport.SetDatabaseLogon(dbConfig.UserName, dbConfig.Password)
        End If

        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim CrTables As Tables = objReport.Database.Tables

        ' First we assign the connection to all tables in the main report
        For Each CrTable As CrystalDecisions.CrystalReports.Engine.Table In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = connectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next CrTable


        ' Now loop through all the sections and its objects to do the same for the subreports
        '
        For Each section As CrystalDecisions.CrystalReports.Engine.Section In objReport.ReportDefinition.Sections
            ' In each section we need to loop through all the reporting objects
            For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                If reportObject.Kind = ReportObjectKind.SubreportObject Then
                    Dim subReport As SubreportObject = CType(reportObject, SubreportObject)
                    Dim subDocument As ReportDocument = subReport.OpenSubreport(subReport.SubreportName)

                    Dim xcrtableLogoninfos As New TableLogOnInfos()
                    Dim xcrtableLogoninfo As New TableLogOnInfo()
                    Dim xCrTables As Tables = objReport.Database.Tables

                    ' First we assign the connection to all tables in the main report
                    For Each xCrTable As CrystalDecisions.CrystalReports.Engine.Table In CrTables
                        xcrtableLogoninfo = xCrTable.LogOnInfo
                        xcrtableLogoninfo.ConnectionInfo = connectionInfo
                        xCrTable.ApplyLogOnInfo(crtableLogoninfo)
                    Next xCrTable


                End If
            Next reportObject
        Next section

        Try

            RecordSelectionFormula = Me.RecordSelectionFormula
            If objReport.RecordSelectionFormula = "" Then
                objReport.RecordSelectionFormula = RecordSelectionFormula ' GetCrystalRecordSelectionFormula()
            Else
                If RecordSelectionFormula <> "" Then
                    objReport.RecordSelectionFormula = RecordSelectionFormula & " AND " & objReport.RecordSelectionFormula
                End If
            End If



            Me.ReportViewer.ReportSource = objReport
            Me.ReportViewer.SelectionFormula = objReport.RecordSelectionFormula


        Catch ex As Exception

            Wisej.Web.MessageBox.Show("Errore durante caricamento stampa." & vbCrLf & ex.Message, Wisej.Web.MessageBoxIcon.Error, Caller.Text)
            Exit Sub
        End Try




    End Sub


    Private Sub AssignTableConnection(ByVal table As CrystalDecisions.CrystalReports.Engine.Table, ByVal connection As ConnectionInfo)
        ' Cache the logon info block
        Dim logOnInfo As TableLogOnInfo = table.LogOnInfo

        ' Set the connection

        logOnInfo.ConnectionInfo = connection

        ' Apply the connection to the table!
        table.ApplyLogOnInfo(logOnInfo)
    End Sub





End Class
