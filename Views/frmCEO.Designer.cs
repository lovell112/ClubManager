namespace ClubManager.Views
{
    partial class frmCEO
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
            imgTinh = new PictureBox();
            imgLong = new PictureBox();
            imgSon = new PictureBox();
            imgThai = new PictureBox();
            imgBao = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblExit = new Label();
            ((System.ComponentModel.ISupportInitialize)imgTinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgThai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBao).BeginInit();
            SuspendLayout();
            // 
            // imgTinh
            // 
            imgTinh.Cursor = Cursors.Hand;
            imgTinh.Image = Properties.Resources.CEOTinh;
            imgTinh.Location = new Point(36, 335);
            imgTinh.Margin = new Padding(3, 2, 3, 2);
            imgTinh.Name = "imgTinh";
            imgTinh.Size = new Size(309, 366);
            imgTinh.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTinh.TabIndex = 0;
            imgTinh.TabStop = false;
            imgTinh.Click += imgTinh_Click;
            // 
            // imgLong
            // 
            imgLong.Cursor = Cursors.Hand;
            imgLong.Image = Properties.Resources.CEOLong;
            imgLong.Location = new Point(412, 335);
            imgLong.Margin = new Padding(3, 2, 3, 2);
            imgLong.Name = "imgLong";
            imgLong.Size = new Size(309, 366);
            imgLong.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLong.TabIndex = 1;
            imgLong.TabStop = false;
            imgLong.Click += imgLong_Click;
            // 
            // imgSon
            // 
            imgSon.Cursor = Cursors.Hand;
            imgSon.Image = Properties.Resources.CEOSon;
            imgSon.Location = new Point(792, 335);
            imgSon.Margin = new Padding(3, 2, 3, 2);
            imgSon.Name = "imgSon";
            imgSon.Size = new Size(309, 366);
            imgSon.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSon.TabIndex = 2;
            imgSon.TabStop = false;
            imgSon.Click += imgSon_Click;
            // 
            // imgThai
            // 
            imgThai.Cursor = Cursors.Hand;
            imgThai.Image = Properties.Resources.CEOTHAI;
            imgThai.Location = new Point(1187, 335);
            imgThai.Margin = new Padding(3, 2, 3, 2);
            imgThai.Name = "imgThai";
            imgThai.Size = new Size(309, 366);
            imgThai.SizeMode = PictureBoxSizeMode.StretchImage;
            imgThai.TabIndex = 3;
            imgThai.TabStop = false;
            imgThai.Click += imgThai_Click;
            // 
            // imgBao
            // 
            imgBao.Cursor = Cursors.Hand;
            imgBao.Image = Properties.Resources.CEOBao;
            imgBao.Location = new Point(1580, 335);
            imgBao.Margin = new Padding(3, 2, 3, 2);
            imgBao.Name = "imgBao";
            imgBao.Size = new Size(309, 366);
            imgBao.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBao.TabIndex = 4;
            imgBao.TabStop = false;
            imgBao.Click += imgBao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(84, 723);
            label1.Name = "label1";
            label1.Size = new Size(225, 52);
            label1.TabIndex = 5;
            label1.Text = "Dang N.T.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(430, 723);
            label2.Name = "label2";
            label2.Size = new Size(276, 52);
            label2.TabIndex = 6;
            label2.Text = "Nguyen H.L.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(820, 723);
            label3.Name = "label3";
            label3.Size = new Size(256, 52);
            label3.TabIndex = 7;
            label3.Text = "Tran N.X.S.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(1236, 723);
            label4.Name = "label4";
            label4.Size = new Size(225, 52);
            label4.TabIndex = 8;
            label4.Text = "Dong Q.T.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(1645, 723);
            label5.Name = "label5";
            label5.Size = new Size(195, 52);
            label5.TabIndex = 9;
            label5.Text = "Kha T.B.";
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Transparent;
            lblExit.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.Black;
            lblExit.Location = new Point(1829, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(95, 69);
            lblExit.TabIndex = 10;
            lblExit.Text = "❌";
            lblExit.Click += lblExit_Click;
            // 
            // frmCEO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgoundCEO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 1060);
            Controls.Add(lblExit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imgBao);
            Controls.Add(imgThai);
            Controls.Add(imgSon);
            Controls.Add(imgLong);
            Controls.Add(imgTinh);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCEO";
            ShowIcon = false;
            Text = "CEO";
            WindowState = FormWindowState.Maximized;
            Load += frmCEO_Load;
            ((System.ComponentModel.ISupportInitialize)imgTinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLong).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSon).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgThai).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgTinh;
        private PictureBox imgLong;
        private PictureBox imgSon;
        private PictureBox imgThai;
        private PictureBox imgBao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblExit;
    }
}