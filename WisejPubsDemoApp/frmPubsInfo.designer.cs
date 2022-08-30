using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmPubsInfo : Form
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
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPubsInfo));
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.uploadLogo = new Wisej.Web.Upload();
            this.panelLogo = new Wisej.Web.Panel();
            this.pict_logo = new Wisej.Web.PictureBox();
            this.txt_pub_id = new Wisej.Web.TextBox();
            this.txt_pr_info = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.txt_pub_name = new Wisej.Web.TextBox();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).BeginInit();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(752, 396);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_pub_name);
            this.tabForm.Controls.Add(this.uploadLogo);
            this.tabForm.Controls.Add(this.panelLogo);
            this.tabForm.Controls.Add(this.txt_pub_id);
            this.tabForm.Controls.Add(this.txt_pr_info);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(750, 355);
            this.tabForm.Text = "Form View";
            // 
            // uploadLogo
            // 
            this.uploadLogo.HideValue = true;
            this.uploadLogo.Location = new System.Drawing.Point(597, 313);
            this.uploadLogo.Name = "uploadLogo";
            this.uploadLogo.Size = new System.Drawing.Size(128, 30);
            this.uploadLogo.TabIndex = 11;
            this.uploadLogo.Text = "Upload Logo";
            this.uploadLogo.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadLogo_Uploaded);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromName("@desktop");
            this.panelLogo.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelLogo.Controls.Add(this.pict_logo);
            this.panelLogo.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelLogo.HeaderBackColor = System.Drawing.Color.FromName("@desktop");
            this.panelLogo.HeaderForeColor = System.Drawing.Color.FromName("@menuText");
            this.panelLogo.HeaderSize = 19;
            this.panelLogo.Location = new System.Drawing.Point(355, 48);
            this.panelLogo.Margin = new Wisej.Web.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.ShowCloseButton = false;
            this.panelLogo.ShowHeader = true;
            this.panelLogo.Size = new System.Drawing.Size(374, 262);
            this.panelLogo.TabIndex = 10;
            this.panelLogo.Text = "Logo";
            componentTool1.ImageSource = "icon-close";
            componentTool1.Name = "logo_clear";
            componentTool1.ToolTipText = "Clear Logo Image";
            this.panelLogo.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
            this.panelLogo.ToolClick += new Wisej.Web.ToolClickEventHandler(this.panelLogo_ToolClick);
            // 
            // pict_logo
            // 
            this.pict_logo.Location = new System.Drawing.Point(11, 4);
            this.pict_logo.Name = "pict_logo";
            this.pict_logo.Size = new System.Drawing.Size(358, 236);
            this.pict_logo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // txt_pub_id
            // 
            this.txt_pub_id.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pub_id.LabelText = "Pub ID";
            this.txt_pub_id.Location = new System.Drawing.Point(7, 5);
            this.txt_pub_id.Name = "txt_pub_id";
            this.txt_pub_id.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_pub_id.ResponsiveProfiles"))));
            this.txt_pub_id.Size = new System.Drawing.Size(150, 46);
            this.txt_pub_id.TabIndex = 3;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "Search";
            componentTool2.ToolTipText = "Search Publishers";
            this.txt_pub_id.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txt_pub_id.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_pub_id_ToolClick);
            this.txt_pub_id.TextChanged += new System.EventHandler(this.txt_pub_id_TextChanged);
            // 
            // txt_pr_info
            // 
            this.txt_pr_info.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pr_info.LabelText = "PR Info";
            this.txt_pr_info.Location = new System.Drawing.Point(7, 55);
            this.txt_pr_info.Multiline = true;
            this.txt_pr_info.Name = "txt_pr_info";
            this.txt_pr_info.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_pr_info.ResponsiveProfiles"))));
            this.txt_pr_info.Size = new System.Drawing.Size(342, 254);
            this.txt_pr_info.TabIndex = 4;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(750, 355);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(744, 349);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 396);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(752, 60);
            this.dataNavigator1.TabIndex = 1;
            // 
            // txt_pub_name
            // 
            this.txt_pub_name.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.txt_pub_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pub_name.Label.Padding = new Wisej.Web.Padding(0);
            this.txt_pub_name.LabelText = "Publisher";
            this.txt_pub_name.Location = new System.Drawing.Point(163, 8);
            this.txt_pub_name.Name = "txt_pub_name";
            this.txt_pub_name.ReadOnly = true;
            this.txt_pub_name.Size = new System.Drawing.Size(323, 43);
            this.txt_pub_name.TabIndex = 17;
            // 
            // frmPubsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmPubsInfo";
            this.Text = "Pubs Info";
            this.Load += new System.EventHandler(this.frmPubsInfo_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).EndInit();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        internal TextBox txt_pub_id;
        internal TextBox txt_pr_info;
        private PictureBox pict_logo;
        private Panel panelLogo;
        private Upload uploadLogo;
        private TextBox txt_pub_name;
    }
}
