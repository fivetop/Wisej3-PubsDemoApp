using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmSales : Form
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
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.tabSales = new Wisej.Web.TabControl();
            this.tabPageSalesMaster = new Wisej.Web.TabPage();
            this.tabPageSalesDetails = new Wisej.Web.TabPage();
            this.pnl_SalesMaster = new Wisej.Web.Panel();
            this.cmb_payterms = new Wisej.Web.ComboBox();
            this.dtp_stor_ord_date = new Wisej.Web.DateTimePicker();
            this.txt_stor_ord_num = new Wisej.Web.TextBox();
            this.txt_stor_id = new Wisej.Web.MaskedTextBox();
            this.lbl_stor_name = new Wisej.Web.TextBox();
            this.dtp_ord_date = new Wisej.Web.DateTimePicker();
            this.txt_ord_num = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.dgv_SalesDetails = new Wisej.Web.DataGridView();
            this.dgvc_ord_num = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_qbe_titles = new Wisej.Web.DataGridViewButtonColumn();
            this.dgvc_title = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_qty = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.dgvc_price = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dgvc_title_id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.pnl_SalesMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesDetails)).BeginInit();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 434);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(726, 60);
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
            this.tabDataNavigator.Size = new System.Drawing.Size(726, 434);
            this.tabDataNavigator.TabIndex = 19;
            this.tabDataNavigator.SelectedIndexChanged += new System.EventHandler(this.tabDataNavigator_SelectedIndexChanged);
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabSales);
            this.tabForm.Controls.Add(this.pnl_SalesMaster);
            this.tabForm.Controls.Add(this.label1);
            this.tabForm.Controls.Add(this.dgv_SalesDetails);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(724, 393);
            this.tabForm.Text = "Form View";
            // 
            // tabSales
            // 
            this.tabSales.BorderStyle = Wisej.Web.BorderStyle.None;
            this.tabSales.Controls.Add(this.tabPageSalesMaster);
            this.tabSales.Controls.Add(this.tabPageSalesDetails);
            this.tabSales.Dock = Wisej.Web.DockStyle.Top;
            this.tabSales.Location = new System.Drawing.Point(0, 0);
            this.tabSales.Name = "tabSales";
            this.tabSales.PageInsets = new Wisej.Web.Padding(0, 40, 0, 0);
            this.tabSales.Size = new System.Drawing.Size(724, 38);
            this.tabSales.TabIndex = 11;
            this.tabSales.SelectedIndexChanged += new System.EventHandler(this.tabSales_SelectedIndexChanged);
            // 
            // tabPageSalesMaster
            // 
            this.tabPageSalesMaster.Location = new System.Drawing.Point(0, 40);
            this.tabPageSalesMaster.Name = "tabPageSalesMaster";
            this.tabPageSalesMaster.Size = new System.Drawing.Size(724, 0);
            this.tabPageSalesMaster.Text = "Sales Master";
            // 
            // tabPageSalesDetails
            // 
            this.tabPageSalesDetails.Location = new System.Drawing.Point(0, 40);
            this.tabPageSalesDetails.Name = "tabPageSalesDetails";
            this.tabPageSalesDetails.Size = new System.Drawing.Size(724, -2);
            this.tabPageSalesDetails.Text = "Sales Details";
            // 
            // pnl_SalesMaster
            // 
            this.pnl_SalesMaster.Controls.Add(this.cmb_payterms);
            this.pnl_SalesMaster.Controls.Add(this.dtp_stor_ord_date);
            this.pnl_SalesMaster.Controls.Add(this.txt_stor_ord_num);
            this.pnl_SalesMaster.Controls.Add(this.txt_stor_id);
            this.pnl_SalesMaster.Controls.Add(this.lbl_stor_name);
            this.pnl_SalesMaster.Controls.Add(this.dtp_ord_date);
            this.pnl_SalesMaster.Controls.Add(this.txt_ord_num);
            this.pnl_SalesMaster.Location = new System.Drawing.Point(3, 42);
            this.pnl_SalesMaster.Name = "pnl_SalesMaster";
            this.pnl_SalesMaster.Size = new System.Drawing.Size(718, 107);
            this.pnl_SalesMaster.TabIndex = 12;
            // 
            // cmb_payterms
            // 
            this.cmb_payterms.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_payterms.Items.AddRange(new object[] {
            "ON Invoice",
            "Net 30",
            "Net 60",
            "Net 90",
            "Net 120",
            "Gift"});
            this.cmb_payterms.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_payterms.LabelText = "Payment Terms";
            this.cmb_payterms.Location = new System.Drawing.Point(538, 3);
            this.cmb_payterms.Name = "cmb_payterms";
            this.cmb_payterms.Size = new System.Drawing.Size(168, 48);
            this.cmb_payterms.TabIndex = 13;
            // 
            // dtp_stor_ord_date
            // 
            this.dtp_stor_ord_date.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_stor_ord_date.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_stor_ord_date.LabelText = "Store Order Date";
            this.dtp_stor_ord_date.Location = new System.Drawing.Point(148, 54);
            this.dtp_stor_ord_date.Name = "dtp_stor_ord_date";
            this.dtp_stor_ord_date.Size = new System.Drawing.Size(108, 48);
            this.dtp_stor_ord_date.TabIndex = 12;
            this.dtp_stor_ord_date.Value = new System.DateTime(((long)(0)));
            // 
            // txt_stor_ord_num
            // 
            this.txt_stor_ord_num.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_ord_num.LabelText = "Store Order Num.";
            this.txt_stor_ord_num.Location = new System.Drawing.Point(4, 54);
            this.txt_stor_ord_num.MaxLength = 20;
            this.txt_stor_ord_num.Name = "txt_stor_ord_num";
            this.txt_stor_ord_num.Size = new System.Drawing.Size(141, 48);
            this.txt_stor_ord_num.TabIndex = 11;
            // 
            // txt_stor_id
            // 
            this.txt_stor_id.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.txt_stor_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_stor_id.LabelText = "Store ";
            this.txt_stor_id.Location = new System.Drawing.Point(197, 3);
            this.txt_stor_id.Name = "txt_stor_id";
            this.txt_stor_id.Size = new System.Drawing.Size(100, 48);
            this.txt_stor_id.TabIndex = 8;
            componentTool1.ImageSource = "icon-search";
            componentTool1.Name = "Search";
            componentTool1.ToolTipText = "Search Store";
            componentTool2.ImageSource = "tab-close";
            componentTool2.Name = "Clear";
            componentTool2.ToolTipText = "Clear Store";
            this.txt_stor_id.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2});
            this.txt_stor_id.ToolClick += new Wisej.Web.ToolClickEventHandler(this.txt_stor_id_ToolClick);
            this.txt_stor_id.TextChanged += new System.EventHandler(this.txt_stor_id_TextChanged);
            // 
            // lbl_stor_name
            // 
            this.lbl_stor_name.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_stor_name.Location = new System.Drawing.Point(300, 21);
            this.lbl_stor_name.Name = "lbl_stor_name";
            this.lbl_stor_name.ReadOnly = true;
            this.lbl_stor_name.Size = new System.Drawing.Size(235, 30);
            this.lbl_stor_name.TabIndex = 7;
            this.lbl_stor_name.TabStop = false;
            // 
            // dtp_ord_date
            // 
            this.dtp_ord_date.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_ord_date.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_ord_date.LabelText = "Order Date";
            this.dtp_ord_date.Location = new System.Drawing.Point(86, 3);
            this.dtp_ord_date.Name = "dtp_ord_date";
            this.dtp_ord_date.Size = new System.Drawing.Size(108, 48);
            this.dtp_ord_date.TabIndex = 10;
            this.dtp_ord_date.Value = new System.DateTime(((long)(0)));
            // 
            // txt_ord_num
            // 
            this.txt_ord_num.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ord_num.LabelText = "Order Number";
            this.txt_ord_num.Location = new System.Drawing.Point(4, 3);
            this.txt_ord_num.MaxLength = 20;
            this.txt_ord_num.Name = "txt_ord_num";
            this.txt_ord_num.ReadOnly = true;
            this.txt_ord_num.Size = new System.Drawing.Size(80, 48);
            this.txt_ord_num.TabIndex = 9;
            this.txt_ord_num.TextChanged += new System.EventHandler(this.txt_ord_num_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sales Details";
            // 
            // dgv_SalesDetails
            // 
            this.dgv_SalesDetails.AutoGenerateColumns = false;
            this.dgv_SalesDetails.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_ord_num,
            this.dgvc_title_id,
            this.dgvc_qbe_titles,
            this.dgvc_title,
            this.dgvc_qty,
            this.dgvc_price});
            this.dgv_SalesDetails.DefaultRowHeight = 20;
            this.dgv_SalesDetails.Location = new System.Drawing.Point(5, 170);
            this.dgv_SalesDetails.Name = "dgv_SalesDetails";
            this.dgv_SalesDetails.SelectionMode = Wisej.Web.DataGridViewSelectionMode.NoSelection;
            this.dgv_SalesDetails.Size = new System.Drawing.Size(699, 214);
            this.dgv_SalesDetails.TabIndex = 3;
            this.dgv_SalesDetails.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_SalesDetails_CellValueChanged);
            this.dgv_SalesDetails.DataBindingComplete += new Wisej.Web.DataGridViewBindingCompleteEventHandler(this.dgv_SalesDetails_DataBindingComplete);
            this.dgv_SalesDetails.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_SalesDetails_CellClick);
            // 
            // dgvc_ord_num
            // 
            this.dgvc_ord_num.DataPropertyName = "ord_num";
            this.dgvc_ord_num.HeaderText = "dgvc_ord_num";
            this.dgvc_ord_num.Name = "dgvc_ord_num";
            this.dgvc_ord_num.Visible = false;
            // 
            // dgvc_qbe_titles
            // 
            this.dgvc_qbe_titles.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.NullValue = "...";
            this.dgvc_qbe_titles.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvc_qbe_titles.HeaderText = "?";
            this.dgvc_qbe_titles.Name = "dgvc_qbe_titles";
            this.dgvc_qbe_titles.Text = "...";
            this.dgvc_qbe_titles.Width = 20;
            // 
            // dgvc_title
            // 
            this.dgvc_title.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.dgvc_title.HeaderText = "Title";
            this.dgvc_title.Name = "dgvc_title";
            this.dgvc_title.ReadOnly = true;
            this.dgvc_title.Width = 200;
            // 
            // dgvc_qty
            // 
            this.dgvc_qty.DataPropertyName = "qty";
            this.dgvc_qty.HeaderText = "Qty";
            this.dgvc_qty.HideUpDownButtons = true;
            this.dgvc_qty.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dgvc_qty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.dgvc_qty.Name = "dgvc_qty";
            // 
            // dgvc_price
            // 
            this.dgvc_price.DataPropertyName = "price";
            this.dgvc_price.DecimalPlaces = 2;
            this.dgvc_price.HeaderText = "Unit Price";
            this.dgvc_price.HideUpDownButtons = true;
            this.dgvc_price.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dgvc_price.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dgvc_price.Name = "dgvc_price";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(724, 393);
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
            this.dgvList.Size = new System.Drawing.Size(718, 387);
            this.dgvList.TabIndex = 0;
            // 
            // dgvc_title_id
            // 
            this.dgvc_title_id.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.dgvc_title_id.DataPropertyName = "title_id";
            this.dgvc_title_id.HeaderText = "Title ID";
            this.dgvc_title_id.MaxInputLength = 6;
            this.dgvc_title_id.Name = "dgvc_title_id";
            this.dgvc_title_id.Width = 120;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 494);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.pnl_SalesMaster.ResumeLayout(false);
            this.pnl_SalesMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesDetails)).EndInit();
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
        private DataGridView dgv_SalesDetails;
        private DataGridViewButtonColumn dgvc_qbe_titles;
        private DataGridViewTextBoxColumn dgvc_title;
        private DataGridViewNumericUpDownColumn dgvc_qty;
        private MaskedTextBox txt_stor_id;
        private TextBox lbl_stor_name;
        private TextBox txt_ord_num;
        private DateTimePicker dtp_ord_date;
        private Label label1;
        private Panel pnl_SalesMaster;
        private TabControl tabSales;
        private TabPage tabPageSalesMaster;
        private TabPage tabPageSalesDetails;
        private DataGridViewTextBoxColumn dgvc_ord_num;
        private ComboBox cmb_payterms;
        private DateTimePicker dtp_stor_ord_date;
        private TextBox txt_stor_ord_num;
        private DataGridViewNumericUpDownColumn dgvc_price;
        private DataGridViewTextBoxColumn dgvc_title_id;
    }
}
