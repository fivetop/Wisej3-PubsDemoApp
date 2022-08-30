using System;
using Wisej.Web;
namespace WisejPubsDemoApp
{

    partial class frmJobs : Form
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
            this.txt_max_lvl = new Wisej.Web.TextBox();
            this.txt_min_lvl = new Wisej.Web.TextBox();
            this.txt_job_desc = new Wisej.Web.TextBox();
            this.txt_job_id = new Wisej.Web.TextBox();
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
            this.dataNavigator1.Caption = "Jobs";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@primary");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 258);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(557, 60);
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
            this.tabDataNavigator.Size = new System.Drawing.Size(557, 258);
            this.tabDataNavigator.TabIndex = 19;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txt_max_lvl);
            this.tabForm.Controls.Add(this.txt_min_lvl);
            this.tabForm.Controls.Add(this.txt_job_desc);
            this.tabForm.Controls.Add(this.txt_job_id);
            this.tabForm.Location = new System.Drawing.Point(1, 40);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(555, 217);
            this.tabForm.Text = "Form View";
            // 
            // txt_max_lvl
            // 
            this.txt_max_lvl.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_max_lvl.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_max_lvl.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_max_lvl.LabelText = "Max Level";
            this.txt_max_lvl.Location = new System.Drawing.Point(112, 56);
            this.txt_max_lvl.Name = "txt_max_lvl";
            this.txt_max_lvl.Size = new System.Drawing.Size(100, 48);
            this.txt_max_lvl.TabIndex = 12;
            // 
            // txt_min_lvl
            // 
            this.txt_min_lvl.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_min_lvl.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_min_lvl.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_min_lvl.LabelText = "Min. Level";
            this.txt_min_lvl.Location = new System.Drawing.Point(6, 56);
            this.txt_min_lvl.Name = "txt_min_lvl";
            this.txt_min_lvl.Size = new System.Drawing.Size(100, 48);
            this.txt_min_lvl.TabIndex = 11;
            // 
            // txt_job_desc
            // 
            this.txt_job_desc.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_job_desc.LabelText = "Job Description";
            this.txt_job_desc.Location = new System.Drawing.Point(112, 5);
            this.txt_job_desc.Name = "txt_job_desc";
            this.txt_job_desc.Size = new System.Drawing.Size(337, 48);
            this.txt_job_desc.TabIndex = 10;
            // 
            // txt_job_id
            // 
            this.txt_job_id.InputType.Mode = Wisej.Web.TextBoxMode.Numeric;
            this.txt_job_id.InputType.Type = Wisej.Web.TextBoxType.Number;
            this.txt_job_id.Label.Font = new System.Drawing.Font("default", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_job_id.LabelText = "Job ID";
            this.txt_job_id.Location = new System.Drawing.Point(6, 5);
            this.txt_job_id.Name = "txt_job_id";
            this.txt_job_id.Size = new System.Drawing.Size(100, 48);
            this.txt_job_id.TabIndex = 9;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgvList);
            this.tabList.Location = new System.Drawing.Point(1, 40);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new Wisej.Web.Padding(3);
            this.tabList.Size = new System.Drawing.Size(555, 217);
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
            this.dgvList.Size = new System.Drawing.Size(549, 211);
            this.dgvList.TabIndex = 0;
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 318);
            this.Controls.Add(this.tabDataNavigator);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmJobs";
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.frmJobs_Load);
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
        private TextBox txt_job_desc;
        private TextBox txt_job_id;
        private TextBox txt_max_lvl;
        private TextBox txt_min_lvl;
    }

}