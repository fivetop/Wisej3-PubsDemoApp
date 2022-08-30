using System;
using Wisej.Web;
namespace WisejPubsDemoApp
{
    public partial class frmTitles : Form
    {

        public AppConfig appConfig = new AppConfig();

        private DbT_dbo_titles dbT_Dbo_Titles = new DbT_dbo_titles();
        private DbT_dbo_publishers dbT_Dbo_Publishers = new DbT_dbo_publishers();
        private DbT_dbo_titleauthor dbT_Dbo_Titleauthor = new DbT_dbo_titleauthor();
        private DbT_dbo_authors dbT_Dbo_Authors = new DbT_dbo_authors();
        private BasicDAL.DbLookUp dbl_Authors = new BasicDAL.DbLookUp();
        private BasicDAL.DbConfig DbConfig = new BasicDAL.DbConfig();
        private BasicDALWisejControls.BasicDALMessageBox BasicDALMessageBox = new BasicDALWisejControls.BasicDALMessageBox();
        private bool FormInit = false;
        private bool DataNavigatorHandlerInitialized = false;
        
        public frmTitles()
        {
            InitializeComponent();
        }


        private void InitDataContext(bool ForceFormInit = false)
        {

            //this.appConfig.ReadWebConfigAppConfig();

            if (ForceFormInit == true)
            {
                FormInit = false;
            }

            if (this.FormInit)
            {
                return;
            }
            InitDataNavigatorHandler();

            this.DbConfig = this.appConfig.DbConfig.Clone();

            this.DbConfig.RuntimeUI = BasicDAL.RuntimeUI.Wisej;
            this.DbConfig.RedirectErrorsNotificationTo = this.BasicDALMessageBox;

            //Initialize a DBObject
            this.dbT_Dbo_Titles.Init(this.DbConfig);
            this.dbT_Dbo_Titles.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            this.dbT_Dbo_Publishers.Init(this.DbConfig);
            this.dbT_Dbo_Publishers.DataBinding = BasicDAL.DataBoundControlsBehaviour.NoDataBinding;
            this.dbT_Dbo_Titleauthor.Init(this.DbConfig);
            this.dbT_Dbo_Authors.DataBinding = BasicDAL.DataBoundControlsBehaviour.NoDataBinding;
            this.dbT_Dbo_Authors.Init(this.DbConfig);
            this.dbT_Dbo_Authors.DataBinding = BasicDAL.DataBoundControlsBehaviour.NoDataBinding;

            //binding for BasicDAL DbObject columns into UI objects.
            // EX: this.DbObject.dbstringcolumn.BoundControls.Add(this.txt_dbstringcolumn, "text");

            this.dbT_Dbo_Titles.DbC_title_id.BoundControls.Add(this.txt_title_id, "text");
            this.dbT_Dbo_Titles.DbC_title.BoundControls.Add(this.txt_title, "text");
            this.dbT_Dbo_Titles.DbC_advance.BoundControls.Add(this.txt_advance, "text");
            this.dbT_Dbo_Titles.DbC_notes.BoundControls.Add(this.txt_notes, "text");
            this.dbT_Dbo_Titles.DbC_price.BoundControls.Add(this.txt_price, "text");
            this.dbT_Dbo_Titles.DbC_pubdate.BoundControls.Add(this.dtp_pubbdate, "value");
            this.dbT_Dbo_Titles.DbC_royalty.BoundControls.Add(this.txt_royalty, "text");
            this.dbT_Dbo_Titles.DbC_type.BoundControls.Add(this.txt_type, "text");
            this.dbT_Dbo_Titles.DbC_ytd_sales.BoundControls.Add(this.txt_ytd_sales, "text");
            this.dbT_Dbo_Titles.DbC_pub_id.BoundControls.Add(this.cmb_pub_id, "selectedvalue");

            BasicDALWisejControls.Utilities.BoundComboBoxItemsToDbObject(this.cmb_pub_id,
                                                                       this.dbT_Dbo_Publishers,
                                                                       this.dbT_Dbo_Publishers.DbC_pub_name.DbColumnNameE,
                                                                       this.dbT_Dbo_Publishers.DbC_pub_id.DbColumnNameE,
                                                                       true,
                                                                       DBNull.Value);

            //BasicDALWisejControls.Utilities.BoundDataGridViewComboBoxColumnItemsToDbObject(this.dgvc_cmb_au_id,
            //                                                           this.dbT_Dbo_Authors,
            //                                                           this.dbT_Dbo_Authors.DbC_au_lname.DbColumnNameE,
            //                                                           this.dbT_Dbo_Authors.DbC_au_id.DbColumnNameE,
            //                                                           true,
            //                                                           DBNull.Value);


            // Declare of DbLookUp 
          
            //this.dbl_Authors.DbObject = this.dbT_Dbo_Authors ;
            //this.dbl_Authors.Filters.AddBoundControl(this.dbT_Dbo_Authors.DbC_au_id , BasicDAL.ComparisionOperator.Equal, this.txt_ID, "text", BasicDAL.LogicOperator.None);
            //this.DbL_LookUp.BoundControls.Add(this.DbObjectToQuery.Name, this.lbl_Name, "text");

            this.dataNavigator1.DbObject = this.dbT_Dbo_Titles;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.DataGrid = this.dgv_TitleAuthors;
            this.dataNavigator1.DataGridActive = false;
            this.dataNavigator1.DataGridListView = this.dgvListView;
            this.dataNavigator1.InitDataNavigator(true);
            this.ManageTabTitle();


        }


        private void ManageTabTitle()
        {
            switch (this.tabTitle.SelectedTab.Name.ToLower())
            {
                case "tabpagetitles":
                    this.txt_title_id.Enabled = true;
                    this.dataNavigator1.Caption = "Titles";
                    this.dataNavigator1.ReadOnlyMode = true;
                    this.dataNavigator1.DbObject = this.dbT_Dbo_Titles;
                    this.dataNavigator1.DataGridActive = false;
                    this.dataNavigator1.DataGrid.Enabled = false;
                    this.pnl_Title.Enabled = true;
                    this.txt_title_id.Focus();
                    break;
                case "tabpagetitleauthors":
                    this.pnl_Title.Enabled = false;
                    this.dataNavigator1.Caption = "Title Authors";
                    this.txt_title_id.Enabled = false;
                    this.dataNavigator1.ReadOnlyMode = false;
                    this.dataNavigator1.DbObject = this.dbT_Dbo_Titleauthor;
                    this.dataNavigator1.DataGridActive = true;
                    this.dataNavigator1.DataGrid.Enabled  = true;
                    this.dataNavigator1.Focus();
                    
                    break;
                default:
                    break;
            }
        }
        private void LoadTitleAuthors()
        {
            BasicDAL.DbFilters dbFilters = new BasicDAL.DbFilters();

            dbFilters.Add(this.dbT_Dbo_Titleauthor.DbC_title_id, BasicDAL.ComparisionOperator.Equal, this.txt_title_id.Text);
            this.dbT_Dbo_Titleauthor.FiltersGroup.Clear();
            this.dbT_Dbo_Titleauthor.FiltersGroup.Add(dbFilters);
            this.dbT_Dbo_Titleauthor.LoadAll();
            this.dgv_TitleAuthors.DataSource = this.dbT_Dbo_Titleauthor.DataTable;
        }

        private void qbe_Titles()
        {
            DbT_dbo_titles QBEDbObject = new DbT_dbo_titles();
            QBEDbObject.Init(this.DbConfig.Clone());

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;// ' torna tutte le righe selezionate
            QBEForm.Text = "Search for " + this.Text;

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_Dbo_Titles;
            QBEForm.AutoLoadAll = true;
            QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_title_id, this.dbT_Dbo_Titles.DbC_title_id);
            QBEForm.ShowQBE(this);
        }

        #region DataNavigatorHandler
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
        #endregion 


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

            qbe_Titles();

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
                    this.dgv_TitleAuthors.CurrentRow[dgvc_title_id.Name].Value = this.txt_title_id.Text;
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

        #region DataNavigator Request Events
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
        #endregion 

        private void tabDataNavigator_SelectedIndexChanged(object sender, EventArgs e)
        {

            ManageTabDataNavigator(this.tabDataNavigator.SelectedTab.Name);
        }



        private void dataNavigator1_eBoundCompleted()
        {

        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            this.InitDataContext();

        }

        private void txt_title_id_TextChanged(object sender, EventArgs e)
        {
            this.LoadTitleAuthors();
        }

        private void tabTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ManageTabTitle();
        }

        private void dgv_TitleAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_TitleAuthors.CurrentRow == null)
                return;

            if (this.dgv_TitleAuthors.CurrentCell.OwningColumn.Name == this.dgvc_qbe_authors.Name)
            {
                DbV_dbo_AuthorsFullname  QBEDbObject = new DbV_dbo_AuthorsFullname ();

                BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

                QBEDbObject.Init(this.appConfig.DbConfig.Clone());
                QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
                QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.BoundControls;
                QBEForm.CallerForm = this;
                QBEForm.Text = "Search for " + this.Text;

                QBEForm.DbObject = QBEDbObject;
                QBEForm.QueryDbObject = this.dbT_Dbo_Authors;
                QBEForm.AutoLoadAll = true;
                QBEForm.UseExactSearchForString = false;
                //QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_au_id, this.dbT_Dbo_Authors.DbC_au_id);
                QBEForm.BoundControls.Add(QBEDbObject.DbC_au_id, this.dgv_TitleAuthors.CurrentRow[this.dgvc_au_id.Name], "value");
                QBEForm.BoundControls.Add(QBEDbObject.DbC_au_fullname, this.dgv_TitleAuthors.CurrentRow[this.dgvc_au_fullname.Name], "value");
                QBEForm.ShowQBE(this);
            }

        }

    
        private string  GetAutorsFullName(string au_id, DbT_dbo_authors dbT_Dbo_Authors)
            {

            if (dbT_Dbo_Authors.GetByPrimaryKey(au_id))
                return String.Format("{0}, {1}", dbT_Dbo_Authors.DbC_au_lname.Value.ToString ().Trim(), dbT_Dbo_Authors.DbC_au_fname.Value.ToString ().Trim() );
            return "";
            }

       


        // Must Be Used to populate Unbound columns
        private void dgv_TitleAuthors_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow cRow in this.dgv_TitleAuthors.Rows)
            {
                if (cRow[this.dgvc_au_id.Name].Value != null)
                {
                    cRow[this.dgvc_au_fullname].Value = GetAutorsFullName(cRow[this.dgvc_au_id.Name].Value.ToString(), this.dbT_Dbo_Authors);
                }
            }
        }

        
        
        //Can be used to update values in other columns when a Cell is edited
        private void dgv_TitleAuthors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            if (this.dgv_TitleAuthors.CurrentCell == null)
                return;

            DataGridViewCell cCell = this.dgv_TitleAuthors.CurrentCell;
            if (cCell.OwningColumn.Name == this.dgvc_qbe_authors.Name)
            {
                cCell.OwningRow[this.dgvc_au_fullname].Value = GetAutorsFullName(cCell.OwningRow[this.dgvc_au_id].Value.ToString(), this.dbT_Dbo_Authors );
            }
        }
    }

        
}

