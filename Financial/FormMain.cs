using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Financial
{
    /// <summary>
    /// ϵͳ������
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// ��ȡ������ϵͳ�ĵ�ǰ�û�
        /// </summary>
        public User currentUser = null; 
        private FormAccountManage formAccout = null;    
        public FormMain()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormMain_Closing);   //����������¼�
        }

        /// <summary>
        /// �ر�������ǰ�Ĵ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormMain_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("��δ��������ݽ��ᶪʧ��������ȷ��Ҫ�˳���", "�˳�", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                this.toolStripStatusLabel_UserName.Text = currentUser.UserName;     //���½�������ʾΪ��ǰ�û�

                if (this.formAccout == null)
                {
                    this.formAccout = new FormAccountManage(this.currentUser);
                    this.formAccout.MdiParent = this;
                }

                this.formAccout.Show();
                this.formAccout.BringToFront();
                this.formAccout.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// �˳���ť
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// �����޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordModify_Click(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                FormPswModify fpm = new FormPswModify(this.currentUser.UserName, this.currentUser.PassWord);    //�������޸Ĳ˵�
                if (fpm.ShowDialog() == DialogResult.OK)    //������صĴ�����ΪOK
                {
                    string newPsw = fpm.newPsw;
                    this.currentUser.PassWord = newPsw;     //��ȡ���õ�������

                    for (int i = 0; i < UserManager.UserList.Count; i++)    //���û��б���������û����б���
                    {
                        if(UserManager.UserList[i].UserName.Equals(this.currentUser.UserName))  //ץȡ��ǰҪ��������û���
                        {
                            UserManager.UserList[i].PassWord = newPsw;      //��ץȡ�����û����������Ϊ������
                            break;
                        }
                    }

                    //�޸ĳɹ�����ʾ��ʾ
                    if (UserManager.SaveUserListToFile())
                    {
                        MessageBox.Show("\n                �����޸ĳɹ�             \n");
                    }

                }

            }
        }



        /// <summary>
        /// չʾ���ڲ˵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About_Click(object sender, EventArgs e)
        {
            AboutBox_AboutUs ab = new AboutBox_AboutUs();
            ab.ShowDialog();
        }

        private void AccountManage_Click(object sender, EventArgs e)
        {
            if (this.currentUser == null)
            {
                return;
            }

            if (this.formAccout == null)
            {
                this.formAccout = new FormAccountManage(this.currentUser);
                this.formAccout.MdiParent = this;
            }

            this.formAccout.Show();
            this.formAccout.BringToFront();
            this.formAccout.WindowState = FormWindowState.Maximized;
        }

    }
}