namespace NengHuan.Forms
{
    partial class FDeviceInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.utxt_UnitRule = new Sunny.UI.UITextBox();
            this.utxt_UnitRange = new Sunny.UI.UITextBox();
            this.utxt_UnitKind = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btn_Select = new Sunny.UI.UIButton();
            this.udgv_UInfo = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.udgv_UInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // utxt_UnitRule
            // 
            this.utxt_UnitRule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxt_UnitRule.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.utxt_UnitRule.Location = new System.Drawing.Point(650, 48);
            this.utxt_UnitRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxt_UnitRule.MinimumSize = new System.Drawing.Size(1, 16);
            this.utxt_UnitRule.Name = "utxt_UnitRule";
            this.utxt_UnitRule.Padding = new System.Windows.Forms.Padding(5);
            this.utxt_UnitRule.ShowText = false;
            this.utxt_UnitRule.Size = new System.Drawing.Size(181, 40);
            this.utxt_UnitRule.TabIndex = 59;
            this.utxt_UnitRule.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.utxt_UnitRule.Watermark = "";
            // 
            // utxt_UnitRange
            // 
            this.utxt_UnitRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxt_UnitRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.utxt_UnitRange.Location = new System.Drawing.Point(392, 48);
            this.utxt_UnitRange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxt_UnitRange.MinimumSize = new System.Drawing.Size(1, 16);
            this.utxt_UnitRange.Name = "utxt_UnitRange";
            this.utxt_UnitRange.Padding = new System.Windows.Forms.Padding(5);
            this.utxt_UnitRange.ShowText = false;
            this.utxt_UnitRange.Size = new System.Drawing.Size(144, 40);
            this.utxt_UnitRange.TabIndex = 57;
            this.utxt_UnitRange.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.utxt_UnitRange.Watermark = "";
            // 
            // utxt_UnitKind
            // 
            this.utxt_UnitKind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxt_UnitKind.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.utxt_UnitKind.Location = new System.Drawing.Point(135, 48);
            this.utxt_UnitKind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxt_UnitKind.MinimumSize = new System.Drawing.Size(1, 16);
            this.utxt_UnitKind.Name = "utxt_UnitKind";
            this.utxt_UnitKind.Padding = new System.Windows.Forms.Padding(5);
            this.utxt_UnitKind.ShowText = false;
            this.utxt_UnitKind.Size = new System.Drawing.Size(144, 40);
            this.utxt_UnitKind.TabIndex = 56;
            this.utxt_UnitKind.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.utxt_UnitKind.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(543, 48);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(115, 40);
            this.uiLabel3.TabIndex = 48;
            this.uiLabel3.Text = "校准规则";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(282, 48);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(115, 40);
            this.uiLabel2.TabIndex = 47;
            this.uiLabel2.Text = "量程";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(26, 48);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(115, 40);
            this.uiLabel1.TabIndex = 46;
            this.uiLabel1.Text = "设备类型";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Select
            // 
            this.btn_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Select.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.Location = new System.Drawing.Point(856, 53);
            this.btn_Select.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(100, 35);
            this.btn_Select.TabIndex = 45;
            this.btn_Select.Text = "查询";
            this.btn_Select.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.udgv_UInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.udgv_UInfo.EnableHeadersVisualStyles = false;
            this.udgv_UInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.udgv_UInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.udgv_UInfo.Location = new System.Drawing.Point(21, 96);
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
            this.udgv_UInfo.Size = new System.Drawing.Size(935, 401);
            this.udgv_UInfo.TabIndex = 65;
            this.udgv_UInfo.SelectionChanged += new System.EventHandler(this.udgv_UInfo_SelectionChanged);
            // 
            // FDeviceInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(973, 513);
            this.Controls.Add(this.udgv_UInfo);
            this.Controls.Add(this.utxt_UnitRule);
            this.Controls.Add(this.utxt_UnitRange);
            this.Controls.Add(this.utxt_UnitKind);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.btn_Select);
            this.Name = "FDeviceInfo";
            this.Text = "FConnectPage";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 869, 513);
            this.Load += new System.EventHandler(this.FDeviceInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udgv_UInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox utxt_UnitRule;
        private Sunny.UI.UITextBox utxt_UnitRange;
        private Sunny.UI.UITextBox utxt_UnitKind;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btn_Select;
        private Sunny.UI.UIDataGridView udgv_UInfo;
    }
}