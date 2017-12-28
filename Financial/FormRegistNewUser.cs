using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Financial
{
    /// <summary>
    /// ע�����û��Ĵ���
    /// </summary>
    public partial class FormRegistNewUser : Form
    {
        public FormRegistNewUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ��������������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.textBox_UserName.Text.Trim().Length == 0)
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "�û�������Ϊ��";
                return;
            }

            if(this.textBox_Psw.Text.Trim().Length == 0)
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "���벻��Ϊ��";
                return;
            }

            if (!this.textBox_Psw.Text.Equals(this.textBox_Psw2.Text))
            {
                this.label_Info.ForeColor = Color.Red;
                this.textBox_Psw.Clear();
                this.textBox_Psw2.Clear();
                this.label_Info.Text = "��������������벻һ��";
                return;
            }

            foreach (User u in UserManager.UserList)      //����½�����ͨ����������ע���û�������û��Ƿ��ѱ�ע��
            {
                if (u.UserName.Equals(this.textBox_UserName.Text.Trim()))
                {
                    this.label_Info.ForeColor = Color.Red;
                    this.label_Info.Text = "���û����Ѿ��������û�ʹ��,��ʹ�������û���";
                    return;
                }

            }


            this.DialogResult = DialogResult.OK;
        }

    }
}