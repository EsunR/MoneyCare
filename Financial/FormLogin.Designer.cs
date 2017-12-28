namespace Financial
{
    partial class FormLogin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Log = new System.Windows.Forms.Button();
            this.textBox_Psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_UserName = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.labe3 = new System.Windows.Forms.Label();
            this.linkLabel_Regist = new System.Windows.Forms.LinkLabel();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.Location = new System.Drawing.Point(82, 282);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(152, 23);
            this.label_Info.TabIndex = 5;
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Log
            // 
            this.button_Log.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Log.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Log.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button_Log.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Log.Location = new System.Drawing.Point(82, 240);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(152, 39);
            this.button_Log.TabIndex = 4;
            this.button_Log.Text = "登   录";
            this.button_Log.UseVisualStyleBackColor = false;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // textBox_Psw
            // 
            this.textBox_Psw.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Psw.Location = new System.Drawing.Point(82, 191);
            this.textBox_Psw.Name = "textBox_Psw";
            this.textBox_Psw.PasswordChar = '●';
            this.textBox_Psw.Size = new System.Drawing.Size(153, 29);
            this.textBox_Psw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // comboBox_UserName
            // 
            this.comboBox_UserName.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox_UserName.FormattingEnabled = true;
            this.comboBox_UserName.Location = new System.Drawing.Point(82, 129);
            this.comboBox_UserName.Name = "comboBox_UserName";
            this.comboBox_UserName.Size = new System.Drawing.Size(153, 29);
            this.comboBox_UserName.TabIndex = 0;
            this.comboBox_UserName.SelectedIndexChanged += new System.EventHandler(this.comboBox_UserName_SelectedIndexChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(234, 324);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // labe3
            // 
            this.labe3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labe3.AutoSize = true;
            this.labe3.Location = new System.Drawing.Point(10, 330);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(41, 12);
            this.labe3.TabIndex = 2;
            this.labe3.Text = "新用户";
            // 
            // linkLabel_Regist
            // 
            this.linkLabel_Regist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Regist.AutoSize = true;
            this.linkLabel_Regist.Location = new System.Drawing.Point(55, 330);
            this.linkLabel_Regist.Name = "linkLabel_Regist";
            this.linkLabel_Regist.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_Regist.TabIndex = 3;
            this.linkLabel_Regist.TabStop = true;
            this.linkLabel_Regist.Text = "注册";
            this.linkLabel_Regist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Regist_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 93);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_Log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_UserName);
            this.Controls.Add(this.textBox_Psw);
            this.Controls.Add(this.button_Log);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.linkLabel_Regist);
            this.Controls.Add(this.labe3);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Care";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_UserName;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.LinkLabel linkLabel_Regist;
        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}