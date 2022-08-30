using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    public partial class frmAuthors : Form
    {
        public AppConfig appConfig;
        public DbT_dbo_authors dbT_Dbo_Authors;
        private BasicDAL .DbConfig DbConfig  ;
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void InitDataContext()
        {
            this.DbConfig = this.appConfig.DbConfig.Clone();
            
            this.dbT_Dbo_Authors = new DbT_dbo_authors();
            this.dbT_Dbo_Authors.Init(this.DbConfig);
            this.dbT_Dbo_Authors.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding;
            
            //binding section
            this.dbT_Dbo_Authors.DbC_address.BoundControls.Add(this.txt_address, "text");
            this.dbT_Dbo_Authors.DbC_au_fname.BoundControls.Add(this.txt_au_fname , "text");
            this.dbT_Dbo_Authors.DbC_au_id.BoundControls.Add(this.txt_au_id , "text"  );
            this.dbT_Dbo_Authors.DbC_au_lname.BoundControls.Add(this.txt_au_lname , "text");
            this.dbT_Dbo_Authors.DbC_city.BoundControls.Add(this.txt_city, "text");
            this.dbT_Dbo_Authors.DbC_phone.BoundControls.Add(this.txt_phone, "text");
            this.dbT_Dbo_Authors.DbC_state.BoundControls.Add(this.txt_state, "text");
            this.dbT_Dbo_Authors.DbC_zip.BoundControls.Add(this.txt_zip, "text");
            this.dbT_Dbo_Authors.DbC_email.BoundControls.Add(this.txt_email, "text");

      
            //bind datanavigator
            this.dataNavigator1.DbObject = this.dbT_Dbo_Authors;
            this.dataNavigator1.ManageNavigation = false;
            this.dataNavigator1.InitDataNavigator(true);
            

                
        }
        private void frmAuthors_Load(object sender, EventArgs e)
        {
            this.InitDataContext();
            
        }

        private void qbe_Authors()
        {
            DbT_dbo_authors QBEDbObject = new DbT_dbo_authors();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.appConfig.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Query;
            QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Search for " + this.Text;

            QBEForm.DbObject = QBEDbObject;
            QBEForm.QueryDbObject = this.dbT_Dbo_Authors;
            QBEForm.AutoLoadAll = true;
            QBEForm.UseExactSearchForString = false;
            QBEForm.DbColumnsMapping.Add(QBEDbObject.DbC_au_id, this.dbT_Dbo_Authors.DbC_au_id);
            QBEForm.ShowQBE(this);
        }

        private void qbePrint_Authors()
        {
            DbT_dbo_authors QBEDbObject = new DbT_dbo_authors();

            BasicDALWisejControls.QBEForm QBEForm = new BasicDALWisejControls.QBEForm();

            QBEDbObject.Init(this.appConfig.DbConfig.Clone());
            QBEForm.Mode = BasicDALWisejControls.QbeMode.Report ;
            QBEForm.CallerForm = this;
            QBEForm.Text = "Reports for " + this.Text;
            QBEForm.DbObject = QBEDbObject;
            QBEForm.UseExactSearchForString = false;
            QBEForm.ReportsPath = Application.StartupPath +"reports" ;
            
            QBEForm.AddReport("Authors list", "rptAuthors1.rpt", "Authors list");
            
            QBEForm.ShowQBE(this);

        }
        private void dataNavigator1_eAddNew()
        {
            this.dataNavigator1.DbObject.AddNew();
        }

        private void dataNavigator1_eBoundCompleted()
        {

        }

        private void dataNavigator1_eClose()
        {

        }

        private void dataNavigator1_eDelete()
        {
            this.dataNavigator1.DbObject.Delete();
        }

        private void dataNavigator1_eFind()
        {

            qbe_Authors();
            
        }

        private void dataNavigator1_eMoveFirst()
        {
            this.dataNavigator1.DbObject.MoveFirst();
        }

        private void dataNavigator1_eMoveLast()
        {
            this.dataNavigator1.DbObject.MoveLast();
        }

        private void dataNavigator1_eMoveNext()
        {
            this.dataNavigator1.DbObject.MoveNext();
        }

        private void dataNavigator1_eMovePrevious()
        {
            this.dataNavigator1.DbObject.MovePrevious();
        }

        private void dataNavigator1_ePrint()
        {
            this.qbePrint_Authors();
        }

        private void dataNavigator1_eRefresh()
        {
            this.dataNavigator1.DbObject.LoadAll();
        }

        private void dataNavigator1_eSave()
        {
            this.dataNavigator1.DbObject.Update();

            
            MessageBox.Show(this.dataNavigator1.DbObject.DumpInsertCommandParameters ().ToLower ());
        }

        private void dataNavigator1_eUndo()
        {
            this.dataNavigator1.DbObject.UndoChanges();
        }
    }
}
