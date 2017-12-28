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
        /// ָʾ���ݸ�ʽ�Ƿ�Ϸ�
        /// </summary>
        private bool dataFormatOK = true;

        /// <summary>
        /// ����ʻ��Ĵ���
        /// </summary>
        public FormAddAccount()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ȷ��
        /// </summary>
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!this.dataFormatOK)
            {
                MessageBox.Show("\n       �������˲��Ϸ������ݣ�������\n   ");
                return;
            }

            if (this.textBox_IniBalance.Text.Trim().Length == 0)    //���û�����ʼ��ȣ�Ĭ��Ϊ0
            {
                this.textBox_IniBalance.Text = "0"; 
            }

            if (this.textBox_RemainBalance.Text.Trim().Length == 0)     //���û��������ȣ�Ĭ��Ϊ0
            {
                this.textBox_RemainBalance.Text = "0";
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// ȡ��
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    //���ؽ��ΪCancel
        }

        /// <summary>
        /// ����
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


        #region            ���ݺϷ��Բ���

        private void textBox_IniBalance_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (!string.IsNullOrEmpty(tb.Text.Trim()))  //������տո���
            {
                try
                {
                    double tmp = double.Parse(tb.Text); //������ַ�������ת��double�ͣ�������ת��catch����ʾ������Ϣ
                }
                catch
                {
                    this.label_Info.Text = "���Ϸ�����������: " + tb.Text; //��ʾ������Ϣ
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