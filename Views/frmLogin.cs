using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManager.Views
{
    public partial class frmLogin : Form
    {
        private int _iCount;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int iCount
        {
            get { return _iCount; }
            set { _iCount = value; }
        }

        private bool _locked;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool locked
        {
            get { return _locked; }
            set { _locked = value; }
        }
        public frmLogin()
        {
            InitializeComponent();
            iCount = 0;
            locked = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // 🔹 Ban đầu tắt nút xác nhận
            btnLogin.Enabled = false;

            #region Gắn sự kiện theo dõi khi nhập tên
                txtUser.TextChanged += (s, args) =>
                {
                    if (locked) return;
                    bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                    bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                    if (coTen && coPass) btnLogin.Enabled = true;
                };
                txtPass.TextChanged += (s, args) =>
                {
                    if (locked) return;
                    bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                    bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                    if (coTen && coPass) btnLogin.Enabled = true;
                };
            #endregion
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.ForeColor = Color.Black;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Red;          // Màu khi hover
            btnThoat.ForeColor = Color.White;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = SystemColors.Control; // Màu gốc
            btnThoat.ForeColor = Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsLoginSuccess = false;
        public string LoggedUser = ""; 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == "CEO" && pass == "ceo!")
            {
                MessageBox.Show("Xin chào CEO!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoggedUser = "CEO";
                IsLoginSuccess = true;
                this.Close(); // Đóng form login
            }
            else if (user == "CT" && pass == "ct!")
            {
                MessageBox.Show("Xin chào Cầu thủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoggedUser = "Cầu thủ";
                IsLoginSuccess = true;
                this.Close();
            }
            else if (user == "HLV" && pass == "hlv!")
            {
                MessageBox.Show("Xin chào HLV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoggedUser = "HLV";
                IsLoginSuccess = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
        }
    }
}
