using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace Financial
{
    /// <summary>
    /// �ʻ���������������д���ߵ�ȡ�û��б�
    /// </summary>
    public class AccountManager
    {
        private AccountCollection accountList = new AccountCollection();    //�����˻��ռ�����˽��

        /// <summary>
        /// ��ȡ�������ʻ��б�
        /// </summary>
        public AccountCollection AccoutList
        {
            get
            {
                return this.accountList;
            }
            set
            {
                this.accountList = value;
            }
        }




        /// <summary>
        /// ���ʻ��������ݱ��浽�ļ�
        /// </summary>
        /// <param name="pathOfDataFile">�����ļ�·��</param>
        public bool SaveDataToFile(string pathOfDataFile)
        {
            StreamWriter sw = new StreamWriter(pathOfDataFile,false,Encoding.Default);  //�ĵ����Ĳ���
            XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));   //xml���л�
            try
            {
                xml.Serialize(sw, this.accountList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            return true;
        }

        /// <summary>
        /// ���ļ���ȡ�ʻ���������
        /// </summary>
        /// <param name="pathOfDataFile">�����ļ�·��</param>
        public bool LoadDataFromFile(string pathOfDataFile)
        {
            StreamReader sr = new StreamReader(pathOfDataFile,Encoding.Default);
            XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));
            try
            {
                this.accountList = (AccountCollection)xml.Deserialize(sr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return true;
        }


    }
}
