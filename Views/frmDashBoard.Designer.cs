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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
        panelLeft = new Panel();
        picC1 = new PictureBox();
        picLogo = new PictureBox();
        statusStrip1 = new StatusStrip();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        toolStripSplitButton1 = new ToolStripSplitButton();
        panelHeader = new Panel();
        menuStrip1 = new MenuStrip();
        hỆTHỐNGToolStripMenuItem = new ToolStripMenuItem();
        đĂNGNHẬPToolStripMenuItem = new ToolStripMenuItem();
        tHOÁTToolStripMenuItem = new ToolStripMenuItem();
        tHOÁTToolStripMenuItem1 = new ToolStripMenuItem();
        dANHMỤCToolStripMenuItem = new ToolStripMenuItem();
        qUẢNLÝCẦUTHỦToolStripMenuItem = new ToolStripMenuItem();
        qUẢNLÝHLVToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        dANHHIỆUToolStripMenuItem = new ToolStripMenuItem();
        cỬAHÀNGToolStripMenuItem = new ToolStripMenuItem();
        hỖTRỢToolStripMenuItem = new ToolStripMenuItem();
        cỬAHÀNGToolStripMenuItem1 = new ToolStripMenuItem();
        hỖTRỢToolStripMenuItem1 = new ToolStripMenuItem();
        dANHSÁCHCẦUTHỦToolStripMenuItem = new ToolStripMenuItem();
        dANHSÁCHHLVToolStripMenuItem = new ToolStripMenuItem();
        hỢPĐỒNGToolStripMenuItem = new ToolStripMenuItem();
        hỢPĐỒNGToolStripMenuItem1 = new ToolStripMenuItem();
        panelLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picC1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        statusStrip1.SuspendLayout();
        panelHeader.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // panelLeft
        // 
        panelLeft.Controls.Add(picC1);
        panelLeft.Controls.Add(picLogo);
        panelLeft.Dock = DockStyle.Left;
        panelLeft.Location = new Point(0, 0);
        panelLeft.Name = "panelLeft";
        panelLeft.Size = new Size(175, 1055);
        panelLeft.TabIndex = 0;
        // 
        // picC1
        // 
        picC1.BackgroundImage = (Image)resources.GetObject("picC1.BackgroundImage");
        picC1.BackgroundImageLayout = ImageLayout.Stretch;
        picC1.Location = new Point(86, 0);
        picC1.Name = "picC1";
        picC1.Size = new Size(80, 80);
        picC1.TabIndex = 1;
        picC1.TabStop = false;
        // 
        // picLogo
        // 
        picLogo.BackgroundImage = Properties.Resources.Logo;
        picLogo.BackgroundImageLayout = ImageLayout.Stretch;
        picLogo.Location = new Point(0, 0);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(80, 80);
        picLogo.TabIndex = 0;
        picLogo.TabStop = false;
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripSplitButton1 });
        statusStrip1.Location = new Point(175, 1029);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(1749, 26);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(151, 20);
        toolStripStatusLabel1.Text = "toolStripStatusLabel1";
        // 
        // toolStripSplitButton1
        // 
        toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
        toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
        toolStripSplitButton1.Name = "toolStripSplitButton1";
        toolStripSplitButton1.Size = new Size(39, 24);
        toolStripSplitButton1.Text = "toolStripSplitButton1";
        // 
        // panelHeader
        // 
        panelHeader.Controls.Add(menuStrip1);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(175, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(1749, 66);
        panelHeader.TabIndex = 2;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { hỆTHỐNGToolStripMenuItem, dANHMỤCToolStripMenuItem, qUẢNLÝCẦUTHỦToolStripMenuItem, qUẢNLÝHLVToolStripMenuItem, hỖTRỢToolStripMenuItem, hỖTRỢToolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1749, 34);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // hỆTHỐNGToolStripMenuItem
        // 
        hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đĂNGNHẬPToolStripMenuItem, toolStripSeparator1, tHOÁTToolStripMenuItem, tHOÁTToolStripMenuItem1 });
        hỆTHỐNGToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
        hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
        hỆTHỐNGToolStripMenuItem.Size = new Size(138, 30);
        hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
        // 
        // đĂNGNHẬPToolStripMenuItem
        // 
        đĂNGNHẬPToolStripMenuItem.Name = "đĂNGNHẬPToolStripMenuItem";
        đĂNGNHẬPToolStripMenuItem.Size = new Size(230, 30);
        đĂNGNHẬPToolStripMenuItem.Text = "ĐĂNG NHẬP";
        // 
        // tHOÁTToolStripMenuItem
        // 
        tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
        tHOÁTToolStripMenuItem.Size = new Size(230, 30);
        tHOÁTToolStripMenuItem.Text = "ĐĂNG XUẤT";
        // 
        // tHOÁTToolStripMenuItem1
        // 
        tHOÁTToolStripMenuItem1.Name = "tHOÁTToolStripMenuItem1";
        tHOÁTToolStripMenuItem1.Size = new Size(230, 30);
        tHOÁTToolStripMenuItem1.Text = "THOÁT";
        tHOÁTToolStripMenuItem1.Click += tHOÁTToolStripMenuItem1_Click;
        // 
        // dANHMỤCToolStripMenuItem
        // 
        dANHMỤCToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHHIỆUToolStripMenuItem, cỬAHÀNGToolStripMenuItem, cỬAHÀNGToolStripMenuItem1 });
        dANHMỤCToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dANHMỤCToolStripMenuItem.Name = "dANHMỤCToolStripMenuItem";
        dANHMỤCToolStripMenuItem.Size = new Size(144, 30);
        dANHMỤCToolStripMenuItem.Text = "DANH MỤC";
        // 
        // qUẢNLÝCẦUTHỦToolStripMenuItem
        // 
        qUẢNLÝCẦUTHỦToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHSÁCHCẦUTHỦToolStripMenuItem, hỢPĐỒNGToolStripMenuItem });
        qUẢNLÝCẦUTHỦToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        qUẢNLÝCẦUTHỦToolStripMenuItem.Name = "qUẢNLÝCẦUTHỦToolStripMenuItem";
        qUẢNLÝCẦUTHỦToolStripMenuItem.Size = new Size(228, 30);
        qUẢNLÝCẦUTHỦToolStripMenuItem.Text = "QUẢN LÝ CẦU THỦ";
        // 
        // qUẢNLÝHLVToolStripMenuItem
        // 
        qUẢNLÝHLVToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dANHSÁCHHLVToolStripMenuItem, hỢPĐỒNGToolStripMenuItem1 });
        qUẢNLÝHLVToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        qUẢNLÝHLVToolStripMenuItem.Name = "qUẢNLÝHLVToolStripMenuItem";
        qUẢNLÝHLVToolStripMenuItem.Size = new Size(174, 30);
        qUẢNLÝHLVToolStripMenuItem.Text = "QUẢN LÝ HLV";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(227, 6);
        // 
        // dANHHIỆUToolStripMenuItem
        // 
        dANHHIỆUToolStripMenuItem.Name = "dANHHIỆUToolStripMenuItem";
        dANHHIỆUToolStripMenuItem.Size = new Size(246, 30);
        dANHHIỆUToolStripMenuItem.Text = "DANH HIỆU";
        // 
        // cỬAHÀNGToolStripMenuItem
        // 
        cỬAHÀNGToolStripMenuItem.Name = "cỬAHÀNGToolStripMenuItem";
        cỬAHÀNGToolStripMenuItem.Size = new Size(246, 30);
        cỬAHÀNGToolStripMenuItem.Text = "LỊCH THI ĐẤU";
        // 
        // hỖTRỢToolStripMenuItem
        // 
        hỖTRỢToolStripMenuItem.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        hỖTRỢToolStripMenuItem.Name = "hỖTRỢToolStripMenuItem";
        hỖTRỢToolStripMenuItem.Size = new Size(83, 30);
        hỖTRỢToolStripMenuItem.Text = "LỊCH ";
        // 
        // cỬAHÀNGToolStripMenuItem1
        // 
        cỬAHÀNGToolStripMenuItem1.Name = "cỬAHÀNGToolStripMenuItem1";
        cỬAHÀNGToolStripMenuItem1.Size = new Size(246, 30);
        cỬAHÀNGToolStripMenuItem1.Text = "CỬA HÀNG";
        // 
        // hỖTRỢToolStripMenuItem1
        // 
        hỖTRỢToolStripMenuItem1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        hỖTRỢToolStripMenuItem1.Name = "hỖTRỢToolStripMenuItem1";
        hỖTRỢToolStripMenuItem1.Size = new Size(110, 30);
        hỖTRỢToolStripMenuItem1.Text = "HỖ TRỢ";
       
        // 
        // dANHSÁCHCẦUTHỦToolStripMenuItem
        // 
        dANHSÁCHCẦUTHỦToolStripMenuItem.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dANHSÁCHCẦUTHỦToolStripMenuItem.Name = "dANHSÁCHCẦUTHỦToolStripMenuItem";
        dANHSÁCHCẦUTHỦToolStripMenuItem.Size = new Size(329, 30);
        dANHSÁCHCẦUTHỦToolStripMenuItem.Text = "DANH SÁCH CẦU THỦ";
        // 
        // dANHSÁCHHLVToolStripMenuItem
        // 
        dANHSÁCHHLVToolStripMenuItem.Name = "dANHSÁCHHLVToolStripMenuItem";
        dANHSÁCHHLVToolStripMenuItem.Size = new Size(275, 30);
        dANHSÁCHHLVToolStripMenuItem.Text = "DANH SÁCH HLV";
        // 
        // hỢPĐỒNGToolStripMenuItem
        // 
        hỢPĐỒNGToolStripMenuItem.Name = "hỢPĐỒNGToolStripMenuItem";
        hỢPĐỒNGToolStripMenuItem.Size = new Size(329, 30);
        hỢPĐỒNGToolStripMenuItem.Text = "HỢP ĐỒNG";
        // 
        // hỢPĐỒNGToolStripMenuItem1
        // 
        hỢPĐỒNGToolStripMenuItem1.Name = "hỢPĐỒNGToolStripMenuItem1";
        hỢPĐỒNGToolStripMenuItem1.Size = new Size(275, 30);
        hỢPĐỒNGToolStripMenuItem1.Text = "HỢP ĐỒNG";
        // 
        // frmDashBoard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1924, 1055);
        Controls.Add(panelHeader);
        Controls.Add(statusStrip1);
        Controls.Add(panelLeft);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmDashBoard";
        Text = "Dashboard";
        panelLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)picC1).EndInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panelLeft;
    private PictureBox picLogo;
    private PictureBox picC1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripSplitButton toolStripSplitButton1;
    private Panel panelHeader;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
    private ToolStripMenuItem đĂNGNHẬPToolStripMenuItem;
    private ToolStripMenuItem tHOÁTToolStripMenuItem;
    private ToolStripMenuItem dANHMỤCToolStripMenuItem;
    private ToolStripMenuItem qUẢNLÝCẦUTHỦToolStripMenuItem;
    private ToolStripMenuItem qUẢNLÝHLVToolStripMenuItem;
    private ToolStripMenuItem tHOÁTToolStripMenuItem1;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem dANHHIỆUToolStripMenuItem;
    private ToolStripMenuItem cỬAHÀNGToolStripMenuItem;
    private ToolStripMenuItem cỬAHÀNGToolStripMenuItem1;
    private ToolStripMenuItem hỖTRỢToolStripMenuItem;
    private ToolStripMenuItem hỖTRỢToolStripMenuItem1;
    private ToolStripMenuItem dANHSÁCHCẦUTHỦToolStripMenuItem;
    private ToolStripMenuItem hỢPĐỒNGToolStripMenuItem;
    private ToolStripMenuItem dANHSÁCHHLVToolStripMenuItem;
    private ToolStripMenuItem hỢPĐỒNGToolStripMenuItem1;
}