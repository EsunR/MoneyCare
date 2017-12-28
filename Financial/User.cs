using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Financial
{
    /// <summary>
    /// 系统用户类型，用来存放用户名、密码等用户信息，存放为user.xml
    /// </summary>
    public class User
    {

        private string userName = string.Empty;                         //定义用户名
        private string passWord = string.Empty;                         //定义密码
        private bool isAdministrator = false;                           //判断管理员
        private AccountManager accountManager = new AccountManager();   //账户管理器
        private string dirOfDateFile = string.Empty;                    //文件路径
        private string dirOfDateFile_Relative = string.Empty;           //文件相对路径
        private string pathOfDateFile_Account = string.Empty;           //数据路径
        private string pathOfDateFile_Account_Relative = string.Empty;  //数据相对路径


        public User()
        {
        }

        public User(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }


        /// <summary>
        /// （由相对路径）获取文件所在目录的绝对路径
        /// </summary>
        public string DirOfDataFile
        {
            get
            {
                if (!String.IsNullOrEmpty(this.dirOfDateFile))  //判断路径是否为空
                {
                    return this.dirOfDateFile;
                }

                string path = Application.StartupPath + this.DirOfDataFile_Relative;    //连接相对路径的字符串构成绝对路径

                if (!Directory.Exists(path))    //判断路径是否引用磁盘上的现有目录
                {
                    Directory.CreateDirectory(path);    //创建目录
                }
                return path;
            }
            set
            {
                this.dirOfDateFile = value;
            }
        }

        /// <summary>
        /// 获取文件所在目录的相对路径
        /// </summary>
        public string DirOfDataFile_Relative
        {
            get
            {
                return UserManager.DirOfUserListFile_Relative + "\\" + userName;    //返回相对路径，保存名字为[username]
            }
            set
            {
                this.dirOfDateFile_Relative = value;
            }
        }

        /// <summary>
        /// （由相对路径）获取数据的绝对路径
        /// </summary>
        public string PathOfDataFile_Account
        {
            get
            {
                if(!string.IsNullOrEmpty(this.pathOfDateFile_Account))  //判断路径是否为空
                {
                    return this.pathOfDateFile_Account;
                }

                string path = Application.StartupPath + this.PathOfDataFile_Account_Relative;   //连接相对路径字符串构成绝对路径

                if (!File.Exists(path)) //确定指定的文件是否存在
                {
                    FileStream fs = null;
                    //异常处理
                    try
                    {
                        fs = File.Create(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        fs.Close();
                    }
                }

                return path;
            }
            set
            {
                this.pathOfDateFile_Account = value;
            }
        }
        

        /// <summary>
        /// 获取数据的相对路径
        /// </summary>
        public string PathOfDataFile_Account_Relative
        {
            get
            {
                if (!string.IsNullOrEmpty(this.pathOfDateFile_Account_Relative))
                {
                    return this.pathOfDateFile_Account_Relative;
                }

                return this.DirOfDataFile_Relative + "\\account.xml";   //DirOfDateFile的相对路径 + "\\account.xml"就是数据的相对路径
            }
            set
            {
                this.pathOfDateFile_Account_Relative = value;
            }
        }

        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }


        /// <summary>
        /// 获取或设置密码
        /// </summary>
        public string PassWord
        {
            get
            {
                return this.passWord;
            }
            set
            {
                this.passWord = value;
            }
        }

        /// <summary>
        /// 获取或设置一个值，其指示该用户是否为系统管理员
        /// </summary>
        public bool IsAdministrator
        {
            get
            {
                return this.isAdministrator;
            }
            set
            {
                this.isAdministrator = value;
            }
        }

        /// <summary>
        /// 获取其AccountManager对象
        /// </summary>
        public AccountManager AccountMagr
        {
            get
            {
                return this.accountManager;
            }
        }
    }
}
