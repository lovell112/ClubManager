using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManager.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // 🔹 Ban đầu tắt nút xác nhận
            btnLogin.Enabled = false;

            #region Gắn sự kiện theo dõi khi nhập tên
            txtUser.TextChanged += (s, args) =>
            {
                bool coTen = !string.IsNullOrWhiteSpace(txtUser.Text);
                bool coPass = !string.IsNullOrWhiteSpace(txtPass.Text);
                if( coTen && coPass ) btnLogin.Enabled = true;
            };
            txtPass.TextChanged += (s, args) =>
            {
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

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
