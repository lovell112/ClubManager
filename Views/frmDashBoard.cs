using ClubManager.Views;

namespace ClubManager;

public partial class frmDashBoard : Form
{
    public frmDashBoard()
    {
        InitializeComponent();
    }

    private void frmDashBoard_Load(object sender, EventArgs e)
    {
        LogoutToolStripMenuItem.Visible = false;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmLogin login = new frmLogin();
        login.ShowDialog();
        LogoutToolStripMenuItem.Visible = true;
    }

    
}