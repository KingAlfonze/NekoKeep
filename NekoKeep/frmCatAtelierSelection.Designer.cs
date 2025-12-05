namespace NekoKeep
{
    partial class frmCatAtelierSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatAtelierSelection));
            btnNext = new Panel();
            btnBackward = new Panel();
            btnForward = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(728, 858);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(147, 42);
            btnNext.TabIndex = 0;
            // 
            // btnBackward
            // 
            btnBackward.BackColor = Color.Transparent;
            btnBackward.Cursor = Cursors.Hand;
            btnBackward.Location = new Point(151, 449);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(225, 154);
            btnBackward.TabIndex = 1;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.Transparent;
            btnForward.Cursor = Cursors.Hand;
            btnForward.Location = new Point(1238, 450);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(225, 154);
            btnForward.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.NekoKeep_Gray_Cat1;
            pictureBox1.Location = new Point(604, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 673);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmCatAtelierSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Cat_Atelier_Form;
            ClientSize = new Size(1584, 921);
            Controls.Add(pictureBox1);
            Controls.Add(btnForward);
            Controls.Add(btnBackward);
            Controls.Add(btnNext);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCatAtelierSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep - Cat Atelier Selection";
            Load += frmCatAtelierSelection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel btnNext;
        private Panel btnBackward;
        private Panel btnForward;
        private PictureBox pictureBox1;
    }
}