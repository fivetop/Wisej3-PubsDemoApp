
namespace WisejPubsDemoApp
{
    partial class frmAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthors));
            this.txt_au_id = new Wisej.Web.TextBox();
            this.txt_phone = new Wisej.Web.TextBox();
            this.txt_au_fname = new Wisej.Web.TextBox();
            this.txt_au_lname = new Wisej.Web.TextBox();
            this.txt_address = new Wisej.Web.TextBox();
            this.txt_city = new Wisej.Web.TextBox();
            this.txt_state = new Wisej.Web.TextBox();
            this.txt_zip = new Wisej.Web.TextBox();
            this.dataNavigator1 = new BasicDALWisejControls.DataNavigator();
            this.txt_email = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // txt_au_id
            // 
            this.txt_au_id.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_au_id.LabelText = "Author ID";
            this.txt_au_id.Location = new System.Drawing.Point(13, 23);
            this.txt_au_id.Margin = new Wisej.Web.Padding(0);
            this.txt_au_id.Name = "txt_au_id";
            this.txt_au_id.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_au_id.ResponsiveProfiles"))));
            this.txt_au_id.Size = new System.Drawing.Size(110, 46);
            this.txt_au_id.TabIndex = 0;
            // 
            // txt_phone
            // 
            this.txt_phone.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.LabelText = "Author Phone Number";
            this.txt_phone.Location = new System.Drawing.Point(13, 121);
            this.txt_phone.Margin = new Wisej.Web.Padding(0);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_phone.ResponsiveProfiles"))));
            this.txt_phone.Size = new System.Drawing.Size(149, 46);
            this.txt_phone.TabIndex = 7;
            // 
            // txt_au_fname
            // 
            this.txt_au_fname.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_au_fname.LabelText = "Author First Name";
            this.txt_au_fname.Location = new System.Drawing.Point(328, 23);
            this.txt_au_fname.Margin = new Wisej.Web.Padding(0);
            this.txt_au_fname.Name = "txt_au_fname";
            this.txt_au_fname.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_au_fname.ResponsiveProfiles"))));
            this.txt_au_fname.Size = new System.Drawing.Size(193, 46);
            this.txt_au_fname.TabIndex = 2;
            // 
            // txt_au_lname
            // 
            this.txt_au_lname.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_au_lname.LabelText = "Author Last Name";
            this.txt_au_lname.Location = new System.Drawing.Point(129, 23);
            this.txt_au_lname.Margin = new Wisej.Web.Padding(0);
            this.txt_au_lname.Name = "txt_au_lname";
            this.txt_au_lname.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_au_lname.ResponsiveProfiles"))));
            this.txt_au_lname.Size = new System.Drawing.Size(193, 46);
            this.txt_au_lname.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_address.LabelText = "Author Address";
            this.txt_address.Location = new System.Drawing.Point(13, 72);
            this.txt_address.Margin = new Wisej.Web.Padding(0);
            this.txt_address.Name = "txt_address";
            this.txt_address.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_address.ResponsiveProfiles"))));
            this.txt_address.Size = new System.Drawing.Size(225, 46);
            this.txt_address.TabIndex = 3;
            // 
            // txt_city
            // 
            this.txt_city.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_city.LabelText = "Author City";
            this.txt_city.Location = new System.Drawing.Point(244, 72);
            this.txt_city.Margin = new Wisej.Web.Padding(0);
            this.txt_city.Name = "txt_city";
            this.txt_city.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_city.ResponsiveProfiles"))));
            this.txt_city.Size = new System.Drawing.Size(225, 46);
            this.txt_city.TabIndex = 4;
            // 
            // txt_state
            // 
            this.txt_state.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_state.LabelText = "Author State";
            this.txt_state.Location = new System.Drawing.Point(564, 72);
            this.txt_state.Margin = new Wisej.Web.Padding(0);
            this.txt_state.Name = "txt_state";
            this.txt_state.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_state.ResponsiveProfiles"))));
            this.txt_state.Size = new System.Drawing.Size(62, 46);
            this.txt_state.TabIndex = 6;
            // 
            // txt_zip
            // 
            this.txt_zip.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_zip.LabelText = "Author Zip Code";
            this.txt_zip.Location = new System.Drawing.Point(475, 72);
            this.txt_zip.Margin = new Wisej.Web.Padding(0);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_zip.ResponsiveProfiles"))));
            this.txt_zip.Size = new System.Drawing.Size(83, 46);
            this.txt_zip.TabIndex = 5;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Caption = "Authors";
            this.dataNavigator1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dataNavigator1.FindCaption = "Search";
            this.dataNavigator1.HeaderBackColor = System.Drawing.Color.FromName("@activeCaption");
            this.dataNavigator1.HeaderForeColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.dataNavigator1.Location = new System.Drawing.Point(0, 350);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataNavigator1.ResponsiveProfiles"))));
            this.dataNavigator1.Size = new System.Drawing.Size(637, 60);
            this.dataNavigator1.TabIndex = 0;
            this.dataNavigator1.eAddNew += new BasicDALWisejControls.DataNavigator.eAddNewEventHandler(this.dataNavigator1_eAddNew);
            this.dataNavigator1.ePrint += new BasicDALWisejControls.DataNavigator.ePrintEventHandler(this.dataNavigator1_ePrint);
            this.dataNavigator1.eDelete += new BasicDALWisejControls.DataNavigator.eDeleteEventHandler(this.dataNavigator1_eDelete);
            this.dataNavigator1.eRefresh += new BasicDALWisejControls.DataNavigator.eRefreshEventHandler(this.dataNavigator1_eRefresh);
            this.dataNavigator1.eClose += new BasicDALWisejControls.DataNavigator.eCloseEventHandler(this.dataNavigator1_eClose);
            this.dataNavigator1.eFind += new BasicDALWisejControls.DataNavigator.eFindEventHandler(this.dataNavigator1_eFind);
            this.dataNavigator1.eSave += new BasicDALWisejControls.DataNavigator.eSaveEventHandler(this.dataNavigator1_eSave);
            this.dataNavigator1.eMovePrevious += new BasicDALWisejControls.DataNavigator.eMovePreviousEventHandler(this.dataNavigator1_eMovePrevious);
            this.dataNavigator1.eMoveFirst += new BasicDALWisejControls.DataNavigator.eMoveFirstEventHandler(this.dataNavigator1_eMoveFirst);
            this.dataNavigator1.eMoveLast += new BasicDALWisejControls.DataNavigator.eMoveLastEventHandler(this.dataNavigator1_eMoveLast);
            this.dataNavigator1.eMoveNext += new BasicDALWisejControls.DataNavigator.eMoveNextEventHandler(this.dataNavigator1_eMoveNext);
            this.dataNavigator1.eUndo += new BasicDALWisejControls.DataNavigator.eUndoEventHandler(this.dataNavigator1_eUndo);
            this.dataNavigator1.eBoundCompleted += new BasicDALWisejControls.DataNavigator.eBoundCompletedEventHandler(this.dataNavigator1_eBoundCompleted);
            // 
            // txt_email
            // 
            this.txt_email.InputType.Mode = Wisej.Web.TextBoxMode.Email;
            this.txt_email.InvalidMessage = "Please insert a valid Email address";
            this.txt_email.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.LabelText = "Author Email";
            this.txt_email.Location = new System.Drawing.Point(168, 121);
            this.txt_email.Margin = new Wisej.Web.Padding(0);
            this.txt_email.Name = "txt_email";
            this.txt_email.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txt_email.ResponsiveProfiles"))));
            this.txt_email.Size = new System.Drawing.Size(210, 46);
            this.txt_email.TabIndex = 8;
            // 
            // frmAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 410);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_zip);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_au_id);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_au_fname);
            this.Controls.Add(this.txt_au_lname);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "frmAuthors";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.frmAuthors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicDALWisejControls.DataNavigator dataNavigator1;
        internal Wisej.Web.TextBox txt_au_id;
        internal Wisej.Web.TextBox txt_phone;
        internal Wisej.Web.TextBox txt_au_fname;
        internal Wisej.Web.TextBox txt_au_lname;
        internal Wisej.Web.TextBox txt_address;
        internal Wisej.Web.TextBox txt_city;
        internal Wisej.Web.TextBox txt_state;
        internal Wisej.Web.TextBox txt_zip;
        internal Wisej.Web.TextBox txt_email;
    }
}