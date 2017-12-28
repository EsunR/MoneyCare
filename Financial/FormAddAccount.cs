using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Financial
{
    public partial class FormAddAccount : Form
    {
        /// <summary>
        /// 指示数据格式是否合法
        /// </summary>
        private bool dataFormatOK = true;

        /// <summary>
        /// 添加帐户的窗体
        /// </summary>
        public FormAddAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 确定
        /// </summary>
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!this.dataFormatOK)
            {
                MessageBox.Show("\n       您输入了不合法的数据，请修正\n   ");
                return;
            }

            if (this.textBox_IniBalance.Text.Trim().Length == 0)    //如果没输入初始额度，默认为0
            {
                this.textBox_IniBalance.Text = "0"; 
            }

            if (this.textBox_RemainBalance.Text.Trim().Length == 0)     //如果没输入余额额度，默认为0
            {
                this.textBox_RemainBalance.Text = "0";
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    //返回结果为Cancel
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                TextBox tb = this.Controls[i] as TextBox;
                if (tb != null)
                {
                    tb.Clear();
                }
            }

            this.dateTimePicker_StartDate.Value = DateTime.Today;
        }


        #region            数据合法性测试

        private void textBox_IniBalance_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!string.IsNullOrEmpty(tb.Text.Trim()))  //先做清空空格处理
            {
                try
                {
                    double tmp = double.Parse(tb.Text); //输入的字符必须能转成double型，否则跳转到catch中显示错误信息
                }
                catch
                {
                    this.label_Info.Text = "不合法的数据类型: " + tb.Text; //显示错误信息
                    this.dataFormatOK = false;
                    return;
                }
                this.label_Info.Text = "";
                this.dataFormatOK = true;
                
            }
        }

        private void textBox_RemainBalance_TextChanged(object sender, EventArgs e)
        {
            textBox_IniBalance_TextChanged(sender, e);
        }

        private void textBox_BankbookNum_TextChanged(object sender, EventArgs e)
        {
            textBox_IniBalance_TextChanged(sender, e);
        }

        private void textBox_cardNum_TextChanged(object sender, EventArgs e)
        {
            textBox_IniBalance_TextChanged(sender, e);
        }

        #endregion


    }
}