using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmTitles : Form
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
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.tabTitle = new Wisej.Web.TabControl();
            this.tabPageTitles = new Wisej.Web.TabPage();
            this.tabPageTitleAuthors = new Wisej.Web.TabPage();
            this.pnl_Title = new Wisej.Web.Panel();
            this.txt_notes = new Wisej.Web.TextBox();
            this.cmb_pub_id = new Wisej.Web.ComboBox();
            this.txt_title_id = new Wisej.Web.TextBox();
            this.txt_title = new Wisej.Web.TextBox();
            this.txt_type = new Wisej.Web.TextBox();
            this.txt_price = new Wisej.Web.TextBox();
            this.dtp_pubbdate = new Wisej.Web.DateTimePicker();
            this.txt_advance = new Wisej.Web.TextBox();
            this.txt_royalty = new Wisej.Web.TextBox();
            this.txt_ytd_sales = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
            this.dgv_TitleAuthors = new Wisej.Web.DataGridView();
            this.dgvc_title_id = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_au_id = new Wisej.Web.DataGridViewMaskedTextBoxColumn();
            this.dgvc_qbe_authors = new Wisej.Web.DataGridViewButtonColumn();
            this.dgvc_au_fullname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.dgvc_au_ord = new Wisej.Web.DataGridViewNumericUpDownColumn();
            this.dgvc_royaltyper = new Wisej.Web.DataGridViewTextBoxColumn();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvListView = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabTitle.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TitleAuthors)).BeginInit();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).BeginInit();
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
            this.tabDataNavigator.Size = new System.Drawing.Size(761, 478);
            this.tabDataNavigator.TabIndex = 0;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.tabTitle);
            this.tabForm.Controls.Add(this.pnl_Title);
            this.tabForm.Controls.Add(this.label1);
            this.tabForm.Controls.Add(this.dgv_TitleAuthors);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(759, 437);
            this.tabForm.Text = "Form View";
            // 
            // tabTitle
            // 
            this.tabTitle.BorderStyle = Wisej.Web.BorderStyle.None;
            this.tabTitle.Controls.Add(this.tabPageTitles);
            this.tabTitle.Controls.Add(this.tabPageTitleAuthors);
            this.tabTitle.Dock = Wisej.Web.DockStyle.Top;
            this.tabTitle.Location = new System.Drawing.Point(0, 0);
            this.tabTitle.Name = "tabTitle";
            this.tabTitle.PageInsets = new Wisej.Web.Padding(0, 40, 0, 0);
            this.tabTitle.Size = new System.Drawing.Size(759, 38);
            this.tabTitle.TabIndex = 0;
            this.tabTitle.SelectedIndexChanged += new System.EventHandler(this.tabTitle_SelectedIndexChanged);
            // 
            // tabPageTitles
            // 
            this.tabPageTitles.Location = new System.Drawing.Point(0, 40);
            this.tabPageTitles.Name = "tabPageTitles";
            this.tabPageTitles.Size = new System.Drawing.Size(759, 0);
            this.tabPageTitles.Text = "Title";
            // 
            // tabPageTitleAuthors
            // 
            this.tabPageTitleAuthors.Location = new System.Drawing.Point(0, 40);
            this.tabPageTitleAuthors.Name = "tabPageTitleAuthors";
            this.tabPageTitleAuthors.Size = new System.Drawing.Size(759, -2);
            this.tabPageTitleAuthors.Text = "Title Authors";
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.txt_notes);
            this.pnl_Title.Controls.Add(this.cmb_pub_id);
            this.pnl_Title.Controls.Add(this.txt_title_id);
            this.pnl_Title.Controls.Add(this.txt_title);
            this.pnl_Title.Controls.Add(this.txt_type);
            this.pnl_Title.Controls.Add(this.txt_price);
            this.pnl_Title.Controls.Add(this.dtp_pubbdate);
            this.pnl_Title.Controls.Add(this.txt_advance);
            this.pnl_Title.Controls.Add(this.txt_royalty);
            this.pnl_Title.Controls.Add(this.txt_ytd_sales);
            this.pnl_Title.Location = new System.Drawing.Point(6, 45);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(731, 178);
            this.pnl_Title.TabIndex = 21;
            // 
            // txt_notes
            // 
            this.txt_notes.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_notes.LabelText = "Notes";
            this.txt_notes.Location = new System.Drawing.Point(3, 106);
            this.txt_notes.Margin = new Wisej.Web.Padding(0);
            this.txt_notes.MaxLength = 200;
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(368, 66);
            this.txt_notes.TabIndex = 9;
            // 
            // cmb_pub_id
            // 
            this.cmb_pub_id.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_pub_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_pub_id.LabelText = "Publisher";
            this.cmb_pub_id.Location = new System.Drawing.Point(3, 55);
            this.cmb_pub_id.Margin = new Wisej.Web.Padding(0);
            this.cmb_pub_id.Name = "cmb_pub_id";
            this.cmb_pub_id.Size = new System.Drawing.Size(266, 48);
            this.cmb_pub_id.TabIndex = 3;
            // 
            // txt_title_id
            // 
            this.txt_title_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title_id.LabelText = "Title ID";
            this.txt_title_id.Location = new System.Drawing.Point(3, 4);
            this.txt_title_id.Margin = new Wisej.Web.Padding(0);
            this.txt_title_id.Name = "txt_title_id";
            this.txt_title_id.Size = new System.Drawing.Size(100, 48);
            this.txt_title_id.TabIndex = 0;
            this.txt_title_id.TextChanged += new System.EventHandler(this.txt_title_id_TextChanged);
            // 
            // txt_title
            // 
            this.txt_title.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_title.LabelText = "Title";
            this.txt_title.Location = new System.Drawing.Point(109, 4);
            this.txt_title.Margin = new Wisej.Web.Padding(0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(277, 48);
            this.txt_title.TabIndex = 1;
            // 
            // txt_type
            // 
            this.txt_type.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_type.LabelText = "Type";
            this.txt_type.Location = new System.Drawing.Point(392, 4);
            this.txt_type.Margin = new Wisej.Web.Padding(0);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(277, 48);
            this.txt_type.TabIndex = 2;
            // 
            // txt_price
            // 
            this.txt_price.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.txt_price.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_price.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_price.LabelText = "Price";
            this.txt_price.Location = new System.Drawing.Point(383, 55);
            this.txt_price.Margin = new Wisej.Web.Padding(0);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(80, 48);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextAlign = Wisej.Web.HorizontalAlignment.Right;
            // 
            // dtp_pubbdate
            // 
            this.dtp_pubbdate.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_pubbdate.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_pubbdate.LabelText = "Pub. Date";
            this.dtp_pubbdate.Location = new System.Drawing.Point(272, 55);
            this.dtp_pubbdate.Margin = new Wisej.Web.Padding(0);
            this.dtp_pubbdate.Name = "dtp_pubbdate";
            this.dtp_pubbdate.Size = new System.Drawing.Size(108, 48);
            this.dtp_pubbdate.TabIndex = 4;
            this.dtp_pubbdate.Value = new System.DateTime(((long)(0)));
            // 
            // txt_advance
            // 
            this.txt_advance.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.txt_advance.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_advance.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_advance.LabelText = "Advance";
            this.txt_advance.Location = new System.Drawing.Point(468, 55);
            this.txt_advance.Margin = new Wisej.Web.Padding(0);
            this.txt_advance.Name = "txt_advance";
            this.txt_advance.Size = new System.Drawing.Size(80, 48);
            this.txt_advance.TabIndex = 6;
            this.txt_advance.TextAlign = Wisej.Web.HorizontalAlignment.Right;
            // 
            // txt_royalty
            // 
            this.txt_royalty.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_royalty.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_royalty.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_royalty.LabelText = "Royalty";
            this.txt_royalty.Location = new System.Drawing.Point(553, 55);
            this.txt_royalty.Margin = new Wisej.Web.Padding(0);
            this.txt_royalty.Name = "txt_royalty";
            this.txt_royalty.Size = new System.Drawing.Size(80, 48);
            this.txt_royalty.TabIndex = 7;
            this.txt_royalty.TextAlign = Wisej.Web.HorizontalAlignment.Right;
            // 
            // txt_ytd_sales
            // 
            this.txt_ytd_sales.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_ytd_sales.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_ytd_sales.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ytd_sales.LabelText = "Ytd Sales";
            this.txt_ytd_sales.Location = new System.Drawing.Point(638, 55);
            this.txt_ytd_sales.Margin = new Wisej.Web.Padding(0);
            this.txt_ytd_sales.Name = "txt_ytd_sales";
            this.txt_ytd_sales.Size = new System.Drawing.Size(81, 48);
            this.txt_ytd_sales.TabIndex = 8;
            this.txt_ytd_sales.TextAlign = Wisej.Web.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title Authors";
            // 
            // dgv_TitleAuthors
            // 
            this.dgv_TitleAuthors.AutoGenerateColumns = false;
            this.dgv_TitleAuthors.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.dgvc_title_id,
            this.dgvc_au_id,
            this.dgvc_qbe_authors,
            this.dgvc_au_fullname,
            this.dgvc_au_ord,
            this.dgvc_royaltyper});
            this.dgv_TitleAuthors.DefaultRowHeight = 20;
            this.dgv_TitleAuthors.Location = new System.Drawing.Point(8, 242);
            this.dgv_TitleAuthors.Name = "dgv_TitleAuthors";
            this.dgv_TitleAuthors.SelectionMode = Wisej.Web.DataGridViewSelectionMode.NoSelection;
            this.dgv_TitleAuthors.Size = new System.Drawing.Size(731, 177);
            this.dgv_TitleAuthors.TabIndex = 2;
            this.dgv_TitleAuthors.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_TitleAuthors_CellValueChanged);
            this.dgv_TitleAuthors.DataBindingComplete += new Wisej.Web.DataGridViewBindingCompleteEventHandler(this.dgv_TitleAuthors_DataBindingComplete);
            this.dgv_TitleAuthors.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dgv_TitleAuthors_CellClick);
            // 
            // dgvc_title_id
            // 
            this.dgvc_title_id.DataPropertyName = "title_id";
            this.dgvc_title_id.HeaderText = "dgvc_title_id";
            this.dgvc_title_id.Name = "dgvc_title_id";
            this.dgvc_title_id.Visible = false;
            // 
            // dgvc_au_id
            // 
            this.dgvc_au_id.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.dgvc_au_id.DataPropertyName = "au_id";
            this.dgvc_au_id.HeaderText = "Author ID";
            this.dgvc_au_id.Mask = "999-99-999";
            this.dgvc_au_id.Name = "dgvc_au_id";
            this.dgvc_au_id.Width = 120;
            // 
            // dgvc_qbe_authors
            // 
            this.dgvc_qbe_authors.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.NullValue = "...";
            this.dgvc_qbe_authors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvc_qbe_authors.HeaderText = "";
            this.dgvc_qbe_authors.Name = "dgvc_qbe_authors";
            this.dgvc_qbe_authors.Text = "...";
            this.dgvc_qbe_authors.Width = 20;
            // 
            // dgvc_au_fullname
            // 
            this.dgvc_au_fullname.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.None;
            this.dgvc_au_fullname.HeaderText = "Author";
            this.dgvc_au_fullname.Name = "dgvc_au_fullname";
            this.dgvc_au_fullname.ReadOnly = true;
            this.dgvc_au_fullname.Width = 200;
            // 
            // dgvc_au_ord
            // 
            this.dgvc_au_ord.DataPropertyName = "au_ord";
            this.dgvc_au_ord.HeaderText = "Auth.Order";
            this.dgvc_au_ord.HideUpDownButtons = true;
            this.dgvc_au_ord.Name = "dgvc_au_ord";
            // 
            // dgvc_royaltyper
            // 
            this.dgvc_royaltyper.DataPropertyName = "royaltyper";
            this.dgvc_royaltyper.HeaderText = "Royalties%";
            this.dgvc_royaltyper.InputType.Max = "100";
            this.dgvc_royaltyper.InputType.Min = "0";
            this.dgvc_royaltyper.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.dgvc_royaltyper.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.dgvc_royaltyper.Name = "dgvc_royaltyper";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvListView);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(759, 437);
            this.tabList.Text = "List View";
            // 
            // dgvListView
            // 
            this.dgvListView.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListView.AutoSizeRowsMode = Wisej.Web.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListView.Dock = Wisej.Web.DockStyle.Fill;
            this.dgvListView.KeepSameRowHeight = true;
            this.dgvListView.Location = new System.Drawing.Point(3, 3);
            this.dgvListView.Name = "dgvListView";
            this.dgvListView.ReadOnly = true;
            this.dgvListView.Size = new System.Drawing.Size(753, 431);
            this.dgvListView.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 478);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(761, 57);
            this.dataNavigator1.TabIndex = 1;
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 535);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmTitles";
            this.Text = "Titles";
            this.Load += new System.EventHandler(this.frmTitles_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabTitle.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TitleAuthors)).EndInit();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvListView;
        private TextBox txt_title_id;
        private TextBox txt_type;
        private TextBox txt_title;
        private ComboBox cmb_pub_id;
        private DateTimePicker dtp_pubbdate;
        private TextBox txt_notes;
        private TextBox txt_ytd_sales;
        private TextBox txt_royalty;
        private TextBox txt_advance;
        private TextBox txt_price;
        private Label label1;
        private DataGridView dgv_TitleAuthors;
        private TabControl tabTitle;
        private TabPage tabPageTitles;
        private TabPage tabPageTitleAuthors;
        private DataGridViewTextBoxColumn dgvc_title_id;
        private DataGridViewNumericUpDownColumn dgvc_au_ord;
        private DataGridViewButtonColumn dgvc_qbe_authors;
        private DataGridViewTextBoxColumn dgvc_au_fullname;
        private DataGridViewTextBoxColumn dgvc_royaltyper;
        private Panel pnl_Title;
        private DataGridViewMaskedTextBoxColumn dgvc_au_id;
    }
}
