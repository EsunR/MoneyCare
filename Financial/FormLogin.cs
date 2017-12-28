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
    /// 登陆界面
    /// </summary>
    public partial class FormLogin : Form
    {
        /// <summary>
        /// 加载窗口
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化,加载用户列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {

            if (UserManager.LoadUserListFromFile())
            {

                foreach (User u in UserManager.UserList)
                {
                    this.comboBox_UserName.Items.Add(u.UserName);   //向控件的下拉列表中添加已注册用户
                }
            }
            else
            {
                MessageBox.Show("加载用户列表出错");
            }

        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Log_Click(object sender, EventArgs e)
        {
            User user = new User(this.comboBox_UserName.Text, this.textBox_Psw.Text);
            bool ok = false;

            foreach (User u in UserManager.UserList)    //从用户列表中查找已注册用户，来判断密码和用户名是否能够正确对应
            {
                if (u.UserName.Equals(user.UserName) && u.PassWord.Equals(user.PassWord))
                {
                    ok = true;
                    break;
                }
            }

            //如果登陆成功，跳转到下一个界面
            if (ok)     
            {
                FormMain formMain = new FormMain();
                formMain.currentUser = user;
                user.AccountMagr.LoadDataFromFile(Application.StartupPath + user.PathOfDataFile_Account_Relative);
                this.Hide();
                formMain.Show();
            }

            //登陆失败则弹出对话框
            else
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "用户名或密码错误";
                this.textBox_Psw.Clear();

            }
        }



        /// <summary>
        /// 注册新用户
        /// </summary>
        private void linkLabel_Regist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistNewUser form = new FormRegistNewUser();
            //弹出注册对话框，让用户填入信息，判断用户点击结果
            if (form.ShowDialog() == DialogResult.OK)
            {
                string userName = form.textBox_UserName.Text;   //抓取用户名
                string psw = form.textBox_Psw.Text;     //抓取密码

                User newUser = new User(userName, psw);
                UserManager.UserList.Add(newUser);  //添加新用户名到列表中
                UserManager.SaveUserListToFile();   //保存文件

                this.comboBox_UserName.Items.Add(newUser.UserName);     //将用户名放入windows控件中
            }
        }


        private void comboBox_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}