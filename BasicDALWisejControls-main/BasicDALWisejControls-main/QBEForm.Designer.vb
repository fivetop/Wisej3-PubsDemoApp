<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QBEForm
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.ContextMenuRecords = New Wisej.Web.ContextMenu()
        Me.menuRecords100 = New Wisej.Web.MenuItem()
        Me.menuRecords500 = New Wisej.Web.MenuItem()
        Me.menuRecords1000 = New Wisej.Web.MenuItem()
        Me.menuRecords2000 = New Wisej.Web.MenuItem()
        Me.menuRecords5000 = New Wisej.Web.MenuItem()
        Me.menuRecords10000 = New Wisej.Web.MenuItem()
        Me.menuRecordsALL = New Wisej.Web.MenuItem()
        Me.SaveFileDialog = New Wisej.Web.SaveFileDialog(Me.components)
        Me.NavBar = New Wisej.Web.ToolBar()
        Me.bFirst = New Wisej.Web.ToolBarButton()
        Me.bPrev = New Wisej.Web.ToolBarButton()
        Me.RecordLabel = New Wisej.Web.ToolBarButton()
        Me.bNext = New Wisej.Web.ToolBarButton()
        Me.bLast = New Wisej.Web.ToolBarButton()
        Me.bRefresh = New Wisej.Web.ToolBarButton()
        Me.bDelete = New Wisej.Web.ToolBarButton()
        Me.Records = New Wisej.Web.ToolBarButton()
        Me.bPrint = New Wisej.Web.ToolBarButton()
        Me.bSave = New Wisej.Web.ToolBarButton()
        Me.bSaveQBE = New Wisej.Web.ToolBarButton()
        Me.bLoadQBE = New Wisej.Web.ToolBarButton()
        Me.bClose = New Wisej.Web.ToolBarButton()
        Me.TabControl = New Wisej.Web.TabControl()
        Me.TabPageCriteriRicerca = New Wisej.Web.TabPage()
        Me.TabPageEsporta = New Wisej.Web.TabPage()
        Me.TabPageStampe = New Wisej.Web.TabPage()
        Me.TabPageDebug = New Wisej.Web.TabPage()
        Me.dgvcQueryCampo = New Wisej.Web.DataGridViewButtonColumn()
        Me.dgvcValoreCampo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.dgvcNomeCampo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.QueryGrid = New Wisej.Web.DataGridView()
        Me.dgvcReportFileName = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.dgvcDescrizioneReport = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.dgvcNomeReport = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.ReportGrid = New Wisej.Web.DataGridView()
        Me.cmbRecords = New Wisej.Web.ComboBox()
        Me.txtDebug = New Wisej.Web.TextBox()
        Me.PanelEsporta = New Wisej.Web.Panel()
        Me.btnEsporta = New Wisej.Web.Button()
        Me.rbXML = New Wisej.Web.RadioButton()
        Me.rbCSV = New Wisej.Web.RadioButton()
        Me.rbExcel = New Wisej.Web.RadioButton()
        Me.Button1 = New Wisej.Web.Button()
        Me.ResultGrid = New Wisej.Web.DataGridView()
        Me.PdfViewer = New Wisej.Web.PdfViewer()
        Me.WebBrowser = New Wisej.Web.WebBrowser()
        Me.AspNetPanel = New Wisej.Web.AspNetPanel()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.TabControl.SuspendLayout()
        CType(Me.QueryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEsporta.SuspendLayout()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuRecords
        '
        Me.ContextMenuRecords.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.menuRecords100, Me.menuRecords500, Me.menuRecords1000, Me.menuRecords2000, Me.menuRecords5000, Me.menuRecords10000, Me.menuRecordsALL})
        Me.ContextMenuRecords.Name = "ContextMenuRecords"
        '
        'menuRecords100
        '
        Me.menuRecords100.Index = 0
        Me.menuRecords100.Name = "menuRecords100"
        Me.menuRecords100.Tag = "100"
        Me.menuRecords100.Text = "100"
        '
        'menuRecords500
        '
        Me.menuRecords500.Index = 1
        Me.menuRecords500.Name = "menuRecords500"
        Me.menuRecords500.Tag = "500"
        Me.menuRecords500.Text = "500"
        '
        'menuRecords1000
        '
        Me.menuRecords1000.Index = 2
        Me.menuRecords1000.Name = "menuRecords1000"
        Me.menuRecords1000.Tag = "1000"
        Me.menuRecords1000.Text = "1000"
        '
        'menuRecords2000
        '
        Me.menuRecords2000.Index = 3
        Me.menuRecords2000.Name = "menuRecords2000"
        Me.menuRecords2000.Tag = "2000"
        Me.menuRecords2000.Text = "2000"
        '
        'menuRecords5000
        '
        Me.menuRecords5000.Index = 4
        Me.menuRecords5000.Name = "menuRecords5000"
        Me.menuRecords5000.Tag = "5000"
        Me.menuRecords5000.Text = "5000"
        '
        'menuRecords10000
        '
        Me.menuRecords10000.Index = 5
        Me.menuRecords10000.Name = "menuRecords10000"
        Me.menuRecords10000.Tag = "10000"
        Me.menuRecords10000.Text = "10000"
        '
        'menuRecordsALL
        '
        Me.menuRecordsALL.Index = 6
        Me.menuRecordsALL.Name = "menuRecordsALL"
        Me.menuRecordsALL.Tag = "0"
        Me.menuRecordsALL.Text = "0"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.FileName = "SaveFileDialog"
        '
        'NavBar
        '
        Me.NavBar.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.NavBar.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.bFirst, Me.bPrev, Me.RecordLabel, Me.bNext, Me.bLast, Me.bRefresh, Me.bDelete, Me.Records, Me.bPrint, Me.bSave, Me.bSaveQBE, Me.bLoadQBE, Me.bClose})
        Me.NavBar.Dock = Wisej.Web.DockStyle.Bottom
        Me.NavBar.Font = New System.Drawing.Font("default", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.NavBar.Location = New System.Drawing.Point(0, 431)
        Me.NavBar.Margin = New Wisej.Web.Padding(0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(692, 49)
        Me.NavBar.TabIndex = 7
        Me.NavBar.TabStop = False
        '
        'bFirst
        '
        Me.bFirst.ImageSource = "icon-first"
        Me.bFirst.Name = "bFirst"
        Me.bFirst.Text = "Inizio"
        '
        'bPrev
        '
        Me.bPrev.ImageSource = "icon-left"
        Me.bPrev.Name = "bPrev"
        Me.bPrev.Text = "Prec."
        '
        'RecordLabel
        '
        Me.RecordLabel.Enabled = False
        Me.RecordLabel.Name = "RecordLabel"
        Me.RecordLabel.Text = "0/0"
        '
        'bNext
        '
        Me.bNext.ImageSource = "icon-right"
        Me.bNext.Name = "bNext"
        Me.bNext.Text = "Succ."
        '
        'bLast
        '
        Me.bLast.ImageSource = "icon-last"
        Me.bLast.Name = "bLast"
        Me.bLast.Text = "Fine"
        '
        'bRefresh
        '
        Me.bRefresh.ImageSource = "icon-redo"
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Text = "Aggiorna"
        '
        'bDelete
        '
        Me.bDelete.ImageSource = "tab-close"
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Text = "Elimina Filtro"
        '
        'Records
        '
        Me.Records.DropDownMenu = Me.ContextMenuRecords
        Me.Records.Name = "Records"
        Me.Records.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton
        Me.Records.Text = "Max Rows"
        '
        'bPrint
        '
        Me.bPrint.ImageSource = "icon-print"
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Text = "Stampa"
        '
        'bSave
        '
        Me.bSave.ImageSource = "icon-check"
        Me.bSave.Name = "bSave"
        Me.bSave.Text = "Seleziona"
        '
        'bSaveQBE
        '
        Me.bSaveQBE.ImageSource = "icon-save"
        Me.bSaveQBE.Name = "bSaveQBE"
        Me.bSaveQBE.Text = "Salva Filtro"
        '
        'bLoadQBE
        '
        Me.bLoadQBE.ImageSource = "icon-open"
        Me.bLoadQBE.Name = "bLoadQBE"
        Me.bLoadQBE.Text = "Carica Filtro"
        '
        'bClose
        '
        Me.bClose.ImageSource = "icon-exit"
        Me.bClose.Name = "bClose"
        Me.bClose.Text = "Chiudi"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageCriteriRicerca)
        Me.TabControl.Controls.Add(Me.TabPageEsporta)
        Me.TabControl.Controls.Add(Me.TabPageStampe)
        Me.TabControl.Controls.Add(Me.TabPageDebug)
        Me.TabControl.Dock = Wisej.Web.DockStyle.Top
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.PageInsets = New Wisej.Web.Padding(1, 40, 1, 1)
        Me.TabControl.Size = New System.Drawing.Size(690, 44)
        Me.TabControl.TabIndex = 0
        '
        'TabPageCriteriRicerca
        '
        Me.TabPageCriteriRicerca.Location = New System.Drawing.Point(1, 40)
        Me.TabPageCriteriRicerca.Name = "TabPageCriteriRicerca"
        Me.TabPageCriteriRicerca.Size = New System.Drawing.Size(688, 3)
        Me.TabPageCriteriRicerca.Text = "Criteri Ricerca"
        '
        'TabPageEsporta
        '
        Me.TabPageEsporta.Hidden = True
        Me.TabPageEsporta.Location = New System.Drawing.Point(1, 40)
        Me.TabPageEsporta.Name = "TabPageEsporta"
        Me.TabPageEsporta.Size = New System.Drawing.Size(688, 3)
        Me.TabPageEsporta.Text = "Esporta"
        '
        'TabPageStampe
        '
        Me.TabPageStampe.Hidden = True
        Me.TabPageStampe.Location = New System.Drawing.Point(1, 40)
        Me.TabPageStampe.Name = "TabPageStampe"
        Me.TabPageStampe.Size = New System.Drawing.Size(688, 3)
        Me.TabPageStampe.Text = "Stampe Disponibili"
        '
        'TabPageDebug
        '
        Me.TabPageDebug.Hidden = True
        Me.TabPageDebug.Location = New System.Drawing.Point(1, 40)
        Me.TabPageDebug.Name = "TabPageDebug"
        Me.TabPageDebug.Padding = New Wisej.Web.Padding(3)
        Me.TabPageDebug.Size = New System.Drawing.Size(688, 3)
        Me.TabPageDebug.Text = "Debug"
        '
        'dgvcQueryCampo
        '
        Me.dgvcQueryCampo.HeaderText = "?"
        Me.dgvcQueryCampo.Name = "dgvcQueryCampo"
        '
        'dgvcValoreCampo
        '
        Me.dgvcValoreCampo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvcValoreCampo.HeaderText = "Valore"
        Me.dgvcValoreCampo.MaxInputLength = 1024
        Me.dgvcValoreCampo.Name = "dgvcValoreCampo"
        '
        'dgvcNomeCampo
        '
        Me.dgvcNomeCampo.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvcNomeCampo.HeaderText = "Campo"
        Me.dgvcNomeCampo.MaxInputLength = 50
        Me.dgvcNomeCampo.Name = "dgvcNomeCampo"
        '
        'QueryGrid
        '
        Me.QueryGrid.AutoGenerateColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromName("@buttonFace")
        Me.QueryGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.QueryGrid.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.dgvcNomeCampo, Me.dgvcValoreCampo, Me.dgvcQueryCampo})
        Me.QueryGrid.Location = New System.Drawing.Point(5, 47)
        Me.QueryGrid.Name = "QueryGrid"
        Me.QueryGrid.RowHeadersWidth = 24
        Me.QueryGrid.Size = New System.Drawing.Size(156, 90)
        Me.QueryGrid.TabIndex = 1
        '
        'dgvcReportFileName
        '
        Me.dgvcReportFileName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvcReportFileName.HeaderText = "Report FileName"
        Me.dgvcReportFileName.Name = "dgvcReportFileName"
        '
        'dgvcDescrizioneReport
        '
        Me.dgvcDescrizioneReport.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvcDescrizioneReport.HeaderText = "Descrizione"
        Me.dgvcDescrizioneReport.Name = "dgvcDescrizioneReport"
        '
        'dgvcNomeReport
        '
        Me.dgvcNomeReport.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgvcNomeReport.HeaderText = "Nome Report"
        Me.dgvcNomeReport.Name = "dgvcNomeReport"
        '
        'ReportGrid
        '
        Me.ReportGrid.AutoGenerateColumns = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromName("@buttonFace")
        Me.ReportGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ReportGrid.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.dgvcNomeReport, Me.dgvcDescrizioneReport, Me.dgvcReportFileName})
        Me.ReportGrid.Location = New System.Drawing.Point(164, 47)
        Me.ReportGrid.Name = "ReportGrid"
        Me.ReportGrid.ReadOnly = True
        Me.ReportGrid.RowHeadersWidth = 24
        Me.ReportGrid.RowTemplate.ReadOnly = True
        Me.ReportGrid.Size = New System.Drawing.Size(160, 90)
        Me.ReportGrid.TabIndex = 2
        '
        'cmbRecords
        '
        Me.cmbRecords.Items.AddRange(New Object() {"100", "500", "1000", "2000", "5000", "10000"})
        Me.cmbRecords.Location = New System.Drawing.Point(111, 143)
        Me.cmbRecords.Name = "cmbRecords"
        Me.cmbRecords.Size = New System.Drawing.Size(68, 30)
        Me.cmbRecords.TabIndex = 4
        Me.cmbRecords.Visible = False
        '
        'txtDebug
        '
        Me.txtDebug.AutoSize = False
        Me.txtDebug.Location = New System.Drawing.Point(5, 143)
        Me.txtDebug.Multiline = True
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.Size = New System.Drawing.Size(100, 22)
        Me.txtDebug.TabIndex = 5
        Me.txtDebug.Text = "Debug"
        Me.txtDebug.Visible = False
        '
        'PanelEsporta
        '
        Me.PanelEsporta.Controls.Add(Me.btnEsporta)
        Me.PanelEsporta.Controls.Add(Me.rbXML)
        Me.PanelEsporta.Controls.Add(Me.rbCSV)
        Me.PanelEsporta.Controls.Add(Me.rbExcel)
        Me.PanelEsporta.Location = New System.Drawing.Point(330, 48)
        Me.PanelEsporta.Name = "PanelEsporta"
        Me.PanelEsporta.Size = New System.Drawing.Size(354, 117)
        Me.PanelEsporta.TabIndex = 6
        Me.PanelEsporta.TabStop = True
        Me.PanelEsporta.Visible = False
        '
        'btnEsporta
        '
        Me.btnEsporta.Anchor = CType((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.btnEsporta.Location = New System.Drawing.Point(247, 9)
        Me.btnEsporta.Name = "btnEsporta"
        Me.btnEsporta.Size = New System.Drawing.Size(100, 27)
        Me.btnEsporta.TabIndex = 3
        Me.btnEsporta.Text = "Esporta"
        '
        'rbXML
        '
        Me.rbXML.Location = New System.Drawing.Point(14, 51)
        Me.rbXML.Name = "rbXML"
        Me.rbXML.Size = New System.Drawing.Size(82, 23)
        Me.rbXML.TabIndex = 2
        Me.rbXML.Text = "File XML"
        '
        'rbCSV
        '
        Me.rbCSV.Location = New System.Drawing.Point(14, 30)
        Me.rbCSV.Name = "rbCSV"
        Me.rbCSV.Size = New System.Drawing.Size(82, 23)
        Me.rbCSV.TabIndex = 1
        Me.rbCSV.Text = "File CSV"
        '
        'rbExcel
        '
        Me.rbExcel.Checked = True
        Me.rbExcel.Location = New System.Drawing.Point(14, 9)
        Me.rbExcel.Name = "rbExcel"
        Me.rbExcel.Size = New System.Drawing.Size(87, 23)
        Me.rbExcel.TabIndex = 0
        Me.rbExcel.TabStop = True
        Me.rbExcel.Text = "File Excel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'ResultGrid
        '
        Me.ResultGrid.AutoGenerateColumns = False
        Me.ResultGrid.DefaultRowHeight = 24
        Me.ResultGrid.KeepSameRowHeight = True
        Me.ResultGrid.Location = New System.Drawing.Point(29, 59)
        Me.ResultGrid.Name = "ResultGrid"
        Me.ResultGrid.ReadOnly = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromName("@buttonFace")
        Me.ResultGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ResultGrid.RowHeadersWidth = 24
        Me.ResultGrid.RowTemplate.Height = 20
        Me.ResultGrid.Size = New System.Drawing.Size(200, 177)
        Me.ResultGrid.TabIndex = 0
        Me.ResultGrid.Visible = False
        '
        'PdfViewer
        '
        Me.PdfViewer.Location = New System.Drawing.Point(566, 59)
        Me.PdfViewer.Name = "PdfViewer"
        Me.PdfViewer.Size = New System.Drawing.Size(98, 135)
        Me.PdfViewer.TabIndex = 1
        Me.PdfViewer.Visible = False
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(465, 59)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(95, 135)
        Me.WebBrowser.TabIndex = 3
        Me.WebBrowser.Url = New System.Uri("~/BasicDalWisejCRViewer.aspx", System.UriKind.Relative)
        Me.WebBrowser.Visible = False
        '
        'AspNetPanel
        '
        Me.AspNetPanel.Location = New System.Drawing.Point(247, 59)
        Me.AspNetPanel.Name = "AspNetPanel"
        Me.AspNetPanel.Size = New System.Drawing.Size(200, 100)
        Me.AspNetPanel.TabIndex = 4
        Me.AspNetPanel.Text = "AspNetPanel"
        Me.AspNetPanel.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New Wisej.Web.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.AspNetPanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WebBrowser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PdfViewer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ResultGrid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelEsporta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDebug)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbRecords)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.QueryGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(692, 431)
        Me.SplitContainer1.SplitterDistance = 267
        Me.SplitContainer1.TabIndex = 0
        '
        'QBEForm
        '
        Me.ClientSize = New System.Drawing.Size(692, 480)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.NavBar)
        Me.IconSource = "icon-search"
        Me.Name = "QBEForm"
        Me.Text = "QBEForm"
        Me.TabControl.ResumeLayout(False)
        CType(Me.QueryGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEsporta.ResumeLayout(False)
        Me.PanelEsporta.PerformLayout()
        CType(Me.ResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuRecords As ContextMenu
    Friend WithEvents menuRecords100 As MenuItem
    Friend WithEvents menuRecords500 As MenuItem
    Friend WithEvents menuRecords1000 As MenuItem
    Friend WithEvents menuRecords2000 As MenuItem
    Friend WithEvents menuRecords5000 As MenuItem
    Friend WithEvents menuRecords10000 As MenuItem
    Friend WithEvents menuRecordsALL As MenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents NavBar As ToolBar
    Friend WithEvents bFirst As ToolBarButton
    Friend WithEvents bPrev As ToolBarButton
    Friend WithEvents RecordLabel As ToolBarButton
    Friend WithEvents bNext As ToolBarButton
    Friend WithEvents bLast As ToolBarButton
    Friend WithEvents bRefresh As ToolBarButton
    Friend WithEvents bDelete As ToolBarButton
    Friend WithEvents Records As ToolBarButton
    Friend WithEvents bPrint As ToolBarButton
    Friend WithEvents bSave As ToolBarButton
    Friend WithEvents bSaveQBE As ToolBarButton
    Friend WithEvents bLoadQBE As ToolBarButton
    Friend WithEvents bClose As ToolBarButton
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageCriteriRicerca As TabPage
    Friend WithEvents TabPageEsporta As TabPage
    Friend WithEvents TabPageStampe As TabPage
    Friend WithEvents TabPageDebug As TabPage
    Private WithEvents dgvcQueryCampo As DataGridViewButtonColumn
    Private WithEvents dgvcValoreCampo As DataGridViewTextBoxColumn
    Private WithEvents dgvcNomeCampo As DataGridViewTextBoxColumn
    Friend WithEvents QueryGrid As DataGridView
    Private WithEvents dgvcReportFileName As DataGridViewTextBoxColumn
    Private WithEvents dgvcDescrizioneReport As DataGridViewTextBoxColumn
    Private WithEvents dgvcNomeReport As DataGridViewTextBoxColumn
    Friend WithEvents ReportGrid As DataGridView
    Friend WithEvents cmbRecords As ComboBox
    Friend WithEvents txtDebug As TextBox
    Friend WithEvents PanelEsporta As Panel
    Friend WithEvents btnEsporta As Button
    Friend WithEvents rbXML As RadioButton
    Friend WithEvents rbCSV As RadioButton
    Friend WithEvents rbExcel As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents ResultGrid As DataGridView
    Friend WithEvents PdfViewer As PdfViewer
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents AspNetPanel As AspNetPanel
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
