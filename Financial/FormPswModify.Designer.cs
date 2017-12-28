namespace Financial
{
    partial class FormPswModify
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
            this.label_User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_OldPsw = new System.Windows.Forms.TextBox();
            this.textBox_NewPsw = new System.Windows.Forms.TextBox();
            this.textBox_NewPsw2 = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(33, 27);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(47, 12);
            this.label_User.TabIndex = 0;
            this.label_User.Text = "用户名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "旧口令:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新口令:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "重输新口令:";
            // 
            // textBox_OldPsw
            // 
            this.textBox_OldPsw.Location = new System.Drawing.Point(129, 70);
            this.textBox_OldPsw.Name = "textBox_OldPsw";
            this.textBox_OldPsw.PasswordChar = '●';
            this.textBox_OldPsw.Size = new System.Drawing.Size(243, 21);
            this.textBox_OldPsw.TabIndex = 1;
            // 
            // textBox_NewPsw
            // 
            this.textBox_NewPsw.Location = new System.Drawing.Point(129, 110);
            this.textBox_NewPsw.Name = "textBox_NewPsw";
            this.textBox_NewPsw.PasswordChar = '●';
            this.textBox_NewPsw.Size = new System.Drawing.Size(243, 21);
            this.textBox_NewPsw.TabIndex = 2;
            // 
            // textBox_NewPsw2
            // 
            this.textBox_NewPsw2.Location = new System.Drawing.Point(129, 147);
            this.textBox_NewPsw2.Name = "textBox_NewPsw2";
            this.textBox_NewPsw2.PasswordChar = '●';
            this.textBox_NewPsw2.Size = new System.Drawing.Size(243, 21);
            this.textBox_NewPsw2.TabIndex = 3;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(293, 211);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(106, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(216, 211);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(71, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 5);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label_Info
            // 
            this.label_Info.ForeColor = System.Drawing.Color.Red;
            this.label_Info.Location = new System.Drawing.Point(12, 211);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(198, 37);
            this.label_Info.TabIndex = 5;
            // 
            // FormPswModify
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(426, 257);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_NewPsw2);
            this.Controls.Add(this.textBox_NewPsw);
            this.Controls.Add(this.textBox_OldPsw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPswModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_OldPsw;
        private System.Windows.Forms.TextBox textBox_NewPsw;
        private System.Windows.Forms.TextBox textBox_NewPsw2;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Info;
    }
}