using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Financial
{
    /// <summary>
    /// ��½����
    /// </summary>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// ���ش���
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ��ʼ��,�����û��б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {

            if (UserManager.LoadUserListFromFile())
            {

                foreach (User u in UserManager.UserList)
                {
                    this.comboBox_UserName.Items.Add(u.UserName);   //��ؼ��������б��������ע���û�
                }
            }
            else
            {
                MessageBox.Show("�����û��б����");
            }

        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ��½
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Log_Click(object sender, EventArgs e)
        {
            User user = new User(this.comboBox_UserName.Text, this.textBox_Psw.Text);
            bool ok = false;

            foreach (User u in UserManager.UserList)    //���û��б��в�����ע���û������ж�������û����Ƿ��ܹ���ȷ��Ӧ
            {
                if (u.UserName.Equals(user.UserName) && u.PassWord.Equals(user.PassWord))
                {
                    ok = true;
                    break;
                }
            }

            //�����½�ɹ�����ת����һ������
            if (ok)     
            {
                FormMain formMain = new FormMain();
                formMain.currentUser = user;
                user.AccountMagr.LoadDataFromFile(Application.StartupPath + user.PathOfDataFile_Account_Relative);
                this.Hide();
                formMain.Show();
            }

            //��½ʧ���򵯳��Ի���
            else
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "�û������������";
                this.textBox_Psw.Clear();

            }
        }



        /// <summary>
        /// ע�����û�
        /// </summary>
        private void linkLabel_Regist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistNewUser form = new FormRegistNewUser();
            //����ע��Ի������û�������Ϣ���ж��û�������
            if (form.ShowDialog() == DialogResult.OK)
            {
                string userName = form.textBox_UserName.Text;   //ץȡ�û���
                string psw = form.textBox_Psw.Text;     //ץȡ����

                User newUser = new User(userName, psw);
                UserManager.UserList.Add(newUser);  //������û������б���
                UserManager.SaveUserListToFile();   //�����ļ�

                this.comboBox_UserName.Items.Add(newUser.UserName);     //���û�������windows�ؼ���
            }
        }


        private void comboBox_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}