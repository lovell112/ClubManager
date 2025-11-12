namespace ClubManager.Views
{
    partial class frmCEOInfor
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
            imgCEO = new PictureBox();
            panelText = new Panel();
            lblText = new Label();
            lblExit = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCEO).BeginInit();
            panelText.SuspendLayout();
            SuspendLayout();
            // 
            // imgCEO
            // 
            imgCEO.Location = new Point(47, 150);
            imgCEO.Margin = new Padding(4);
            imgCEO.Name = "imgCEO";
            imgCEO.Size = new Size(200, 246);
            imgCEO.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCEO.TabIndex = 0;
            imgCEO.TabStop = false;
            // 
            // panelText
            // 
            panelText.Controls.Add(lblText);
            panelText.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelText.Location = new Point(377, 150);
            panelText.Margin = new Padding(4);
            panelText.Name = "panelText";
            panelText.Size = new Size(587, 246);
            panelText.TabIndex = 1;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Dock = DockStyle.Fill;
            lblText.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.Location = new Point(0, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(67, 26);
            lblText.TabIndex = 0;
            lblText.Text = "label1";
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 27.75F);
            lblExit.Location = new Point(960, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(77, 54);
            lblExit.TabIndex = 2;
            lblExit.Text = "❌";
            lblExit.Click += lblExit_Click;
            // 
            // frmCEOInfor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgoundCEO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 507);
            Controls.Add(lblExit);
            Controls.Add(panelText);
            Controls.Add(imgCEO);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCEOInfor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCEOInfor";
            Load += frmCEOInfor_Load;
            ((System.ComponentModel.ISupportInitialize)imgCEO).EndInit();
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgCEO;
        private Panel panelText;
        private Label lblText;
        private Label lblExit;
    }
}