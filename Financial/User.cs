using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Financial
{
    /// <summary>
    /// ϵͳ�û����ͣ���������û�����������û���Ϣ�����Ϊuser.xml
    /// </summary>
    public class User
    {

        private string userName = string.Empty;                         //�����û���
        private string passWord = string.Empty;                         //��������
        private bool isAdministrator = false;                           //�жϹ���Ա
        private AccountManager accountManager = new AccountManager();   //�˻�������
        private string dirOfDateFile = string.Empty;                    //�ļ�·��
        private string dirOfDateFile_Relative = string.Empty;           //�ļ����·��
        private string pathOfDateFile_Account = string.Empty;           //����·��
        private string pathOfDateFile_Account_Relative = string.Empty;  //�������·��


        public User()
        {
        }

        public User(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }


        /// <summary>
        /// �������·������ȡ�ļ�����Ŀ¼�ľ���·��
        /// </summary>
        public string DirOfDataFile
        {
            get
            {
                if (!String.IsNullOrEmpty(this.dirOfDateFile))  //�ж�·���Ƿ�Ϊ��
                {
                    return this.dirOfDateFile;
                }

                string path = Application.StartupPath + this.DirOfDataFile_Relative;    //�������·�����ַ������ɾ���·��

                if (!Directory.Exists(path))    //�ж�·���Ƿ����ô����ϵ�����Ŀ¼
                {
                    Directory.CreateDirectory(path);    //����Ŀ¼
                }
                return path;
            }
            set
            {
                this.dirOfDateFile = value;
            }
        }

        /// <summary>
        /// ��ȡ�ļ�����Ŀ¼�����·��
        /// </summary>
        public string DirOfDataFile_Relative
        {
            get
            {
                return UserManager.DirOfUserListFile_Relative + "\\" + userName;    //�������·������������Ϊ[username]
            }
            set
            {
                this.dirOfDateFile_Relative = value;
            }
        }

        /// <summary>
        /// �������·������ȡ���ݵľ���·��
        /// </summary>
        public string PathOfDataFile_Account
        {
            get
            {
                if(!string.IsNullOrEmpty(this.pathOfDateFile_Account))  //�ж�·���Ƿ�Ϊ��
                {
                    return this.pathOfDateFile_Account;
                }

                string path = Application.StartupPath + this.PathOfDataFile_Account_Relative;   //�������·���ַ������ɾ���·��

                if (!File.Exists(path)) //ȷ��ָ�����ļ��Ƿ����
                {
                    FileStream fs = null;
                    //�쳣����
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
        /// ��ȡ���ݵ����·��
        /// </summary>
        public string PathOfDataFile_Account_Relative
        {
            get
            {
                if (!string.IsNullOrEmpty(this.pathOfDateFile_Account_Relative))
                {
                    return this.pathOfDateFile_Account_Relative;
                }

                return this.DirOfDataFile_Relative + "\\account.xml";   //DirOfDateFile�����·�� + "\\account.xml"�������ݵ����·��
            }
            set
            {
                this.pathOfDateFile_Account_Relative = value;
            }
        }

        /// <summary>
        /// ��ȡ�������û���
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
        /// ��ȡ����������
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
        /// ��ȡ������һ��ֵ����ָʾ���û��Ƿ�Ϊϵͳ����Ա
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
        /// ��ȡ��AccountManager����
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
