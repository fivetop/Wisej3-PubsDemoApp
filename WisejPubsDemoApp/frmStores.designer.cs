using System;
using Wisej.Web;
namespace WisejPubsDemoApp
{

    partial class frmStores : Form
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
            this.txt_stor_address = new Wisej.Web.TextBox();
            this.txt_zip = new Wisej.Web.TextBox();
            this.txt_state = new Wisej.Web.TextBox();
            this.txt_city = new Wisej.Web.TextBox();
            this.txt_stor_name = new Wisej.Web.TextBox();
            this.txt_stor_id = new Wisej.Web.TextBox();
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
            this.dataNavigator1.Caption = "";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 229);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(572, 60);
            this.dataNavigator1.TabIndex = 1;
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(572, 229);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_stor_address);
            this.tabForm.Controls.Add(this.txt_zip);
            this.tabForm.Controls.Add(this.txt_state);
            this.tabForm.Controls.Add(this.txt_city);
            this.tabForm.Controls.Add(this.txt_stor_name);
            this.tabForm.Controls.Add(this.txt_stor_id);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(570, 188);
            this.tabForm.Text = "Form View";
            // 
            // txt_stor_address
            // 
            this.txt_stor_address.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_address.LabelText = "Store Address";
            this.txt_stor_address.Location = new System.Drawing.Point(4, 54);
            this.txt_stor_address.Name = "txt_stor_address";
            this.txt_stor_address.Size = new System.Drawing.Size(337, 48);
            this.txt_stor_address.TabIndex = 14;
            // 
            // txt_zip
            // 
            this.txt_zip.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_zip.LabelText = "Store Zip";
            this.txt_zip.Location = new System.Drawing.Point(347, 105);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(74, 48);
            this.txt_zip.TabIndex = 13;
            // 
            // txt_state
            // 
            this.txt_state.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_state.LabelText = "Store State";
            this.txt_state.Location = new System.Drawing.Point(427, 105);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(100, 48);
            this.txt_state.TabIndex = 12;
            // 
            // txt_city
            // 
            this.txt_city.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_city.LabelText = "Store City";
            this.txt_city.Location = new System.Drawing.Point(4, 105);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(337, 48);
            this.txt_city.TabIndex = 11;
            // 
            // txt_stor_name
            // 
            this.txt_stor_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_name.LabelText = "Store Name";
            this.txt_stor_name.Location = new System.Drawing.Point(110, 3);
            this.txt_stor_name.Name = "txt_stor_name";
            this.txt_stor_name.Size = new System.Drawing.Size(337, 48);
            this.txt_stor_name.TabIndex = 10;
            // 
            // txt_stor_id
            // 
            this.txt_stor_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_id.LabelText = "Store ID";
            this.txt_stor_id.Location = new System.Drawing.Point(4, 3);
            this.txt_stor_id.Name = "txt_stor_id";
            this.txt_stor_id.Size = new System.Drawing.Size(100, 48);
            this.txt_stor_id.TabIndex = 9;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(570, 188);
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
            this.dgvList.Size = new System.Drawing.Size(564, 182);
            this.dgvList.TabIndex = 0;
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 289);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmStores";
            this.Text = "Stores";
            this.Load += new System.EventHandler(this.frmStores_Load);
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
        private TextBox txt_stor_address;
        private TextBox txt_zip;
        private TextBox txt_state;
        private TextBox txt_city;
        private TextBox txt_stor_name;
        private TextBox txt_stor_id;
    }
}