using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    public partial class frmLogin : Form
    {
        public AppConfig appConfig = new AppConfig();
        System.Collections.Generic.List<WebAppUser> _WebAppUsers;
        public frmLogin()
        {
            InitializeComponent();
            // create users list - this is only for demo purpose NEVER use in a real application
            _WebAppUsers = new System.Collections.Generic.List<WebAppUser>();
            _WebAppUsers.Add(new WebAppUser () { UserName = "User1" , Password = "Password1" });
            _WebAppUsers.Add(new WebAppUser() { UserName = "User2", Password = "Password2" });
            _WebAppUsers.Add(new WebAppUser() { UserName = "User3", Password = "Password3" });
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!IsValidLogin(ref this.appConfig.CurrentWebAppUser))
            {
                MessageBox.Show("UserName or Password not valid!");
            }
            else
            {
                PubsDesktop pubsDesktop = new PubsDesktop();
                pubsDesktop.appConfig = this.appConfig;
                pubsDesktop.Show();
                this.Close();
            }
        }
        private bool IsValidLogin(ref WebAppUser LoggedInWebAppUser)
        {
            LoggedInWebAppUser = new WebAppUser() ;
            WebAppUser UserToCheck = new WebAppUser();
            UserToCheck.UserName = this.txt_UserName.Text.Trim().ToLower();
            UserToCheck.Password = this.txt_Password.Text;
            bool UserOk = false;
            foreach (WebAppUser _WebAppUser in _WebAppUsers)
            {
                if (_WebAppUser.UserName.ToLower()  == UserToCheck .UserName)
                {
                    if (_WebAppUser.Password == UserToCheck.Password)
                    {
                        LoggedInWebAppUser.UserName  = _WebAppUser.UserName;
                        LoggedInWebAppUser.Password  = _WebAppUser.Password ;
                        this.appConfig.CurrentWebAppUser = LoggedInWebAppUser;
                        UserOk = true; 
                        break;
                    }
                }

            }
            return UserOk;
        }
    }
    public class WebAppUser
    {
        public string UserName;
        public string Password;
        public WebAppUser()
        {
        }
   
    }
}        