using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmDiscounts : Form
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
            this.txt_discount_id = new Wisej.Web.TextBox();
            this.txt_stor_id = new Wisej.Web.MaskedTextBox();
            this.txt_stor_name = new Wisej.Web.TextBox();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.txt_stor_city = new Wisej.Web.TextBox();
            this.cmb_stor_id = new Wisej.Web.ComboBox();
            this.txt_discount = new Wisej.Web.TextBox();
            this.txt_highqty = new Wisej.Web.TextBox();
            this.txt_lowqty = new Wisej.Web.TextBox();
            this.txt_discounttype = new Wisej.Web.TextBox();
            this.tabList = new Wisej.Web.TabPage();
            this.dgvList = new Wisej.Web.DataGridView();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.tabDataNavigator.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_discount_id
            // 
            this.txt_discount_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_discount_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_discount_id.LabelText = "Discount ID";
            this.txt_discount_id.Location = new System.Drawing.Point(12, 12);
            this.txt_discount_id.Margin = new Wisej.Web.Padding(0);
            this.txt_discount_id.Name = "txt_discount_id";
            this.txt_discount_id.Size = new System.Drawing.Size(100, 48);
            this.txt_discount_id.TabIndex = 0;
            // 
            // txt_stor_id
            // 
            this.txt_stor_id.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.txt_stor_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_stor_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_stor_id.LabelText = "Apply to Store ";
            this.txt_stor_id.Location = new System.Drawing.Point(12, 110);
            this.txt_stor_id.Margin = new Wisej.Web.Padding(0);
            this.txt_stor_id.Name = "txt_stor_id";
            this.txt_stor_id.Size = new System.Drawing.Size(114, 48);
            this.txt_stor_id.TabIndex = 6;
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
            // txt_stor_name
            // 
            this.txt_stor_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_stor_name.Location = new System.Drawing.Point(128, 128);
            this.txt_stor_name.Margin = new Wisej.Web.Padding(0);
            this.txt_stor_name.Name = "txt_stor_name";
            this.txt_stor_name.ReadOnly = true;
            this.txt_stor_name.Size = new System.Drawing.Size(238, 30);
            this.txt_stor_name.TabIndex = 2;
            this.txt_stor_name.TabStop = false;
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(539, 282);
            this.tabDataNavigator.TabIndex = 0;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_stor_city);
            this.tabForm.Controls.Add(this.cmb_stor_id);
            this.tabForm.Controls.Add(this.txt_discount);
            this.tabForm.Controls.Add(this.txt_highqty);
            this.tabForm.Controls.Add(this.txt_lowqty);
            this.tabForm.Controls.Add(this.txt_discounttype);
            this.tabForm.Controls.Add(this.txt_discount_id);
            this.tabForm.Controls.Add(this.txt_stor_id);
            this.tabForm.Controls.Add(this.txt_stor_name);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(537, 241);
            this.tabForm.Text = "Form View";
            // 
            // txt_stor_city
            // 
            this.txt_stor_city.BackColor = System.Drawing.SystemColors.Info;
            this.txt_stor_city.Location = new System.Drawing.Point(369, 128);
            this.txt_stor_city.Margin = new Wisej.Web.Padding(0);
            this.txt_stor_city.Name = "txt_stor_city";
            this.txt_stor_city.ReadOnly = true;
            this.txt_stor_city.Size = new System.Drawing.Size(141, 30);
            this.txt_stor_city.TabIndex = 7;
            this.txt_stor_city.TabStop = false;
            // 
            // cmb_stor_id
            // 
            this.cmb_stor_id.DisplayMember = "stor_name";
            this.cmb_stor_id.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmb_stor_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_stor_id.LabelText = "Apply to Store";
            this.cmb_stor_id.Location = new System.Drawing.Point(191, 61);
            this.cmb_stor_id.Margin = new Wisej.Web.Padding(0);
            this.cmb_stor_id.Name = "cmb_stor_id";
            this.cmb_stor_id.Size = new System.Drawing.Size(218, 48);
            this.cmb_stor_id.TabIndex = 5;
            this.cmb_stor_id.ValueMember = "stor_id";
            // 
            // txt_discount
            // 
            this.txt_discount.InputType.Max = "100";
            this.txt_discount.InputType.Min = "0";
            this.txt_discount.InputType.Mode = Wisej.Web.TextBoxMode.Decimal;
            this.txt_discount.InputType.Step = 0.01D;
            this.txt_discount.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_discount.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_discount.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_discount.LabelText = "Discount %";
            this.txt_discount.Location = new System.Drawing.Point(131, 61);
            this.txt_discount.Margin = new Wisej.Web.Padding(0);
            this.txt_discount.MaxLength = 5;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(54, 48);
            this.txt_discount.TabIndex = 4;
            // 
            // txt_highqty
            // 
            this.txt_highqty.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_highqty.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_highqty.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_highqty.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_highqty.LabelText = "High Qty";
            this.txt_highqty.Location = new System.Drawing.Point(72, 61);
            this.txt_highqty.Margin = new Wisej.Web.Padding(0);
            this.txt_highqty.Name = "txt_highqty";
            this.txt_highqty.Size = new System.Drawing.Size(54, 48);
            this.txt_highqty.TabIndex = 3;
            // 
            // txt_lowqty
            // 
            this.txt_lowqty.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_lowqty.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_lowqty.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lowqty.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_lowqty.LabelText = "Low Qty";
            this.txt_lowqty.Location = new System.Drawing.Point(12, 61);
            this.txt_lowqty.Margin = new Wisej.Web.Padding(0);
            this.txt_lowqty.Name = "txt_lowqty";
            this.txt_lowqty.Size = new System.Drawing.Size(54, 48);
            this.txt_lowqty.TabIndex = 2;
            // 
            // txt_discounttype
            // 
            this.txt_discounttype.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_discounttype.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_discounttype.LabelText = "Discount Type";
            this.txt_discounttype.Location = new System.Drawing.Point(118, 12);
            this.txt_discounttype.Margin = new Wisej.Web.Padding(0);
            this.txt_discounttype.Name = "txt_discounttype";
            this.txt_discounttype.Size = new System.Drawing.Size(292, 48);
            this.txt_discounttype.TabIndex = 1;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(537, 241);
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
            this.dgvList.Size = new System.Drawing.Size(531, 235);
            this.dgvList.TabIndex = 0;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Discounts";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 282);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(539, 60);
            this.dataNavigator1.TabIndex = 1;
            // 
            // frmDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmDiscounts";
            this.Text = "Discounts";
            this.Load += new System.EventHandler(this.frmDiscounts_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TextBox txt_discount_id;
        private Wisej.Web.MaskedTextBox txt_stor_id;
        private Wisej.Web.TextBox txt_stor_name;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private TextBox txt_discounttype;
        private TextBox txt_discount;
        private TextBox txt_highqty;
        private TextBox txt_lowqty;
        private ComboBox cmb_stor_id;
        private TextBox txt_stor_city;
    }
}