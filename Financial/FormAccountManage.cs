using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Xml;
using System.Xml.Serialization;

namespace Financial
{
    /// <summary>
    /// �ʻ�������
    /// </summary>
    public partial class FormAccountManage : Form
    {
        private AccountManager accountManager = new AccountManager();   //����һ��˽�е��˻�������
        private User user = null;   //����һ��˽�е��û��ṹ

        public FormAccountManage(User user)
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormAccountManage_Closing);  //�������Ͻǹرհ�ťʱҲ�ر�FormAccountManagerС��
            this.user = user;
        }

        void FormAccountManage_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// ���ش���ʱ�����ʻ���ʼ��
        /// </summary>
        private void FormAccountManage_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            if (this.user != null)
            {

                foreach (Account acc in this.user.AccountMagr.AccoutList)   //�������û���ÿ���˻�������Ϣ��������֮�󼴻���ʾ�ڴ��ڵ��б���
                {
                    this.accountManager.AccoutList.Add(acc);    //��˽��accountManager�����һ������

                    string[] items = new string[]{
                    (this.listView1.Items.Count+1).ToString(),  //�û���ţ���Ϊ���������Ŀ+1
                    acc.OwnerName.ToString(),
                    acc.BankbookNum.ToString(),
                    acc.CardNum.ToString(),
                    acc.StartDate.ToString(),
                    acc.BankName.ToString(),
                    acc.MoneyType.ToString(),
                    acc.AccountType.ToString(),
                    acc.IniBlance.ToString(),
                    acc.RemainBlance.ToString(),
                    acc.Remark.ToString()}; //����һ����������Ϣ

                    ListViewItem lvi = new ListViewItem(items); //�½�һ��ListViewItem�ؼ�
                    this.listView1.Items.Add(lvi); //��������ӵ��ÿؼ��У�����һ���б�
                }
            }
        }

        /// <summary>
        /// �����б��е�����
        /// </summary>
        private void SaveListViewToFile()
        {

            AccountCollection accCollect = new AccountCollection();

            foreach (ListViewItem item in this.listView1.Items) //����listView1�е�����
            {
                Account acc = new Account(); 
                acc.OwnerName = item.SubItems[1].Text;
                acc.BankbookNum = item.SubItems[2].Text;
                acc.CardNum = item.SubItems[3].Text;
                acc.StartDate = DateTime.Parse(item.SubItems[4].Text);
                acc.BankName = item.SubItems[5].Text;
                acc.MoneyType = item.SubItems[6].Text;
                acc.AccountType = item.SubItems[7].Text;
                acc.IniBlance = double.Parse(item.SubItems[8].Text);
                acc.RemainBlance = double.Parse(item.SubItems[9].Text);
                acc.Remark = item.SubItems[10].Text;

                accCollect.Add(acc); //����ǰlistView����Ϣ���浽�û������У�ʵ�����������һ�ζ����ݵ�����д��
            }

            this.user.AccountMagr.AccoutList = accCollect;
            this.user.AccountMagr.SaveDataToFile(this.user.PathOfDataFile_Account);
        }


        /// <summary>
        /// ����ʻ���Ϣ
        /// </summary>
        private void toolStripSplitButton_Add_Click(object sender, EventArgs e)
        {
            FormAddAccount faa = new FormAddAccount();
            Account acc = new Account();

            if (faa.ShowDialog(this) == DialogResult.OK)    //��ʾFormAddAccount���ڣ��жϷ��ؽ��ΪOKʱ���еĲ���
            {
                acc.IniBlance = double.Parse(faa.textBox_IniBalance.Text);  //ת��Ϊdouble��
                acc.MoneyType = faa.textBox_MoneyType.Text;
                acc.OwnerName = faa.textBox_UserName.Text;
                acc.RemainBlance = double.Parse(faa.textBox_RemainBalance.Text);    //ת��Ϊdouble��
                acc.Remark = faa.textBox_Reamrk.Text;
                acc.StartDate = faa.dateTimePicker_StartDate.Value;
                acc.AccountType = faa.textBox_AccountType.Text;
                acc.BankbookNum = faa.textBox_BankbookNum.Text;
                acc.BankName = faa.textBox_BankName.Text;
                acc.CardNum = faa.textBox_cardNum.Text;


                this.accountManager.AccoutList.Add(acc);

                string[] items = new string[]{
                (this.listView1.Items.Count+1).ToString(),
                acc.OwnerName.ToString(),
                acc.BankbookNum.ToString(),
                acc.CardNum.ToString(),
                acc.StartDate.ToString(),
                acc.BankName.ToString(),
                acc.MoneyType.ToString(),
                acc.AccountType.ToString(),
                acc.IniBlance.ToString(),
                acc.RemainBlance.ToString(),
                acc.Remark.ToString()};
                ListViewItem lvi = new ListViewItem(items);
                this.listView1.Items.Add(lvi);  //���µ��˻���Ϣ��ӵ��б���
            }

            
        }


        /// <summary>
        /// ����б�ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem lviSelected = this.listView1.GetItemAt(e.X, e.Y);  //̽��λ���ö�λ�õ������ǰѡ�е���
            if (lviSelected != null)    //��������б�λ��������ʱ
            {
                if (e.Button == MouseButtons.Left && e.Clicks > 1)
                {
                    this.toolStripButton_Modify.PerformClick(); //�����������1ʱ��˫��ʱ���Ը��б���ʾ�޸Ľ���
                }

                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip_ListViewItemRightClick.Show(this.listView1, e.Location);  //�Ҽ�ʱ��ʾ�Ҽ��˵�
                }

            }
            else
            {
                if (e.Button == MouseButtons.Right) //��������б�λ��������ʱ����ʾ��һ���Ҽ��˵�
                {
                    this.contextMenuStrip_ListViewRightClick.Show(this.listView1, e.Location); 
                }
            }
        }

        
        /// <summary>
        /// ����
        /// </summary>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            this.SaveListViewToFile();     //������水ťʱִ�б��溯��
        }

        /// <summary>
        /// ɾ��
        /// </summary>
        private void toolStripButton_Del_Click(object sender, EventArgs e)
        {
            string names = string.Empty;
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                names += item.SubItems[1].Text + "\n";  //��ȡ��Ϣ�����еĵڶ�����û��������ַ��������name��
            }
            if (!String.IsNullOrEmpty(names))
            {
                DialogResult dr = MessageBox.Show("ȷʵҪɾ��\n" + names + "���ʻ���Ϣ��?", "ɾ���ʻ�", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);  //��ʾ�Ի���
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < this.listView1.SelectedItems.Count;)    // this.listView1.SelectedItems.Count��ʾ���ǵ�ǰѡ�е��б��ж��������ɾ���Ĳ������ı䣬��ѡ����Ϊ0ʱ����ѡ���ɾ�꣩��ֹͣѭ��
                    {
                        this.listView1.Items.Remove(this.listView1.SelectedItems[i]);
                    }
                }
            }
        }

        

        /// <summary>
        ///�޸��ʻ���Ϣ
        /// </summary>
        private void toolStripButton_Modify_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                return;
            }


            FormAddAccount faa = new FormAddAccount();  //�¶��󴰿�faa
            Account acc = new Account();    //�¶���acc
            ListViewItem item = this.listView1.SelectedItems[0];    //����itemΪ��ǰѡ�е��б�

            faa.textBox_UserName.Text = item.SubItems[1].Text;
            faa.textBox_BankbookNum.Text = item.SubItems[2].Text;
            faa.textBox_cardNum.Text = item.SubItems[3].Text;
            faa.dateTimePicker_StartDate.Text = item.SubItems[4].Text;
            faa.textBox_BankName.Text = item.SubItems[5].Text;
            faa.textBox_MoneyType.Text = item.SubItems[6].Text;
            faa.textBox_AccountType.Text = item.SubItems[7].Text;
            faa.textBox_IniBalance.Text = item.SubItems[8].Text;
            faa.textBox_RemainBalance.Text = item.SubItems[9].Text;
            faa.textBox_Reamrk.Text = item.SubItems[10].Text;   //��ȡ������Ϣ����š�����...��

            if (faa.ShowDialog() == DialogResult.OK)
            {
                acc.IniBlance = double.Parse(faa.textBox_IniBalance.Text);
                acc.MoneyType = faa.textBox_MoneyType.Text;
                acc.OwnerName = faa.textBox_UserName.Text;
                acc.RemainBlance = double.Parse(faa.textBox_RemainBalance.Text);
                acc.Remark = faa.textBox_Reamrk.Text;
                acc.StartDate = faa.dateTimePicker_StartDate.Value;
                acc.AccountType = faa.textBox_AccountType.Text;
                acc.BankbookNum = faa.textBox_BankbookNum.Text;
                acc.BankName = faa.textBox_BankName.Text;
                acc.CardNum = faa.textBox_cardNum.Text;


                this.accountManager.AccoutList.Add(acc);    //���б������acc

                string[] its = new string[]{
                (this.listView1.SelectedIndices[0]+1).ToString(),
                acc.OwnerName.ToString(),
                acc.BankbookNum.ToString(),
                acc.CardNum.ToString(),
                acc.StartDate.ToString(),
                acc.BankName.ToString(),
                acc.MoneyType.ToString(),
                acc.AccountType.ToString(),
                acc.IniBlance.ToString(),
                acc.RemainBlance.ToString(),
                acc.Remark.ToString()};
                ListViewItem lvi = new ListViewItem(its);

                this.listView1.Items[this.listView1.SelectedIndices[0]] = lvi; //����д��ѡ���������

            }
        }


        /// <summary>
        /// ���루���ǵ��룩
        /// </summary>
        private void toolStripButton_DataInput_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path, Encoding.Default);
                XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));
                AccountCollection accColl = null;
                try
                {
                    accColl = (AccountCollection)xml.Deserialize(sr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("���𻵵������ļ��򲻺Ϸ������ݸ�ʽ,�޷�����!!\n:" + ex.Message);
                    return;
                }
                finally
                {
                    if(sr == null)
                    {
                        sr.Close();
                    }
                }

                File.Copy(path, this.user.PathOfDataFile_Account,true); //���ļ����Ƶ�����Ŀ¼�н��и��Ǻ��ٶ�ȡ

                if (accColl != null)
                {
                    this.user.AccountMagr.AccoutList = accColl;
                }
                this.FormAccountManage_Load(null, null);
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_DataOutput_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.saveFileDialog1.FileName;
                try
                {
                    File.Copy(this.user.PathOfDataFile_Account, path);  //�������ļ����Ƶ�ѡ����Ŀ¼��
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ת��ʱ�����쳣:\n" + ex.Message);
                }

            }

        }

        /// <summary>
        /// �˳�
        /// </summary>
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region       right click �һ��¼�

        private void ToolStripMenuItem_AddNew_Click(object sender, EventArgs e)
        {
            this.toolStripSplitButton_Add.PerformClick();
        }

        private void ToolStripMenuItem_Import_Click(object sender, EventArgs e)
        {
            this.toolStripButton_DataInput.PerformClick();
        }

        private void ToolStripMenuItem_Output_Click(object sender, EventArgs e)
        {
            this.toolStripButton_DataOutput.PerformClick();
        }

        private void ToolStripMenuItem_Modify_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Modify.PerformClick();
        }

        private void ToolStripMenuItem_Del_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Del.PerformClick();
        }

        #endregion

        /// <summary>
        /// ������������Ϊɸѡ�ı����е�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Select_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.buttonSelect.PerformClick();
            }
        }

        /// <summary>
        /// ɸѡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string pattern = this.textBox_Select.Text.Trim();   //ץȡ����������Ϊpattern

            if (string.IsNullOrEmpty(pattern))
            {
                return;
            }

            ListViewGroup groupSelected = new ListViewGroup("groupSelected", "ɸѡ���: " + pattern);   //��ɸѡ�����ŵ�һ��
            ListViewGroup groupOther = new ListViewGroup("groupOther","����");    //�����������ŵ�һ��

            this.listView1.Groups.Clear();  //ÿ�ε����������ϴε�ɸѡ���
            
            for (int i = 0; i < this.listView1.Items.Count; i++)    //�����б���������˻���Ϣ
            {
                ListViewItem lvi = this.listView1.Items[i];   //��ȡ��i���˻���ϢΪlvi
                this.listView1.Items[i].Remove();   //ɾ����i���˻���Ϣ����Ϊ�ڽ�����ӵ�Group�Ĳ���ʱ������ɾ�����߿�¡�����б���Ϣ����ɾ���ᱨ��
                string source = "";
                for (int j = 0; j < lvi.SubItems.Count; j++)
                {
                    source += lvi.SubItems[j].Text;     //����һ���˻�������������Ϣ�����source�ַ�����
                }
                if (source.ToString().Contains(pattern))
                {
                    groupSelected.Items.Add(lvi);   //���pattern�ַ�����source�ַ����У�����ѯ���ַ�����һ���˻���������Ϣ��ͽ����˻�����groupSelected��
                }
                else
                {
                    groupOther.Items.Add(lvi);  //���������groupOther��
                }
                this.listView1.Items.Add(lvi);  //����ǰ��ķ����ƶ������ѵ�i���˻���Ϣɾ���ˣ�����Ϊ�����б�����ʾ������Ҫ�����ٰ�ɾ�����˻���Ϣ��ӵ�ListView1��Items��
            }

            this.listView1.Groups.Add(groupSelected);   //���groupSelected����
            this.listView1.Groups.Add(groupOther);  //���groupOther����


        }

        private void button_CancelSelect_Click(object sender, EventArgs e)
        {
            this.listView1.Groups.Clear();  //�������
        }


       
    }
}