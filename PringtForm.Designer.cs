namespace SwiftLabel
{
    partial class PrintForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.tabs1 = new AntdUI.Tabs();
            this.tabPage1 = new AntdUI.TabPage();
            this.hintShow = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.frontData = new AntdUI.Input();
            this.pringData = new AntdUI.Input();
            this.tabPage2 = new AntdUI.TabPage();
            this.gridPanel3 = new AntdUI.GridPanel();
            this.saveConfig = new AntdUI.Button();
            this.passWrod = new AntdUI.Input();
            this.inputNum = new AntdUI.Input();
            this.label9 = new AntdUI.Label();
            this.inputText = new AntdUI.Input();
            this.label8 = new AntdUI.Label();
            this.inputContinuous = new AntdUI.Input();
            this.label7 = new AntdUI.Label();
            this.inputStart = new AntdUI.Input();
            this.label6 = new AntdUI.Label();
            this.checkAutoPrint = new AntdUI.Checkbox();
            this.checkVerify = new AntdUI.Checkbox();
            this.dataName = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.btnFileOpen = new AntdUI.Button();
            this.fileNametBox = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.hint = new AntdUI.Input();
            this.label3 = new AntdUI.Label();
            this.tabs1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gridPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs1.BackColor = System.Drawing.SystemColors.Control;
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs1.Location = new System.Drawing.Point(12, 12);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tabPage1);
            this.tabs1.Pages.Add(this.tabPage2);
            this.tabs1.Size = new System.Drawing.Size(748, 511);
            this.tabs1.Style = styleLine1;
            this.tabs1.TabIndex = 0;
            this.tabs1.Text = "tabs1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hintShow);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Controls.Add(this.frontData);
            this.tabPage1.Controls.Add(this.pringData);
            this.tabPage1.Location = new System.Drawing.Point(3, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(742, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            // 
            // hintShow
            // 
            this.hintShow.BackColor = System.Drawing.SystemColors.Control;
            this.hintShow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hintShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hintShow.Location = new System.Drawing.Point(12, 15);
            this.hintShow.Name = "hintShow";
            this.hintShow.Size = new System.Drawing.Size(720, 56);
            this.hintShow.TabIndex = 13;
            this.hintShow.Text = "label1";
            // 
            // label2
            // 
            this.label2.BadgeSize = 0.1F;
            this.label2.Location = new System.Drawing.Point(389, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "上一条数据：";
            // 
            // label10
            // 
            this.label10.BadgeSize = 0.1F;
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(349, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "当前数据：";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(231, 161);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // frontData
            // 
            this.frontData.Enabled = false;
            this.frontData.Location = new System.Drawing.Point(389, 100);
            this.frontData.Name = "frontData";
            this.frontData.Size = new System.Drawing.Size(343, 55);
            this.frontData.TabIndex = 9;
            // 
            // pringData
            // 
            this.pringData.Location = new System.Drawing.Point(7, 100);
            this.pringData.Name = "pringData";
            this.pringData.Size = new System.Drawing.Size(372, 55);
            this.pringData.TabIndex = 8;
            this.pringData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pringData_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.gridPanel3);
            this.tabPage2.Location = new System.Drawing.Point(-742, -476);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(742, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置";
            // 
            // gridPanel3
            // 
            this.gridPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.gridPanel3.Controls.Add(this.saveConfig);
            this.gridPanel3.Controls.Add(this.passWrod);
            this.gridPanel3.Controls.Add(this.inputNum);
            this.gridPanel3.Controls.Add(this.label9);
            this.gridPanel3.Controls.Add(this.inputText);
            this.gridPanel3.Controls.Add(this.label8);
            this.gridPanel3.Controls.Add(this.inputContinuous);
            this.gridPanel3.Controls.Add(this.label7);
            this.gridPanel3.Controls.Add(this.inputStart);
            this.gridPanel3.Controls.Add(this.label6);
            this.gridPanel3.Controls.Add(this.checkAutoPrint);
            this.gridPanel3.Controls.Add(this.checkVerify);
            this.gridPanel3.Controls.Add(this.dataName);
            this.gridPanel3.Controls.Add(this.label5);
            this.gridPanel3.Controls.Add(this.btnFileOpen);
            this.gridPanel3.Controls.Add(this.fileNametBox);
            this.gridPanel3.Controls.Add(this.label4);
            this.gridPanel3.Controls.Add(this.hint);
            this.gridPanel3.Controls.Add(this.label3);
            this.gridPanel3.Location = new System.Drawing.Point(4, 3);
            this.gridPanel3.Name = "gridPanel3";
            this.gridPanel3.Size = new System.Drawing.Size(742, 442);
            this.gridPanel3.Span = "15% 85%;15% 65% 20%;15% 85%;50% 50%;;15% 85%;15% 85%;15% 85%;15% 85%;50% 50%;;";
            this.gridPanel3.TabIndex = 0;
            this.gridPanel3.Text = "gridPanel3";
            // 
            // saveConfig
            // 
            this.saveConfig.Enabled = false;
            this.saveConfig.Location = new System.Drawing.Point(374, 395);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(365, 43);
            this.saveConfig.TabIndex = 36;
            this.saveConfig.Text = "保存配置";
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // passWrod
            // 
            this.passWrod.Location = new System.Drawing.Point(3, 395);
            this.passWrod.Name = "passWrod";
            this.passWrod.PasswordChar = '*';
            this.passWrod.Size = new System.Drawing.Size(365, 43);
            this.passWrod.TabIndex = 35;
            this.passWrod.Text = "123456789";
            this.passWrod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passWrod_KeyPress);
            // 
            // inputNum
            // 
            this.inputNum.Enabled = false;
            this.inputNum.Location = new System.Drawing.Point(114, 346);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(625, 43);
            this.inputNum.TabIndex = 34;
            this.inputNum.Text = "10";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 43);
            this.label9.TabIndex = 33;
            this.label9.Text = "字符总长：";
            // 
            // inputText
            // 
            this.inputText.Enabled = false;
            this.inputText.Location = new System.Drawing.Point(114, 297);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(625, 43);
            this.inputText.TabIndex = 32;
            this.inputText.Text = "id";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 43);
            this.label8.TabIndex = 31;
            this.label8.Text = "字符串为：";
            // 
            // inputContinuous
            // 
            this.inputContinuous.Enabled = false;
            this.inputContinuous.Location = new System.Drawing.Point(114, 248);
            this.inputContinuous.Name = "inputContinuous";
            this.inputContinuous.Size = new System.Drawing.Size(625, 43);
            this.inputContinuous.TabIndex = 30;
            this.inputContinuous.Text = "3";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 43);
            this.label7.TabIndex = 29;
            this.label7.Text = "连续几位：";
            // 
            // inputStart
            // 
            this.inputStart.Enabled = false;
            this.inputStart.Location = new System.Drawing.Point(114, 199);
            this.inputStart.Name = "inputStart";
            this.inputStart.Size = new System.Drawing.Size(625, 43);
            this.inputStart.TabIndex = 28;
            this.inputStart.Text = "1";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 43);
            this.label6.TabIndex = 27;
            this.label6.Text = "几位开始：";
            // 
            // checkAutoPrint
            // 
            this.checkAutoPrint.Enabled = false;
            this.checkAutoPrint.Location = new System.Drawing.Point(374, 150);
            this.checkAutoPrint.Name = "checkAutoPrint";
            this.checkAutoPrint.Size = new System.Drawing.Size(365, 43);
            this.checkAutoPrint.TabIndex = 8;
            this.checkAutoPrint.Text = "自动打印 ";
            // 
            // checkVerify
            // 
            this.checkVerify.Enabled = false;
            this.checkVerify.Location = new System.Drawing.Point(3, 150);
            this.checkVerify.Name = "checkVerify";
            this.checkVerify.Size = new System.Drawing.Size(365, 43);
            this.checkVerify.TabIndex = 7;
            this.checkVerify.Text = "是否检验字符";
            // 
            // dataName
            // 
            this.dataName.Enabled = false;
            this.dataName.Location = new System.Drawing.Point(114, 101);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(625, 43);
            this.dataName.TabIndex = 6;
            this.dataName.Text = "id";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "数据源名：";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Enabled = false;
            this.btnFileOpen.Location = new System.Drawing.Point(596, 52);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(142, 43);
            this.btnFileOpen.TabIndex = 4;
            this.btnFileOpen.Text = "选择";
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // fileNametBox
            // 
            this.fileNametBox.Location = new System.Drawing.Point(114, 52);
            this.fileNametBox.Name = "fileNametBox";
            this.fileNametBox.Size = new System.Drawing.Size(476, 43);
            this.fileNametBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "模板文件：";
            // 
            // hint
            // 
            this.hint.Location = new System.Drawing.Point(114, 3);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(625, 43);
            this.hint.TabIndex = 1;
            this.hint.Text = "仅限于117";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "提示信息：";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 535);
            this.Controls.Add(this.tabs1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(785, 574);
            this.Name = "PrintForm";
            this.Text = "SwiftLabel v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintForm_FormClosed);
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.tabs1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gridPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage1;
        private AntdUI.TabPage tabPage2;
        private AntdUI.GridPanel gridPanel3;
        private AntdUI.Input hint;
        private AntdUI.Label label3;
        private AntdUI.Checkbox checkVerify;
        private AntdUI.Input dataName;
        private AntdUI.Label label5;
        private AntdUI.Button btnFileOpen;
        private AntdUI.Input fileNametBox;
        private AntdUI.Label label4;
        private AntdUI.Button saveConfig;
        private AntdUI.Input passWrod;
        private AntdUI.Input inputNum;
        private AntdUI.Label label9;
        private AntdUI.Input inputText;
        private AntdUI.Label label8;
        private AntdUI.Input inputContinuous;
        private AntdUI.Label label7;
        private AntdUI.Input inputStart;
        private AntdUI.Label label6;
        private AntdUI.Checkbox checkAutoPrint;
        private System.Windows.Forms.PictureBox pictureBox;
        private AntdUI.Input frontData;
        private AntdUI.Input pringData;
        private AntdUI.Label hintShow;
        private AntdUI.Label label2;
        private AntdUI.Label label10;
    }
}

