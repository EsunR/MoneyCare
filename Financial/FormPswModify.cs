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
        /// ���ݲ�����userName��oldPsw��
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="psw"></param>
        public FormPswModify(string userName, string psw)
        {
            InitializeComponent();
            this.userName = userName;   //��ȡ��ǰ�û���
            this.oldPsw = psw;  //��ȡ��ǰ����
            this.label_User.Text += "       "+ this.userName;   //���Ϸ���ʾ��ǰ�û���Ϣ
        }

        /// <summary>
        /// ���ȡ����ť�󷵻ؽ��ΪCancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// ���ȷ�����������¾���������ж�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!this.textBox_OldPsw.Text.Equals(this.oldPsw))
            {
                this.label_Info.Text = "�ɿ������!";
                return;
            }
            else 
            {
                if (!this.textBox_NewPsw.Text.Equals(this.textBox_NewPsw2.Text))
                {
                    this.label_Info.Text = "����������¿��һ��!";
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;    //���ش�����ΪOK
                    this.newPsw = this.textBox_NewPsw2.Text;    //����������
                }
            }

        }

    }
}