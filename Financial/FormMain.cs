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
    /// 系统主窗口
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// 获取或设置系统的当前用户
        /// </summary>
        public User currentUser = null; 
        private FormAccountManage formAccout = null;    
        public FormMain()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormMain_Closing);   //添加主窗口事件
        }

        /// <summary>
        /// 关闭主窗口前的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormMain_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("您未保存的数据将会丢失，请问您确定要退出吗？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                this.toolStripStatusLabel_UserName.Text = currentUser.UserName;     //左下角名字显示为当前用户

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
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /// <summary>
        /// 口令修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordModify_Click(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                FormPswModify fpm = new FormPswModify(this.currentUser.UserName, this.currentUser.PassWord);    //打开密码修改菜单
                if (fpm.ShowDialog() == DialogResult.OK)    //如果返回的窗体结果为OK
                {
                    string newPsw = fpm.newPsw;
                    this.currentUser.PassWord = newPsw;     //获取设置的新密码

                    for (int i = 0; i < UserManager.UserList.Count; i++)    //对用户列表里的所有用户进行遍历
                    {
                        if(UserManager.UserList[i].UserName.Equals(this.currentUser.UserName))  //抓取当前要改密码的用户名
                        {
                            UserManager.UserList[i].PassWord = newPsw;      //将抓取到的用户名的密码改为新密码
                            break;
                        }
                    }

                    //修改成功后显示提示
                    if (UserManager.SaveUserListToFile())
                    {
                        MessageBox.Show("\n                口令修改成功             \n");
                    }

                }

            }
        }



        /// <summary>
        /// 展示关于菜单
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