
namespace WisejPubsDemoApp
{
    partial class frmLogin
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
            this.txt_UserName = new Wisej.Web.TextBox();
            this.txt_Password = new Wisej.Web.TextBox();
            this.btn_Login = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_UserName.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_UserName.LabelText = "User Name";
            this.txt_UserName.Location = new System.Drawing.Point(49, 18);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(203, 46);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.Watermark = "Your Username";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.InputType.Type = Wisej.Web.TextBoxType.Password;
            this.txt_Password.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.LabelText = "Password";
            this.txt_Password.Location = new System.Drawing.Point(49, 66);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(203, 46);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Watermark = "Your Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(97, 121);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 27);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(295, 162);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.KeepCentered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
            this.Text = "Wisej Pubs Demo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txt_UserName;
        private Wisej.Web.TextBox txt_Password;
        private Wisej.Web.Button btn_Login;
    }
}