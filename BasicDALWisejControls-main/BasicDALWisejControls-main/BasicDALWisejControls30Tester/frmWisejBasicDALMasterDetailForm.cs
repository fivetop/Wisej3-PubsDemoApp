using System;
using Wisej.Web;

namespace RetailProWebDesktop
{
    public partial class frmWisejBasicDALMasterDetailForm : Form
    {
        public frmWisejBasicDALMasterDetailForm()
        {
            InitializeComponent();
        }

        AppConfig appConfig = new AppConfig();
        DbT_NonConformitaDDT DbT_NonConformitaDDT = new DbT_NonConformitaDDT();
        DbT_RigheNonConformitaDDT DbT_RigheNonConformitaDDT = new DbT_RigheNonConformitaDDT();
        DbT_Fornitori DbT_Fornitori = new DbT_Fornitori();
        DbV_PuntiVendita DbV_PuntiVendita = new DbV_PuntiVendita();
        BasicDAL.DbLookUp DbL_PuntiVendita = new BasicDAL.DbLookUp();
        BasicDAL.DbLookUp DbL_Fornitori = new BasicDAL.DbLookUp();
        DbT_AllegatiNC DbT_AllegatiNC = new DbT_AllegatiNC();


        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        //public CXMLSession.SessionManager SessionManager = new CXMLSession.SessionManager();
        //public CXMLSession.SessionStore SessionStore = new CXMLSession.SessionStore();
        public BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();

        private void Init(bool ForceFormInit = false)
        {

            this.appConfig.ReadWebConfigAppConfig();

            if (ForceFormInit == true)
            {
                FormInit = false;
            }

            if (this.FormInit)
            {
                return;
            }
            //this.SessionStore.StoreMode = CXMLSession.SessionStore.StoreModes.MemoryMapped;
            //this.SessionStore.ID = Application.SessionId.ToString();
            this.DbConfig.RuntimeUI = BasicDAL.RuntimeUI.Wisej;
            BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();

            this.DbConfig.Provider = BasicDAL.Providers.SqlServer;
            this.DbConfig.ServerName = appConfig.DbConfigServerName;
            this.DbConfig.DataBaseName = appConfig.DbConfigDataBaseName;
            this.DbConfig.UserName = appConfig.DbConfigUserName;
            this.DbConfig.Password = appConfig.DbConfigPassword;
            this.DbConfig.AuthenticationMode = appConfig.DbConfigAuthenticationMode;


            //this.DbConfig.SuppressErrorsNotification = true;
            //this.DbObject.SuppressErrorsNotification = true;

            this.DbT_NonConformitaDDT.SuppressErrorsNotification = false;
            this.DbT_RigheNonConformitaDDT.SuppressErrorsNotification = false;

            this.DbConfig.RedirectErrorsNotificationTo = BasicDALMessageBox;

            InitDataNavigatorHandler();

            this.DbT_NonConformitaDDT.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            //this.dbT_RigheNonConformitaDDT.DataBinding = BasicDAL.DataBoundControlsBehaviour.NoDataBinding;

            //binding oggetti UI
            this.DbT_NonConformitaDDT.idnonconformita.BoundControls.Add(this.txt_IDNonConformita, "text");
            this.DbT_NonConformitaDDT.dataregistrazione.BoundControls.Add(this.txt_DataRegistrazione, "text");
            this.DbT_NonConformitaDDT.dataddt.BoundControls.Add(this.dtp_DataDDT, "value");

            this.DbT_NonConformitaDDT.numeroddt.BoundControls.Add(this.txt_NumeroDDT, "text");

            this.DbT_NonConformitaDDT.progressivononconformità.BoundControls.Add(this.txt_ProgressivoNonConformità, "text");
            this.DbT_NonConformitaDDT.codicepdv.BoundControls.Add(this.txt_CodicePDV, "text");
            this.DbT_NonConformitaDDT.codicefornitore.BoundControls.Add(this.txt_CodiceFornitore, "text");
            this.DbT_NonConformitaDDT.statononconformita.BoundControls.Add(this.txt_StatoNonConformita, "text");
            this.DbT_NonConformitaDDT.dataelaborazionecoge.BoundControls.Add(this.txt_DataElaborazioneCOGE, "text");
            this.DbT_NonConformitaDDT.note.BoundControls.Add(this.txt_NOTE, "text");



            //this.DbObject.dbstring.ValidationType = BasicDAL.ValidationTypes.Equal;

            //this.DbObject.dbstring.ValidationExpression = "A";
            //this.DbObject.dbstring.ValidationMessage = "HAI CANNATO!!!";
            //    this.DbObject.dbstring.ValidationDataType = BasicDAL.ValidationDataType.String;
            //System.ComponentModel.BindingList<poco_dbo_TestTable> poco = new System.ComponentModel.BindingList<poco_dbo_TestTable>();

            //inizializza fornitori e punti vendita
            this.DbT_Fornitori.Init(DbConfig);
            this.DbV_PuntiVendita.Init(DbConfig);

            // definizione dei DBLOOKCUP per PuntiVendita
            this.DbL_PuntiVendita.DbObject = this.DbV_PuntiVendita;
            // dichiara un filtro per il dblookup DbL_PuntiVendita associando al campo a5cdne (codice negozio) il valore a runtime del textbox txt_CodicePDV. 
            this.DbL_PuntiVendita.Filters.AddBoundControl(this.DbV_PuntiVendita.a5cdne, BasicDAL.ComparisionOperator.Equal, this.txt_CodicePDV, "text", BasicDAL.LogicOperator.None);
            // per il dblookup DbL_PuntiVendita ritorna il valore del campo a5dene (descrizione negozio) nella property text dell'oggetto lbl_CodicePDV
            this.DbL_PuntiVendita.BoundControls.Add(this.DbV_PuntiVendita.a5dene, this.lbl_CodicePDV, "text");


            this.DbL_Fornitori.DbObject = this.DbT_Fornitori;
            this.DbL_Fornitori.Filters.AddBoundControl(this.DbT_Fornitori.codicefornitore, BasicDAL.ComparisionOperator.Equal, this.txt_CodiceFornitore, "text", BasicDAL.LogicOperator.None);
            this.DbL_Fornitori.BoundControls.Add(this.DbT_Fornitori.nominativofornitore, this.lbl_CodiceFornitore, "text");


            // inizializza gli oggetti database con la configurazione presente in DBConfig
            this.DbT_NonConformitaDDT.Init(DbConfig);
            this.DbT_RigheNonConformitaDDT.Init(DbConfig);
            // l'aggiornamento batch va disabilitato quando un oggetto database (DbObject) viene associato ad una griglia e si vuole aggiornare tutti i dati modificati nella griglia
            // in questo caso vogliamo salvare tutte le modifiche fatte nella griglia della righe articolo.
            this.DbT_RigheNonConformitaDDT.UpdateBatchEnabled = false;

            //Gestione visibilità dei pv per l'utente loggato
            if (Application.Session.SESSION_UTENTE_LOGGATO_RUOLO != "A") //A=admin, P=utente di punto vendita
            {
                string objFiltro = (string)Application.Session.SESSION_UTENTE_LOGGATO_PV;
               // var arObjFiltro = objFiltro.Split(separatore);

                //BasicDAL.DbFilters fDB = new BasicDAL.DbFilters();
                //fDB.Add(this.DbT_NonConformitaDDT.codicepdv, BasicDAL.ComparisionOperator.In, arObjFiltro);
                //this.DbT_NonConformitaDDT.FiltersGroup.Clear();
                //this.DbT_NonConformitaDDT.FiltersGroup.Add(fDB);
            }
            else
            {
                this.txt_CodicePDV.ReadOnly = false;
            }

            this.DbT_NonConformitaDDT.LoadAll();

            //Gestione Allegati
            this.DbT_AllegatiNC.Init(DbConfig);

            // carico le righe del DDT nella griglia
            this.CaricaRigheNCDDT();
            this.DbT_AllegatiNC.SuppressErrorsNotification = false;
            this.DbT_AllegatiNC.UpdateBatchEnabled = false;


            this.dataNavigator1.DbObject = this.DbT_NonConformitaDDT;
            // non gestisco automaticamente la navigazione (debbo quindi gestire il codice negli eventi)
            this.dataNavigator1.ManageNavigation = false;

            // associo la griglia delle righe articolo al datanavigator
            this.dataNavigator1.DataGrid = this.dgv_RigheNC;
            // tuttavia la griglia non è attiva. Si attiva solo se viene premuto il bottone "Articoli NC"
            this.dataNavigator1.DataGridActive = false;

            // gestice l'aspetto dei bottoni di selezione delle varie sezioni (testata, righe, note, allegati)
            ImpostaSezioneTestata();






        }
        private void InitDataNavigatorHandler()
        {
            // la dichiarazione di tutti gli eventi che emette il datanavigator
            if (DataNavigatorHandlerInitialized == true)
            {
                return;
            }

            this.dataNavigator1.eAddNew -= new BasicDALWisejControls.DataNavigator.eAddNewEventHandler(this.dataNavigator1_eAddNew);
            this.dataNavigator1.eAddNew += new BasicDALWisejControls.DataNavigator.eAddNewEventHandler(this.dataNavigator1_eAddNew);
            this.dataNavigator1.ePrint -= new BasicDALWisejControls.DataNavigator.ePrintEventHandler(this.dataNavigator1_ePrint);
            this.dataNavigator1.ePrint += new BasicDALWisejControls.DataNavigator.ePrintEventHandler(this.dataNavigator1_ePrint);
            this.dataNavigator1.eDelete -= new BasicDALWisejControls.DataNavigator.eDeleteEventHandler(this.dataNavigator1_eDelete);
            this.dataNavigator1.eDelete += new BasicDALWisejControls.DataNavigator.eDeleteEventHandler(this.dataNavigator1_eDelete);
            this.dataNavigator1.eRefresh -= new BasicDALWisejControls.DataNavigator.eRefreshEventHandler(this.dataNavigator1_eRefresh);
            this.dataNavigator1.eRefresh += new BasicDALWisejControls.DataNavigator.eRefreshEventHandler(this.dataNavigator1_eRefresh);
            this.dataNavigator1.eClose -= new BasicDALWisejControls.DataNavigator.eCloseEventHandler(this.dataNavigator1_eClose);
            this.dataNavigator1.eClose += new BasicDALWisejControls.DataNavigator.eCloseEventHandler(this.dataNavigator1_eClose);
            this.dataNavigator1.eFind -= new BasicDALWisejControls.DataNavigator.eFindEventHandler(this.dataNavigator1_eFind);
            this.dataNavigator1.eFind += new BasicDALWisejControls.DataNavigator.eFindEventHandler(this.dataNavigator1_eFind);
            this.dataNavigator1.eSave -= new BasicDALWisejControls.DataNavigator.eSaveEventHandler(this.dataNavigator1_eSave);
            this.dataNavigator1.eSave += new BasicDALWisejControls.DataNavigator.eSaveEventHandler(this.dataNavigator1_eSave);
            this.dataNavigator1.eMovePrevious -= new BasicDALWisejControls.DataNavigator.eMovePreviousEventHandler(this.dataNavigator1_eMovePrevious);
            this.dataNavigator1.eMovePrevious += new BasicDALWisejControls.DataNavigator.eMovePreviousEventHandler(this.dataNavigator1_eMovePrevious);
            this.dataNavigator1.eMoveFirst -= new BasicDALWisejControls.DataNavigator.eMoveFirstEventHandler(this.dataNavigator1_eMoveFirst);
            this.dataNavigator1.eMoveFirst += new BasicDALWisejControls.DataNavigator.eMoveFirstEventHandler(this.dataNavigator1_eMoveFirst);
            this.dataNavigator1.eMoveLast -= new BasicDALWisejControls.DataNavigator.eMoveLastEventHandler(this.dataNavigator1_eMoveLast);
            this.dataNavigator1.eMoveLast += new BasicDALWisejControls.DataNavigator.eMoveLastEventHandler(this.dataNavigator1_eMoveLast);
            this.dataNavigator1.eMoveNext -= new BasicDALWisejControls.DataNavigator.eMoveNextEventHandler(this.dataNavigator1_eMoveNext);
            this.dataNavigator1.eMoveNext += new BasicDALWisejControls.DataNavigator.eMoveNextEventHandler(this.dataNavigator1_eMoveNext);
            this.dataNavigator1.eUndo -= new BasicDALWisejControls.DataNavigator.eUndoEventHandler(this.dataNavigator1_eUndo);
            this.dataNavigator1.eUndo += new BasicDALWisejControls.DataNavigator.eUndoEventHandler(this.dataNavigator1_eUndo);

            // REQUEST viene emesso PRIMA che l'operazione venga effettuata sui dati.
            //this.dataNavigator1.eAddNewRequest -= new BasicDALWisejControls.DataNavigator.eAddNewRequestEventHandler(this.dataNavigator1_eAddNewRequest);
            //this.dataNavigator1.ePrintRequest -= new BasicDALWisejControls.DataNavigator.ePrintRequestEventHandler(this.dataNavigator1_ePrintRequest);
            //this.dataNavigator1.eDeleteRequest -= new BasicDALWisejControls.DataNavigator.eDeleteRequestEventHandler(this.dataNavigator1_eDeleteRequest);
            //this.dataNavigator1.eRefreshRequest -= new BasicDALWisejControls.DataNavigator.eRefreshRequestEventHandler(this.dataNavigator1_eRefreshRequest);
            //this.dataNavigator1.eCloseRequest -= new BasicDALWisejControls.DataNavigator.eCloseRequestEventHandler(this.dataNavigator1_eCloseRequest);
            //this.dataNavigator1.eFindRequest -= new BasicDALWisejControls.DataNavigator.eFindRequestEventHandler(this.dataNavigator1_eFindRequest);
            //this.dataNavigator1.eSaveRequest -= new BasicDALWisejControls.DataNavigator.eSaveRequestEventHandler(this.dataNavigator1_eSaveRequest);
            //this.dataNavigator1.eMovePreviousRequest -= new BasicDALWisejControls.DataNavigator.eMovePreviousRequestEventHandler(this.dataNavigator1_eMovePreviousRequest);
            //this.dataNavigator1.eMoveFirstRequest -= new BasicDALWisejControls.DataNavigator.eMoveFirstRequestEventHandler(this.dataNavigator1_eMoveFirstRequest);
            //this.dataNavigator1.eMoveLastRequest -= new BasicDALWisejControls.DataNavigator.eMoveLastRequestEventHandler(this.dataNavigator1_eMoveLastRequest);
            //this.dataNavigator1.eMoveNextRequest -= new BasicDALWisejControls.DataNavigator.eMoveNextRequestEventHandler(this.dataNavigator1_eMoveNextRequest);
            //this.dataNavigator1.eUndoRequest -= new BasicDALWisejControls.DataNavigator.eUndoRequestEventHandler(this.dataNavigator1_eUndoRequest);

            //this.dataNavigator1.eAddNewRequest += new BasicDALWisejControls.DataNavigator.eAddNewRequestEventHandler(this.dataNavigator1_eAddNewRequest);
            //this.dataNavigator1.ePrintRequest += new BasicDALWisejControls.DataNavigator.ePrintRequestEventHandler(this.dataNavigator1_ePrintRequest);
            //this.dataNavigator1.eDeleteRequest += new BasicDALWisejControls.DataNavigator.eDeleteRequestEventHandler(this.dataNavigator1_eDeleteRequest);
            //this.dataNavigator1.eRefreshRequest += new BasicDALWisejControls.DataNavigator.eRefreshRequestEventHandler(this.dataNavigator1_eRefreshRequest);
            //this.dataNavigator1.eCloseRequest += new BasicDALWisejControls.DataNavigator.eCloseRequestEventHandler(this.dataNavigator1_eCloseRequest);
            //this.dataNavigator1.eFindRequest += new BasicDALWisejControls.DataNavigator.eFindRequestEventHandler(this.dataNavigator1_eFindRequest);
            //this.dataNavigator1.eSaveRequest += new BasicDALWisejControls.DataNavigator.eSaveRequestEventHandler(this.dataNavigator1_eSaveRequest);
            //this.dataNavigator1.eMovePreviousRequest += new BasicDALWisejControls.DataNavigator.eMovePreviousRequestEventHandler(this.dataNavigator1_eMovePreviousRequest);
            //this.dataNavigator1.eMoveFirstRequest += new BasicDALWisejControls.DataNavigator.eMoveFirstRequestEventHandler(this.dataNavigator1_eMoveFirstRequest);
            //this.dataNavigator1.eMoveLastRequest += new BasicDALWisejControls.DataNavigator.eMoveLastRequestEventHandler(this.dataNavigator1_eMoveLastRequest);
            //this.dataNavigator1.eMoveNextRequest += new BasicDALWisejControls.DataNavigator.eMoveNextRequestEventHandler(this.dataNavigator1_eMoveNextRequest);
            //this.dataNavigator1.eUndoRequest += new BasicDALWisejControls.DataNavigator.eUndoRequestEventHandler(this.dataNavigator1_eUndoRequest);

            DataNavigatorHandlerInitialized = true;
        }
        private void Window1_Load(object sender, EventArgs e)
        {
            Init();
        }


        private void ManageTabDataNavigator(string Item)
        {
            switch (Item.ToLower())
            {
                case "tabform":
                    this.dataNavigator1.DataGridActive = false;
                    break;

                case "tablist":
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                    break;

                default:
                    break;
            }
        }
        private void dataNavigator1_eFind()
        {
            // ricerca delle testata DDT
            DbT_NonConformitaDDT QBEDbObject = new DbT_NonConformitaDDT();
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;// ' torna tutte le righe selezionate
            QBEForm.CallerForm = this;
            QBEForm.Text = "Ricerca " + this.Text;

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.DbT_NonConformitaDDT;
            QBEForm.AutoLoadAll = true;
            QBEForm.DbColumnsMapping.Add(QBEDbObject.idnonconformita, this.DbT_NonConformitaDDT.idnonconformita);
            //QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);

        }

        private void dataNavigator1_ePrint()
        {

            DbT_NonConformitaDDT QBEDbObject = new DbT_NonConformitaDDT();
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Report;
            QBEForm.ReportsPath = @"C:\camping\WisejDemo\WisejDemo\Reports";
            //QBEForm.AddReport("Report","Report.rpt", "Descrizione del report");

            //QBEForm.DefaultReport= QBEForm .Reports["Report"];
            //QBEForm.Text = "Stampa " + this.Text;
            //QBEForm.ReportViewerMode = BasicDALWisejControls.ReportViewerMode.PDFStream;
            QBEForm.CrystalReportViewerPage = Application.StartupUrl + "CrystalReportViewer.aspx";
            QBEForm.DbObject = QBEDbObject;

            QBEForm.ShowQBE(this);

        }

        private void dataNavigator1_eAddNew()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.AddNew();

                this.CaricaRigheNCDDT();

                //Disabilito pulsante ARTICOLI NC in testata per evitare aggiunta di
                //una riga per una testata ancora da salvare
                this.btnArticoliNC.Enabled = false;
            }
            else
            {
                // genera i valori della chiave primaria da inserire nelle righe articolo
                this.dataNavigator1.DataGrid_AddNew();
                if (this.dataNavigator1.Caption == "Articoli NC")
                {
                    //Righe Articoli
                    this.dgv_RigheNC.CurrentRow[dgvc_IDNonConformita].Value = this.DbT_NonConformitaDDT.idnonconformita.Value;
                    this.dgv_RigheNC.CurrentRow[dgvc_IDRigaNonConformita].Value = this.DbT_RigheNonConformitaDDT.OttieniNuovoIDRigaNC(Convert.ToInt32(this.DbT_NonConformitaDDT.idnonconformita.Value));
                }
                else
                {
                    //Righe Allegati
                    this.dgvAllegatii.CurrentRow[dgvcAllegati_IDNonConformita].Value = this.DbT_NonConformitaDDT.idnonconformita.Value;
                    this.dgvAllegatii.CurrentRow[dgvcAllegati_NumeroAllegato].Value = this.DbT_AllegatiNC.OttieniNuovoIDAllegatoPerDDTNC(Convert.ToInt32(this.DbT_NonConformitaDDT.idnonconformita.Value));
                    this.upl_allegaFileNC.Enabled = true;
                }



            }
        }

        private void dataNavigator1_eClose()
        {
            this.Close();
        }

        private void dataNavigator1_eDelete()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.Delete();
            }
            else
            {
                this.dataNavigator1.DataGrid_Delete();
            }
        }

        private void dataNavigator1_eMoveFirst()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveFirst();
            }
            else
            {
                this.dataNavigator1.DataGrid_MoveFirst();
            }

        }

        private void dataNavigator1_eMoveLast()
        {

            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveLast();
            }
            else
            {
                this.dataNavigator1.DataGrid_MoveLast();
            }
        }

        private void dataNavigator1_eMoveNext()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MoveNext();
            }
            else
            {
                this.dataNavigator1.DataGrid_MoveNext();
            }
        }

        private void dataNavigator1_eMovePrevious()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.MovePrevious();
            }
            else
            {
                this.dataNavigator1.DataGrid_MovePrevious();
            }
        }

        private void dataNavigator1_eRefresh()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.LoadAll();
            }
            else
            {
                this.dataNavigator1.DbObject.LoadAll();
                this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
            }
        }

        private void dataNavigator1_eSave()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.Update();

                //Riabilito pulsante ARTICOLI NC in testata
                this.btnArticoliNC.Enabled = true;
            }
            else
            {
                this.dataNavigator1.DataGrid_Update();
                if (this.dataNavigator1.Caption == "Allegati NC")
                {
                    this.upl_allegaFileNC.Enabled = false;
                    this.dataNavigator1.DisablePrint();
                    this.dataNavigator1.DisableFind();
                }
            }
        }

        private void dataNavigator1_eUndo()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.UndoChanges();

                //Riabilito pulsante ARTICOLI NC in testata
                this.btnArticoliNC.Enabled = true;
            }
            else
            {
                this.dataNavigator1.DataGrid_Undo();
                if (this.dataNavigator1.Caption == "Allegati NC")
                {
                    this.upl_allegaFileNC.Enabled = false;
                    this.dataNavigator1.DisablePrint();
                    this.dataNavigator1.DisableFind();
                }
            }
        }

        private void dataNavigator1_eSaveRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eDeleteRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eAddNewRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eCloseRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eUndoRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_ePrintRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eRefreshRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMovePreviousRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveNextRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveLastRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eMoveFirstRequest(ref bool Cancel)
        {

        }

        private void dataNavigator1_eFindRequest(ref bool Cancel)
        {

        }

        private void tabDataNavigator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void frmRilevazioneNCDDT_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void txt_IDNonConformita_TextChanged(object sender, EventArgs e)
        {
            this.CaricaRigheNCDDT();
        }

        private void dataNavigator1_eBoundCompleted()
        {

            // this.CaricaRigheNCDDT();
        }


        private void CaricaRigheNCDDT()
        {

            BasicDAL.DbFilters fDB = new BasicDAL.DbFilters();
            fDB.Add(this.DbT_RigheNonConformitaDDT.idnonconformita, BasicDAL.ComparisionOperator.Equal, this.DbT_NonConformitaDDT.idnonconformita.Value);
            this.DbT_RigheNonConformitaDDT.OrderBy = this.DbT_RigheNonConformitaDDT.idriganonconformita.DbColumnName;
            this.DbT_RigheNonConformitaDDT.FiltersGroup.Clear();
            this.DbT_RigheNonConformitaDDT.FiltersGroup.Add(fDB);
            this.DbT_RigheNonConformitaDDT.LoadAll();
            this.dgv_RigheNC.DataSource = this.DbT_RigheNonConformitaDDT.GetDataTable();
        }

        private void CaricaRigheAllegatiNC()
        {

            BasicDAL.DbFilters fDB = new BasicDAL.DbFilters();
            fDB.Add(this.DbT_AllegatiNC.idnonconformita, BasicDAL.ComparisionOperator.Equal, this.DbT_NonConformitaDDT.idnonconformita.Value);
            this.DbT_AllegatiNC.OrderBy = this.DbT_AllegatiNC.numeroallegato.DbColumnName;
            this.DbT_AllegatiNC.FiltersGroup.Clear();
            this.DbT_AllegatiNC.FiltersGroup.Add(fDB);
            this.DbT_AllegatiNC.LoadAll();
            this.dgvAllegatii.DataSource = this.DbT_AllegatiNC.GetDataTable();
        }





        private void txt_CodicePDV_ToolClick(object sender, ToolClickEventArgs e)
        {
            // invoca la ricerca del PDV
            qbePDV();
        }




        private void txt_CodiceFornitore_ToolClick(object sender, ToolClickEventArgs e)
        {
            // invoca la ricerca dei Fornitori
            qbeFornitori();
        }

        private void qbeFornitori()
        {
            DbT_Fornitori QBEDbObject = new DbT_Fornitori();
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Ricerca Fornitori";

            QBEForm.DbObject = QBEDbObject;
            //QBEForm.QueryDbObject = this.DbV_Fornitori;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.codicefornitore, this.txt_CodiceFornitore, "text");
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.b5cdfo , this.DbT_NonConformitaDDT.codicefornitore);
            //QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);
        }

        private void qbePDV()
        {
            DbV_PuntiVendita QBEDbObject = new DbV_PuntiVendita();
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Ricerca Punti Vendita";
            //QBEForm.QueryDbObject = this.DbV_Fornitori;
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;

            QBEForm.BoundControls.Add(QBEDbObject.a5cdne, this.txt_CodicePDV, "text");

            // Gestione visibilità dei pv per l'utente loggato
            string pvVisibili = "";
            if (Application.Session.SESSION_UTENTE_LOGGATO_RUOLO != "A") //A=admin, P=utente di punto vendita
            {
                pvVisibili = (string)Application.Session.SESSION_UTENTE_LOGGATO_PV;
                QBEForm.QBEColumns.Add(QBEDbObject.a5cdne, "Cod.PDV", "", pvVisibili, false, true);
            }
            else
            {
                QBEForm.QBEColumns.Add(QBEDbObject.a5cdne, "Cod.PDV", "", pvVisibili, true, true);
            }

            QBEForm.QBEColumns.Add(QBEDbObject.a5dene, "Descrizione PDV", "", "", true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.a5indi, "Via", "", "", true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.a5nciv, "Civico", "", "", true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.a5loca, "Luogo", "", "", true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.a5capc, "Cap", "", "", true, true);
            QBEForm.QBEColumns.Add(QBEDbObject.a5prov, "Prov.", "", "", true, true);
            QBEForm.ShowQBE(this);
        }


        private void qbeArticoli(int mode)
        {
            DbV_RicercaArticoli QBEDbObject = new DbV_RicercaArticoli();
            QBEDbObject.Init(this.DbConfig);

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Ricerca Articoli";
            //QBEForm.QueryDbObject = this.DbV_Fornitori;
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;

            QBEForm.BoundControls.Add(QBEDbObject.codicearticolo, this.dgv_RigheNC.CurrentRow[this.dgvc_CodiceArticolo], "Value");
            QBEForm.BoundControls.Add(QBEDbObject.barcode, this.dgv_RigheNC.CurrentRow[this.dgvc_Barcode], "value");
            QBEForm.BoundControls.Add(QBEDbObject.descrizionearticolo, this.dgv_RigheNC.CurrentRow[this.dgvc_DescrizioneArticolo], "value");
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.b5cdfo , this.DbT_NonConformitaDDT.codicefornitore);
            //QBEForm.QBEColumns.Add(QBEDbObject.dbint, "DB INT", "", "1", true, true);
            QBEForm.ShowQBE(this);
        }



        private void ImpostaSezioneArticoliNC()
        {
            DataNavigatorRighe();
            this.panelTestataNC.Enabled = false;

            this.tabPageArticoliNC.Hidden = false;
            this.tabPageNote.Hidden = true;
            this.tabPageAllegati.Hidden = true;

            this.tabControlSezioni.SelectedTab = this.tabPageArticoliNC;
            setbtnbackcolor();
            this.btnArticoliNC.BackColor = System.Drawing.Color.Red;

        }

        private void ImpostaSezioneNote()
        {
            DataNavigatorTestata();
            this.tabPageArticoliNC.Hidden = true;
            this.tabPageNote.Hidden = false;
            this.tabPageAllegati.Hidden = true;
            this.panelTestataNC.Enabled = false;
            this.tabControlSezioni.SelectedTab = this.tabPageNote;
            setbtnbackcolor();
            this.btnNote.BackColor = System.Drawing.Color.Red;

        }

        private void ImpostaSezioneAllegati()
        {
            CaricaRigheAllegatiNC();
            DataNavigatorAllegati();
            this.panelTestataNC.Enabled = false;
            this.tabPageArticoliNC.Hidden = true;
            this.tabPageNote.Hidden = true;
            this.tabPageAllegati.Hidden = false;
            this.tabControlSezioni.SelectedTab = this.tabPageAllegati;
            setbtnbackcolor();
            this.BtnAllegati.BackColor = System.Drawing.Color.Red;
            this.upl_allegaFileNC.Enabled = false;

        }



        private void setbtnbackcolor()
        {
            System.Drawing.Color c = Application.Theme.GetColor("buttonFace");
            this.btnTestataNC.BackColor = c;
            this.btnNote.BackColor = c;
            this.BtnAllegati.BackColor = c;
            this.btnArticoliNC.BackColor = c;

        }
        private void ImpostaSezioneTestata()
        {
            this.panelTestataNC.Enabled = true;
            DataNavigatorTestata();
            this.tabControlSezioni.SelectedTab = this.tabPageArticoliNC;
            this.tabPageArticoliNC.Hidden = false;
            this.tabPageNote.Hidden = true;
            this.tabPageAllegati.Hidden = true;
            setbtnbackcolor();
            this.btnTestataNC.BackColor = System.Drawing.Color.Red;


        }

        private void DataNavigatorTestata()
        {
            this.dataNavigator1.DbObject = this.DbT_NonConformitaDDT;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGrid.Enabled = false;
            this.dataNavigator1.Caption = "Testata NC";

        }

        private void DataNavigatorAllegati()
        {
            this.dataNavigator1.DbObject = this.DbT_AllegatiNC;
            this.dataNavigator1.DataGrid = this.dgvAllegatii;
            this.dataNavigator1.DataGridActive = true;
            this.dataNavigator1.DataGrid.Enabled = true;
            this.dataNavigator1.Caption = "Allegati NC";
            this.dataNavigator1.DisablePrint();
            this.dataNavigator1.DisableFind();

        }
        private void DataNavigatorRighe()
        {
            this.dataNavigator1.DbObject = this.DbT_RigheNonConformitaDDT;
            this.dataNavigator1.DataGridActive = true;
            this.dataNavigator1.DataGrid.Enabled = true;
            this.dataNavigator1.Caption = "Articoli NC";

        }

        private void txt_CodicePDV_TextChanged(object sender, EventArgs e)
        {
            this.DbL_PuntiVendita.LookUpByFilters();
        }

        private void txt_CodiceFornitore_TextChanged(object sender, EventArgs e)
        {
            this.DbL_Fornitori.LookUpByFilters();
        }

        private void btnTestataNC_Click(object sender, EventArgs e)
        {
            ImpostaSezioneTestata();


        }

        private void btnArticoliNC_Click(object sender, EventArgs e)
        {
            ImpostaSezioneArticoliNC();

        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            ImpostaSezioneNote();

        }

        private void BtnAllegati_Click(object sender, EventArgs e)
        {
            ImpostaSezioneAllegati();
        }

        private void dgv_RigheNC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ImpostaSezioneAllegati();
        }

        private void txt_CodicePDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.DbL_PuntiVendita.LookUpByFilters();
        }

        private void txt_CodiceFornitore_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.DbL_Fornitori.LookUpByFilters();
        }

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {

        }

        private void dgvAllegatii_Click(object sender, EventArgs e)
        {

        }
    }
}
