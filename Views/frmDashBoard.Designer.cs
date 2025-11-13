namespace ClubManager;

partial class frmDashBoard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
        statusStrip1 = new StatusStrip();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        panelHeader = new Panel();
        picC1 = new PictureBox();
        menuStrip1 = new MenuStrip();
        SystemToolStripMenuItem = new ToolStripMenuItem();
        LoginToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        LogoutToolStripMenuItem = new ToolStripMenuItem();
        ExitToolStripMenuItem = new ToolStripMenuItem();
        CategoryToolStripMenuItem = new ToolStripMenuItem();
        TitleToolStripMenuItem = new ToolStripMenuItem();
        MatchScheduleMenuItem = new ToolStripMenuItem();
        ShopToolStripMenuItem = new ToolStripMenuItem();
        listCeoToolStripMenuItem = new ToolStripMenuItem();
        PlayerManagementToolStripMenuItem = new ToolStripMenuItem();
        PlayerListToolStripMenuItem = new ToolStripMenuItem();
        PlayerContractToolStripMenuItem = new ToolStripMenuItem();
        ManageCoachToolStripMenuItem = new ToolStripMenuItem();
        ListCoachToolStripMenuItem = new ToolStripMenuItem();
        CoachContractToolStripMenuItem = new ToolStripMenuItem();
        ScheduleMenuItem = new ToolStripMenuItem();
        HelpToolStripMenuItem1 = new ToolStripMenuItem();
        picLogo = new PictureBox();
        timer1 = new System.Windows.Forms.Timer(components);
        toolTip1 = new ToolTip(components);
        lblInfor = new ToolStripStatusLabel();
        statusStrip1.SuspendLayout();
        panelHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picC1).BeginInit();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        SuspendLayout();
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblInfor });
        statusStrip1.Location = new Point(0, 1027);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1924, 28);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(182, 22);
        toolStripStatusLabel1.Text = "toolStripStatusLabel1";
        // 
        // panelHeader
        // 
        panelHeader.Controls.Add(picC1);
        panelHeader.Controls.Add(menuStrip1);
        panelHeader.Controls.Add(picLogo);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(1924, 88);
        panelHeader.TabIndex = 2;
        // 
        // picC1
        // 
        picC1.BackgroundImage = (Image)resources.GetObject("picC1.BackgroundImage");
        picC1.BackgroundImageLayout = ImageLayout.Stretch;
        picC1.Location = new Point(1758, 0);
        picC1.Name = "picC1";
        picC1.Size = new Size(80, 80);
        picC1.TabIndex = 1;
        picC1.TabStop = false;
        // 
        // menuStrip1
        // 
        menuStrip1.Dock = DockStyle.None;
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { SystemToolStripMenuItem, CategoryToolStripMenuItem, PlayerManagementToolStripMenuItem, ManageCoachToolStripMenuItem, ScheduleMenuItem, HelpToolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(885, 34);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // SystemToolStripMenuItem
        // 
        SystemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoginToolStripMenuItem, toolStripSeparator1, LogoutToolStripMenuItem, ExitToolStripMenuItem });
        SystemToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
        SystemToolStripMenuItem.Size = new Size(138, 30);
        SystemToolStripMenuItem.Text = "&HỆ THỐNG";
        // 
        // LoginToolStripMenuItem
        // 
        LoginToolStripMenuItem.Image = Properties.Resources.iconLogin;
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
        LoginToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.L;
        LoginToolStripMenuItem.Size = new Size(348, 30);
        LoginToolStripMenuItem.Text = "&ĐĂNG NHẬP";
        LoginToolStripMenuItem.Click += LoginToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(345, 6);
        // 
        // LogoutToolStripMenuItem
        // 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
        LogoutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.O;
        LogoutToolStripMenuItem.Size = new Size(348, 30);
        LogoutToolStripMenuItem.Text = "ĐĂNG &XUẤT";
        LogoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
        // 
        // ExitToolStripMenuItem
        // 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
        ExitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.E;
        ExitToolStripMenuItem.Size = new Size(348, 30);
        ExitToolStripMenuItem.Text = "&THOÁT";
        ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        // 
        // CategoryToolStripMenuItem
        // 
        CategoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TitleToolStripMenuItem, MatchScheduleMenuItem, ShopToolStripMenuItem, listCeoToolStripMenuItem });
        CategoryToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
        CategoryToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D;
        CategoryToolStripMenuItem.Size = new Size(144, 30);
        CategoryToolStripMenuItem.Text = "&DANH MỤC";
        // 
        // TitleToolStripMenuItem
        // 
        TitleToolStripMenuItem.Name = "TitleToolStripMenuItem";
        TitleToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.T;
        TitleToolStripMenuItem.Size = new Size(333, 30);
        TitleToolStripMenuItem.Text = "DANH &HIỆU";
        // 
        // MatchScheduleMenuItem
        // 
        MatchScheduleMenuItem.Name = "MatchScheduleMenuItem";
        MatchScheduleMenuItem.Size = new Size(333, 30);
        MatchScheduleMenuItem.Text = "LỊCH THI ĐẤU";
        // 
        // ShopToolStripMenuItem
        // 
        ShopToolStripMenuItem.Name = "ShopToolStripMenuItem";
        ShopToolStripMenuItem.Size = new Size(333, 30);
        ShopToolStripMenuItem.Text = "CỬA HÀNG";
        // 
        // listCeoToolStripMenuItem
        // 
        listCeoToolStripMenuItem.Name = "listCeoToolStripMenuItem";
        listCeoToolStripMenuItem.Size = new Size(333, 30);
        listCeoToolStripMenuItem.Text = "DANH SÁCH CEO";
        listCeoToolStripMenuItem.Click += listCeoToolStripMenuItem_Click;
        // 
        // PlayerManagementToolStripMenuItem
        // 
        PlayerManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PlayerListToolStripMenuItem, PlayerContractToolStripMenuItem });
        PlayerManagementToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PlayerManagementToolStripMenuItem.Name = "PlayerManagementToolStripMenuItem";
        PlayerManagementToolStripMenuItem.Size = new Size(228, 30);
        PlayerManagementToolStripMenuItem.Text = "QUẢN LÝ CẦU THỦ";
        // 
        // PlayerListToolStripMenuItem
        // 
        PlayerListToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PlayerListToolStripMenuItem.Name = "PlayerListToolStripMenuItem";
        PlayerListToolStripMenuItem.Size = new Size(329, 30);
        PlayerListToolStripMenuItem.Text = "DANH SÁCH CẦU THỦ";
        // 
        // PlayerContractToolStripMenuItem
        // 
        PlayerContractToolStripMenuItem.Name = "PlayerContractToolStripMenuItem";
        PlayerContractToolStripMenuItem.Size = new Size(329, 30);
        PlayerContractToolStripMenuItem.Text = "HỢP ĐỒNG";
        // 
        // ManageCoachToolStripMenuItem
        // 
        ManageCoachToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListCoachToolStripMenuItem, CoachContractToolStripMenuItem });
        ManageCoachToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ManageCoachToolStripMenuItem.Name = "ManageCoachToolStripMenuItem";
        ManageCoachToolStripMenuItem.Size = new Size(174, 30);
        ManageCoachToolStripMenuItem.Text = "QUẢN LÝ HLV";
        // 
        // ListCoachToolStripMenuItem
        // 
        ListCoachToolStripMenuItem.Name = "ListCoachToolStripMenuItem";
        ListCoachToolStripMenuItem.Size = new Size(275, 30);
        ListCoachToolStripMenuItem.Text = "DANH SÁCH HLV";
        // 
        // CoachContractToolStripMenuItem
        // 
        CoachContractToolStripMenuItem.Name = "CoachContractToolStripMenuItem";
        CoachContractToolStripMenuItem.Size = new Size(275, 30);
        CoachContractToolStripMenuItem.Text = "HỢP ĐỒNG";
        // 
        // ScheduleMenuItem
        // 
        ScheduleMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ScheduleMenuItem.Name = "ScheduleMenuItem";
        ScheduleMenuItem.Size = new Size(83, 30);
        ScheduleMenuItem.Text = "LỊCH ";
        // 
        // HelpToolStripMenuItem1
        // 
        HelpToolStripMenuItem1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
        HelpToolStripMenuItem1.Size = new Size(110, 30);
        HelpToolStripMenuItem1.Text = "HỖ TRỢ";
        // 
        // picLogo
        // 
        picLogo.BackgroundImage = Properties.Resources.Logo;
        picLogo.BackgroundImageLayout = ImageLayout.Stretch;
        picLogo.Location = new Point(1844, 0);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(80, 80);
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // lblInfor
        // 
        lblInfor.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblInfor.Name = "lblInfor";
        lblInfor.Size = new Size(174, 22);
        lblInfor.Text = "Bạn chưa đăng nhập!";
        // 
        // frmDashBoard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1924, 1055);
        Controls.Add(panelHeader);
        Controls.Add(statusStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmDashBoard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        WindowState = FormWindowState.Maximized;
        Load += frmDashBoard_Load;
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picC1).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private Panel panelHeader;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem SystemToolStripMenuItem;
    private ToolStripMenuItem LoginToolStripMenuItem;
    private ToolStripMenuItem LogoutToolStripMenuItem;
    private ToolStripMenuItem CategoryToolStripMenuItem;
    private ToolStripMenuItem PlayerManagementToolStripMenuItem;
    private ToolStripMenuItem ManageCoachToolStripMenuItem;
    private ToolStripMenuItem ExitToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem TitleToolStripMenuItem;
    private ToolStripMenuItem MatchScheduleMenuItem;
    private ToolStripMenuItem ShopToolStripMenuItem;
    private ToolStripMenuItem ScheduleMenuItem;
    private ToolStripMenuItem HelpToolStripMenuItem1;
    private ToolStripMenuItem PlayerListToolStripMenuItem;
    private ToolStripMenuItem PlayerContractToolStripMenuItem;
    private ToolStripMenuItem ListCoachToolStripMenuItem;
    private ToolStripMenuItem CoachContractToolStripMenuItem;
    private ToolStripMenuItem listCeoToolStripMenuItem;
    private System.Windows.Forms.Timer timer1;
    private ToolTip toolTip1;
    private PictureBox picLogo;
    private PictureBox picC1;
    private ToolStripStatusLabel lblInfor;
}