Imports System
Imports Wisej.Web
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Win32.SafeHandles

Public Class QBEForm


    Private mDbObject As New BasicDAL.DbObject
    Private mQueryDbObject As BasicDAL.DbObject
    Private mResultsDBObject As BasicDAL.DbObject
    Private mResultsDataTable As System.Data.DataTable
    Private mQBEColumns As New QBEColumns
    Private mMode As QbeMode = QbeMode.Query
    Private mReportViewerMode As ReportViewerMode = ReportViewerMode.PDFStream
    Private mResultMode As QBEResultMode
    Private mDbColumnsMapping As New DbColumnsMapping
    Private mBoundControls As New QBEBoundControls
    Private mAutoLoadAll As Boolean = False
    Private mReportViewerMDIParent As Form
    Private mReports As Dictionary(Of String, QBEReport) = New Dictionary(Of String, QBEReport)
    Private mAfterCloseFocus As Control
    Private mTopRecords As Integer = 500
    Private mCallerForm As Form
    Private mReportCopies As Integer = 1
    Private mDefaultReport As QBEReport = Nothing
    Private mPrintDefaultReport As Boolean = False
    Private mReportsPath As String = Application.StartupPath + "reports"
    Private mReportsPDFUrlPath As String = "\Reports\"
    Private mReportFileName As String = ""
    Private mReportName As String = ""
    Private mUseExactSearchForString As Boolean = False


    Public DoNotAllowQBEFilterChange As Boolean = False
    Public PreserveDbFilters As Boolean = False
    Public AllowQBEUserColumnsSetCreation As Boolean = False
    Public FormWidth As Integer = 800
    Public FormHeight As Integer = 600
    Public ResultGridRowHeight = 20
    Public QueryGridRowHeight = 20
    Public ReportGridRowHeight = 20
    Public CrystalReportViewerQueryStringParameter As String = "ID"
    Public CrystalReportViewerPage As String = "BasicDALWisejCRViewer.aspx"
    Public CrystalReportViewerURL As String = CrystalReportViewerPage
    Public SessionStoreMode As CXMLSession.SessionStore.StoreModes = CXMLSession.SessionStore.StoreModes.FileSystem
    Public SessionStoreFileSystemStorePath As String = System.IO.Path.GetTempPath()
    Public BoundDataGridView As DataGridView = Nothing

    Private mReportSession As String = ""
    Private mReportsTempDir As String = ""
    Private mReportsLastPDFViewerFileName As String = ""
    Private SessionStore As New CXMLSession.SessionStore()

    Public Event QBEForm_ResultReturned(ByRef ResultDbObject As BasicDAL.DbObject)
    Public Event QBEForm_Closed()
    Public Event QBEForm_ReportShowRequest(ByVal ReportName As String, ByRef Cancel As Boolean)
    Public Event QBEForm_ReportShowed(ByVal ReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument)
    Dim oFiltersGroup As New BasicDAL.DbFiltersGroup




    Property TabQueryFiltersText() As String
        Get
            Return TabControl.TabPages(0).Text
        End Get
        Set(ByVal value As String)
            '_TabQueryFiltersCaption = value
            TabControl.TabPages(0).Text = value
        End Set
    End Property
    Property TabExportText() As String
        Get
            Return TabControl.TabPages(1).Text
        End Get
        Set(ByVal value As String)
            '_TabQueryFiltersCaption = value
            TabControl.TabPages(1).Text = value
        End Set
    End Property
    Property TabReportsText() As String
        Get
            Return TabControl.TabPages(2).Text
        End Get
        Set(ByVal value As String)

            TabControl.TabPages(2).Text = value
        End Set
    End Property
    Property TabDebugText() As String
        Get
            Return TabControl.TabPages(3).Text
        End Get
        Set(ByVal value As String)
            TabControl.TabPages(3).Text = value
        End Set
    End Property
    Property ButtonExportDataText() As String
        Get
            Return btnEsporta.Text
        End Get
        Set(ByVal value As String)
            btnEsporta.Text = value
        End Set
    End Property


    Property QueryGridFilterColumnHeaderText() As String
        Get
            Return dgvcNomeCampo.HeaderText
        End Get
        Set(ByVal value As String)
            dgvcNomeCampo.HeaderText = value
        End Set
    End Property


    Property QueryGridFilterValueHeaderText() As String
        Get
            Return dgvcValoreCampo.HeaderText
        End Get
        Set(ByVal value As String)
            dgvcValoreCampo.HeaderText = value
        End Set
    End Property




    Property UseExactSearchForString() As Boolean
        Get
            Return Me.mUseExactSearchForString
        End Get
        Set(ByVal value As Boolean)
            Me.mUseExactSearchForString = value
        End Set
    End Property

    Property QueryGridView() As DataGridView
        Get
            QueryGridView = Me.QueryGrid
        End Get
        Set(ByVal value As DataGridView)
            Me.QueryGrid = value
        End Set
    End Property

    Property ResultGridView() As DataGridView
        Get
            ResultGridView = Me.ResultGrid
        End Get
        Set(ByVal value As DataGridView)
            Me.ResultGrid = value
        End Set
    End Property
    Property ReportGridView() As DataGridView
        Get
            ReportGridView = Me.ReportGrid
        End Get
        Set(ByVal value As DataGridView)
            Me.ReportGrid = value
        End Set
    End Property

    Property QueryGridColumNameHeaderText() As String
        Get
            QueryGridColumNameHeaderText = Me.QueryGrid.Columns(0).HeaderText
        End Get
        Set(ByVal value As String)
            Me.QueryGrid.Columns(0).HeaderText = value
        End Set
    End Property

    Property QueryGridValueHeaderText() As String
        Get
            QueryGridValueHeaderText = Me.QueryGrid.Columns(1).HeaderText
        End Get
        Set(ByVal value As String)
            Me.QueryGrid.Columns(1).HeaderText = value
        End Set
    End Property
    Property ReportGridReportNameHeaderText() As String
        Get
            ReportGridReportNameHeaderText = Me.ReportGrid.Columns(0).HeaderText
        End Get
        Set(ByVal value As String)
            Me.ReportGrid.Columns(0).HeaderText = value
        End Set
    End Property
    Property ReportGridReportDescriptionHeaderText() As String
        Get
            ReportGridReportDescriptionHeaderText = Me.ReportGrid.Columns(1).HeaderText
        End Get
        Set(ByVal value As String)
            Me.ReportGrid.Columns(1).HeaderText = value
        End Set
    End Property
    Property ReportGridReportFileNameHeaderText() As String
        Get
            ReportGridReportFileNameHeaderText = Me.ReportGrid.Columns(2).HeaderText
        End Get
        Set(ByVal value As String)
            Me.ReportGrid.Columns(2).HeaderText = value
        End Set
    End Property
    Property SearchTabText() As String
        Get
            SearchTabText = Me.TabControl.TabPages(0).Text
        End Get
        Set(ByVal value As String)
            Me.TabControl.TabPages(0).Text = value
        End Set
    End Property

    Property ReportTabText() As String
        Get
            ReportTabText = Me.TabControl.TabPages(1).Text
        End Get
        Set(ByVal value As String)
            Me.TabControl.TabPages(1).Text = value
        End Set

    End Property
    Property MoveFirstCaption() As String
        Get
            MoveFirstCaption = bFirst.Text
        End Get
        Set(ByVal value As String)
            '_MoveFirstCaption = value
            bFirst.Text = value
        End Set

    End Property
    Property MoveFirstToolTipText() As String
        Get
            MoveFirstToolTipText = bFirst.ToolTipText
        End Get
        Set(ByVal value As String)

            bFirst.ToolTipText = value
        End Set
    End Property

    Property MoveLastCaption() As String
        Get
            MoveLastCaption = bLast.Text
        End Get
        Set(ByVal value As String)
            ' _MoveLastCaption = value
            bLast.Text = value
        End Set
    End Property
    Property MoveLastToolTipText() As String
        Get
            MoveLastToolTipText = bLast.ToolTipText
        End Get
        Set(ByVal value As String)
            bLast.ToolTipText = value
        End Set
    End Property

    Property MovePreviousCaption() As String
        Get
            MovePreviousCaption = bPrev.Text
        End Get
        Set(ByVal value As String)
            '_MovePreviousCaption = value
            bPrev.Text = value
        End Set
    End Property
    Property MovePreviousToolTipText() As String
        Get
            MovePreviousToolTipText = bPrev.ToolTipText
        End Get
        Set(ByVal value As String)
            bPrev.ToolTipText = value
        End Set
    End Property

    Property MoveNextCaption() As String
        Get
            MoveNextCaption = bNext.Text
        End Get
        Set(ByVal value As String)
            '_MoveNextCaption = value
            bNext.Text = value
        End Set
    End Property
    Property MoveNextToolTipText() As String
        Get
            MoveNextToolTipText = bNext.ToolTipText
        End Get
        Set(ByVal value As String)
            bNext.ToolTipText = value
        End Set
    End Property


    Property RefreshCaption() As String
        Get
            RefreshCaption = bRefresh.Text
        End Get
        Set(ByVal value As String)
            '_RefreshCaption = value
            bRefresh.Text = value
        End Set
    End Property
    Property RefreshToolTipText() As String
        Get
            RefreshToolTipText = bRefresh.ToolTipText
        End Get
        Set(ByVal value As String)
            bRefresh.ToolTipText = value
        End Set
    End Property

    Property DeleteFiltersCaption() As String
        Get
            DeleteFiltersCaption = bDelete.Text
        End Get
        Set(ByVal value As String)
            '_DeleteFiltersCaption = value
            bDelete.Text = value
        End Set
    End Property
    Property DeleteFiltersToolTipText() As String
        Get
            DeleteFiltersToolTipText = bDelete.ToolTipText
        End Get
        Set(ByVal value As String)
            bDelete.ToolTipText = value
        End Set
    End Property

    Property PrintCaption() As String
        Get
            PrintCaption = bPrint.Text
        End Get
        Set(ByVal value As String)
            '_PrintCaption = value
            bPrint.Text = value
        End Set
    End Property
    Property PrintToolTipText() As String
        Get
            PrintToolTipText = bPrint.ToolTipText
        End Get
        Set(ByVal value As String)
            bPrint.ToolTipText = value
        End Set
    End Property

    Property SelectCaption() As String
        Get
            SelectCaption = bSave.Text
        End Get
        Set(ByVal value As String)
            '_SelectCaption = value
            bSave.Text = value
        End Set
    End Property
    Property SelectToolTipText() As String
        Get
            SelectToolTipText = bSave.ToolTipText
        End Get
        Set(ByVal value As String)
            bSave.ToolTipText = value
        End Set
    End Property

    Property CloseCaption() As String
        Get
            CloseCaption = bClose.Text
        End Get
        Set(ByVal value As String)
            '_CloseCaption = value
            bClose.Text = value
        End Set
    End Property
    Property CloseToolTipText() As String
        Get
            CloseToolTipText = bClose.ToolTipText
        End Get
        Set(ByVal value As String)
            bClose.ToolTipText = value
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As Windows.Forms.CreateParams
        Get
            Dim cp As Windows.Forms.CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Property ReportsPath() As String

        Get
            ReportsPath = mReportsPath
        End Get
        Set(value As String)
            mReportsPath = value
        End Set
    End Property

    Property ReportsPDFUrlPath() As String
        Get
            ReportsPDFUrlPath = mReportsPDFUrlPath
        End Get
        Set(value As String)
            mReportsPDFUrlPath = value
        End Set
    End Property

    Property PrintDefaultReport() As Boolean
        Get
            PrintDefaultReport = mPrintDefaultReport
        End Get
        Set(ByVal value As Boolean)
            mPrintDefaultReport = value
        End Set

    End Property

    Property DefaultReport() As QBEReport
        Get
            DefaultReport = mDefaultReport
        End Get
        Set(ByVal value As QBEReport)
            mDefaultReport = value
        End Set

    End Property


    Property ReportCopies() As Integer
        Get
            ReportCopies = mReportCopies
        End Get
        Set(ByVal value As Integer)
            mReportCopies = value
        End Set

    End Property
    Property CallerForm() As Form
        Get
            CallerForm = mCallerForm
        End Get
        Set(ByVal value As Form)
            mCallerForm = value
        End Set
    End Property
    Property TopRecords() As Integer
        Get
            TopRecords = mTopRecords
        End Get
        Set(ByVal value As Integer)
            mTopRecords = value
        End Set
    End Property
    Property AfterCloseFocus() As Control
        Get
            AfterCloseFocus = mAfterCloseFocus
        End Get
        Set(ByVal value As Control)
            mAfterCloseFocus = value
        End Set
    End Property
    'Property Reports() As QBEReports
    '    Get
    '        Reports = mReports
    '    End Get
    '    Set(ByVal value As QBEReports)
    '        mReports = value
    '    End Set
    'End Property

    Property Reports() As Dictionary(Of String, QBEReport)
        Get
            Reports = mReports
        End Get
        Set(ByVal value As Dictionary(Of String, QBEReport))
            mReports = value
        End Set
    End Property

    Property ReportViewerMode() As ReportViewerMode
        Get
            ReportViewerMode = mReportViewerMode
        End Get
        Set(ByVal value As ReportViewerMode)
            mReportViewerMode = value
        End Set
    End Property


    Property ReportViewerMDIParent() As Form
        Get
            ReportViewerMDIParent = mReportViewerMDIParent
        End Get
        Set(ByVal value As Form)
            mReportViewerMDIParent = value
        End Set
    End Property


    Property QBEColumns() As QBEColumns
        Get
            QBEColumns = mQBEColumns
        End Get
        Set(ByVal value As QBEColumns)
            mQBEColumns = value
        End Set
    End Property
    Property AutoLoadAll() As Boolean
        Get
            AutoLoadAll = mAutoLoadAll
        End Get
        Set(ByVal value As Boolean)
            mAutoLoadAll = value
        End Set
    End Property
    Property BoundControls() As QBEBoundControls
        Get
            BoundControls = mBoundControls

        End Get
        Set(ByVal value As QBEBoundControls)
            mBoundControls = value
        End Set
    End Property

    Property DbColumnsMapping() As DbColumnsMapping
        Get
            DbColumnsMapping = mDbColumnsMapping
        End Get
        Set(ByVal value As DbColumnsMapping)

        End Set
    End Property

    Property ResultMode() As QBEResultMode
        Get
            ResultMode = mResultMode
        End Get
        Set(ByVal value As QBEResultMode)
            mResultMode = value

        End Set
    End Property

    Property ResultsDbObject() As BasicDAL.DbObject
        Get
            ResultsDbObject = mResultsDBObject

        End Get
        Set(ByVal value As BasicDAL.DbObject)
            mResultsDBObject = value

        End Set
    End Property

    Property ResultsDataTable() As System.Data.DataTable
        Get
            ResultsDataTable = mResultsDataTable

        End Get
        Set(ByVal value As System.Data.DataTable)
            mResultsDataTable = value

        End Set
    End Property


    Property QueryDbObject() As BasicDAL.DbObject
        Get
            QueryDbObject = mQueryDbObject

        End Get
        Set(ByVal value As BasicDAL.DbObject)
            mQueryDbObject = value

        End Set
    End Property
    Property Title() As String
        Get
            Title = Me.Text

        End Get
        Set(ByVal value As String)
            Me.Text = value

        End Set
    End Property


    Property Mode() As QbeMode
        Get
            Mode = mMode
        End Get
        Set(ByVal value As QbeMode)
            mMode = value
        End Set
    End Property

    Property DbObject() As BasicDAL.DbObject
        Get
            DbObject = mDbObject
        End Get
        Set(ByVal value As BasicDAL.DbObject)
            mDbObject = value
        End Set
    End Property



    Private Function CalcolaSplitterDistance() As Double

        Me.SplitContainer1.SplitterDistance = Me.SplitContainer1.Height * 30 / 100

        'If Me.QueryGrid.Rows.Count <= 8 Then
        '    Me.SplitContainer1.SplitterDistance = Me.SplitContainer1.Height - (Me.TabControl.Height + ((Me.QueryGrid.Rows.Count + 1) * Me.QueryGridRowHeight) + Me.QueryGrid.ColumnHeadersHeight)
        'End If


    End Function

    Public Function AddQBEFormReportsFromFile(ByVal ReportsFile As String) As Boolean

        Dim OK As Boolean = False
        Dim QBEFormReports As New List(Of QBEFormReport)

        If System.IO.File.Exists(ReportsFile) Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ReportsFile)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(";")
                Dim currentRow As String()
                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        If (currentRow.Length = 3) Then

                            Dim QBEFormReport = New QBEFormReport
                            QBEFormReport.ReportTitle = currentRow(0)
                            QBEFormReport.ReportDescription = currentRow(1)
                            QBEFormReport.ReportFileName = currentRow(2)
                            If System.IO.Path.IsPathRooted(QBEFormReport.ReportFileName) = True Then
                                If System.IO.File.Exists(QBEFormReport.ReportFileName) Then
                                    If QBEFormReports.Contains(QBEFormReport) = False Then
                                        QBEFormReports.Add(QBEFormReport)
                                    End If
                                End If
                            Else
                                If QBEFormReports.Contains(QBEFormReport) = False Then
                                    QBEFormReports.Add(QBEFormReport)
                                End If
                            End If
                        End If
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        'MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                    End Try
                End While
            End Using
        End If

        If QBEFormReports.Count = 0 Then
            Return False
        Else

            For Each QBEFormReport As QBEFormReport In QBEFormReports
                Me.AddReport(QBEFormReport.ReportTitle, QBEFormReport.ReportFileName, QBEFormReport.ReportDescription)
            Next
            Return True
        End If

    End Function


    Public Function AddReport(ByVal ReportTitle As String, ByVal ReportFileName As String, ByVal ReportDescription As String) As QBEReport
        Dim x As New QBEReport
        With x
            .ReportDescription = ReportDescription
            .ReportFileName = ReportFileName
            .ReportTitle = ReportTitle
        End With

        If (Me.mReports.ContainsKey(ReportTitle) = False) Then
            Me.mReports.Add(ReportTitle, x)
            Return (x)
        Else
            Return Nothing
        End If

    End Function

    Public Sub ShowQBE(Optional ByVal CallerForm As Form = Nothing)

        Dim x As Integer = 0
        If CallerForm IsNot Nothing Then
            Me.mCallerForm = CallerForm
            Me.mCallerForm.Enabled = False
        End If

        If Me.mCallerForm IsNot Nothing Then
            If Me.mCallerForm.MdiParent IsNot Nothing Then
                Me.MdiParent = Me.mCallerForm.MdiParent
            End If
        End If

        Me.SetTopLevel(True)

        If Me.mMode = QbeMode.Query Then
            Me.TabPageDebug.Hidden = True
            Me.TabPageEsporta.Hidden = False
            Me.TabPageStampe.Hidden = True
            Me.PanelEsporta.Dock = DockStyle.Fill
        End If


        If Me.mMode = QbeMode.Report Then
            Me.TabPageStampe.Hidden = False
            Me.TabPageDebug.Hidden = False
            Me.TabPageEsporta.Hidden = True
            If Me.mReportViewerMode <> ReportViewerMode.WEB Then
                Me.txtDebug.Dock = DockStyle.Fill
            Else

            End If

            If Me.mReports.Count = 0 Then
                Dim _text = ""
                If Me.mCallerForm IsNot Nothing Then
                    _text = Me.mCallerForm.Text
                End If
                MessageBox.Show("Non ci sono Reports associati!", _text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.mCallerForm.Enabled = True
                Return
            End If
        End If


        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ResultGrid.AutoGenerateColumns = False
        Me.ResultGrid.RowTemplate.Height = ResultGridRowHeight
        Me.QueryGrid.RowTemplate.Height = QueryGridRowHeight
        Me.ReportGrid.RowTemplate.Height = ReportGridRowHeight
        Me.ResultGrid.DefaultRowHeight = ResultGridRowHeight
        Me.QueryGrid.DefaultRowHeight = QueryGridRowHeight
        Me.ReportGrid.DefaultRowHeight = ReportGridRowHeight




        Me.bSaveQBE.Visible = AllowQBEUserColumnsSetCreation
        Me.bLoadQBE.Visible = AllowQBEUserColumnsSetCreation

        Me.LoadParameters()

        Me.Records.Text = Me.mTopRecords.ToString

        If Me.QueryGrid.Rows.Count <= 8 Then
            Me.SplitContainer1.SplitterDistance = Me.SplitContainer1.Height - (Me.TabControl.Height + ((Me.QueryGrid.Rows.Count + 1) * Me.QueryGridRowHeight) + Me.QueryGrid.ColumnHeadersHeight)
        End If

        ' ----------------------------------------------
        If Me.mMode = QbeMode.Report Then
            Me.Records.Visible = False
            Me.RecordLabel.Visible = False

        End If

        If Me.Mode = QbeMode.Query Then

            oFiltersGroup = mDbObject.FiltersGroup
            If Me.mDbObject.OrderBy = "" Then
                Me.mDbObject.OrderBy = Me.OrderByRules
            End If
            Me.BuildQuery3()
            If Me.mAutoLoadAll = True Then
                mDbObject.LoadAll()
                Me.ResultGrid.DataSource = Me.mDbObject.GetDataTable
            End If
        End If



        If Me.Mode = QbeMode.Report Then

            'Me.mReportSession = System.IO.Path.GetRandomFileName()
            Me.mReportSession = System.Guid.NewGuid.ToString()


            Select Case Me.ReportViewerMode
                Case ReportViewerMode.WEB
                    Me.WebBrowser.Dock = DockStyle.Fill
                    Me.AspNetPanel.Dock = DockStyle.Fill
                Case ReportViewerMode.PDFStream, ReportViewerMode.PDFUrl
                    Me.PdfViewer.Dock = DockStyle.Fill
                Case Else
            End Select


            oFiltersGroup = mDbObject.FiltersGroup
            If Me.mDbObject.OrderBy = "" Then
                Me.mDbObject.OrderBy = Me.OrderByRules
            End If

            Me.BuildQuery3()
            mDbObject.LoadAll()

            If Me.DefaultReport Is Nothing Then
                Me.DefaultReport = Me.Reports.FirstOrDefault().Value
            End If


            Dim i As Integer
            For i = 0 To Me.ReportGrid.RowCount - 1
                If UCase(Me.ReportGrid.Rows(i).Cells(0).Value) = UCase(Me.DefaultReport.ReportFileName) Then
                    mReportFileName = Me.ReportGrid.Rows(i).Cells(2).Value
                    mReportName = Me.ReportGrid.Rows(i).Cells(0).Value
                    Exit For
                End If
            Next

            If Me.mPrintDefaultReport = True Then
                If mReportFileName <> "" Then
                    Select Case Me.ReportViewerMode
                        Case ReportViewerMode.WEB
                            Me.ShowReportWEB(Me.Reports(mReportName))
                        Case ReportViewerMode.PDFStream, ReportViewerMode.PDFUrl
                            Me.ShowReportPDF(Me.Reports(mReportName))
                        Case Else
                    End Select
                End If
            End If

        End If

        Me.Visible = True

        Me.Select()




    End Sub

    Private Sub PrintReport(ByVal Print As Boolean)


        If Me.ReportGrid.CurrentRow Is Nothing Then
            Return
        End If

        Dim ReportFileName As String = mReportFileName
        Dim ReportName As String = mReportName

        Dim Cancel As Boolean = False


        If Me.ReportGrid.CurrentRow Is Nothing And Me.DefaultReport.ReportFileName = "" Then Exit Sub

        If Me.ReportGrid.CurrentRow IsNot Nothing Then
            ReportFileName = Me.ReportGrid.CurrentRow.Tag
            ReportName = Me.ReportGrid.CurrentRow.Cells(0).Value
        End If


        If ReportFileName.Trim <> "" Then

            RaiseEvent QBEForm_ReportShowRequest(ReportFileName, Cancel)
            If Cancel = False Then
                Select Case ReportViewerMode
                    Case ReportViewerMode.PDFUrl, ReportViewerMode.PDFStream
                        ShowReportPDF(Me.Reports(ReportName))
                    Case ReportViewerMode.WEB
                        ShowReportWEB(Me.Reports(ReportName))
                End Select

                If Print = True Then
                    'Me.PdfViewer.Select()
                    'Me.PdfViewer.Focus()

                End If
            End If

        End If


    End Sub
    Public Sub ShowReportWEB(ByVal Report As QBEReport)

        Dim ShowReportRequest = New ShowReportRequest
        Dim URL As String = ""
        Dim GUID As String = System.Guid.NewGuid.ToString()

        Dim TipoSessione = "SESS"
        'Me.WebBrowser.Dock = DockStyle.Fill
        'Me.WebBrowser .Height = Me.SplitContainer1.Panel1.Height

        Me.AspNetPanel.Dock = DockStyle.Fill
        Me.AspNetPanel.Height = Me.SplitContainer1.Panel1.Height

        With ShowReportRequest
            .GUID = GUID
            .ReportFileName = ReportsPath & "\" & Report.ReportFileName
            .ServerName = Me.DbObject.DbConfig.ServerName
            .DataBaseName = Me.DbObject.DbConfig.DataBaseName
            .UserName = Me.DbObject.DbConfig.UserName
            .Password = Me.DbObject.DbConfig.Password
            .RecordSelectionFormula = Me.GetCrystalRecordSelectionFormula()
            .AuthenticationMode = Me.DbObject.DbConfig.AuthenticationMode
            .ViewerHeight = Me.AspNetPanel.Height
            '.ViewerHeight = Me.WebBrowser.Height
        End With

        Select Case TipoSessione

            Case "CXML"
                Me.SessionStore.StoreMode = SessionStoreMode
                Me.SessionStore.StoreMode = CXMLSession.SessionStore.StoreModes.MemoryMappedFile
                Me.SessionStore.FileSystemStorePath = SessionStoreFileSystemStorePath
                Me.SessionStore.ID = GUID
                Me.SessionStore.Namespace = "BasicDALWisejCRViewer"
                Me.SessionStore.AddObject(Of ShowReportRequest)("ShowReportRequest", ShowReportRequest)
                Me.SessionStore.Write()
                URL = Me.CrystalReportViewerURL & "?" & Me.CrystalReportViewerQueryStringParameter & "=CXML_" & GUID

            Case "SESS"
                URL = Me.CrystalReportViewerURL & "?" & Me.CrystalReportViewerQueryStringParameter & "=SESS_" & GUID
                Wisej.Web.Application.Session(GUID) = ShowReportRequest

        End Select

        'Me.WebBrowser.Url = New Uri(URL)
        'Me.WebBrowser .Visible =true
        Me.AspNetPanel.Url = URL
        Me.AspNetPanel.Visible = True

    End Sub


    Public Shared Function SerializeObjectToString(Of T)(ByVal toSerialize As T) As String
        Dim xmlSerializer As New Xml.Serialization.XmlSerializer(toSerialize.GetType())
        Using textWriter As New IO.StringWriter()
            xmlSerializer.Serialize(textWriter, toSerialize)
            Return textWriter.ToString()
        End Using
    End Function

    Public Shared Function DeSerializeStringToObject(Of T)(ByVal toDeserialize As String) As String
        Dim xmlSerializer As New Xml.Serialization.XmlSerializer(toDeserialize.GetType())
        Using textWriter As New IO.StringWriter()
            Dim reader = New IO.StreamReader(toDeserialize)
            xmlSerializer.Deserialize(reader)
            Return textWriter.ToString()
        End Using
    End Function



    'Public Sub ShowReportPDF(ByVal ReportName As String, ByVal FileReportName As String)
    Public Sub ShowReportPDF(ByVal Report As QBEReport)


        Dim _ReportsPath As String = ""
        Dim objReport As New ReportDocument
        Dim ReportFileName As String = "" ' Application.StartupPath & ReportsPath & Report.ReportFileName
        Dim ReportMsg = ""
        Dim ErrMsg2 = ""
        Dim Where As String = ""
        Dim RecordSelectionFormula As String = ""
        Dim Debug As System.Text.StringBuilder = New System.Text.StringBuilder

        Me.txtDebug.Dock = DockStyle.Fill

        If System.IO.Path.IsPathRooted(Me.ReportsPath) = True Then
            _ReportsPath = Me.ReportsPath
        Else
            _ReportsPath = Application.StartupPath & Me.ReportsPath
        End If

        ' controllare per Report.Filename PATHROOTED

        If (System.IO.Directory.Exists(_ReportsPath)) Then
            ReportFileName = _ReportsPath & "\" & Report.ReportFileName
        Else
            ReportMsg = "Report: " & Report.ReportTitle & vbCrLf + "ReportFile: " & Report.ReportFileName & vbCrLf
            Wisej.Web.MessageBox.Show(ReportMsg & ". Il percorso dei Reports non esiste!", Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Return
        End If

        Debug.AppendLine("ReporViewertMode: " & Me.ReportViewerMode.ToString)
        Debug.AppendLine("Report: " & Report.ReportTitle)
        Debug.AppendLine("ReportFile: " & ReportFileName)

        ReportMsg = "Report: " & Report.ReportTitle & vbCrLf + "ReportFile: " & ReportFileName & vbCrLf

        If System.IO.File.Exists(ReportFileName) = False Then
            Wisej.Web.MessageBox.Show(ReportMsg & ". Il file non esiste!", Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Return
        End If

        Try
            objReport.Load(ReportFileName)
        Catch ex As Exception
            Wisej.Web.MessageBox.Show(ReportMsg & vbCrLf & "Errore durante in caricamento: " & ex.Message, Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Return
        End Try


        'Wisej.Web.MessageBox.Show(ReportMsg & ". ConnectionInfo", Me.Text)
        Dim connectionInfo As New ConnectionInfo()
        connectionInfo.DatabaseName = Me.DbObject.DbConfig.DataBaseName
        connectionInfo.ServerName = Me.DbObject.DbConfig.ServerName

        'Wisej.Web.MessageBox.Show(ReportMsg & ". Authetication", Me.Text)
        If Me.DbObject.DbConfig.AuthenticationMode = 1 Then
            connectionInfo.IntegratedSecurity = True
        Else
            connectionInfo.IntegratedSecurity = False
            connectionInfo.UserID = Me.DbObject.DbConfig.UserName
            connectionInfo.Password = Me.DbObject.DbConfig.Password
            'objReport.SetDatabaseLogon(dbConfig.UserName, dbConfig.Password)
        End If

        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim CrTables As Tables = objReport.Database.Tables

        'Wisej.Web.MessageBox.Show(ReportMsg & ". Authentication CrTables", Me.Text)

        ' First we assign the connection to all tables in the main report
        Try
            For Each CrTable As Table In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = connectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next CrTable
        Catch ex As Exception
            Wisej.Web.MessageBox.Show(ReportMsg & vbCrLf & "Errore durante impostazione della connessione DB: " & ex.Message, Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Return
        End Try



        ' Now loop through all the sections and its objects to do the same for the subreports
        '
        'Wisej.Web.MessageBox.Show(ReportMsg & ". Authentication Subreports", Me.Text)
        Try
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
        Catch ex As Exception
            Wisej.Web.MessageBox.Show(ReportMsg & vbCrLf & "Errore durante impostazione della connessione DB per i sottoreports: " & ex.Message, Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Return
        End Try


        Try
            ErrMsg2 = "GetCrystalRecordSelectionFormula"
            RecordSelectionFormula = Me.GetCrystalRecordSelectionFormula
            If objReport.RecordSelectionFormula <> "" Then
                RecordSelectionFormula = RecordSelectionFormula & " And " & objReport.RecordSelectionFormula
            End If
            ErrMsg2 = "Set RecordSelectionFormula"
            objReport.RecordSelectionFormula = RecordSelectionFormula
            ErrMsg2 = " objReport.Refresh()"
            objReport.SummaryInfo.ReportTitle = Report.ReportTitle
            objReport.SummaryInfo.ReportSubject = Report.ReportDescription
            objReport.Refresh()


            Select Case Me.mReportViewerMode

                Case ReportViewerMode.PDFUrl


                    ErrMsg2 = "objReport.ExportToDisk()"
                    Dim ReportsPDFUrlPath = Me.mReportsPDFUrlPath
                    Dim LocalReportTempDir As String = Application.MapPath(ReportsPDFUrlPath)
                    LocalReportTempDir = LocalReportTempDir.Replace("/", "\")
                    Debug.AppendLine("ReportsSitePath = " & ReportsPDFUrlPath)
                    Debug.AppendLine("LocalReportTempDir = " & LocalReportTempDir)

                    Dim PDFViewerFileName = LocalReportTempDir & "\" & BasicDAL.Utilities.GetSafeFileName(Report.ReportTitle & ".pdf")
                    PDFViewerFileName = BasicDAL.Utilities.GetUniqueFileName(PDFViewerFileName)
                    objReport.ExportToDisk(ExportFormatType.PortableDocFormat, PDFViewerFileName)
                    If System.IO.File.Exists(mReportsLastPDFViewerFileName) Then
                        System.IO.File.Delete(mReportsLastPDFViewerFileName)
                    End If
                    Me.mReportsLastPDFViewerFileName = PDFViewerFileName
                    Dim PDFViewerFileNameURL = BasicDAL.Utilities.GetURLWithoutFileName(Application.Url) & ReportsPDFUrlPath & "/" & Web.HttpUtility.HtmlEncode(BasicDAL.Utilities.GetFileName(PDFViewerFileName))
                    Debug.AppendLine("PDFViewerFileNameURL = " & PDFViewerFileNameURL)

                    Me.PdfViewer.PdfSource = PDFViewerFileNameURL
                    Me.mReportsTempDir = LocalReportTempDir
                    'Me.PdfViewer.Visible = True


                Case ReportViewerMode.PDFStream

                    'Dim ExportOptions As New ExportOptions
                    'Dim PDFFormatOptions As PdfFormatOptions = ExportOptions.CreatePdfFormatOptions()

                    ErrMsg2 = "objReport.ExportToStream()"
                    Me.PdfViewer.PdfStream = objReport.ExportToStream(ExportFormatType.PortableDocFormat)
                    Debug.AppendLine("PDFViewer.PdfStream.Lenght = " & Me.PdfViewer.PdfStream.Length)

                    Me.PdfViewer.Visible = True
                Case Else
                    Return
            End Select
            Me.txtDebug.Text = Debug.ToString()


        Catch ex As Exception
            Wisej.Web.MessageBox.Show(ReportMsg & vbCrLf & ErrMsg2 & vbCrLf & "Errore Report durante caricamento dati." & ex.Message & vbCrLf & ex.StackTrace, Me.Text, Wisej.Web.MessageBoxIcon.Error)
            Exit Sub
        End Try




    End Sub



    Private Function OrderByRules() As String

        Dim OrderBy As String = ""

        'For Each Col As DataGridViewColumn In Me.ResultGrid.Columns
        '    If Col.DataPropertyName <> "" Then
        '        OrderBy = OrderBy & Col.DataPropertyName & ", "
        '    End If
        'Next

        For Each Col As QBEColumn In Me.QBEColumns
            If Col.DisplayInQBEResult And Col.DbCOlumn.IsSortable() = True Then
                OrderBy = OrderBy & Col.DbCOlumn.DbColumnName & ", "
            End If
        Next

        OrderBy = OrderBy.Trim()

        If OrderBy <> "" Then
            OrderBy = Mid(OrderBy, 1, OrderBy.Length - 1)
        End If

        Return OrderBy

    End Function

    Public Sub LoadParameters()

        Dim DbColumn As BasicDAL.DbColumn
        Dim DbColumns As New BasicDAL.DbColumns
        Dim QBEReport As QBEReport

        Dim i As Integer = 0
        Dim x As Integer = 0
        Dim RowCount As Integer = 100
        Dim charw As Integer = 0
        Dim cellw As Integer = 0

        If Me.Icon Is Nothing Then
            Me.Icon = Me.CallerForm.Icon
        End If

        Me.TabControl.Dock = DockStyle.Top
        Me.ReportGrid.Visible = False
        Me.ResultGrid.Columns.Clear()
        Me.QueryGrid.Rows.Clear()

        Select Case Me.mMode
            Case Is = QbeMode.Report
                Me.bPrint.Visible = True

                Select Case Me.ReportViewerMode
                    Case ReportViewerMode.PDFStream, ReportViewerMode.PDFUrl
                        Me.PdfViewer.Dock = DockStyle.Fill
                        Me.PdfViewer.Visible = True
                    Case Else
                        Me.WebBrowser.Dock = DockStyle.Fill
                        Me.WebBrowser.Visible = True
                End Select

                Me.ResultGrid.Visible = False
                Me.bSave.Visible = False

            Case Else

                Me.TabPageCriteriRicerca.Visible = True
                Me.bPrint.Visible = False
                Me.ResultGrid.Visible = True
                Me.ResultGrid.Dock = DockStyle.Fill
                Me.PdfViewer.Visible = False
        End Select

        RowCount = Me.mQBEColumns.Count

        If Me.ResultMode = QBEResultMode.SingleRow Then
            Me.ResultGrid.MultiSelect = False
        Else
            Me.ResultGrid.MultiSelect = True
        End If


        Me.QueryGrid.Columns(Me.dgvcNomeCampo.Name).ReadOnly = True
        Me.QueryGrid.Columns(Me.dgvcNomeCampo.Name).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.QueryGrid.Columns(Me.dgvcValoreCampo.Name).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.QueryGrid.Columns(Me.dgvcQueryCampo.Name).Visible = False


        ' controllo per verifica collection QBEColumns
        If Me.mQBEColumns.Count = 0 Then
            Me.mQBEColumns.Clear()
            DbColumns = Me.mDbObject.GetDbColumns
            For Each DbColumn In DbColumns
                Me.mQBEColumns.Add(DbColumn, DbColumn.FriendlyName, DbColumn.DisplayFormat, DbColumn.QBEValue, DbColumn.UseInQBE, DbColumn.DisplayInQBEResult)
            Next
        End If


        Dim QueryColumnWidth As Double = 0

        For Each _QBEColumn As QBEColumn In Me.mQBEColumns

            If Me.mMode = QbeMode.Query Then

                If IsNothing(_QBEColumn.DbCOlumn) = True Then
                    _QBEColumn.UseInQBE = False

                    Select Case _QBEColumn.QBEColumnType

                        Case Is = DbType.Boolean

                            Dim ncol As New DataGridViewCheckBoxColumn
                            ncol.Name = System.Guid.NewGuid().ToString
                            ncol.HeaderText = _QBEColumn.FriendlyName
                            x = Me.ResultGrid.Columns.Add(ncol)

                        Case Else

                            Dim ncol As New DataGridViewTextBoxColumn
                            ncol.Name = System.Guid.NewGuid().ToString
                            ncol.HeaderText = _QBEColumn.FriendlyName
                            x = Me.ResultGrid.Columns.Add(ncol)

                    End Select
                Else
                    ' modifica per tipo colonne diverse in QBEResult
                    Select Case _QBEColumn.DbCOlumn.DbType
                        Case Is = DbType.Boolean
                            Dim ncol As New DataGridViewCheckBoxColumn
                            ncol.Name = _QBEColumn.DbCOlumn.DbColumnName
                            'ncol.HeaderText = _QBEColumn.DbCOlumn.FriendlyName
                            ncol.HeaderText = _QBEColumn.FriendlyName

                            x = Me.ResultGrid.Columns.Add(ncol)

                        Case Else

                            Dim ncol As New DataGridViewTextBoxColumn
                            ncol.Name = _QBEColumn.DbCOlumn.DbColumnName
                            'ncol.HeaderText = _QBEColumn.DbCOlumn.FriendlyName
                            ncol.HeaderText = _QBEColumn.FriendlyName
                            x = Me.ResultGrid.Columns.Add(ncol)
                    End Select


                    Me.ResultGrid.Columns(x).Visible = False

                    If Me.DbObject.DbObjectType = BasicDAL.DbObjectTypeEnum.Join Then
                        Me.ResultGrid.Columns(x).DataPropertyName = _QBEColumn.DbCOlumn.DbColumnNameAlias
                    Else
                        Me.ResultGrid.Columns(x).DataPropertyName = _QBEColumn.DbCOlumn.DbColumnNameE
                    End If

                    If _QBEColumn.DisplayInQBEResult = True Then

                        With Me.ResultGrid.Columns(x)
                            ' modifica per export
                            .Tag = _QBEColumn.DbCOlumn.Name
                            ' ------
                            .Visible = True
                            charw = 8
                            Select Case _QBEColumn.DbCOlumn.DbType
                                Case Is = DbType.Byte, DbType.Currency, DbType.Date, DbType.DateTime, DbType.Decimal, DbType.Double _
                                , DbType.Int16, DbType.Int32, DbType.Int64, DbType.SByte, DbType.Single, DbType.Time, DbType.UInt16, DbType.UInt32, DbType.UInt64, DbType.VarNumeric
                                    .Width = charw * 10
                                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                                Case = DbType.Binary
                                    If _QBEColumn.ColumnWidth = 0 Then
                                        .Visible = False
                                    Else
                                        .Width = _QBEColumn.ColumnWidth
                                        .AutoSizeMode = DataGridViewAutoSizeColumnsMode.None
                                    End If
                                Case Else
                                    If _QBEColumn.ColumnWidth = 0 Then
                                        If _QBEColumn.DbCOlumn.Size < 30 Then
                                            cellw = charw * _QBEColumn.DbCOlumn.Size
                                        Else
                                            cellw = charw * 30
                                        End If

                                        If cellw < (ResultGrid.Columns(x).HeaderText.Length * charw) Then
                                            cellw = ResultGrid.Columns(x).HeaderText.Length * charw
                                        End If
                                        .Width = cellw
                                    Else
                                        .Width = _QBEColumn.ColumnWidth
                                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                                    End If

                                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


                            End Select

                            '.HeaderText = QBEColumn.FriendlyName
                            '.DataPropertyName = QBEColumn.DbCOlumn.DbColumnNameE
                            With .DefaultCellStyle
                                .Format = _QBEColumn.DisplayFormat

                                If _QBEColumn.BackColor.ToString <> "" Then
                                    .BackColor = _QBEColumn.BackColor
                                End If
                                If _QBEColumn.ForeColor.ToString <> "" Then
                                    .ForeColor = _QBEColumn.ForeColor
                                End If
                            End With

                        End With

                    End If
                End If
            End If


            If _QBEColumn.UseInQBE = UseInQBEEnum.UseInQUE Or _QBEColumn.QBEValue <> "" Then
                Me.QueryGrid.Rows.Add()

                ' modifica
                Select Case _QBEColumn.DbCOlumn.DbType
                    Case Is = DbType.Boolean
                        Dim ncell As New DataGridViewCheckBoxCell
                        ncell.ThreeState = True
                        ncell.IndeterminateValue = ""
                        ncell.TrueValue = True
                        ncell.FalseValue = False
                        If _QBEColumn.QBEValue <> Nothing Then
                            If _QBEColumn.QBEValue = "True" Then
                                ncell.Value = True
                            Else
                                ncell.Value = False
                            End If
                        Else
                            ncell.Value = ncell.IndeterminateValue
                        End If

                        Me.QueryGrid.Rows(i).Cells(1) = ncell


                    Case Else
                        Dim ncell As New DataGridViewTextBoxCell
                        ncell.Value = _QBEColumn.QBEValue
                        Me.QueryGrid.Rows(i).Cells(1) = ncell
                End Select



                With Me.QueryGrid.Rows(i)


                    .Cells(0).Value = _QBEColumn.FriendlyName
                    .Cells(0).Tag = _QBEColumn.DbCOlumn.DbColumnNameE
                    If Trim(_QBEColumn.QBEValue) <> "" Then
                        .Cells(1).ReadOnly = True
                        .Cells(1).Style.ForeColor = Drawing.Color.Red
                    End If
                    .Tag = _QBEColumn.DbCOlumn.DbColumnName
                    If _QBEColumn.UseInQBE = False Then
                        Me.QueryGrid.Rows(i).Visible = False
                    End If
                End With
                i = i + 1
            End If


        Next

        If i <= 6 Then
            Me.QueryGrid.Height = i * 23 + 25
        Else
            Me.QueryGrid.Height = 6 * 23 + 25
        End If

        If Me.Mode = QbeMode.Report Then
            i = 0
            For Each QBEReport In mReports.Values
                Me.ReportGrid.Rows.Add()
                With Me.ReportGrid.Rows(i)
                    .Cells(Me.dgvcNomeReport.Name).Value = QBEReport.ReportTitle
                    .Cells(Me.dgvcDescrizioneReport.Name).Value = QBEReport.ReportDescription
                    .Cells(Me.dgvcReportFileName.Name).Value = QBEReport.ReportFileName
                    .Tag = QBEReport.ReportFileName
                End With
                i = i + 1
            Next
            Me.ReportGrid.AutoResizeColumn(0)
        End If

        Me.QueryGrid.AutoResizeColumn(0)


    End Sub



    Private Sub BuildQuery3()

        Dim FiltersGroup As New BasicDAL.DbFiltersGroup

        Dim Filters As New BasicDAL.DbFilters
        Dim Filter As New BasicDAL.DbFilter
        Dim dbColumnName As String = ""
        Dim dbColumn As BasicDAL.DbColumn
        Dim Value As String = ""
        Dim CompOp As String = ""
        Dim row As DataGridViewRow = Nothing
        Dim i As Integer = 0
        Dim item As Integer = 0
        Dim FriendlyName As String = ""
        Dim array() As String
        Dim SQLWhere As String = ""

        Me.QueryGrid.EndEdit()

        FiltersGroup.Clear()

        For Each row In Me.QueryGrid.Rows
            FriendlyName = (row.Cells(Me.dgvcNomeCampo.Name).Value)
            ' MsgBox(row.Cells(1).ValueType.ToString)


            If TypeOf (row.Cells(1)) Is DataGridViewCheckBoxCell Then
                Dim c As DataGridViewCheckBoxCell = row.Cells(dgvcValoreCampo.Name)
                Value = c.Value
            Else
                Value = row.Cells(1).Value
            End If





            If i >= 0 Then
                dbColumn = GetDbColumnFromFriendlyName(FriendlyName)
                'dbColumn = GetDbColumnFromDbColumnName(row.Cells(Me.dgvcNomeCampo.Name).Tag)
                If Trim(Value) <> "" Or Value <> Nothing Then
                    Value = Value.Trim()
                    If Value <> ";" Then
                        array = Split(Value, ";")
                    Else
                        ReDim array(0)
                        array(0) = ";"
                    End If
                    Filters = xBuildFilters(dbColumn, array)
                    If Filters IsNot Nothing Then
                        Filters.Item(Filters.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
                        Filters.LogicOperator = BasicDAL.LogicOperator.AND
                        FiltersGroup.Add(Filters)
                    End If
                    item = item + 1
                End If
            End If

        Next



        If FiltersGroup.Count Then
            FiltersGroup.Item(FiltersGroup.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
        End If


        FiltersGroup.BuildSQLFilter("")
        mDbObject.TopRecords = mTopRecords

        If Me.PreserveDbFilters = False Then
            mDbObject.FiltersGroup = FiltersGroup
        Else
            For Each _Filters As BasicDAL.DbFilters In FiltersGroup
                mDbObject.FiltersGroup.AddFilters(_Filters, BasicDAL.LogicOperator.AND)
            Next
        End If



    End Sub
    Private Function xBuildFilters(ByVal DbColumn As BasicDAL.DbColumn, ByVal FilterConditions() As String) As BasicDAL.DbFilters


        Dim Element As String
        Dim Filters As New BasicDAL.DbFilters
        Dim Filter As New BasicDAL.DbFilter
        Dim value As Object = Nothing
        Dim p As Integer = 0


        For Each Element In FilterConditions

            Me.SearchNE(Element, DbColumn, Filters)
            Me.SearchGTE(Element, DbColumn, Filters)
            Me.SearchLTE(Element, DbColumn, Filters)
            Me.SearchGT(Element, DbColumn, Filters)
            Me.SearchLT(Element, DbColumn, Filters)
            Me.SearchRange(Element, DbColumn, Filters)
            Me.SearchISNULL(Element, DbColumn, Filters)
            Me.SearchISNOTNULL(Element, DbColumn, Filters)

            If Element <> "" Then
                DbColumn.IsDate()

                If DbColumn.IsString And Me.mUseExactSearchForString = False Then
                    If (Element.StartsWith("[") = False And Element.EndsWith("]") = False) Then
                        Element = "%" & Element & "%"
                    Else
                        Element = Element.Substring(1, Element.Length - 2)
                    End If
                End If

                Filter = New BasicDAL.DbFilter
                With Filter
                    .DbColumn = DbColumn

                    '.DbColumn.DBColumnName = DbColumn.DBColumnName
                    If InStr(Element, "%") Then
                        .ComparisionOperator = BasicDAL.ComparisionOperator.Like
                    Else
                        .ComparisionOperator = BasicDAL.ComparisionOperator.Equals
                    End If
                    .Value = Cast(Element, DbColumn.DbType)
                    .LogicOperator = BasicDAL.LogicOperator.OR

                End With
                Filters.Add(Filter)
            End If

        Next

        Return Filters


    End Function


    Private Sub SearchGT(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim Value As Object = Nothing


        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, ">")

        If Mid(Inputs, 1, 1) = ">" Then
            Select Case Array.Length
                Case Is = 0

                Case Else

                    Value = Cast(Array(1), DbColumn.DbType)

                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.GreaterThan, Value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If






    End Sub

    Private Sub SearchGTE(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing

        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, ">=")

        If Mid(Inputs, 1, 2) = ">=" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.GreaterThanOrEqualTo, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If



    End Sub


    Private Sub SearchLT(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing
        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, "<")

        If Mid(Inputs, 1, 1) = "<" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.LessThan, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If



    End Sub

    Private Sub SearchISNULL(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing
        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, "ISNULL")

        If Mid(Inputs, 1, 6).ToUpper = "ISNULL" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.IsNull, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If
    End Sub


    Private Sub SearchISNOTNULL(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing
        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, "ISNOTNULL")

        If Mid(Inputs, 1, 6).ToUpper = "ISNOTNULL" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.IsNotNull, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If
    End Sub



    Private Sub SearchLTE(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing
        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, "<=")

        If Mid(Inputs, 1, 2) = "<=" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.LessThanOrEqualTo, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If


    End Sub


    Private Sub SearchNE(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String

        Dim value As Object = Nothing

        If Inputs = "" Then Exit Sub
        Array = Split(Inputs, "<>")


        If Mid(Inputs, 1, 2) = "<>" Then
            Select Case Array.Length
                Case Is = 0

                Case Else
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.NotEqualTo, value, BasicDAL.LogicOperator.OR)
                    Inputs = ""
            End Select
        End If



    End Sub
    Private Sub SearchRange(ByRef Inputs As String, ByVal DbColumn As BasicDAL.DbColumn, ByVal Filters As BasicDAL.DbFilters)
        Dim Array() As String
        Dim value As Object = Nothing

        If Inputs = "" Then Exit Sub
        If InStr(Inputs, "...") = False Then Exit Sub

        Array = Split(Inputs, "...")

        Select Case Array.Length
            Case Is = 0
            Case Is = 1
                value = Cast(Array(0), DbColumn.DbType)
                Filters.Add(DbColumn, BasicDAL.ComparisionOperator.GreaterThanOrEqualTo, value, BasicDAL.LogicOperator.OR)
            Case Else
                value = Cast(Array(0), DbColumn.DbType)
                Filters.Add(DbColumn, BasicDAL.ComparisionOperator.GreaterThanOrEqualTo, value, BasicDAL.LogicOperator.AND)
                If Array(1) <> "" Then
                    value = Nothing
                    value = Cast(Array(1), DbColumn.DbType)
                    Filters.Add(DbColumn, BasicDAL.ComparisionOperator.LessThanOrEqualTo, value, BasicDAL.LogicOperator.OR)
                End If
                Inputs = ""
        End Select

    End Sub


    Private Sub ReturnQueryResult()

        If mMode = QbeMode.Report Then Exit Sub


        Select Case Me.ResultMode
            Case Is = QBEResultMode.BoundControls
                ReturnBoundControls()
            Case Is = QBEResultMode.SingleRow
                ReturnSelectedRows()
            Case Is = QBEResultMode.AllRows
                ReturnSelectedRows()
            Case Is = QBEResultMode.SelectedRows
                ReturnSelectedRows()
            Case Is = QBEResultMode.DataTable
                ReturnResultsDataTable()
            Case Is = QBEResultMode.DBObject
                ReturnResultsDBObject()

        End Select




        mDbObject.FiltersGroup = Me.oFiltersGroup


        ' mCallerForm.Focus()
        Me.CallerForm.Enabled = True
        RaiseEvent QBEForm_ResultReturned(Me.DbObject)
        Me.Close()

    End Sub


    Private Function GetQueryGridRowValue(ByVal DbColumnName As String) As Object
        Dim row As DataGridViewRow

        For Each row In Me.QueryGrid.Rows
            If UCase(Trim(row.Tag)) = UCase(Trim(DbColumnName)) Then
                Return row.Cells(2).Value
            End If
        Next
        Return (Nothing)

    End Function

    Private Sub ReturnResultsDataTable()
        If Me.ResultGrid.SelectedRows.Count = 0 Then Exit Sub

        mResultsDataTable = New DataTable
        mResultsDataTable = mDbObject.GetDataTable.Clone
        mResultsDataTable.Clear()
        Dim oSourceDataRow As DataRow
        Dim oDataRow As DataRow
        Dim oRow As DataGridViewRow
        For Each oRow In Me.ResultGrid.SelectedRows
            oSourceDataRow = TryCast(oRow.DataBoundItem, DataRowView).Row
            oDataRow = mResultsDataTable.NewRow
            Me.CopyDataRow(oSourceDataRow, oDataRow)
            mResultsDataTable.Rows.Add(oDataRow)
        Next

    End Sub

    Private Sub CopyDataRow(ByVal oSourceRow As DataRow, ByVal oTargetRow As DataRow)
        Dim nIndex As Integer = 0
        Dim oItem As Object
        '- Copy all the fields from the source row to the target row
        For Each oItem In oSourceRow.ItemArray
            oTargetRow(nIndex) = oItem
            nIndex += 1
        Next
    End Sub
    Private Sub ReturnResultsDBObject()


        If Me.ResultGrid.SelectedRows.Count = 0 Then Exit Sub
        If mDbColumnsMapping.Count = 0 Then Exit Sub

        Dim Filters As BasicDAL.DbFilters = Nothing
        Dim FiltersGroup As New BasicDAL.DbFiltersGroup

        Dim DbColumnMapping As DbColumnMapping
        Dim row As DataGridViewRow

        Dim value As Object



        For Each row In Me.ResultGrid.SelectedRows
            Filters = New BasicDAL.DbFilters

            For Each DbColumnMapping In mDbColumnsMapping
                value = row.Cells(DbColumnMapping.QBEDbColumn.DbColumnName).Value
                If value IsNot DBNull.Value Then
                    Filters.Add(DbColumnMapping.TargetDbColumn, BasicDAL.ComparisionOperator.Equals, value, BasicDAL.LogicOperator.AND)
                End If
            Next


            Filters.Item(Filters.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
            Filters.LogicOperator = BasicDAL.LogicOperator.OR
            FiltersGroup.Add(Filters)
        Next



        Filters.Item(Filters.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
        Filters.LogicOperator = BasicDAL.LogicOperator.OR
        FiltersGroup.Add(Filters)
        FiltersGroup.Item(FiltersGroup.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
        mResultsDBObject.FiltersGroup = FiltersGroup
        mResultsDBObject.LoadAll()
        '  mResultsDBObject.MoveFirst()


    End Sub
    Private Sub ReturnSelectedRows()


        If Me.ResultGrid.SelectedRows.Count = 0 Then Exit Sub

        Dim Filters As BasicDAL.DbFilters = Nothing
        Dim FiltersGroup As New BasicDAL.DbFiltersGroup

        Dim DbColumnMapping As DbColumnMapping
        Dim row As DataGridViewRow

        Dim value As Object


        For Each row In Me.ResultGrid.SelectedRows
            Filters = New BasicDAL.DbFilters
            For Each DbColumnMapping In mDbColumnsMapping
                value = row.Cells(DbColumnMapping.QBEDbColumn.DbColumnName).Value
                If value IsNot DBNull.Value Then
                    Filters.Add(DbColumnMapping.TargetDbColumn, BasicDAL.ComparisionOperator.Equals, value, BasicDAL.LogicOperator.AND)
                End If
            Next
            If Filters.Count Then
                Filters.Item(Filters.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
                Filters.LogicOperator = BasicDAL.LogicOperator.OR
                FiltersGroup.Add(Filters)
            End If

        Next
        If Filters.Count Then
            FiltersGroup.Item(FiltersGroup.Count - 1).LogicOperator = BasicDAL.LogicOperator.None
        End If

        ' modifica per colonna di ordinamento risultato
        Dim orderby = ""
        Dim sortorder = " ASC "
        If (Me.ResultGrid.SortedColumn IsNot Nothing) Then

            If Me.ResultGrid.SortOrder <> Wisej.Web.SortOrder.Ascending Then
                sortorder = " DESC "
            End If

            orderby = Me.QueryDbObject.GetDbColumnByDbColumnNameE(Me.ResultGrid.SortedColumn.DataPropertyName).DbColumnNameE + sortorder
        Else
            For Each Dbcolumn As BasicDAL.DbColumn In Me.QueryDbObject.GetPrimaryKeyDbColumns
                orderby = orderby + Dbcolumn.DbColumnNameE + ", "
            Next
            orderby = orderby.Trim()
            If (orderby.EndsWith(",")) Then
                orderby = Mid(orderby, 1, orderby.Length - 1)
            End If
        End If

        Me.QueryDbObject.OrderBy = orderby
        Me.QueryDbObject.FiltersGroup = FiltersGroup
        Me.QueryDbObject.LoadAll()

        If Me.BoundDataGridView IsNot Nothing Then
            Me.BoundDataGridView.DataSource = Me.QueryDbObject.DataTable
        End If


    End Sub

    Private Sub ReturnBoundControls()

        Dim QBEBoundControl As QBEBoundControl
        Dim value As Object

        For Each QBEBoundControl In mBoundControls
            Try

                value = Me.ResultGrid.CurrentRow.Cells(QBEBoundControl.DbColumn.DbColumnName).Value

                'If (QBEBoundControl.Control.GetType.FullName.StartsWith("Wisej.Web.DataGridView")) Then
                '    Dim isInEditMode As Boolean = False
                '    isInEditMode = CallByName(QBEBoundControl.Control, "IsInEditMode", CallType.Get, False)
                '    If isInEditMode = True Then
                '        CallByName(QBEBoundControl.Control, "IsInEditMode", CallType.Set, False)
                '    End If

                '    CallByName(QBEBoundControl.Control, QBEBoundControl.PropertyName, CallType.Set, value)

                '    If isInEditMode = True Then
                '        CallByName(QBEBoundControl.Control, "IsInEditMode", CallType.Set, True)
                '    End If


                'Else


                CallByName(QBEBoundControl.Control, QBEBoundControl.PropertyName, CallType.Set, value)

                'End If





            Catch ex As Exception
                Dim x As Integer = 0

            End Try

        Next
        '  RaiseEvent QBEForm_ResultReturned(Me.DbObject)
    End Sub




    Private Function GetDbColumnNameFromFriendlyName(ByVal FriendlyName As String) As String
        Dim QBEColumn As QBEColumn

        For Each QBEColumn In mQBEColumns

            If UCase(QBEColumn.FriendlyName) = UCase(FriendlyName) Then
                Return QBEColumn.DbCOlumn.DbColumnName
            End If
        Next
        Return ""


    End Function
    Private Function GetDbColumnFromFriendlyName(ByVal FriendlyName As String) As BasicDAL.DbColumn

        Dim QBEColumn As QBEColumn
        For Each QBEColumn In QBEColumns

            If UCase(QBEColumn.FriendlyName) = UCase(FriendlyName) Then
                Return QBEColumn.DbCOlumn
            End If
        Next

        Return Nothing


    End Function
    Private Function GetDbColumnFromDbColumnName(ByVal DbColumnName As String) As BasicDAL.DbColumn
        Dim QBEColumn As QBEColumn

        For Each QBEColumn In mQBEColumns

            If UCase(QBEColumn.DbCOlumn.DbColumnName) = UCase(DbColumnName) Then
                Return QBEColumn.DbCOlumn
            End If
        Next
        Return Nothing



    End Function

    Private Function Cast(ByVal Value As Object, ByVal dbType As DbType) As Object
        Try
            Select Case dbType
                Case Is = Data.DbType.AnsiString, Data.DbType.AnsiStringFixedLength, Data.DbType.String, Data.DbType.StringFixedLength
                    Cast = Convert.ToString(Value)
                Case Is = Data.DbType.Byte
                    Cast = Convert.ToByte(Value)
                Case Is = Data.DbType.Boolean
                    Cast = Convert.ToBoolean(Value)
                Case Is = Data.DbType.Currency, Data.DbType.Decimal, Data.DbType.VarNumeric
                    Cast = Convert.ToDecimal(Value)
                Case Is = DbType.Single
                    Cast = Convert.ToSingle(Value)
                Case Is = Data.DbType.Date, Data.DbType.DateTime, Data.DbType.Time
                    Cast = Convert.ToDateTime(Value)
                Case Is = Data.DbType.Double
                    Cast = Convert.ToDouble(Value)
                Case Is = Data.DbType.Guid
                    Cast = Convert.ToString(Value)
                Case Is = Data.DbType.SByte
                    Cast = Convert.ToSByte(Value)
                Case Is = Data.DbType.Int16
                    Cast = Convert.ToInt16(Value)
                Case Is = Data.DbType.Int32
                    Cast = Convert.ToInt32(Value)
                Case Is = Data.DbType.Int64
                    Cast = Convert.ToInt64(Value)
                Case Is = Data.DbType.UInt16
                    Cast = Convert.ToUInt16(Value)
                Case Is = Data.DbType.UInt32
                    Cast = Convert.ToUInt32(Value)
                Case Is = Data.DbType.UInt64
                    Cast = Convert.ToUInt64(Value)
                Case Else
                    Cast = Value
            End Select

        Catch ex As Exception
            Return DBNull.Value
        End Try

    End Function
    Private Sub ClearConditions()
        Dim row As DataGridViewRow
        Me.ResultGrid.Select()
        For Each row In Me.QueryGrid.Rows
            If row.Cells(1).ReadOnly = False Then
                row.Cells(1).Value = ""
            End If
        Next
        DoQuery()
        Me.QueryGrid.Select()
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.

        Try
            InitializeComponent()

            MovePreviousCaption = "Prev."
            MoveNextCaption = "Next"
            MoveFirstCaption = "First"
            MoveLastCaption = "Last"
            RefreshCaption = "Refresh"
            CloseCaption = "Close"
            DeleteFiltersCaption = "Clear Filters"
            PrintCaption = "Print"
            SelectCaption = "Select"
            TabQueryFiltersText = "Query Filters"
            TabReportsText = "Reports"
            TabExportText = "Export Data"
            TabDebugText = "Debug Info"
            ButtonExportDataText = "Export Data"
            QueryGridFilterColumnHeaderText = "Column Name"
            QueryGridFilterValueHeaderText = "Filter value"
            ReportGridReportNameHeaderText = "Report"
            ReportGridReportDescriptionHeaderText = "Report Description"
            ReportGridReportFileNameHeaderText = "File Name"

        Catch ex As Exception

        End Try

        Me.ResultGrid.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub DoQuery()
        Me.BuildQuery3()
        Me.mDbObject.LoadAll()
        Me.ResultGrid.DataSource = Me.mDbObject.GetDataTable
        If (ResultGrid.Rows.Count > 0) Then
            ResultGrid.Rows(0).Selected = True
        End If
        Me.ResultGrid.Focus()

    End Sub
    Private Sub MovePrevious()
        If mMode = QbeMode.Report Then Exit Sub
        Me.ResultGrid.Focus()
        If Me.ResultGrid.CurrentRow.ClientIndex > 0 Then

            Dim CurrentRowClientIndex As Integer = Me.ResultGrid.CurrentRow.ClientIndex - 1
            Me.ResultGrid.CurrentCell = Me.ResultGrid(Me.ResultGrid.CurrentCell.ColumnIndex, CurrentRowClientIndex)
        End If



        'SendKeys.Send("{UP}")

    End Sub
    Private Sub MoveNext()
        If mMode = QbeMode.Report Then Exit Sub
        Me.ResultGrid.Focus()
        If Me.ResultGrid.CurrentRow.ClientIndex < Me.ResultGrid.Rows.Count - 1 Then
            Dim CurrentRowClientIndex As Integer = Me.ResultGrid.CurrentRow.ClientIndex + 1
            Me.ResultGrid.CurrentCell = Me.ResultGrid(Me.ResultGrid.CurrentCell.ColumnIndex, CurrentRowClientIndex)
        End If


    End Sub
    Private Sub MoveFirst()
        If mMode = QbeMode.Report Then Exit Sub
        Me.ResultGrid.Focus()
        If Me.ResultGrid.Rows.Count Then
            Me.ResultGrid.CurrentCell = Me.ResultGrid(Me.ResultGrid.CurrentCell.ColumnIndex, 0)
        End If


    End Sub
    Private Sub MoveLast()
        If mMode = QbeMode.Report Then Exit Sub
        Me.ResultGrid.Focus()
        If Me.ResultGrid.Rows.Count Then
            Me.ResultGrid.CurrentCell = Me.ResultGrid(Me.ResultGrid.CurrentCell.ColumnIndex, Me.ResultGrid.Rows.Count - 1)
        End If


    End Sub


    Private Sub SplitContainer1_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        ResizeSplitter(True)
    End Sub

    Private Sub ResizeSplitter(ByVal Mode As Boolean)
        If (Me.mMode = QbeMode.Report And Me.mReportViewerMode = ReportViewerMode.WEB) Then
            'Me.Eval("App.QBEForm.aspNetPanel.getDocument().getElementById(""CrystalReportViewer"").Height = """ & Me.AspNetPanel.Height & """;")
        End If

    End Sub

    Private Sub bLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLast.Click
        MoveLast()
    End Sub

    Private Sub bPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrev.Click
        MovePrevious()
    End Sub

    Private Sub bNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNext.Click

        MoveNext()
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click

        ReturnQueryResult()
    End Sub

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click


        'mDbObject.FiltersGroup = Me.oFiltersGroup

        If Me.mCallerForm IsNot Nothing Then
            Try
                Me.mCallerForm.Enabled = True
            Catch ex As Exception

            End Try

        End If

        RaiseEvent QBEForm_Closed()

        Me.Close()
    End Sub



    Private Sub ResultGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResultGrid.DoubleClick


        Me.ReturnQueryResult()
    End Sub

    Private Sub bRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefresh.Click

        DoQuery()
        If Me.Mode = QbeMode.Report Then
            PrintReport(False)
        End If

    End Sub





    Private Sub bDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bDelete.Click
        ClearConditions()

    End Sub

    Private Sub bFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bFirst.Click
        MoveFirst()
    End Sub

    Private Sub bPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bPrint.Click
        DoQuery()
        PrintReport(True)
    End Sub



    Private Sub TabControl_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) Handles TabControl.Selected

        Me.QueryGrid.Visible = False
        Me.ReportGrid.Visible = False
        Me.txtDebug.Visible = False
        Me.PanelEsporta.Visible = False

        Select Case e.TabPage.Name

            Case Is = Me.TabPageCriteriRicerca.Name
                Me.QueryGrid.Visible = True

            Case Is = Me.TabPageStampe.Name
                Me.ReportGrid.Visible = True

            Case Is = Me.TabPageDebug.Name
                Me.txtDebug.Visible = True

            Case Is = Me.TabPageEsporta.Name
                Me.PanelEsporta.Visible = True

        End Select
    End Sub

    Private Sub QueryGrid_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles QueryGrid.CellDoubleClick

        If Me.DoNotAllowQBEFilterChange = True Then Return


        If Me.QueryGrid.CurrentCell Is Nothing Then
            Return
        End If

        If e.ColumnIndex = 1 Then

            If Me.QueryGrid.CurrentCell.ReadOnly = True Then
                If Wisej.Web.MessageBox.Show("Modificare il parametro di ricerca?", Me.Text, MessageBoxButtons.YesNo) = MessageBoxButtons.Yes Then
                    Me.QueryGrid.CurrentCell.ReadOnly = False
                End If
            End If

        End If
    End Sub



    'Private Sub QueryGrid_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles QueryGrid.CellContentClick
    '    If e.ColumnIndex = 2 Then
    '        Me.LoadQBESearchValue(Me.QueryGrid.CurrentRow.Tag, Me.QueryGrid.CurrentRow.Cells(0).Value)
    '    End If
    'End Sub


    'Private Sub LoadQBESearchValue(ByVal DBColumnName As String, ByVal FriendlyName As String)


    '    Dim SQL As String = ""
    '    Dim datatable As New System.Data.DataTable

    '    QBESearchValue.SearchDBColumn = Me.mDbObject.GetDbColumn(DBColumnName)
    '    QBESearchValue.SearchDBColumnFriendlyName = FriendlyName
    '    QBESearchValue.DoQuery()


    'End Sub
    Private Sub CloseQBEForm()
        Try
            If System.IO.File.Exists(mReportsLastPDFViewerFileName) Then
                System.IO.File.Delete(mReportsLastPDFViewerFileName)
            End If
        Catch ex As Exception

        End Try

        If Me.CallerForm IsNot Nothing Then
            Me.CallerForm.Enabled = True
            Me.CallerForm.Focus()
            Me.CallerForm.Select()
            If mAfterCloseFocus IsNot Nothing Then
                mAfterCloseFocus.Focus()
            End If
        End If


    End Sub


    Private Sub QueryGrid_DataError(sender As System.Object, e As DataGridViewDataErrorEventArgs) Handles QueryGrid.DataError
        ' non cancellare
    End Sub

    Private Sub QBEForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        CloseQBEForm()

    End Sub

    Private Sub ResultGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ResultGrid.CellEnter
        Try
            Me.RecordLabel.Text = Me.ResultGrid.CurrentCell.RowIndex + 1 & vbCrLf & " / " & Me.DbObject.RowCount
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResultGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles ResultGrid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ReturnQueryResult()
        End If
    End Sub

    Private Sub QBEForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.PdfViewer.Visible = False
        Me.WebBrowser.Visible = False
        Me.QueryGrid.Dock = DockStyle.Fill
        Me.ReportGrid.Dock = DockStyle.Fill

    End Sub

    Private Sub QBEForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Dim Height As Integer = Me.SplitContainer1.Height - (Me.TabControl.Height + Me.QueryGrid.ColumnHeadersHeight)



        Select Case Me.QueryGrid.Rows.Count

            Case < 5
                Me.SplitContainer1.SplitterDistance = Height - (Me.QueryGrid.Rows.Count * Me.QueryGrid.DefaultRowHeight)
            Case Else
                Me.SplitContainer1.SplitterDistance = Height - (5 * Me.QueryGrid.DefaultRowHeight)
        End Select

        ResizeSplitter(True)





    End Sub

    Function GetCrystalRecordSelectionFormula(Optional ByVal RemoveSchemaName As Boolean = True) As String

        Dim i As Integer
        Dim where As String = Me.DbObject.SQLWhereConditions
        Dim c As String = ""
        Dim p As String = ""
        Dim t As String = ""
        Dim v As Object
        Dim ov As Object
        Dim dv As Date
        Dim DbColumns As BasicDAL.DbColumns
        '   Dim DbColumn As BasicDAL.DbColumn



        ' primo passo modifica dei nomi campi
        t = Me.DbObject.DbTableName.ToString
        t = Replace(t, "]", "")
        t = Replace(t, "[", "")

        DbColumns = Me.DbObject.GetDbColumns

        For Each xDbColumn As BasicDAL.DbColumn In DbColumns
            c = xDbColumn.DbColumnNameE
            'xDbColumn.DbColumnNameE
            where = Me.ReplaceWholeWord(where, c, "{" + t + "." + c + "}")

        Next

        where = where.Replace("]", "")
        where = where.Replace("[", "")

        ' secondo passo modifica dei valori parametri

        For i = 0 To Me.DbObject.Command.Parameters.Count - 1
            ov = Me.DbObject.Command.Parameters(i).Value
            p = Me.DbObject.Command.Parameters(i).ParameterName
            ' Select Me.DbObject.GetDbColumn(Me.DbObject.Command.Parameters(i).SourceColumn).DBType
            Select Case Me.DbObject.Command.Parameters(i).DbType
                Case Is = DbType.AnsiString, DbType.AnsiString, DbType.String, DbType.StringFixedLength, DbType.Xml
                    v = "'" + ov + "'"
                    'v = Chr(34) + ov + Chr(34)
                    v = Replace(v, "%", "*")

                Case Is = DbType.Date
                    dv = CDate(ov)
                    v = "Datetime(" + dv.Year.ToString + "," + dv.Month.ToString + "," + dv.Day.ToString + ")"
                Case Is = DbType.DateTime
                    dv = CDate(ov)
                    v = "Datetime(" + dv.Year.ToString + "," + dv.Month.ToString + "," + dv.Day.ToString + "," + dv.Hour.ToString + "," + dv.Minute.ToString + "," + dv.Second.ToString + ")"
                Case Is = DbType.Time
                    dv = CDate(ov)
                    v = "Datetime(" + dv.Year.ToString + "," + dv.Month.ToString + "," + dv.Day.ToString + "," + dv.Hour.ToString + "," + dv.Minute.ToString + "," + dv.Second.ToString + ")"
                Case Is = DbType.Boolean
                    v = ov
                Case Else
                    v = ov
            End Select

            where = ReplaceWholeWord(where, p, v)

        Next i

        Return where


    End Function
    Public Function ReplaceWholeWord(ByVal s As String, ByVal word As String, ByVal bywhat As String) As String
        Dim firstLetter As Char = word.Chars(0)
        Dim sb As New System.Text.StringBuilder()
        Dim previousWasLetterOrDigit As Boolean = False
        Dim i As Integer = 0
        Do While i < s.Length - word.Length + 1
            Dim wordFound As Boolean = False
            Dim c As Char = s.Chars(i)
            If c = firstLetter Then
                If (Not previousWasLetterOrDigit) Then
                    If s.Substring(i, word.Length).Equals(word) Then
                        wordFound = True
                        Dim wholeWordFound As Boolean = True
                        If s.Length > i + word.Length Then
                            If Char.IsLetterOrDigit(s.Chars(i + word.Length)) Then
                                wholeWordFound = False
                            End If
                        End If

                        If wholeWordFound Then
                            sb.Append(bywhat)
                        Else
                            sb.Append(word)
                        End If

                        i += word.Length
                    End If
                End If
            End If

            If (Not wordFound) Then
                previousWasLetterOrDigit = Char.IsLetterOrDigit(c)
                sb.Append(c)
                i += 1
            End If
        Loop

        If s.Length - i > 0 Then
            sb.Append(s.Substring(i))
        End If

        Return sb.ToString()
    End Function

    Private Sub SplitContainer1_DoubleClick(sender As Object, e As EventArgs) Handles SplitContainer1.DoubleClick
        Me.ResizeSplitter(True)
    End Sub

    Private Sub NavBar_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs)
        'Dim buttoname As String = e.Button.Name

        'Select Case (e.Button.Name).ToLower
        '    Case = "records"
        '        Me.cmbRecords.Parent = Me.NavBar
        '        Me.cmbRecords.Top = 0
        '        Me.cmbRecords.Left = MousePosition.Y
        '        Me.cmbRecords.BringToFront()
        '        Me.cmbRecords.Visible = True

        'End Select

    End Sub


    Private Sub ContextMenuRecords_MenuItemClicked(sender As Object, e As MenuItemEventArgs) Handles ContextMenuRecords.MenuItemClicked
        Me.TopRecords = e.MenuItem.Tag
        Me.Records.Text = e.MenuItem.Text
    End Sub

    Private Sub ResultGrid_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ResultGrid.RowEnter
        If Me.ResultGrid.CurrentCell Is Nothing = True Then
            Return
        End If

        Try
            Me.RecordLabel.Text = Me.ResultGrid.CurrentCell.RowIndex + 1 & " / " & Me.DbObject.RowCount
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bSaveQBE_Click(sender As Object, e As EventArgs) Handles bSaveQBE.Click


        Dim Path As String = Application.CommonAppDataPath
        Dim FileName As String = "D:\TEST.XML"
        SaveQBEUserColumnSet(FileName)

    End Sub

    Private Sub bLoadQBE_Click(sender As Object, e As EventArgs) Handles bLoadQBE.Click
        Dim FileName As String = "D:\TEST.XML"
        LoadQBEUserColumnSet(FileName)

    End Sub
    Private Sub LoadQBEUserColumnSet(ByVal FileName As String)
        Dim QBEUserColumnsSet As New QBEUserColumnsSet
        Dim QBEUserColumns As New List(Of QBEUserColumn)

        If System.IO.File.Exists(FileName) = False Then
            Return
        End If

        BasicDAL.Utilities.DeserializeObjectFromFile(FileName, QBEUserColumnsSet)
        If (QBEUserColumnsSet IsNot Nothing) Then
            If (QBEUserColumnsSet.DBObjectName.Trim.ToLower = Me.DbObject.Name.Trim.ToLower()) Then
                Me.QBEColumns.Clear()
                For Each N As QBEUserColumn In QBEUserColumnsSet.QBEUserColumns
                    Dim Q As QBEColumn
                    Dim DbColumn As BasicDAL.DbColumn = Me.mDbObject.GetDbColumn(N.DBColumnName)
                    Q = Me.QBEColumns.Add(DbColumn, N.FriendlyName, N.DisplayFormat, N.QBEValue, N.UseInQBE, N.DisplayInQBEResult, N.QBEColumnType)
                    Q.BackColor = N.BackColor
                    Q.ForeColor = N.ForeColor
                Next
                Me.LoadParameters()
            End If
        End If
    End Sub
    Private Sub SaveQBEUserColumnSet(ByVal FileName As String)
        Me.QueryGrid.EndEdit()
        Dim QBEUserColumnsSet As New QBEUserColumnsSet
        Dim QBEUserColumns As New List(Of QBEUserColumn)
        For Each Q As QBEColumn In Me.mQBEColumns
            Dim N = New QBEUserColumn
            N.BackColor = Q.BackColor
            N.DBColumnName = Q.DbCOlumn.DbColumnNameE
            N.DisplayFormat = Q.DisplayFormat
            N.DisplayInQBEResult = Q.DisplayInQBEResult
            N.ForeColor = Q.ForeColor
            N.FriendlyName = Q.FriendlyName
            N.QBEColumnType = Q.QBEColumnType
            N.UseInQBE = Q.UseInQBE
            ' recupera il Value
            For Each row As DataGridViewRow In QueryGrid.Rows
                If row(0).Tag = N.DBColumnName Then
                    N.QBEValue = row(dgvcValoreCampo.Name).Value
                    Exit For
                End If
            Next
            QBEUserColumns.Add(N)
        Next
        QBEUserColumnsSet.Name = "Filtro Tipologie"
        QBEUserColumnsSet.Description = "Filtro Tipologie"
        QBEUserColumnsSet.UserName = Application.User.Identity.Name
        QBEUserColumnsSet.QBEUserColumns = QBEUserColumns
        QBEUserColumnsSet.DBObjectName = Me.mDbObject.Name
        'Dim xml As String = ""
        'BasicDAL.Utilities.SerializeObjectToFile(FileName, QBEUserColumnsSet)

        Dim frmx As New QBEFormSaveUserColumnSet
        frmx.QBEUserColumnsSet = QBEUserColumnsSet
        frmx.ShowDialog()

    End Sub

    Private Sub AspNetPanel_Resize(sender As Object, e As EventArgs) Handles AspNetPanel.Resize
        'Dim fullcontrolname As String = BasicDALWisejControls.Utilities.GetClientControlFullName(Me.AspNetPanel)
        'Dim style As String = """border-style:None;height:" & (Me.AspNetPanel.Height - 50).ToString() + "px;width:" & Me.AspNetPanel.Width.ToString() + "px;overflow:auto"""
        'Dim visualStyle As String = """height:" & (Me.AspNetPanel.Height - 50).ToString() + "px;width:" & Me.AspNetPanel.Width.ToString() + "px"""
        'Dim cmdDiv As String = fullcontrolname + ".getDocument().getElementById('CrystalReportViewerDiv').style=" + style
        'Dim cmdCrystalReportViewer As String = fullcontrolname + ".getDocument().getElementById('CrystalReportViewer').style=" + style
        'Dim cmdCrystalReportViewer__UI As String = fullcontrolname + ".getDocument().getElementById('CrystalReportViewer__UI').visualStyle=" + visualStyle


        'cmdCrystalReportViewer__UI = fullcontrolname + ".getDocument().getElementById('CrystalReportViewer__UI').visible='false'"
        ''Me.Eval(cmdDiv)
        ''Me.Eval(cmdCrystalReportViewer)
        'Me.Eval(cmdCrystalReportViewer__UI)

    End Sub

    Private Sub btnEsporta_Click(sender As Object, e As EventArgs) Handles btnEsporta.Click

        Dim filename As String = ""
        filename = System.IO.Path.GetTempFileName
        Dim exportfilename As String = BasicDAL.Utilities.GetSafeFileName(Me.Text)

        Dim DbColumns As New BasicDAL.DbColumns

        For Each Column As DataGridViewColumn In Me.ResultGrid.Columns
            If Column.Visible = True Then
                DbColumns.Add(Me.DbObject.GetDbColumn(Column.Tag))
            End If
        Next

        Dim Stream As System.IO.FileStream
        If Me.rbExcel.Checked Then
            Me.DbObject.SaveAsCSV(filename,,,, DbColumns)
            Stream = BasicDAL.Utilities.FileToFileStream(filename)
            Application.Download(Stream, exportfilename + ".csv")
            Stream.Close()
        End If

        If Me.rbCSV.Checked Then
            Me.DbObject.SaveAsCSV(filename)
            Stream = BasicDAL.Utilities.FileToFileStream(filename)
            Application.Download(Stream, exportfilename + ".csv")
            Stream.Close()
        End If

        If Me.rbXML.Checked Then
            Me.DbObject.SaveAsXML(filename)
            Stream = BasicDAL.Utilities.FileToFileStream(filename)
            Application.Download(Stream, exportfilename + ".xml")
            Stream.Close()
        End If

        If System.IO.File.Exists(filename) Then
            System.IO.File.Delete(filename)
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fullcontrolname As String = BasicDALWisejControls.Utilities.GetClientControlFullName(Me.AspNetPanel)
        Dim par As String = Me.AspNetPanel.Height & ";" & Me.AspNetPanel.Width
        Dim x As String = fullcontrolname & ".CallingServerSideFunction()"

    End Sub


    Private Sub QueryGrid_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles QueryGrid.EditingControlShowing

        If (QueryGrid.Columns(QueryGrid.CurrentCell.ColumnIndex).Name = dgvcValoreCampo.Name) Then
            RemoveHandler e.Control.KeyDown, AddressOf dgvcValoreCampo_KeyDown
            AddHandler e.Control.KeyDown, AddressOf dgvcValoreCampo_KeyDown
        End If
    End Sub

    Private Sub dgvcValoreCampo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        ' F4 Pressed
        If (QueryGrid.Columns(QueryGrid.CurrentCell.ColumnIndex).Name = dgvcValoreCampo.Name) Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                Me.DoQuery()
            End If
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_PanelCollapsed(sender As Object, e As EventArgs) Handles SplitContainer1.Panel1.PanelCollapsed

    End Sub

    Private Sub ReportGrid_Click(sender As Object, e As EventArgs) Handles ReportGrid.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
<System.Serializable>
Public Class QBEUserColumnsSet
    Public Name As String = ""
    Public Description As String = ""
    Public UserName As String = ""
    Public ApplyToUsersOrGroups As String = "everyone"
    Public DBObjectName As String = ""
    Public QBEUserColumns As List(Of QBEUserColumn)
End Class


<Serializable>
Public Class QBEUserColumn
    Public DBColumnName As String = ""
    Public UseInQBE As Boolean = True
    Public DisplayInQBEResult As Boolean = True
    Public FriendlyName As String = ""
    Public QBEValue As String = ""
    Public DisplayFormat As String = ""
    Public BackColor As Drawing.Color
    Public ForeColor As Drawing.Color
    Public QBEColumnType As QBEColumnsTypes
    Public ColumnWidth As Integer = 0
End Class


Public Class QBEColumn
    Private mDBColumn As BasicDAL.DbColumn
    Private mUseInQBE As Boolean
    Private mDisplayInQBEResult As Boolean
    Private mFriendlyName As String
    Private mQBEValue As String
    Private mDisplayFormat As String
    Private mBackColor As Drawing.Color
    Private mForeColor As Drawing.Color
    Private mQBEColumnType As QBEColumnsTypes
    Private mColumnWidth As Integer = 0


    Property QBEColumnType() As QBEColumnsTypes
        Get
            QBEColumnType = mQBEColumnType

        End Get
        Set(ByVal value As QBEColumnsTypes)
            mQBEColumnType = value
        End Set
    End Property


    Property ForeColor() As Drawing.Color
        Get
            ForeColor = mForeColor

        End Get
        Set(ByVal value As Drawing.Color)
            mForeColor = value
        End Set
    End Property

    Property BackColor() As Drawing.Color
        Get
            BackColor = mBackColor

        End Get
        Set(ByVal value As Drawing.Color)
            mBackColor = value
        End Set
    End Property


    Property DisplayFormat() As String
        Get
            DisplayFormat = mDisplayFormat

        End Get
        Set(ByVal value As String)
            mDisplayFormat = value
        End Set
    End Property
    Property QBEValue() As Object
        Get
            QBEValue = Me.mQBEValue
        End Get
        Set(ByVal value As Object)
            Me.mQBEValue = value
        End Set
    End Property

    Property FriendlyName() As String
        Get
            FriendlyName = Me.mFriendlyName
        End Get
        Set(ByVal value As String)
            Me.mFriendlyName = value
        End Set
    End Property
    Property DisplayInQBEResult() As Boolean
        Get
            DisplayInQBEResult = Me.mDisplayInQBEResult
        End Get
        Set(ByVal value As Boolean)
            Me.mDisplayInQBEResult = value
        End Set
    End Property
    Property UseInQBE() As Boolean
        Get
            UseInQBE = Me.mUseInQBE
        End Get
        Set(ByVal value As Boolean)
            Me.mUseInQBE = value
        End Set
    End Property
    Property DbCOlumn() As BasicDAL.DbColumn
        Get
            DbCOlumn = Me.mDBColumn
        End Get
        Set(ByVal value As BasicDAL.DbColumn)
            mDBColumn = value
        End Set
    End Property

    Property ColumnWidth() As Integer
        Get
            ColumnWidth = Me.mColumnWidth
        End Get
        Set(ByVal value As Integer)
            mColumnWidth = value
        End Set
    End Property
End Class
Public Class QBEReport
    Private mReportTitle As String
    Private mReportFileName As String
    Private mReportDescription As String
    Property ReportFileName() As String
        Get
            ReportFileName = mReportFileName

        End Get
        Set(ByVal value As String)
            mReportFileName = value

        End Set
    End Property


    Property ReportDescription() As String
        Get
            ReportDescription = mReportDescription

        End Get
        Set(ByVal value As String)
            mReportDescription = value

        End Set
    End Property


    Property ReportTitle() As String
        Get
            ReportTitle = mReportTitle

        End Get
        Set(ByVal value As String)
            mReportTitle = value

        End Set
    End Property
End Class
Public Class QBEReports
    Inherits CollectionBase
    Public Function Add(ByVal ReportTitle As String, ByVal ReportName As String, ByVal ReportDescription As String) As QBEReport
        Dim x As New QBEReport
        With x
            .ReportDescription = ReportDescription
            .ReportFileName = ReportName
            .ReportTitle = ReportTitle

        End With
        List.Add(x)
        Return (x)
    End Function

    Property Item(ByVal Index As Integer) As QBEReport
        Get
            Item = List.Item(Index)
        End Get
        Set(ByVal value As QBEReport)
            List.Item(Index) = value
        End Set
    End Property


End Class


Public Class QBEColumns
    Inherits CollectionBase

    Public Function Add(ByVal DbColumn As BasicDAL.DbColumn, Optional ByVal FriendlyName As String = "", Optional ByVal DisplayFormat As String = "", Optional ByVal QBEValue As Object = "", Optional ByVal UseInQBE As Boolean = True, Optional ByVal DisplayInQBEResult As Boolean = True, Optional ByVal ColumnWidth As Integer = 0) As QBEColumn
        Dim x As New QBEColumn

        Return Me.Add(DbColumn, FriendlyName, DisplayFormat, QBEValue, UseInQBE, DisplayInQBEResult, QBEColumnsTypes.TextBox, ColumnWidth)

    End Function
    Public Function Add(ByVal DbColumn As BasicDAL.DbColumn, ByVal FriendlyName As String, ByVal DisplayFormat As String, ByVal QBEValue As Object, ByVal UseInQBE As Boolean, ByVal DisplayInQBEResult As Boolean, ByVal QBEColumnType As QBEColumnsTypes, ByVal ColumnWidth As Integer) As QBEColumn
        Dim x As New QBEColumn


        With x
            .DbCOlumn = DbColumn
            .UseInQBE = UseInQBE
            .QBEValue = QBEValue
            .FriendlyName = FriendlyName
            .DisplayInQBEResult = DisplayInQBEResult
            .DisplayFormat = DisplayFormat
            .QBEColumnType = QBEColumnType
            .ColumnWidth = ColumnWidth
        End With

        If Trim(x.FriendlyName) = "" Then x.FriendlyName = x.DbCOlumn.FriendlyName

        List.Add(x)
        Return (x)
    End Function


    Property Item(ByVal Index As Integer) As QBEColumn
        Get
            Item = List.Item(Index)
        End Get
        Set(ByVal value As QBEColumn)
            List.Item(Index) = value
        End Set
    End Property


End Class
Public Class DbColumnMapping
    Private mQBEDbColumn As BasicDAL.DbColumn
    Private mTargetDbColumn As BasicDAL.DbColumn

    Property QBEDbColumn() As BasicDAL.DbColumn
        Get
            QBEDbColumn = mQBEDbColumn
        End Get
        Set(ByVal value As BasicDAL.DbColumn)
            mQBEDbColumn = value

        End Set
    End Property

    Property TargetDbColumn() As BasicDAL.DbColumn
        Get
            TargetDbColumn = mTargetDbColumn
        End Get
        Set(ByVal value As BasicDAL.DbColumn)
            mTargetDbColumn = value
        End Set
    End Property

    Sub New()

    End Sub
    Sub New(ByVal QBEDbColumn As BasicDAL.DbColumn, ByVal TargetDbColumn As BasicDAL.DbColumn)
        mQBEDbColumn = QBEDbColumn
        mTargetDbColumn = TargetDbColumn

    End Sub
End Class

Public Class DbColumnsMapping
    Inherits CollectionBase


    Public Function Add(ByVal QBEDbColumn As BasicDAL.DbColumn, ByVal TargetDbColumn As BasicDAL.DbColumn) As DbColumnMapping
        Dim x As New DbColumnMapping
        x.QBEDbColumn = QBEDbColumn
        x.TargetDbColumn = TargetDbColumn
        List.Add(x)
        Return (x)
    End Function

    Property Item(ByVal Index As Integer) As DbColumnMapping
        Get
            Item = List.Item(Index)
        End Get
        Set(ByVal value As DbColumnMapping)
            List.Item(Index) = value
        End Set
    End Property


End Class

#Region "QBEBoundControl Class"

Public Class QBEBoundControl
    Private mControl As Object
    Private mDbColumn As BasicDAL.DbColumn
    Private mPropertyName As String

    Property PropertyName() As String
        Get
            PropertyName = mPropertyName

        End Get
        Set(ByVal value As String)
            mPropertyName = value
        End Set
    End Property
    Property DbColumn() As BasicDAL.DbColumn
        Get
            DbColumn = mDbColumn

        End Get
        Set(ByVal value As BasicDAL.DbColumn)
            mDbColumn = value

        End Set
    End Property
    Property Control() As Object
        Get
            Control = mControl

        End Get
        Set(ByVal value As Object)

            mControl = value
        End Set
    End Property


End Class

Public Class QBEBoundControls
    Inherits System.Collections.CollectionBase

    Public Function Add(ByVal QBEBoundControl As QBEBoundControl) As Boolean
        Try
            List.Add(QBEBoundControl)
            Return (True)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Add(ByVal DbColumn As BasicDAL.DbColumn, ByVal Control As Object, ByVal PropertyName As String) As Boolean

        Dim QBEc As New QBEBoundControl
        With QBEc
            .Control = Control
            .DbColumn = DbColumn
            .PropertyName = PropertyName
        End With
        Try
            List.Add(QBEc)
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function


End Class


#End Region


<Serializable>
Public Class QBEFormReport

    Public ReportTitle As String
    Public ReportDescription As String
    Public ReportFileName As String

End Class
<Serializable>
Public Enum QbeMode
    Query = 0
    Report = 1
End Enum
<Serializable>
Public Enum ReportViewerMode
    WEB = 0
    PDFUrl = 1
    PDFStream = 2
End Enum
Public Enum UseInQBEEnum
    UseInQUE = True
    DoNotUseInQBE = False
End Enum
<Serializable>
Public Enum QBEResultMode
    BoundControls = 0
    AllRows = 2
    SingleRow = 1
    SelectedRows = 3
    DataTable = 4
    DBObject = 5
End Enum
<Serializable>
Public Enum QBEColumnsTypes
    CheckBox = 0
    ComboBox = 1
    Image = 2
    Link = 3
    TextBox = 4
End Enum