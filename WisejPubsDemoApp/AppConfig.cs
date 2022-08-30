using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WisejPubsDemoApp
{
    public class AppConfig
    {
        public WebAppUser CurrentWebAppUser = null;
        public BasicDAL.DbConfig DbConfig;
        public AppConfig()
        {
            DbConfig = new BasicDAL.DbConfig();
        }

        public Boolean ReadWebConfigAppConfig()
        {
            bool _ok = false;
            if (System.Configuration.ConfigurationManager.AppSettings.Count > 0)
            {
                try
                {
                    this.DbConfig.ServerName = System.Configuration.ConfigurationManager
                                                                    .AppSettings["DbConfigServerName"];
                    this.DbConfig.DataBaseName = System.Configuration.ConfigurationManager
                                                                    .AppSettings["DbConfigDataBaseName"];
                    this.DbConfig.UserName = System.Configuration.ConfigurationManager
                                                                    .AppSettings["DbConfigUserName"];
                    this.DbConfig.Password = System.Configuration.ConfigurationManager
                                                                    .AppSettings["DbConfigPassword"];
                    this.DbConfig.AuthenticationMode = Convert.ToInt32(
                                                                       System.Configuration.ConfigurationManager
                                                                       .AppSettings["DbConfigAuthenticationMode"]
                                                                       );
                    // AuthenticationMode = 0 (Zero) means DB Native Authentication
                    // AuthenticationMode = 1 (One) means Windows Authentication

                    _ok = true;
                }
                catch (Exception)
                {
                    Wisej.Web.MessageBox.Show("Error reading Web.Config");
                    _ok = false;
                }
            }
            return _ok;
        }

    }
}