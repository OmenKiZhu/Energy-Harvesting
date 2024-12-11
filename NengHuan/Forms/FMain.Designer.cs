namespace NengHuan.UI
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.传感器数据库配置toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Header = new Sunny.UI.UINavBar();
            this.udgv_UInfo = new Sunny.UI.UIDataGridView();
            this.btn_Select = new Sunny.UI.UIButton();
            this.OKButton = new Sunny.UI.UIButton();
            this.ReadNodeCount = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.EndButton = new Sunny.UI.UIButton();
            this.StartButton = new Sunny.UI.UIButton();
            this.uiLight2 = new Sunny.UI.UILight();
            this.btn_ConnectServer = new Sunny.UI.UIButton();
            this.uiipTextBox = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.Aside = new Sunny.UI.UINavMenu();
            this.ucBtnAddDevice1 = new NengHuan.UserControls.UCBtnAddDevice();
            this.StyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.menuStrip1.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udgv_UInfo)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "能环监测数据采集系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.传感器数据库配置toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(246, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(186, 35);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 传感器数据库配置toolStripMenuItem
            // 
            this.传感器数据库配置toolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(102)))), ((int)(((byte)(104)))));
            this.传感器数据库配置toolStripMenuItem.Name = "传感器数据库配置toolStripMenuItem";
            this.传感器数据库配置toolStripMenuItem.Size = new System.Drawing.Size(178, 29);
            this.传感器数据库配置toolStripMenuItem.Text = "传感器数据库配置";
            this.传感器数据库配置toolStripMenuItem.Click += new System.EventHandler(this.传感器数据库配置toolStripMenuItem_Click_1);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Header.Controls.Add(this.udgv_UInfo);
            this.Header.Controls.Add(this.btn_Select);
            this.Header.Controls.Add(this.OKButton);
            this.Header.Controls.Add(this.ReadNodeCount);
            this.Header.Controls.Add(this.uiLabel1);
            this.Header.Controls.Add(this.EndButton);
            this.Header.Controls.Add(this.StartButton);
            this.Header.Controls.Add(this.uiLight2);
            this.Header.Controls.Add(this.btn_ConnectServer);
            this.Header.Controls.Add(this.uiipTextBox);
            this.Header.Controls.Add(this.menuStrip1);
            this.Header.Controls.Add(this.uiLabel6);
            this.Header.Controls.Add(this.uiPanel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.DropMenuFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Header.Location = new System.Drawing.Point(0, 35);
            this.Header.MenuHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Header.MenuSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Header.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1029, 1265);
            this.Header.TabIndex = 1;
            this.Header.Text = "uiNavBar1";
            this.Header.MenuItemClick += new Sunny.UI.UINavBar.OnMenuItemClick(this.Header_MenuItemClick);
            // 
            // udgv_UInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.udgv_UInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.udgv_UInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.udgv_UInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.udgv_UInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.udgv_UInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.udgv_UInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.udgv_UInfo.EnableHeadersVisualStyles = false;
            this.udgv_UInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.udgv_UInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.udgv_UInfo.Location = new System.Drawing.Point(229, 172);
            this.udgv_UInfo.Name = "udgv_UInfo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.udgv_UInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.udgv_UInfo.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.udgv_UInfo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.udgv_UInfo.RowTemplate.Height = 30;
            this.udgv_UInfo.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.udgv_UInfo.SelectedIndex = -1;
            this.udgv_UInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.udgv_UInfo.Size = new System.Drawing.Size(797, 356);
            this.udgv_UInfo.Style = Sunny.UI.UIStyle.Custom;
            this.udgv_UInfo.TabIndex = 73;
            // 
            // btn_Select
            // 
            this.btn_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Select.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.Location = new System.Drawing.Point(267, 115);
            this.btn_Select.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(100, 35);
            this.btn_Select.TabIndex = 66;
            this.btn_Select.Text = "保存";
            this.btn_Select.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // OKButton
            // 
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(962, 52);
            this.OKButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(55, 35);
            this.OKButton.TabIndex = 64;
            this.OKButton.Text = "确定";
            this.OKButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ReadNodeCount
            // 
            this.ReadNodeCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReadNodeCount.DoubleValue = 100D;
            this.ReadNodeCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadNodeCount.IntValue = 100;
            this.ReadNodeCount.Location = new System.Drawing.Point(868, 52);
            this.ReadNodeCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadNodeCount.MinimumSize = new System.Drawing.Size(1, 16);
            this.ReadNodeCount.Name = "ReadNodeCount";
            this.ReadNodeCount.Padding = new System.Windows.Forms.Padding(5);
            this.ReadNodeCount.ShowText = false;
            this.ReadNodeCount.Size = new System.Drawing.Size(87, 35);
            this.ReadNodeCount.TabIndex = 64;
            this.ReadNodeCount.Text = "100";
            this.ReadNodeCount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadNodeCount.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.ReadNodeCount.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(687, 52);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(203, 35);
            this.uiLabel1.TabIndex = 63;
            this.uiLabel1.Text = "点位数量/线程：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndButton
            // 
            this.EndButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EndButton.Location = new System.Drawing.Point(394, 55);
            this.EndButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(100, 32);
            this.EndButton.TabIndex = 37;
            this.EndButton.Text = "全部停止";
            this.EndButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.StartButton.Location = new System.Drawing.Point(267, 55);
            this.StartButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 32);
            this.StartButton.TabIndex = 36;
            this.StartButton.Text = "全部开始";
            this.StartButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // uiLight2
            // 
            this.uiLight2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight2.Location = new System.Drawing.Point(890, 6);
            this.uiLight2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight2.Name = "uiLight2";
            this.uiLight2.Radius = 35;
            this.uiLight2.Size = new System.Drawing.Size(35, 35);
            this.uiLight2.TabIndex = 13;
            this.uiLight2.Text = "uiLight2";
            // 
            // btn_ConnectServer
            // 
            this.btn_ConnectServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConnectServer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConnectServer.Location = new System.Drawing.Point(525, 55);
            this.btn_ConnectServer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ConnectServer.Name = "btn_ConnectServer";
            this.btn_ConnectServer.Size = new System.Drawing.Size(141, 35);
            this.btn_ConnectServer.TabIndex = 63;
            this.btn_ConnectServer.Text = "连接服务器";
            this.btn_ConnectServer.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConnectServer.Click += new System.EventHandler(this.btn_ConnectServer_Click);
            // 
            // uiipTextBox
            // 
            this.uiipTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiipTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiipTextBox.Location = new System.Drawing.Point(605, 6);
            this.uiipTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiipTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiipTextBox.Name = "uiipTextBox";
            this.uiipTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.uiipTextBox.ShowText = false;
            this.uiipTextBox.Size = new System.Drawing.Size(263, 35);
            this.uiipTextBox.TabIndex = 63;
            this.uiipTextBox.Text = "opc.tcp://192.168.1.112:49320";
            this.uiipTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiipTextBox.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(453, 6);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(169, 35);
            this.uiLabel6.TabIndex = 62;
            this.uiLabel6.Text = "服务器地址：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(36)))));
            this.uiPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uiPanel1.Controls.Add(this.Aside);
            this.uiPanel1.Controls.Add(this.ucBtnAddDevice1);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(36)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(-3, -3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiPanel1.Size = new System.Drawing.Size(225, 569);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 14;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(36)))));
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Aside.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(36)))));
            this.Aside.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.FullRowSelect = true;
            this.Aside.ItemHeight = 36;
            this.Aside.Location = new System.Drawing.Point(5, 58);
            this.Aside.Margin = new System.Windows.Forms.Padding(0);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(218, 511);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TabIndex = 1;
            this.Aside.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // ucBtnAddDevice1
            // 
            this.ucBtnAddDevice1.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnAddDevice1.Image")));
            this.ucBtnAddDevice1.Location = new System.Drawing.Point(0, 32678);
            this.ucBtnAddDevice1.Margin = new System.Windows.Forms.Padding(6692, 39325, 6692, 39325);
            this.ucBtnAddDevice1.Name = "ucBtnAddDevice1";
            this.ucBtnAddDevice1.Size = new System.Drawing.Size(65535, 65535);
            this.ucBtnAddDevice1.TabIndex = 11;
            this.ucBtnAddDevice1.Text = "添加点位";
            this.ucBtnAddDevice1.Click += new System.EventHandler(this.ucBtnAddDevice1_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.DPIScale = true;
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1029, 596);
            this.Controls.Add(this.Header);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udgv_UInfo)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        protected Sunny.UI.UINavBar Header;
        private Sunny.UI.UIStyleManager StyleManager;
        private System.Windows.Forms.ToolStripMenuItem 传感器数据库配置toolStripMenuItem;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UINavMenu Aside;
        private UserControls.UCBtnAddDevice ucBtnAddDevice1;
        private Sunny.UI.UITextBox uiipTextBox;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIButton btn_ConnectServer;
        private Sunny.UI.UILight uiLight2;
        private Sunny.UI.UIButton EndButton;
        private Sunny.UI.UIButton StartButton;
        private Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UITextBox ReadNodeCount;
        private Sunny.UI.UIButton OKButton;
        private Sunny.UI.UIDataGridView udgv_UInfo;
        private Sunny.UI.UIButton btn_Select;
    }
}