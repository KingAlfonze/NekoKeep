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
            panel2 = new Panel();
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
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(251, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 293);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.MPIN_Blank1;
            panel2.Location = new Point(111, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // frmMPIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MPIN_Form;
            ClientSize = new Size(1584, 921);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMPIN";
            Text = "NekoKeep - MPIN";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnNext;
        private Panel panel1;
        private Panel panel2;
    }
}