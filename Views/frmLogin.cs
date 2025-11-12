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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "Son" && txtPass.Text == "Lo")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); 
                frmCEO mainForm = new frmCEO();
                mainForm.Show();
                // Thực hiện các hành động sau khi đăng nhập thành công

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                iCount++;
            }
            if(iCount >= 3)
            {
                MessageBox.Show("Bạn đã nhập sai quá nhiều lần. Ứng dụng sẽ đóng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = false;
                locked = true;
            }
        }
    }
}
