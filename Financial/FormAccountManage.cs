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
    /// 帐户管理窗口
    /// </summary>
    public partial class FormAccountManage : Form
    {
        private AccountManager accountManager = new AccountManager();   //定义一个私有的账户管理器
        private User user = null;   //定义一个私有的用户结构

        public FormAccountManage(User user)
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormAccountManage_Closing);  //按下右上角关闭按钮时也关闭FormAccountManager小窗
            this.user = user;
        }

        void FormAccountManage_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// 加载窗体时进行帐户初始化
        /// </summary>
        private void FormAccountManage_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            if (this.user != null)
            {

                foreach (Account acc in this.user.AccountMagr.AccoutList)   //遍历该用户的每组账户数据信息，遍历完之后即会显示在窗口的列表中
                {
                    this.accountManager.AccoutList.Add(acc);    //向私有accountManager中添加一组数据

                    string[] items = new string[]{
                    (this.listView1.Items.Count+1).ToString(),  //用户编号，即为该数组的数目+1
                    acc.OwnerName.ToString(),
                    acc.BankbookNum.ToString(),
                    acc.CardNum.ToString(),
                    acc.StartDate.ToString(),
                    acc.BankName.ToString(),
                    acc.MoneyType.ToString(),
                    acc.AccountType.ToString(),
                    acc.IniBlance.ToString(),
                    acc.RemainBlance.ToString(),
                    acc.Remark.ToString()}; //定义一个数组存放信息

                    ListViewItem lvi = new ListViewItem(items); //新建一个ListViewItem控件
                    this.listView1.Items.Add(lvi); //将数组添加到该控件中，生成一行列表
                }
            }
        }

        /// <summary>
        /// 保存列表中的内容
        /// </summary>
        private void SaveListViewToFile()
        {

            AccountCollection accCollect = new AccountCollection();

            foreach (ListViewItem item in this.listView1.Items) //遍历listView1中的数组
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

                accCollect.Add(acc); //将当前listView的信息保存到用户数据中，实际上是完成了一次对数据的重新写入
            }

            this.user.AccountMagr.AccoutList = accCollect;
            this.user.AccountMagr.SaveDataToFile(this.user.PathOfDataFile_Account);
        }


        /// <summary>
        /// 添加帐户信息
        /// </summary>
        private void toolStripSplitButton_Add_Click(object sender, EventArgs e)
        {
            FormAddAccount faa = new FormAddAccount();
            Account acc = new Account();

            if (faa.ShowDialog(this) == DialogResult.OK)    //显示FormAddAccount窗口，判断返回结果为OK时进行的操作
            {
                acc.IniBlance = double.Parse(faa.textBox_IniBalance.Text);  //转化为double型
                acc.MoneyType = faa.textBox_MoneyType.Text;
                acc.OwnerName = faa.textBox_UserName.Text;
                acc.RemainBlance = double.Parse(faa.textBox_RemainBalance.Text);    //转化为double型
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
                this.listView1.Items.Add(lvi);  //将新的账户信息添加到列表中
            }

            
        }


        /// <summary>
        /// 点击列表时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem lviSelected = this.listView1.GetItemAt(e.X, e.Y);  //探索位于置顶位置的项，即当前选中的项
            if (lviSelected != null)    //当点击的列表位置有数据时
            {
                if (e.Button == MouseButtons.Left && e.Clicks > 1)
                {
                    this.toolStripButton_Modify.PerformClick(); //点击次数大于1时（双击时）对该列表显示修改界面
                }

                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip_ListViewItemRightClick.Show(this.listView1, e.Location);  //右键时显示右键菜单
                }

            }
            else
            {
                if (e.Button == MouseButtons.Right) //当点击的列表位置无数据时，显示另一个右键菜单
                {
                    this.contextMenuStrip_ListViewRightClick.Show(this.listView1, e.Location); 
                }
            }
        }

        
        /// <summary>
        /// 保存
        /// </summary>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            this.SaveListViewToFile();     //点击保存按钮时执行保存函数
        }

        /// <summary>
        /// 删除
        /// </summary>
        private void toolStripButton_Del_Click(object sender, EventArgs e)
        {
            string names = string.Empty;
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                names += item.SubItems[1].Text + "\n";  //获取信息数组中的第二项（即用户名）的字符串存放在name中
            }
            if (!String.IsNullOrEmpty(names))
            {
                DialogResult dr = MessageBox.Show("确实要删除\n" + names + "的帐户信息吗?", "删除帐户", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);  //显示对话框
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < this.listView1.SelectedItems.Count;)    // this.listView1.SelectedItems.Count表示的是当前选中的列表有多少项，会随删除的操作而改变，当选中项为0时（即选中项被删完），停止循环
                    {
                        this.listView1.Items.Remove(this.listView1.SelectedItems[i]);
                    }
                }
            }
        }

        

        /// <summary>
        ///修改帐户信息
        /// </summary>
        private void toolStripButton_Modify_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                return;
            }


            FormAddAccount faa = new FormAddAccount();  //新对象窗口faa
            Account acc = new Account();    //新对象acc
            ListViewItem item = this.listView1.SelectedItems[0];    //定义item为当前选中的列表

            faa.textBox_UserName.Text = item.SubItems[1].Text;
            faa.textBox_BankbookNum.Text = item.SubItems[2].Text;
            faa.textBox_cardNum.Text = item.SubItems[3].Text;
            faa.dateTimePicker_StartDate.Text = item.SubItems[4].Text;
            faa.textBox_BankName.Text = item.SubItems[5].Text;
            faa.textBox_MoneyType.Text = item.SubItems[6].Text;
            faa.textBox_AccountType.Text = item.SubItems[7].Text;
            faa.textBox_IniBalance.Text = item.SubItems[8].Text;
            faa.textBox_RemainBalance.Text = item.SubItems[9].Text;
            faa.textBox_Reamrk.Text = item.SubItems[10].Text;   //获取所有信息（序号、户主...）

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


                this.accountManager.AccoutList.Add(acc);    //向列表中添加acc

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

                this.listView1.Items[this.listView1.SelectedIndices[0]] = lvi; //重新写入选中项的数据

            }
        }


        /// <summary>
        /// 导入（覆盖导入）
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
                    MessageBox.Show("被损坏的数据文件或不合法的数据格式,无法导入!!\n:" + ex.Message);
                    return;
                }
                finally
                {
                    if(sr == null)
                    {
                        sr.Close();
                    }
                }

                File.Copy(path, this.user.PathOfDataFile_Account,true); //将文件复制到数据目录中进行覆盖后再读取

                if (accColl != null)
                {
                    this.user.AccountMagr.AccoutList = accColl;
                }
                this.FormAccountManage_Load(null, null);
            }
        }

        /// <summary>
        /// 导出
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
                    File.Copy(this.user.PathOfDataFile_Account, path);  //将数据文件复制到选定的目录下
                }
                catch(Exception ex)
                {
                    MessageBox.Show("转存时发生异常:\n" + ex.Message);
                }

            }

        }

        /// <summary>
        /// 退出
        /// </summary>
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region       right click 右击事件

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
        /// 检索对象设置为筛选文本框中的文字
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
        /// 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string pattern = this.textBox_Select.Text.Trim();   //抓取检索的文字为pattern

            if (string.IsNullOrEmpty(pattern))
            {
                return;
            }

            ListViewGroup groupSelected = new ListViewGroup("groupSelected", "筛选结果: " + pattern);   //将筛选结果存放到一组
            ListViewGroup groupOther = new ListViewGroup("groupOther","其它");    //将其他结果存放到一组

            this.listView1.Groups.Clear();  //每次点击后先清除上次的筛选结果
            
            for (int i = 0; i < this.listView1.Items.Count; i++)    //遍历列表里的所有账户信息
            {
                ListViewItem lvi = this.listView1.Items[i];   //获取第i个账户信息为lvi
                this.listView1.Items[i].Remove();   //删除第i个账户信息，因为在进行添加到Group的操作时，必须删除或者克隆该条列表信息，不删除会报错
                string source = "";
                for (int j = 0; j < lvi.SubItems.Count; j++)
                {
                    source += lvi.SubItems[j].Text;     //连接一条账户的所有文字信息存放至source字符串中
                }
                if (source.ToString().Contains(pattern))
                {
                    groupSelected.Items.Add(lvi);   //如果pattern字符串在source字符串中，即查询的字符串在一条账户的文字信息里，就将该账户移入groupSelected中
                }
                else
                {
                    groupOther.Items.Add(lvi);  //否则就移入groupOther中
                }
                this.listView1.Items.Add(lvi);  //由于前面的分组移动操作把第i个账户信息删除了，但是为了在列表中显示，仍需要重新再把删除的账户信息添加到ListView1的Items中
            }

            this.listView1.Groups.Add(groupSelected);   //添加groupSelected分组
            this.listView1.Groups.Add(groupOther);  //添加groupOther分组


        }

        private void button_CancelSelect_Click(object sender, EventArgs e)
        {
            this.listView1.Groups.Clear();  //清除分组
        }


       
    }
}