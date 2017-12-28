using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Financial
{
    public partial class FormPswModify : Form
    {

        private string userName;
        private string oldPsw;
        internal string newPsw;

        private FormPswModify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 传递参数到userName和oldPsw中
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="psw"></param>
        public FormPswModify(string userName, string psw)
        {
            InitializeComponent();
            this.userName = userName;   //获取当前用户名
            this.oldPsw = psw;  //获取当前密码
            this.label_User.Text += "       "+ this.userName;   //在上方显示当前用户信息
        }

        /// <summary>
        /// 点击取消按钮后返回结果为Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 点击确定后对输入的新旧密码进行判定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!this.textBox_OldPsw.Text.Equals(this.oldPsw))
            {
                this.label_Info.Text = "旧口令错误!";
                return;
            }
            else 
            {
                if (!this.textBox_NewPsw.Text.Equals(this.textBox_NewPsw2.Text))
                {
                    this.label_Info.Text = "两次输入的新口令不一致!";
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;    //返回窗体结果为OK
                    this.newPsw = this.textBox_NewPsw2.Text;    //返回新密码
                }
            }

        }

    }
}