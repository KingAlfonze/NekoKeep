namespace NekoKeep
{
    partial class frmMPIN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMPIN));
            btnNext = new Panel();
            panel1 = new Panel();
            mpin_6 = new Panel();
            mpin_4 = new Panel();
            mpin_5 = new Panel();
            mpin_3 = new Panel();
            mpin_2 = new Panel();
            mpin_1 = new Panel();
            mpin_text = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(725, 657);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(146, 41);
            btnNext.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(mpin_6);
            panel1.Controls.Add(mpin_4);
            panel1.Controls.Add(mpin_5);
            panel1.Controls.Add(mpin_3);
            panel1.Controls.Add(mpin_2);
            panel1.Controls.Add(mpin_1);
            panel1.Location = new Point(258, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 236);
            panel1.TabIndex = 1;
            // 
            // mpin_6
            // 
            mpin_6.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_6.BackgroundImageLayout = ImageLayout.Center;
            mpin_6.Cursor = Cursors.IBeam;
            mpin_6.Location = new Point(904, 54);
            mpin_6.Name = "mpin_6";
            mpin_6.Size = new Size(146, 143);
            mpin_6.TabIndex = 1;
            // 
            // mpin_4
            // 
            mpin_4.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_4.BackgroundImageLayout = ImageLayout.Center;
            mpin_4.Cursor = Cursors.IBeam;
            mpin_4.Location = new Point(556, 54);
            mpin_4.Name = "mpin_4";
            mpin_4.Size = new Size(146, 143);
            mpin_4.TabIndex = 2;
            // 
            // mpin_5
            // 
            mpin_5.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_5.BackgroundImageLayout = ImageLayout.Center;
            mpin_5.Cursor = Cursors.IBeam;
            mpin_5.Location = new Point(730, 54);
            mpin_5.Name = "mpin_5";
            mpin_5.Size = new Size(146, 143);
            mpin_5.TabIndex = 2;
            // 
            // mpin_3
            // 
            mpin_3.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_3.BackgroundImageLayout = ImageLayout.Center;
            mpin_3.Cursor = Cursors.IBeam;
            mpin_3.Location = new Point(382, 54);
            mpin_3.Name = "mpin_3";
            mpin_3.Size = new Size(146, 143);
            mpin_3.TabIndex = 1;
            // 
            // mpin_2
            // 
            mpin_2.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_2.BackgroundImageLayout = ImageLayout.Center;
            mpin_2.Cursor = Cursors.IBeam;
            mpin_2.Location = new Point(208, 54);
            mpin_2.Name = "mpin_2";
            mpin_2.Size = new Size(146, 143);
            mpin_2.TabIndex = 1;
            // 
            // mpin_1
            // 
            mpin_1.BackgroundImage = Properties.Resources.MPIN_Blank1;
            mpin_1.BackgroundImageLayout = ImageLayout.Center;
            mpin_1.Cursor = Cursors.IBeam;
            mpin_1.Location = new Point(34, 54);
            mpin_1.Name = "mpin_1";
            mpin_1.Size = new Size(146, 143);
            mpin_1.TabIndex = 0;
            // 
            // mpin_text
            // 
            mpin_text.BackColor = Color.Transparent;
            mpin_text.BackgroundImage = Properties.Resources.Enter_your_MPIN_Text;
            mpin_text.BackgroundImageLayout = ImageLayout.Center;
            mpin_text.Location = new Point(614, 607);
            mpin_text.Name = "mpin_text";
            mpin_text.Size = new Size(371, 32);
            mpin_text.TabIndex = 2;
            // 
            // frmMPIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MPIN_Form;
            ClientSize = new Size(1584, 921);
            Controls.Add(mpin_text);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMPIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep - MPIN";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnNext;
        private Panel panel1;
        private Panel mpin_1;
        private Panel mpin_6;
        private Panel mpin_4;
        private Panel mpin_5;
        private Panel mpin_3;
        private Panel mpin_2;
        private Panel mpin_text;
    }
}