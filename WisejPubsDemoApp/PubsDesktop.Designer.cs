
namespace WisejPubsDemoApp
{
    partial class PubsDesktop
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubsDesktop));
            this.desktopTaskBarItem1 = new Wisej.Web.DesktopTaskBarItem();
            this.mnuBar1 = new Wisej.Web.MenuBar();
            this.mnuFile = new Wisej.Web.MenuItem();
            this.mnuLogin = new Wisej.Web.MenuItem();
            this.mnuFileSeparator1 = new Wisej.Web.MenuItem();
            this.mnuFile_Exit = new Wisej.Web.MenuItem();
            this.mnuAuthors = new Wisej.Web.MenuItem();
            this.mnuDiscounts = new Wisej.Web.MenuItem();
            this.mnuEmployees = new Wisej.Web.MenuItem();
            this.mnuJobs = new Wisej.Web.MenuItem();
            this.mnuPubInfo = new Wisej.Web.MenuItem();
            this.mnuPublishers = new Wisej.Web.MenuItem();
            this.mnuRoyalties = new Wisej.Web.MenuItem();
            this.mnuSales = new Wisej.Web.MenuItem();
            this.mnuStores = new Wisej.Web.MenuItem();
            this.mnuTitles = new Wisej.Web.MenuItem();
            this.txt_CurrentUser = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // desktopTaskBarItem1
            // 
            this.desktopTaskBarItem1.Image = ((System.Drawing.Image)(resources.GetObject("desktopTaskBarItem1.Image")));
            this.desktopTaskBarItem1.Name = "desktopTaskBarItem1";
            this.desktopTaskBarItem1.Text = "Start";
            // 
            // mnuBar1
            // 
            this.mnuBar1.Dock = Wisej.Web.DockStyle.Top;
            this.mnuBar1.Location = new System.Drawing.Point(0, 0);
            this.mnuBar1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.mnuFile,
            this.mnuAuthors,
            this.mnuDiscounts,
            this.mnuEmployees,
            this.mnuJobs,
            this.mnuPubInfo,
            this.mnuPublishers,
            this.mnuRoyalties,
            this.mnuSales,
            this.mnuStores,
            this.mnuTitles});
            this.mnuBar1.Name = "mnuBar1";
            this.mnuBar1.Size = new System.Drawing.Size(879, 40);
            this.mnuBar1.TabIndex = 0;
            this.mnuBar1.TabStop = false;
            this.mnuBar1.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.mnuBar1_MenuItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.mnuLogin,
            this.mnuFileSeparator1,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "File";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Index = 0;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Text = "Login as different User";
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Index = 1;
            this.mnuFileSeparator1.Name = "mnuFileSeparator1";
            this.mnuFileSeparator1.Text = "-";
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Index = 2;
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Text = "Exit";
            // 
            // mnuAuthors
            // 
            this.mnuAuthors.Index = 1;
            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Text = "Authors";
            // 
            // mnuDiscounts
            // 
            this.mnuDiscounts.Index = 2;
            this.mnuDiscounts.Name = "mnuDiscounts";
            this.mnuDiscounts.Text = "Discounts";
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.Index = 3;
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Text = "Employees";
            // 
            // mnuJobs
            // 
            this.mnuJobs.Index = 4;
            this.mnuJobs.Name = "mnuJobs";
            this.mnuJobs.Text = "Jobs";
            // 
            // mnuPubInfo
            // 
            this.mnuPubInfo.Index = 5;
            this.mnuPubInfo.Name = "mnuPubInfo";
            this.mnuPubInfo.Text = "Pub Info";
            // 
            // mnuPublishers
            // 
            this.mnuPublishers.Index = 6;
            this.mnuPublishers.Name = "mnuPublishers";
            this.mnuPublishers.Text = "Publishers";
            // 
            // mnuRoyalties
            // 
            this.mnuRoyalties.Index = 7;
            this.mnuRoyalties.Name = "mnuRoyalties";
            this.mnuRoyalties.Text = "Royalties ";
            // 
            // mnuSales
            // 
            this.mnuSales.Index = 8;
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Text = "Sales";
            // 
            // mnuStores
            // 
            this.mnuStores.Index = 9;
            this.mnuStores.Name = "mnuStores";
            this.mnuStores.Text = "Stores";
            // 
            // mnuTitles
            // 
            this.mnuTitles.Index = 10;
            this.mnuTitles.Name = "mnuTitles";
            this.mnuTitles.Text = "Titles";
            // 
            // txt_CurrentUser
            // 
            this.txt_CurrentUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.txt_CurrentUser.Enabled = false;
            this.txt_CurrentUser.LabelText = "Current User";
            this.txt_CurrentUser.Location = new System.Drawing.Point(684, 339);
            this.txt_CurrentUser.Name = "txt_CurrentUser";
            this.txt_CurrentUser.Size = new System.Drawing.Size(192, 53);
            this.txt_CurrentUser.TabIndex = 1;
            // 
            // PubsDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.txt_CurrentUser);
            this.Controls.Add(this.mnuBar1);
            this.Items.AddRange(new Wisej.Web.DesktopTaskBarItem[] {
            this.desktopTaskBarItem1});
            this.Name = "PubsDesktop";
            this.Size = new System.Drawing.Size(879, 443);
            this.Load += new System.EventHandler(this.PubsDesktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DesktopTaskBarItem desktopTaskBarItem1;
        private Wisej.Web.MenuBar mnuBar1;
        private Wisej.Web.MenuItem mnuFile;
        private Wisej.Web.MenuItem mnuFile_Exit;
        private Wisej.Web.MenuItem mnuAuthors;
        private Wisej.Web.MenuItem mnuDiscounts;
        private Wisej.Web.MenuItem mnuEmployees;
        private Wisej.Web.MenuItem mnuJobs;
        private Wisej.Web.MenuItem mnuPubInfo;
        private Wisej.Web.MenuItem mnuPublishers;
        private Wisej.Web.MenuItem mnuRoyalties;
        private Wisej.Web.MenuItem mnuSales;
        private Wisej.Web.MenuItem mnuStores;
        private Wisej.Web.MenuItem mnuTitles;
        private Wisej.Web.MenuItem mnuLogin;
        private Wisej.Web.MenuItem mnuFileSeparator1;
        private Wisej.Web.TextBox txt_CurrentUser;
    }
}
