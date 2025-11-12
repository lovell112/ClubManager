namespace ClubManager.Views
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelImage = new Panel();
            panelLogin = new Panel();
            linkQuenMatKhau = new LinkLabel();
            btnLogin = new Button();
            btnThoat = new Button();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            pictureBoxUser = new PictureBox();
            panelName = new Panel();
            labelName = new Label();
            panelLogo = new Panel();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            panelName.SuspendLayout();
            SuspendLayout();
            // 
            // panelImage
            // 
            panelImage.BackgroundImage = Properties.Resources.ImageSanNha;
            panelImage.BackgroundImageLayout = ImageLayout.Stretch;
            panelImage.Dock = DockStyle.Left;
            panelImage.Location = new Point(0, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(395, 653);
            panelImage.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(linkQuenMatKhau);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(btnThoat);
            panelLogin.Controls.Add(txtPass);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(txtUser);
            panelLogin.Controls.Add(pictureBoxUser);
            panelLogin.Controls.Add(panelName);
            panelLogin.Controls.Add(panelLogo);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(395, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(449, 653);
            panelLogin.TabIndex = 1;
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.Location = new Point(164, 592);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new Size(146, 20);
            linkQuenMatKhau.TabIndex = 5;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "FORGOT PASSWORD";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(100, 517);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Location = new Point(263, 517);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 39);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "EXIT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            btnThoat.MouseEnter += btnThoat_MouseEnter;
            btnThoat.MouseLeave += btnThoat_MouseLeave;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(115, 434);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(278, 34);
            txtPass.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPasss;
            pictureBox1.Location = new Point(22, 428);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(115, 350);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(278, 34);
            txtUser.TabIndex = 0;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(22, 344);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(40, 40);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 2;
            pictureBoxUser.TabStop = false;
            // 
            // panelName
            // 
            panelName.Controls.Add(labelName);
            panelName.Location = new Point(81, 179);
            panelName.Name = "panelName";
            panelName.Size = new Size(294, 84);
            panelName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.Highlight;
            labelName.Location = new Point(19, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(263, 64);
            labelName.TabIndex = 0;
            labelName.Text = "   FAKE MADRID \r\nCLUB DE FÚTBOL";
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.Logo;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Location = new Point(146, 23);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(150, 150);
            panelLogo.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 653);
            Controls.Add(panelLogin);
            Controls.Add(panelImage);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += frmLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            panelName.ResumeLayout(false);
            panelName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImage;
        private Panel panelLogin;
        private Panel panelName;
        private Label labelName;
        private Panel panelLogo;
        private Button btnLogin;
        private Button btnThoat;
        private TextBox txtPass;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private PictureBox pictureBoxUser;
        private LinkLabel linkQuenMatKhau;
    }
}