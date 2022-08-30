namespace RetailProWebDesktop
{
    partial class frmWisejBasicDALSimpleForm
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
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.txt_ID = new Wisej.Web.TextBox();
            this.txt_DBLookup = new Wisej.Web.MaskedTextBox();
            this.lbl_DBLookUp = new Wisej.Web.TextBox();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.button1 = new Wisej.Web.Button();
            this.txtDBDate = new Wisej.Web.TextBox();
            this.label3 = new Wisej.Web.Label();
            this.txtDBString = new Wisej.Web.TextBox();
            this.label2 = new Wisej.Web.Label();
            this.txtDBInt = new Wisej.Web.TextBox();
            this.label1 = new Wisej.Web.Label();
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
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 421);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(761, 73);
            this.dataNavigator1.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_ID.LabelText = "ID Registrazione";
            this.txt_ID.Location = new System.Drawing.Point(15, 35);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 42);
            this.txt_ID.TabIndex = 6;
            // 
            // txt_DBLookup
            // 
            this.txt_DBLookup.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_DBLookup.LabelText = "Cod. PDV";
            this.txt_DBLookup.Location = new System.Drawing.Point(121, 35);
            this.txt_DBLookup.Name = "txt_DBLookup";
            this.txt_DBLookup.ReadOnly = true;
            this.txt_DBLookup.Size = new System.Drawing.Size(91, 42);
            this.txt_DBLookup.TabIndex = 7;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "Ricerca";
            componentTool2.ToolTipText = "Ricerca PDV";
            this.txt_DBLookup.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            // 
            // lbl_DBLookUp
            // 
            this.lbl_DBLookUp.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_DBLookUp.Location = new System.Drawing.Point(213, 55);
            this.lbl_DBLookUp.Name = "lbl_DBLookUp";
            this.lbl_DBLookUp.ReadOnly = true;
            this.lbl_DBLookUp.Size = new System.Drawing.Size(255, 22);
            this.lbl_DBLookUp.TabIndex = 8;
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Location = new System.Drawing.Point(15, 97);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(717, 257);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.button1);
            this.tabForm.Controls.Add(this.txtDBDate);
            this.tabForm.Controls.Add(this.label3);
            this.tabForm.Controls.Add(this.txtDBString);
            this.tabForm.Controls.Add(this.label2);
            this.tabForm.Controls.Add(this.txtDBInt);
            this.tabForm.Controls.Add(this.label1);
            this.tabForm.Location = new System.Drawing.Point(1, 35);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(715, 221);
            this.tabForm.Text = "Scheda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            // 
            // txtDBDate
            // 
            this.txtDBDate.Location = new System.Drawing.Point(27, 83);
            this.txtDBDate.Name = "txtDBDate";
            this.txtDBDate.Size = new System.Drawing.Size(144, 22);
            this.txtDBDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DBDate";
            // 
            // txtDBString
            // 
            this.txtDBString.Label.ForeColor = System.Drawing.Color.FromName("@activeBorder");
            this.txtDBString.Label.Position = Wisej.Web.LabelPosition.Inside;
            this.txtDBString.LabelText = "TEXT";
            this.txtDBString.Location = new System.Drawing.Point(27, 132);
            this.txtDBString.Name = "txtDBString";
            this.txtDBString.Size = new System.Drawing.Size(316, 37);
            this.txtDBString.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DBString";
            // 
            // txtDBInt
            // 
            this.txtDBInt.Location = new System.Drawing.Point(27, 24);
            this.txtDBInt.Name = "txtDBInt";
            this.txtDBInt.Size = new System.Drawing.Size(100, 22);
            this.txtDBInt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DBInt";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 35);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(715, 221);
            this.tabList.Text = "Elenco";
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
            this.dgvList.Size = new System.Drawing.Size(709, 215);
            this.dgvList.TabIndex = 0;
            // 
            // frmWisejBasicDALSimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 494);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_DBLookup);
            this.Controls.Add(this.lbl_DBLookUp);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmWisejBasicDALSimpleForm";
            this.Text = "Wisej BasicDAL Simple Form";
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TextBox txt_ID;
        private Wisej.Web.MaskedTextBox txt_DBLookup;
        private Wisej.Web.TextBox lbl_DBLookUp;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.Button button1;
        private Wisej.Web.TextBox txtDBDate;
        private Wisej.Web.Label label3;
        private Wisej.Web.TextBox txtDBString;
        private Wisej.Web.Label label2;
        private Wisej.Web.TextBox txtDBInt;
        private Wisej.Web.Label label1;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
    }
}