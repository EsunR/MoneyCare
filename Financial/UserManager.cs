using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

namespace Financial
{
    /// <summary>
    /// �û�������,�����û������Ϣ����
    /// </summary>
    class UserManager
    {
        private static string dirOfUserListFile = "\\user";         
        private static string pathOfUserListFile = "\\user.xml";


        private static UserCollection userList = new UserCollection();


        /// <summary>
        /// ��ȡ�����û��б���ļ����ļ��еľ���·��
        /// </summary>
        public static string DirOfUserListFile
        {
            get
            {
                string dir = Application.StartupPath + dirOfUserListFile;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                return dir;
            }
        }


        /// <summary>
        /// ��ȡ�����û��б���ļ����ļ��е����·��
        /// </summary>
        public static string DirOfUserListFile_Relative
        {
            get
            {
                return dirOfUserListFile;
            }
        }
    
        /// <summary>
        /// ��ȡ�����û��б���ļ�����·��
        /// </summary>
        public static string PathOfUserListFile
        {
            get
            {
                string path = DirOfUserListFile + pathOfUserListFile;
                if (!File.Exists(path))
                {
                    FileStream fs = null;
                    try
                    {
                        fs = File.Create(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    }
                }
                return path;
            }
        }


        /// <summary>
        /// ��ȡ�����õ�ǰϵͳ�����û����б�
        /// </summary>
        public static UserCollection UserList
        {
            get
            {
                return userList;
            }
            set
            {
                userList = value;
            }
        }

        /// <summary>
        /// ���û��б����л����ļ�
        /// </summary>
        /// <returns></returns>
        public static bool SaveUserListToFile()
        {
            XmlSerializer xml = new XmlSerializer(typeof(UserCollection));
            StreamWriter sw = new StreamWriter(PathOfUserListFile, false, Encoding.Default);
            try
            {
                xml.Serialize(sw, userList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                sw.Close();
            }
            return true;
        }


        /// <summary>
        /// ���ļ������û��б�
        /// </summary>
        /// <returns></returns>
        public static bool LoadUserListFromFile()
        {
            XmlSerializer xml = new XmlSerializer(typeof(UserCollection));
            StreamReader sr = new StreamReader(UserManager.PathOfUserListFile,Encoding.Default);

            try
            {
                UserManager.UserList = (UserCollection)xml.Deserialize(sr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sr.Close();
            }

            return true;
        }

    }
}
