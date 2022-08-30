using System;
using Wisej.Web;

namespace RetailProWebDesktop
{
    public partial class frmWisejBasicDALSimpleForm : Form
    {

        AppConfig appConfig = new AppConfig();
        //Db_DBOBJECT Db_DBOBJECT = new Db_DBOBJECT();
        //BasicDAL.DbLookUp DbL_Lookup = new BasicDAL.DbLookUp();
        

        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        //public CXMLSession.SessionManager SessionManager = new CXMLSession.SessionManager();
        //public CXMLSession.SessionStore SessionStore = new CXMLSession.SessionStore();
        public BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();

        public frmWisejBasicDALSimpleForm()
        {
            InitializeComponent();
        }


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
            this.DbConfig.RedirectErrorsNotificationTo = BasicDALMessageBox;

            InitDataNavigatorHandler();


            //binding oggetti UI
            // ES: this.DbT_NonConformitaDDT.idnonconformita.BoundControls.Add(this.txt_IDNonConformita, "text");
            //this.DbObject.dbstring.ValidationType = BasicDAL.ValidationTypes.Equal;
            //this.DbObject.dbstring.ValidationExpression = "A";
            //this.DbObject.dbstring.ValidationMessage = "ERROR!!!";
            //this.DbObject.dbstring.ValidationDataType = BasicDAL.ValidationDataType.String;
            //System.ComponentModel.BindingList<poco_dbo_TestTable> poco = new System.ComponentModel.BindingList<poco_dbo_TestTable>();

            //inizializza DBObjects
            //this.DbT_Fornitori.Init(DbConfig);
            
            // definizione dei DBLOOKCUP per PuntiVendita
            //this.DbL_Lookup.DbObject = this.DbV_PuntiVendita;
            // dichiara un filtro per il dblookup DbL_PuntiVendita associando al campo a5cdne (codice negozio) il valore a runtime del textbox txt_CodicePDV. 
            //this.DbL_PuntiVendita.Filters.AddBoundControl(this.DbV_PuntiVendita.a5cdne, BasicDAL.ComparisionOperator.Equal, this.txt_CodicePDV, "text", BasicDAL.LogicOperator.None);
            // per il dblookup DbL_PuntiVendita ritorna il valore del campo a5dene (descrizione negozio) nella property text dell'oggetto lbl_CodicePDV
            //this.DbL_PuntiVendita.BoundControls.Add(this.DbV_PuntiVendita.a5dene, this.lbl_CodicePDV, "text");


            // l'aggiornamento batch va disabilitato quando un oggetto database (DbObject) viene associato ad una griglia e si vuole aggiornare tutti i dati modificati nella griglia
            // in questo caso vogliamo salvare tutte le modifiche fatte nella griglia della righe articolo.
            //this.DbT_RigheNonConformitaDDT.UpdateBatchEnabled = false;
            // this.DbT_NonConformitaDDT.LoadAll();

            //this.dataNavigator1.DbObject = this.DbT_NonConformitaDDT;
            // non gestisco automaticamente la navigazione (debbo quindi gestire il codice negli eventi)
            this.dataNavigator1.ManageNavigation = false;

            // associo la griglia delle righe articolo al datanavigator
            //this.dataNavigator1.DataGrid = this.dgv_RigheNC;
            // tuttavia la griglia non è attiva. Si attiva solo se viene premuto il bottone "Articoli NC"
            this.dataNavigator1.DataGridActive = false;
            
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
            //QBEForm.QueryDbObject = this.DbT_NonConformitaDDT;
            QBEForm.AutoLoadAll = true;
            //QBEForm.DbColumnsMapping.Add(QBEDbObject.idnonconformita, this.DbT_NonConformitaDDT.idnonconformita);
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
            }
            else
            {
                this.dataNavigator1.DataGrid_AddNew();
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
            }
            else
            {
                this.dataNavigator1.DataGrid_Update();
            }
        }

        private void dataNavigator1_eUndo()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.UndoChanges();
            }
            else
            {
                this.dataNavigator1.DataGrid_Undo();
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

            ManageTabDataNavigator(this.tabDataNavigator.SelectedTab.Name);
        }



        private void dataNavigator1_eBoundCompleted()
        {
          
        }

    }
}
