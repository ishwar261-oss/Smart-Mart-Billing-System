namespace SmartMartBillingSystem
{
    partial class LoginForm
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
            bgpnl1 = new Panel();
            bgpnl2 = new Panel();
            lblHeading = new Label();
            pictureBox1 = new PictureBox();
            pnlheading = new Panel();
            bgpnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlheading.SuspendLayout();
            SuspendLayout();
            // 
            // bgpnl1
            // 
            bgpnl1.Anchor = AnchorStyles.None;
            bgpnl1.BackColor = Color.SeaShell;
            bgpnl1.BorderStyle = BorderStyle.FixedSingle;
            bgpnl1.Controls.Add(pnlheading);
            bgpnl1.Controls.Add(pictureBox1);
            bgpnl1.Controls.Add(bgpnl2);
            bgpnl1.Location = new Point(336, 29);
            bgpnl1.Name = "bgpnl1";
            bgpnl1.Size = new Size(800, 750);
            bgpnl1.TabIndex = 0;
            // 
            // bgpnl2
            // 
            bgpnl2.BackColor = Color.White;
            bgpnl2.Location = new Point(0, 309);
            bgpnl2.Name = "bgpnl2";
            bgpnl2.Size = new Size(800, 450);
            bgpnl2.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Transparent;
            lblHeading.Location = new Point(131, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(542, 50);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "SMART MART SUPRTMARKET";
            lblHeading.Click += lblHeading_Click;
            // 
            // pictureBox1
            // 
           
            pictureBox1.Location = new Point(305, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 200);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlheading
            // 
            pnlheading.BackColor = Color.DodgerBlue;
            pnlheading.Controls.Add(lblHeading);
            pnlheading.Dock = DockStyle.Top;
            pnlheading.Location = new Point(0, 0);
            pnlheading.Name = "pnlheading";
            pnlheading.Size = new Size(798, 64);
            pnlheading.TabIndex = 3;
            pnlheading.Paint += pnlheading_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
       
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 803);
            Controls.Add(bgpnl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "LoginForm";
            Opacity = 0.01D;
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            bgpnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlheading.ResumeLayout(false);
            pnlheading.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgpnl1;
        private Panel bgpnl2;
        private Label lblHeading;
        private PictureBox pictureBox1;
        private Panel pnlheading;
    }
}