using System;
using Wisej.Web;


namespace WisejPubsDemoApp
{
    public partial class Pubs : Page
    {
        public AppConfig appConfig = new AppConfig();
        
        public Pubs()
        {
            InitializeComponent();
            this.appConfig.DbConfig.RuntimeUI = BasicDAL.RuntimeUI.Wisej;
            this.appConfig.DbConfig.RedirectErrorsNotificationTo = new BasicDALWisejControls.BasicDALMessageBox();
            this.appConfig.DbConfig.Provider = BasicDAL.Providers.SqlServer;
            this.appConfig.DbConfig.ServerName = "(local)";
            this.appConfig.DbConfig.DataBaseName = "Pubs";
            this.appConfig.DbConfig.AuthenticationMode = 1;
            this.appConfig.DbConfig.UserName = "sa";
            this.appConfig.DbConfig.Password = "SQL1qaz@2wsx";

        }

        private void Pubs_Load(object sender, EventArgs e)
        {

        }
    }
}
