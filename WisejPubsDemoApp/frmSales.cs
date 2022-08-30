using System;
using Wisej.Web;
namespace WisejPubsDemoApp
{
    public partial class frmSales : Form
    {
        public AppConfig appConfig = new AppConfig();
        private BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();
        private BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();
        private DbT_dbo_salesdetails dbT_Dbo_SalesDetails = new DbT_dbo_salesdetails();
        private DbT_dbo_titles dbT_Dbo_Titles = new DbT_dbo_titles();
        private DbT_dbo_stores dbT_Dbo_Stores = new DbT_dbo_stores();
        private DbT_dbo_salesmaster dbT_Dbo_SalesMaster = new DbT_dbo_salesmaster();
        private BasicDAL.DbLookUp dbl_stor_id = new BasicDAL.DbLookUp();
        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        public frmSales()
        {
            InitializeComponent();
            InitDataNavigatorHandler();
        }  
        private void frmSales_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
        }
        private void InitDataContext(bool ForceFormInit = false)
        {
            if (ForceFormInit == true)
            {
                FormInit = false;
            }
            if (this.FormInit)
            {
                return;
            }
     
            this.DbConfig = this.appConfig.DbConfig.Clone();
            this.DbConfig.RedirectErrorsNotificationTo = this.BasicDALMessageBox;
            this.dbT_Dbo_SalesDetails.Init(this.DbConfig);
            this.dbT_Dbo_Stores.Init(this.DbConfig);
            this.dbT_Dbo_Titles.Init(this.DbConfig);
            this.dbT_Dbo_SalesMaster.Init(this.DbConfig);
            this.dbT_Dbo_SalesMaster.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            //binding for BasicDAL DbObject columns into UI objects.
            this.dbT_Dbo_SalesMaster.DbC_ord_date.BoundControls.Add(this.dtp_ord_date, "value");
            this.dbT_Dbo_SalesMaster.DbC_ord_num.BoundControls.Add(this.txt_ord_num, "text");
            this.dbT_Dbo_SalesMaster.DbC_stor_id.BoundControls.Add(this.txt_stor_id, "text");
            this.dbT_Dbo_SalesMaster.DbC_stor_ord_date.BoundControls.Add(this.dtp_stor_ord_date, "value");
            this.dbT_Dbo_SalesMaster.DbC_stor_ord_num.BoundControls.Add(this.txt_stor_ord_num, "text");
            this.dbT_Dbo_SalesMaster.DbC_payterms.BoundControls.Add(this.cmb_payterms, "text");
            // Declare of DbLookUp 
            this.dbl_stor_id.DbObject = this.dbT_Dbo_Stores;
            this.dbl_stor_id.Filters.AddBoundControl(this.dbT_Dbo_Stores.DbC_stor_id, 
                                                     BasicDAL.ComparisionOperator.Equal,
                                                     this.txt_stor_id,
                                                     "text");
            this.dbl_stor_id.BoundControls.Add(this.dbT_Dbo_Stores.DbC_stor_name,this.lbl_stor_name, "text");
            this.dataNavigator1.DbObject = this.dbT_Dbo_SalesMaster;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.DataGrid = this.dgv_SalesDetails;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGridListView = this.dgvList;
            this.dataNavigator1.ListViewColumns.Add(this.dbT_Dbo_SalesMaster.DbC_ord_num , "Order Number", "");
            this.dataNavigator1.ListViewColumns.Add(this.dbT_Dbo_SalesMaster.DbC_ord_date, "Order Date", "dd/MM/yyyy");
            this.dataNavigator1.ListViewColumns.Add(this.dbT_Dbo_SalesMaster.DbC_stor_id , "Store Id", "");
            this.dataNavigator1.DataNavigatorInit(true);

           
        }
        private void ManageTabSales()
        {
            switch (this.tabSales.SelectedTab.Name.ToLower())
            {
                case "tabpagesalesmaster":
                    this.dataNavigator1.Caption = "Sales Master";
                    this.dataNavigator1.ReadOnlyMode = true;
                    this.dataNavigator1.DbObject = this.dbT_Dbo_SalesMaster;
                    this.dataNavigator1.DataGridActive = false;
                    this.dataNavigator1.DataGrid.Enabled = false;
                    this.pnl_SalesMaster.Enabled = true;
                    this.txt_stor_id.Focus();
                    break;
                case "tabpagesalesdetails":
                    this.pnl_SalesMaster.Enabled = false;
                    this.dataNavigator1.Caption = "Sales Details";
                    this.dataNavigator1.ReadOnlyMode = false;
                    this.dataNavigator1.DbObject = this.dbT_Dbo_SalesDetails;
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.DataGrid.Enabled = true;
                    this.dataNavigator1.DataGrid.Focus();

                    break;
                default:
                    break;
            }
        }
        private void LoadSalesDetails(int ord_num)
        {
            BasicDAL.DbFilters dbFilters = new BasicDAL.DbFilters();
            dbFilters.Add(this.dbT_Dbo_SalesDetails.DbC_ord_num, BasicDAL.ComparisionOperator.Equal, ord_num);
            this.dbT_Dbo_SalesDetails.FiltersGroup.Clear();
            this.dbT_Dbo_SalesDetails.FiltersGroup.Add(dbFilters);
            this.dbT_Dbo_SalesDetails.LoadAll();
            this.dgv_SalesDetails.DataSource = this.dbT_Dbo_SalesDetails.DataTable;
        }
        private void qbe_Sales()
        {
            DbT_dbo_salesmaster  QBEDbObject = new DbT_dbo_salesmaster ();
            QBEDbObject.Init(this.DbConfig.Clone());
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;// ' torna tutte le righe selezionate
            QBEForm.Text = "Search for Sales";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_ord_num, this.txt_ord_num , "text");
            QBEForm.ShowQBE(this);
        }
        private void qbe_Titles()
        {
            DbT_dbo_titles QBEDbObject = new DbT_dbo_titles();
            QBEDbObject.Init(this.DbConfig.Clone());
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;// ' torna tutte le righe selezionate
            QBEForm.Text = "Search for Titles";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_title_id, this.txt_stor_id, "text");
            QBEForm.ShowQBE(this);
        }
        private void qbe_Store()
        {
            DbT_dbo_stores QBEDbObject = new DbT_dbo_stores();
            QBEDbObject.Init(this.DbConfig.Clone());
            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
            QBEForm.Text = "Search for Store";
            QBEForm.DbObject = QBEDbObject;
            QBEForm.AutoLoadAll = true;
            QBEForm.BoundControls.Add(QBEDbObject.DbC_stor_id, this.txt_stor_id, "text");
            QBEForm.ShowQBE(this);
        }
        private void InitDataNavigatorHandler()
        {
            // Declare Events Handlers for DataNavigator
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
            this.qbe_Sales();
        }
        private void dataNavigator1_ePrint()
        {
            //DbT_DbObjectToPrint QBEDbObject = new DbT_DbObjectToPrint();
            //QBEDbObject.Init(this.DbConfig);

            //BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            //QBEForm.Mode = BasicDALWisejControls.QbeMode.Report;
            //QBEForm.ReportsPath = @"<pathofreports>" // ex: @"C:\WisejDemo\WisejDemo\Reports";
            ////QBEForm.AddReport("Report","Report.rpt", "Descrizione del report");

            ////QBEForm.DefaultReport= QBEForm .Reports["Report"];
            ////QBEForm.Text = "Stampa " + this.Text;
            ////QBEForm.ReportViewerMode = BasicDALWisejControls.ReportViewerMode.PDFStream;
            //QBEForm.CrystalReportViewerPage = Application.StartupUrl + "CrystalReportViewer.aspx";
            //QBEForm.DbObject = QBEDbObject;

            //QBEForm.ShowQBE(this);

        }
        private void dataNavigator1_eAddNew()
        {
            if (this.dataNavigator1.DataGridActive == false)
            {
                this.dataNavigator1.DbObject.AddNew();
            }
            else
            {
                if (this.dataNavigator1.DataGrid != null)
                {
                    this.dataNavigator1.DataGrid_AddNew();
                    this.dgv_SalesDetails.CurrentRow[this.dgvc_ord_num.Name].Value = this.txt_ord_num.Text;
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
                {
                    this.dataNavigator1.DbObject.LoadAll();
                    this.dataNavigator1.DataGrid.DataSource = this.dataNavigator1.DbObject.DataTable;
                }
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
                if (this.dataNavigator1.DataGrid != null)
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
                if (this.dataNavigator1.DataGrid != null)
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

      

        private void txt_stor_id_TextChanged(object sender, EventArgs e)
        {
            this.dbl_stor_id.LookUpByFilters();
        }

        private void txt_ord_num_TextChanged(object sender, EventArgs e)
        {

            if (BasicDAL.Utilities.IsNumeric(this.txt_ord_num.Text) == true)
            {
                int ord_num = Convert.ToInt32(this.txt_ord_num.Text);
                this.LoadSalesDetails(ord_num);
            }
        }

        private void txt_stor_id_ToolClick(object sender, ToolClickEventArgs e)
        {
            if (e.Tool.Name.ToLower() == "search")
            {
                this.qbe_Store();
            }
        }

        private void dgv_SalesDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == this.dgvc_qbe_titles.Index)
                {
                DbT_dbo_titles QBEDbObject = new DbT_dbo_titles();
                BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

                QBEDbObject.Init(this.appConfig.DbConfig.Clone());
                QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
                QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
                QBEForm.Text = "Search for Titles";
                QBEForm.DbObject = QBEDbObject;
                QBEForm.QueryDbObject = this.dbT_Dbo_Titles;
                QBEForm.AutoLoadAll = true;
                QBEForm.UseExactSearchForString = false;
                QBEForm.BoundControls.Add(QBEDbObject.DbC_title_id, this.dgv_SalesDetails.CurrentRow[this.dgvc_title_id.Name], "value");
                QBEForm.ShowQBE(this);
            }
        }

        private void tabSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ManageTabSales();
        }

        private void dgv_SalesDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow cRow in this.dgv_SalesDetails.Rows)
            {
                if (cRow[this.dgvc_title_id.Name].Value != null)
                {
                    if (GetTitleRow(cRow[this.dgvc_title_id.Name].Value.ToString(), this.dbT_Dbo_Titles))
                    {
                        cRow[this.dgvc_title].Value = this.dbT_Dbo_Titles.DbC_title.Value;
                    }
                    else
                    {
                        cRow[this.dgvc_title].Value = DBNull.Value;
                    }
                }
            }
        }

        private string GetTitle(string title_id, DbT_dbo_titles dbo_Titles )
        {
            if (this.dbT_Dbo_Titles.GetByPrimaryKey(title_id))
            {
                return dbT_Dbo_Titles.DbC_title.Value.ToString().Trim();
            }
            else
            {
                return "";
            }
        }

        private  bool GetTitleRow(string title_id,   DbT_dbo_titles dbo_Titles)
        {
            if (this.dbT_Dbo_Titles.GetByPrimaryKey(title_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dgv_SalesDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == this.dgvc_title_id.Index)
            {
                string _title_id = this.dgv_SalesDetails[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (this.GetTitleRow(_title_id,  this.dbT_Dbo_Titles))
                {
                    this.dgv_SalesDetails[this.dgvc_title.Index, e.RowIndex].Value = this.dbT_Dbo_Titles.DbC_title.Value;
                    this.dgv_SalesDetails[this.dgvc_price.Index, e.RowIndex].Value = this.dbT_Dbo_Titles.DbC_price.Value;
                }
                else
                {
                    this.dgv_SalesDetails[this.dgvc_title.Index, e.RowIndex].Value = DBNull.Value;
                    this.dgv_SalesDetails[this.dgvc_price.Index, e.RowIndex].Value = DBNull.Value;
                }
            }
        }

        private void dgv_SalesDetails_CellPaint(object sender, DataGridViewCellPaintEventArgs e)
        {

        }
    }
}
