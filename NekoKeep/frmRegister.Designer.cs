namespace NekoKeep
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            txtDisplayName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnContinue = new Panel();
            btnLogin = new Panel();
            SuspendLayout();
            // 
            // txtDisplayName
            // 
            txtDisplayName.BorderStyle = BorderStyle.None;
            txtDisplayName.Font = new Font("Segoe UI", 15F);
            txtDisplayName.Location = new Point(600, 378);
            txtDisplayName.Margin = new Padding(4, 3, 4, 3);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.PlaceholderText = "Display Name";
            txtDisplayName.Size = new Size(400, 27);
            txtDisplayName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(600, 463);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(400, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(600, 548);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(400, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Transparent;
            btnContinue.Cursor = Cursors.Hand;
            btnContinue.Location = new Point(743, 644);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(111, 25);
            btnContinue.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(895, 717);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(62, 25);
            btnLogin.TabIndex = 4;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register_Form;
            ClientSize = new Size(1584, 921);
            Controls.Add(btnLogin);
            Controls.Add(btnContinue);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtDisplayName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep - Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplayName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Panel btnContinue;
        private Panel btnLogin;
    }
}
