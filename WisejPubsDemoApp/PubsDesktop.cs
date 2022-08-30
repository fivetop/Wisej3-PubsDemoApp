using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    public partial class PubsDesktop : Desktop
    {
        public AppConfig appConfig = new AppConfig();
        public PubsDesktop()
        {
            InitializeComponent();
        }
        private void LoadAppConfig()
        {
            this.appConfig.DbConfig.RuntimeUI = BasicDAL.RuntimeUI.Wisej;
            this.appConfig.DbConfig.RedirectErrorsNotificationTo = new BasicDALWisejControls.BasicDALMessageBox();
            this.appConfig.DbConfig.Provider = BasicDAL.Providers.SqlServer;
            if (!this.appConfig.ReadWebConfigAppConfig())
            {
                MessageBox.Show("Error reading Web.Config parameters!");
                Application.Exit();
            }
        }
        private void PubsDesktop_Load(object sender, EventArgs e)
        {
            this.LoadAppConfig();
            this.txt_CurrentUser.Text = this.appConfig.CurrentWebAppUser.UserName;
        }
        private void mnuBar1_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
            ManageMenuBar(e.MenuItem.Name);
        }

        private void ManageMenuBar(string MenuItemName)
        {
            switch (MenuItemName)
            {
                case "mnuFile_Exit":
                    break;

                case "mnuDiscounts" :
                    frmDiscounts frmDiscounts = new frmDiscounts();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmDiscounts);
                    frmDiscounts.appConfig = this.appConfig;
                    frmDiscounts.Show();
                    break;

                case "mnuAuthors" :
                    frmAuthors frmAuthors = new frmAuthors();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmAuthors);
                    frmAuthors.appConfig = this.appConfig;
                    frmAuthors.Show();
                    break;

                case "mnuEmployees":
                    frmEmployee  frmEmployee = new frmEmployee ();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmEmployee);
                    frmEmployee.appConfig = this.appConfig;
                    frmEmployee.Show();
                    break;

                case "mnuPubInfo":
                    frmPubsInfo frmPubsInfo = new frmPubsInfo();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmPubsInfo);
                    frmPubsInfo.appConfig = this.appConfig;
                    frmPubsInfo.Show();
                    break;

                case "mnuPublishers":
                    frmPublishers frmPublishers = new frmPublishers();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmPublishers);
                    frmPublishers.appConfig = this.appConfig;
                    frmPublishers.Show();
                    break;

                case "mnuRoyalties":
                    frmRoySched  frmRoySched = new frmRoySched();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmRoySched);
                    frmRoySched.appConfig = this.appConfig;
                    frmRoySched.Show();
                    break;

                case "mnuSales":
                    frmSales frmSales = new frmSales();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmSales);
                    frmSales.appConfig = this.appConfig;
                    frmSales.Show();
                    break;

                case "mnuStores":
                    frmStores frmStores = new frmStores();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmStores);
                    frmStores.appConfig = this.appConfig;
                    frmStores.Show();
                    break;

                case "mnuTitles":
                    frmTitles frmTitles = new frmTitles();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmTitles);
                    frmTitles.appConfig = this.appConfig;
                    frmTitles.Show();
                    break;

                case "mnuJobs":
                    frmJobs frmJobs = new frmJobs();
                    BasicDALWisejControls.Utilities.SetFixedWindowStyles(frmJobs);
                    frmJobs.appConfig = this.appConfig;
                    frmJobs.Show();
                    break;

                case "mnuLogin":

                    if (MessageBox.Show("Confirm Logout?", "Wisej Pubs Demo App", MessageBoxButtons.YesNo) == DialogResult.Yes )
                    {
                        CloseAllOpenForms();
                        Application .Desktop  = null;
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                    }
                    break;

                default:
                    break;
            }
        }

        private void CloseAllOpenForms(Form DoNotCloseForm = null)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (DoNotCloseForm == null)
                {
                    Application.OpenForms[i].Close();
                }
                else
                {
                    if (Application.OpenForms[i].Name != DoNotCloseForm.Name)
                        Application.OpenForms[i].Close();
                }
            }
        }
       
    }
}
