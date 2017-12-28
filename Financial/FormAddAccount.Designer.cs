namespace Financial
{
    partial class FormAddAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_BankbookNum = new System.Windows.Forms.TextBox();
            this.textBox_cardNum = new System.Windows.Forms.TextBox();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_BankName = new System.Windows.Forms.TextBox();
            this.textBox_MoneyType = new System.Windows.Forms.TextBox();
            this.textBox_AccountType = new System.Windows.Forms.TextBox();
            this.textBox_IniBalance = new System.Windows.Forms.TextBox();
            this.textBox_RemainBalance = new System.Windows.Forms.TextBox();
            this.textBox_Reamrk = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "户主";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "存折号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "卡号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "开户日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "开户银行";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "币种";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "帐户类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "初始额度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "余额额度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "备注";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(82, 15);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(183, 21);
            this.textBox_UserName.TabIndex = 1;
            // 
            // textBox_BankbookNum
            // 
            this.textBox_BankbookNum.Location = new System.Drawing.Point(82, 50);
            this.textBox_BankbookNum.Name = "textBox_BankbookNum";
            this.textBox_BankbookNum.Size = new System.Drawing.Size(183, 21);
            this.textBox_BankbookNum.TabIndex = 2;
            this.textBox_BankbookNum.TextChanged += new System.EventHandler(this.textBox_BankbookNum_TextChanged);
            // 
            // textBox_cardNum
            // 
            this.textBox_cardNum.Location = new System.Drawing.Point(364, 50);
            this.textBox_cardNum.Name = "textBox_cardNum";
            this.textBox_cardNum.Size = new System.Drawing.Size(183, 21);
            this.textBox_cardNum.TabIndex = 3;
            this.textBox_cardNum.TextChanged += new System.EventHandler(this.textBox_cardNum_TextChanged);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(82, 95);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(183, 21);
            this.dateTimePicker_StartDate.TabIndex = 4;
            // 
            // textBox_BankName
            // 
            this.textBox_BankName.Location = new System.Drawing.Point(364, 95);
            this.textBox_BankName.Name = "textBox_BankName";
            this.textBox_BankName.Size = new System.Drawing.Size(183, 21);
            this.textBox_BankName.TabIndex = 5;
            // 
            // textBox_MoneyType
            // 
            this.textBox_MoneyType.Location = new System.Drawing.Point(82, 140);
            this.textBox_MoneyType.Name = "textBox_MoneyType";
            this.textBox_MoneyType.Size = new System.Drawing.Size(183, 21);
            this.textBox_MoneyType.TabIndex = 6;
            // 
            // textBox_AccountType
            // 
            this.textBox_AccountType.Location = new System.Drawing.Point(364, 140);
            this.textBox_AccountType.Name = "textBox_AccountType";
            this.textBox_AccountType.Size = new System.Drawing.Size(183, 21);
            this.textBox_AccountType.TabIndex = 7;
            // 
            // textBox_IniBalance
            // 
            this.textBox_IniBalance.Location = new System.Drawing.Point(82, 186);
            this.textBox_IniBalance.Name = "textBox_IniBalance";
            this.textBox_IniBalance.Size = new System.Drawing.Size(183, 21);
            this.textBox_IniBalance.TabIndex = 8;
            this.textBox_IniBalance.TextChanged += new System.EventHandler(this.textBox_IniBalance_TextChanged);
            // 
            // textBox_RemainBalance
            // 
            this.textBox_RemainBalance.Location = new System.Drawing.Point(364, 186);
            this.textBox_RemainBalance.Name = "textBox_RemainBalance";
            this.textBox_RemainBalance.Size = new System.Drawing.Size(183, 21);
            this.textBox_RemainBalance.TabIndex = 9;
            this.textBox_RemainBalance.TextChanged += new System.EventHandler(this.textBox_RemainBalance_TextChanged);
            // 
            // textBox_Reamrk
            // 
            this.textBox_Reamrk.Location = new System.Drawing.Point(64, 235);
            this.textBox_Reamrk.Multiline = true;
            this.textBox_Reamrk.Name = "textBox_Reamrk";
            this.textBox_Reamrk.Size = new System.Drawing.Size(483, 75);
            this.textBox_Reamrk.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(-4, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 8);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(452, 336);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(95, 30);
            this.button_Ok.TabIndex = 11;
            this.button_Ok.Text = "确定";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(283, 336);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(364, 336);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 30);
            this.button_Reset.TabIndex = 12;
            this.button_Reset.Text = "重置";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // label_Info
            // 
            this.label_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Info.Location = new System.Drawing.Point(312, 20);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(235, 23);
            this.label_Info.TabIndex = 14;
            // 
            // FormAddAccount
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 377);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.textBox_AccountType);
            this.Controls.Add(this.textBox_RemainBalance);
            this.Controls.Add(this.textBox_Reamrk);
            this.Controls.Add(this.textBox_IniBalance);
            this.Controls.Add(this.textBox_MoneyType);
            this.Controls.Add(this.textBox_BankName);
            this.Controls.Add(this.textBox_cardNum);
            this.Controls.Add(this.textBox_BankbookNum);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帐户详细信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Reset;
        public System.Windows.Forms.TextBox textBox_UserName;
        public System.Windows.Forms.TextBox textBox_BankbookNum;
        public System.Windows.Forms.TextBox textBox_cardNum;
        public System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        public System.Windows.Forms.TextBox textBox_BankName;
        public System.Windows.Forms.TextBox textBox_MoneyType;
        public System.Windows.Forms.TextBox textBox_AccountType;
        public System.Windows.Forms.TextBox textBox_IniBalance;
        public System.Windows.Forms.TextBox textBox_RemainBalance;
        public System.Windows.Forms.TextBox textBox_Reamrk;
        private System.Windows.Forms.Label label_Info;
    }
}