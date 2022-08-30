using System;
using Wisej.Web;
namespace WisejPubsDemoApp
{
    partial class frmPublishers : Form
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
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.txt_country = new Wisej.Web.TextBox();
            this.txt_state = new Wisej.Web.TextBox();
            this.txt_city = new Wisej.Web.TextBox();
            this.txt_pub_name = new Wisej.Web.TextBox();
            this.txt_pub_id = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Publishers";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 291);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(637, 60);
            this.dataNavigator1.TabIndex = 1;
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Location = new System.Drawing.Point(3, 3);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(628, 282);
            this.tabDataNavigator.TabIndex = 19;
            this.tabDataNavigator.SelectedIndexChanged += new System.EventHandler(this.tabDataNavigator_SelectedIndexChanged);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_country);
            this.tabForm.Controls.Add(this.txt_state);
            this.tabForm.Controls.Add(this.txt_city);
            this.tabForm.Controls.Add(this.txt_pub_name);
            this.tabForm.Controls.Add(this.txt_pub_id);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(626, 241);
            this.tabForm.Text = "Form View";
            // 
            // txt_country
            // 
            this.txt_country.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_country.LabelText = "Publisher Country";
            this.txt_country.Location = new System.Drawing.Point(456, 59);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(149, 48);
            this.txt_country.TabIndex = 4;
            // 
            // txt_state
            // 
            this.txt_state.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_state.LabelText = "Publisher State";
            this.txt_state.Location = new System.Drawing.Point(350, 59);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(100, 48);
            this.txt_state.TabIndex = 3;
            // 
            // txt_city
            // 
            this.txt_city.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_city.LabelText = "Publisher City";
            this.txt_city.Location = new System.Drawing.Point(7, 59);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(337, 48);
            this.txt_city.TabIndex = 2;
            // 
            // txt_pub_name
            // 
            this.txt_pub_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pub_name.LabelText = "Publisher Name";
            this.txt_pub_name.Location = new System.Drawing.Point(113, 7);
            this.txt_pub_name.Name = "txt_pub_name";
            this.txt_pub_name.Size = new System.Drawing.Size(337, 48);
            this.txt_pub_name.TabIndex = 1;
            // 
            // txt_pub_id
            // 
            this.txt_pub_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pub_id.LabelText = "Publisher ID";
            this.txt_pub_id.Location = new System.Drawing.Point(7, 7);
            this.txt_pub_id.Name = "txt_pub_id";
            this.txt_pub_id.Size = new System.Drawing.Size(100, 48);
            this.txt_pub_id.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(626, 241);
            this.tabList.Text = "List View";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvList.KeepSameRowHeight = true;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(620, 235);
            this.dgvList.TabIndex = 0;
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 351);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmPublishers";
            this.Text = "Publishers";
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
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
        private TextBox txt_pub_id;
        private TextBox txt_country;
        private TextBox txt_state;
        private TextBox txt_city;
        private TextBox txt_pub_name;
    }
}