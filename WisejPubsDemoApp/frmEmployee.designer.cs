using System;
using Wisej.Web;

namespace WisejPubsDemoApp
{
    partial class frmEmployee : Form
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
            this.txt_emp_id = new Wisej.Web.TextBox();
            this.tabDataNavigator = new Wisej.Web.TabControl();
            this.tabForm = new Wisej.Web.TabPage();
            this.txt_email = new Wisej.Web.TextBox();
            this.txt_phone = new Wisej.Web.TextBox();
            this.dtp_hire_date = new Wisej.Web.DateTimePicker();
            this.cmb_pub_id = new Wisej.Web.ComboBox();
            this.txt_job_lvl = new Wisej.Web.TextBox();
            this.cmb_job_id = new Wisej.Web.ComboBox();
            this.txt_lname = new Wisej.Web.TextBox();
            this.txt_minit = new Wisej.Web.TextBox();
            this.txt_fname = new Wisej.Web.TextBox();
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
            this.dataNavigator1.Location = new System.Drawing.Point(0, 277);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(645, 60);
            this.dataNavigator1.TabIndex = 1;
            // 
            // txt_emp_id
            // 
            this.txt_emp_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_emp_id.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_emp_id.LabelText = "Emp. ID";
            this.txt_emp_id.Location = new System.Drawing.Point(7, 6);
            this.txt_emp_id.Margin = new Wisej.Web.Padding(0);
            this.txt_emp_id.Name = "txt_emp_id";
            this.txt_emp_id.Size = new System.Drawing.Size(90, 48);
            this.txt_emp_id.TabIndex = 6;
            // 
            // tabDataNavigator
            // 
            this.tabDataNavigator.Controls.Add(this.tabForm);
            this.tabDataNavigator.Controls.Add(this.tabList);
            this.tabDataNavigator.Dock = Wisej.Web.DockStyle.Fill;
            this.tabDataNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabDataNavigator.Name = "tabDataNavigator";
            this.tabDataNavigator.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabDataNavigator.Size = new System.Drawing.Size(645, 277);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_email);
            this.tabForm.Controls.Add(this.txt_phone);
            this.tabForm.Controls.Add(this.dtp_hire_date);
            this.tabForm.Controls.Add(this.cmb_pub_id);
            this.tabForm.Controls.Add(this.txt_job_lvl);
            this.tabForm.Controls.Add(this.cmb_job_id);
            this.tabForm.Controls.Add(this.txt_lname);
            this.tabForm.Controls.Add(this.txt_minit);
            this.tabForm.Controls.Add(this.txt_fname);
            this.tabForm.Controls.Add(this.txt_emp_id);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(643, 236);
            this.tabForm.Text = "Form View";
            // 
            // txt_email
            // 
            this.txt_email.InputType.Mode = Wisej.Web.TextBoxMode.Email;
            this.txt_email.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_email.LabelText = "Email";
            this.txt_email.Location = new System.Drawing.Point(288, 108);
            this.txt_email.Margin = new Wisej.Web.Padding(0);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(254, 48);
            this.txt_email.TabIndex = 17;
            // 
            // txt_phone
            // 
            this.txt_phone.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_phone.LabelText = "Phone";
            this.txt_phone.Location = new System.Drawing.Point(129, 108);
            this.txt_phone.Margin = new Wisej.Web.Padding(0);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(154, 48);
            this.txt_phone.TabIndex = 16;
            // 
            // dtp_hire_date
            // 
            this.dtp_hire_date.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dtp_hire_date.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_hire_date.LabelText = "Hire date";
            this.dtp_hire_date.Location = new System.Drawing.Point(7, 108);
            this.dtp_hire_date.Margin = new Wisej.Web.Padding(0);
            this.dtp_hire_date.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtp_hire_date.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_hire_date.Name = "dtp_hire_date";
            this.dtp_hire_date.Size = new System.Drawing.Size(118, 48);
            this.dtp_hire_date.TabIndex = 15;
            this.dtp_hire_date.Value = new System.DateTime(((long)(0)));
            // 
            // cmb_pub_id
            // 
            this.cmb_pub_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_pub_id.LabelText = "Assigned Publisher";
            this.cmb_pub_id.Location = new System.Drawing.Point(302, 58);
            this.cmb_pub_id.Margin = new Wisej.Web.Padding(0);
            this.cmb_pub_id.Name = "cmb_pub_id";
            this.cmb_pub_id.Size = new System.Drawing.Size(222, 48);
            this.cmb_pub_id.TabIndex = 14;
            // 
            // txt_job_lvl
            // 
            this.txt_job_lvl.InputType.Max = "999";
            this.txt_job_lvl.InputType.Min = "1";
            this.txt_job_lvl.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_job_lvl.InputType.Step = 1D;
            this.txt_job_lvl.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_job_lvl.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_job_lvl.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_job_lvl.LabelText = "Job Level";
            this.txt_job_lvl.Location = new System.Drawing.Point(233, 57);
            this.txt_job_lvl.Margin = new Wisej.Web.Padding(0);
            this.txt_job_lvl.Name = "txt_job_lvl";
            this.txt_job_lvl.Size = new System.Drawing.Size(63, 48);
            this.txt_job_lvl.TabIndex = 13;
            // 
            // cmb_job_id
            // 
            this.cmb_job_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_job_id.LabelText = "Job ID";
            this.cmb_job_id.Location = new System.Drawing.Point(7, 57);
            this.cmb_job_id.Margin = new Wisej.Web.Padding(0);
            this.cmb_job_id.Name = "cmb_job_id";
            this.cmb_job_id.Size = new System.Drawing.Size(222, 48);
            this.cmb_job_id.TabIndex = 12;
            // 
            // txt_lname
            // 
            this.txt_lname.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_lname.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_lname.LabelText = "Last Name";
            this.txt_lname.Location = new System.Drawing.Point(396, 6);
            this.txt_lname.Margin = new Wisej.Web.Padding(0);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(226, 48);
            this.txt_lname.TabIndex = 11;
            // 
            // txt_minit
            // 
            this.txt_minit.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_minit.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_minit.LabelText = "Middle Name";
            this.txt_minit.Location = new System.Drawing.Point(330, 6);
            this.txt_minit.Margin = new Wisej.Web.Padding(0);
            this.txt_minit.Name = "txt_minit";
            this.txt_minit.Size = new System.Drawing.Size(63, 48);
            this.txt_minit.TabIndex = 10;
            // 
            // txt_fname
            // 
            this.txt_fname.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fname.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.txt_fname.LabelText = "First Name";
            this.txt_fname.Location = new System.Drawing.Point(101, 6);
            this.txt_fname.Margin = new Wisej.Web.Padding(0);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(226, 48);
            this.txt_fname.TabIndex = 9;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(643, 236);
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
            this.dgvList.Size = new System.Drawing.Size(637, 230);
            this.dgvList.TabIndex = 0;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.tabDataNavigator.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        private Wisej.Web.TextBox txt_emp_id;
        private Wisej.Web.TabControl tabDataNavigator;
        private Wisej.Web.TabPage tabForm;
        private Wisej.Web.TabPage tabList;
        private Wisej.Web.DataGridView dgvList;
        private TextBox txt_email;
        private TextBox txt_phone;
        private DateTimePicker dtp_hire_date;
        private ComboBox cmb_pub_id;
        private TextBox txt_job_lvl;
        private ComboBox cmb_job_id;
        private TextBox txt_lname;
        private TextBox txt_minit;
        private TextBox txt_fname;
    }

}