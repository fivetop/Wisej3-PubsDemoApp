using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmRoySched : Form
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
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.tabRoyalties = new Wisej.Web.TabControl();
            this.tabPageTitles = new Wisej.Web.TabPage();
            this.tabPageRoyalties = new Wisej.Web.TabPage();
            this.txt_pub_name = new Wisej.Web.TextBox();
            this.txt_title = new Wisej.Web.TextBox();
            this.txt_title_id = new Wisej.Web.TextBox();
            this.dgvRoyalties = new Wisej.Web.DataGridView();
            this.dgvc_title_id = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.dgvc_lorange = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.dgvc_hirange = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.dgvc_royalty = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabRoyalties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoyalties)).BeginInit();
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
            this.tabDataNavigator.Size = new System.Drawing.Size(628, 410);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabRoyalties);
            this.tabForm.Controls.Add(this.txt_pub_name);
            this.tabForm.Controls.Add(this.txt_title);
            this.tabForm.Controls.Add(this.txt_title_id);
            this.tabForm.Controls.Add(this.dgvRoyalties);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(626, 369);
            this.tabForm.Text = "Form View";
            // 
            // tabRoyalties
            // 
            this.tabRoyalties.Controls.Add(this.tabPageTitles);
            this.tabRoyalties.Controls.Add(this.tabPageRoyalties);
            this.tabRoyalties.Dock = Wisej.Web.DockStyle.Top;
            this.tabRoyalties.Location = new System.Drawing.Point(0, 0);
            this.tabRoyalties.Name = "tabRoyalties";
            this.tabRoyalties.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabRoyalties.Size = new System.Drawing.Size(626, 35);
            this.tabRoyalties.TabIndex = 17;
            this.tabRoyalties.SelectedIndexChanged += new System.EventHandler(this.tabRoyalties_SelectedIndexChanged);
            // 
            // tabPageTitles
            // 
            this.tabPageTitles.Location = new System.Drawing.Point(1, 40);
            this.tabPageTitles.Name = "tabPageTitles";
            this.tabPageTitles.Size = new System.Drawing.Size(624, 0);
            this.tabPageTitles.Text = "Titles";
            // 
            // tabPageRoyalties
            // 
            this.tabPageRoyalties.Location = new System.Drawing.Point(1, 40);
            this.tabPageRoyalties.Name = "tabPageRoyalties";
            this.tabPageRoyalties.Size = new System.Drawing.Size(624, -6);
            this.tabPageRoyalties.Text = "Royalties";
            // 
            // txt_pub_name
            // 
            this.txt_pub_name.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.txt_pub_name.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pub_name.Label.Padding = new Wisej.Web.Padding(0);
            this.txt_pub_name.LabelText = "Publisher";
            this.txt_pub_name.Location = new System.Drawing.Point(371, 58);
            this.txt_pub_name.Name = "txt_pub_name";
            this.txt_pub_name.ReadOnly = true;
            this.txt_pub_name.Size = new System.Drawing.Size(246, 43);
            this.txt_pub_name.TabIndex = 16;
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.txt_title.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.Label.Padding = new Wisej.Web.Padding(0);
            this.txt_title.LabelText = "Title";
            this.txt_title.Location = new System.Drawing.Point(112, 58);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(253, 43);
            this.txt_title.TabIndex = 15;
            // 
            // txt_title_id
            // 
            this.txt_title_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title_id.Label.Padding = new Wisej.Web.Padding(0);
            this.txt_title_id.LabelText = "Title ID";
            this.txt_title_id.Location = new System.Drawing.Point(6, 58);
            this.txt_title_id.Name = "txt_title_id";
            this.txt_title_id.ReadOnly = true;
            this.txt_title_id.Size = new System.Drawing.Size(100, 43);
            this.txt_title_id.TabIndex = 14;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "Search";
            componentTool2.ToolTipText = "Search Title";
            this.txt_title_id.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txt_title_id.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_title_id_ToolClick);
            this.txt_title_id.TextChanged += new System.EventHandler(this.txt_title_id_TextChanged);
            // 
            // dgvRoyalties
            // 
            this.dgvRoyalties.AutoGenerateColumns = false;
            this.dgvRoyalties.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_title_id,
            this.dgvc_lorange,
            this.dgvc_hirange,
            this.dgvc_royalty});
            this.dgvRoyalties.Location = new System.Drawing.Point(6, 105);
            this.dgvRoyalties.Name = "dgvRoyalties";
            this.dgvRoyalties.SelectionMode = Wisej.Web.DataGridViewSelectionMode.NoSelection;
            this.dgvRoyalties.Size = new System.Drawing.Size(611, 248);
            this.dgvRoyalties.TabIndex = 13;
            // 
            // dgvc_title_id
            // 
            this.dgvc_title_id.DataPropertyName = "title_id";
            this.dgvc_title_id.HeaderText = "Title ID";
            this.dgvc_title_id.Name = "dgvc_title_id";
            this.dgvc_title_id.ReadOnly = true;
            // 
            // dgvc_lorange
            // 
            this.dgvc_lorange.DataPropertyName = "lorange";
            dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
            this.dgvc_lorange.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvc_lorange.HeaderText = "Low Range";
            this.dgvc_lorange.HideUpDownButtons = true;
            this.dgvc_lorange.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dgvc_lorange.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvc_lorange.Name = "dgvc_lorange";
            // 
            // dgvc_hirange
            // 
            this.dgvc_hirange.DataPropertyName = "hirange";
            dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
            this.dgvc_hirange.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvc_hirange.HeaderText = "High Range";
            this.dgvc_hirange.HideUpDownButtons = true;
            this.dgvc_hirange.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dgvc_hirange.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvc_hirange.Name = "dgvc_hirange";
            // 
            // dgvc_royalty
            // 
            this.dgvc_royalty.DataPropertyName = "royalty";
            dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
            this.dgvc_royalty.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvc_royalty.HeaderText = "Royalty";
            this.dgvc_royalty.HideUpDownButtons = true;
            this.dgvc_royalty.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dgvc_royalty.Name = "dgvc_royalty";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Hidden = true;
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(626, 369);
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
            this.dgvList.Size = new System.Drawing.Size(620, 363);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Titles";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 410);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(628, 60);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.eBoundCompleted += new BasicDALWisejControls.DataNavigator.eBoundCompletedEventHandler(this.dataNavigator1_eBoundCompleted);
            // 
            // frmRoySched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 470);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmRoySched";
            this.Text = "Royalties Sched.";
            this.Load += new System.EventHandler(this.frmRoySched_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabRoyalties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoyalties)).EndInit();
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
        private DataGridView dgvRoyalties;
        private DataGridViewNumericUpDownColumn dgvc_title_id;
        private DataGridViewNumericUpDownColumn dgvc_lorange;
        private DataGridViewNumericUpDownColumn dgvc_hirange;
        private DataGridViewNumericUpDownColumn dgvc_royalty;
        private TextBox txt_pub_name;
        private TextBox txt_title;
        private TextBox txt_title_id;
        private TabControl tabRoyalties;
        private TabPage tabPageTitles;
        private TabPage tabPageRoyalties;
    }

}
