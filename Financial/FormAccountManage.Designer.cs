namespace Financial
{
    partial class FormAccountManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Modify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DataInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DataOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_BankBoolNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CardNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Bank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_MoneyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_AccountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_IniBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_About = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox_Select = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_ListViewRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Output = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_ListViewItemRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.button_CancelSelect = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip_ListViewRightClick.SuspendLayout();
            this.contextMenuStrip_ListViewItemRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_Add,
            this.toolStripButton_Del,
            this.toolStripButton_Modify,
            this.toolStripSeparator1,
            this.toolStripButton_DataInput,
            this.toolStripButton_DataOutput,
            this.toolStripButton_Save,
            this.toolStripButton_Exit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(749, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "导出";
            // 
            // toolStripSplitButton_Add
            // 
            this.toolStripSplitButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_Add.Image")));
            this.toolStripSplitButton_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton_Add.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton_Add.Name = "toolStripSplitButton_Add";
            this.toolStripSplitButton_Add.Size = new System.Drawing.Size(64, 34);
            this.toolStripSplitButton_Add.Text = "添加";
            this.toolStripSplitButton_Add.Click += new System.EventHandler(this.toolStripSplitButton_Add_Click);
            // 
            // toolStripButton_Del
            // 
            this.toolStripButton_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Del.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Del.Image")));
            this.toolStripButton_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Del.Name = "toolStripButton_Del";
            this.toolStripButton_Del.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Del.Text = "删除";
            this.toolStripButton_Del.Click += new System.EventHandler(this.toolStripButton_Del_Click);
            // 
            // toolStripButton_Modify
            // 
            this.toolStripButton_Modify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Modify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Modify.Image")));
            this.toolStripButton_Modify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Modify.Name = "toolStripButton_Modify";
            this.toolStripButton_Modify.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Modify.Text = "修改";
            this.toolStripButton_Modify.Click += new System.EventHandler(this.toolStripButton_Modify_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton_DataInput
            // 
            this.toolStripButton_DataInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DataInput.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DataInput.Image")));
            this.toolStripButton_DataInput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_DataInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DataInput.Name = "toolStripButton_DataInput";
            this.toolStripButton_DataInput.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_DataInput.Text = "数据导入";
            this.toolStripButton_DataInput.Click += new System.EventHandler(this.toolStripButton_DataInput_Click);
            // 
            // toolStripButton_DataOutput
            // 
            this.toolStripButton_DataOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DataOutput.Image = global::Financial.Properties.Resources._out;
            this.toolStripButton_DataOutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_DataOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DataOutput.Name = "toolStripButton_DataOutput";
            this.toolStripButton_DataOutput.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_DataOutput.Text = "数据导出";
            this.toolStripButton_DataOutput.Click += new System.EventHandler(this.toolStripButton_DataOutput_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Save.Text = "保存";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Exit.Text = "退出";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "筛选：";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(381, 42);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "给我筛";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Num,
            this.columnHeader_Owner,
            this.columnHeader_BankBoolNum,
            this.columnHeader_CardNum,
            this.columnHeader_Date,
            this.columnHeader_Bank,
            this.columnHeader_MoneyType,
            this.columnHeader_AccountType,
            this.columnHeader_IniBalance,
            this.columnHeader_Balance,
            this.columnHeader_About});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 415);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader_Num
            // 
            this.columnHeader_Num.Text = "序号";
            // 
            // columnHeader_Owner
            // 
            this.columnHeader_Owner.Text = "户主";
            this.columnHeader_Owner.Width = 84;
            // 
            // columnHeader_BankBoolNum
            // 
            this.columnHeader_BankBoolNum.Text = "存折号";
            this.columnHeader_BankBoolNum.Width = 136;
            // 
            // columnHeader_CardNum
            // 
            this.columnHeader_CardNum.Text = "卡号";
            this.columnHeader_CardNum.Width = 156;
            // 
            // columnHeader_Date
            // 
            this.columnHeader_Date.Text = "开户日期";
            this.columnHeader_Date.Width = 90;
            // 
            // columnHeader_Bank
            // 
            this.columnHeader_Bank.Text = "开户银行";
            this.columnHeader_Bank.Width = 89;
            // 
            // columnHeader_MoneyType
            // 
            this.columnHeader_MoneyType.Text = "币种";
            // 
            // columnHeader_AccountType
            // 
            this.columnHeader_AccountType.Text = "帐户类型";
            this.columnHeader_AccountType.Width = 104;
            // 
            // columnHeader_IniBalance
            // 
            this.columnHeader_IniBalance.Text = "初始额";
            this.columnHeader_IniBalance.Width = 90;
            // 
            // columnHeader_Balance
            // 
            this.columnHeader_Balance.Text = "余额";
            this.columnHeader_Balance.Width = 69;
            // 
            // columnHeader_About
            // 
            this.columnHeader_About.Text = "备注";
            this.columnHeader_About.Width = 214;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML文档|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML文档|*.xml";
            // 
            // textBox_Select
            // 
            this.textBox_Select.Location = new System.Drawing.Point(73, 42);
            this.textBox_Select.Name = "textBox_Select";
            this.textBox_Select.Size = new System.Drawing.Size(288, 21);
            this.textBox_Select.TabIndex = 6;
            this.textBox_Select.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Select_KeyDown);
            // 
            // contextMenuStrip_ListViewRightClick
            // 
            this.contextMenuStrip_ListViewRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddNew,
            this.toolStripSeparator5,
            this.ToolStripMenuItem_Import,
            this.ToolStripMenuItem_Output});
            this.contextMenuStrip_ListViewRightClick.Name = "contextMenuStrip_ListViewRightClick";
            this.contextMenuStrip_ListViewRightClick.Size = new System.Drawing.Size(137, 76);
            // 
            // ToolStripMenuItem_AddNew
            // 
            this.ToolStripMenuItem_AddNew.Name = "ToolStripMenuItem_AddNew";
            this.ToolStripMenuItem_AddNew.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_AddNew.Text = "添加新帐户";
            this.ToolStripMenuItem_AddNew.Click += new System.EventHandler(this.ToolStripMenuItem_AddNew_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // ToolStripMenuItem_Import
            // 
            this.ToolStripMenuItem_Import.Name = "ToolStripMenuItem_Import";
            this.ToolStripMenuItem_Import.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_Import.Text = "导入数据";
            this.ToolStripMenuItem_Import.Click += new System.EventHandler(this.ToolStripMenuItem_Import_Click);
            // 
            // ToolStripMenuItem_Output
            // 
            this.ToolStripMenuItem_Output.Name = "ToolStripMenuItem_Output";
            this.ToolStripMenuItem_Output.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_Output.Text = "导出数据";
            this.ToolStripMenuItem_Output.Click += new System.EventHandler(this.ToolStripMenuItem_Output_Click);
            // 
            // contextMenuStrip_ListViewItemRightClick
            // 
            this.contextMenuStrip_ListViewItemRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Modify,
            this.toolStripSeparator7,
            this.ToolStripMenuItem_Del});
            this.contextMenuStrip_ListViewItemRightClick.Name = "contextMenuStrip_ListViewItemRightClick";
            this.contextMenuStrip_ListViewItemRightClick.Size = new System.Drawing.Size(141, 54);
            // 
            // ToolStripMenuItem_Modify
            // 
            this.ToolStripMenuItem_Modify.Name = "ToolStripMenuItem_Modify";
            this.ToolStripMenuItem_Modify.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Modify.Text = "修改          ";
            this.ToolStripMenuItem_Modify.Click += new System.EventHandler(this.ToolStripMenuItem_Modify_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(137, 6);
            // 
            // ToolStripMenuItem_Del
            // 
            this.ToolStripMenuItem_Del.Name = "ToolStripMenuItem_Del";
            this.ToolStripMenuItem_Del.Size = new System.Drawing.Size(140, 22);
            this.ToolStripMenuItem_Del.Text = "删除";
            this.ToolStripMenuItem_Del.Click += new System.EventHandler(this.ToolStripMenuItem_Del_Click);
            // 
            // button_CancelSelect
            // 
            this.button_CancelSelect.Location = new System.Drawing.Point(462, 42);
            this.button_CancelSelect.Name = "button_CancelSelect";
            this.button_CancelSelect.Size = new System.Drawing.Size(108, 23);
            this.button_CancelSelect.TabIndex = 9;
            this.button_CancelSelect.Text = "取消筛选";
            this.button_CancelSelect.UseVisualStyleBackColor = true;
            this.button_CancelSelect.Click += new System.EventHandler(this.button_CancelSelect_Click);
            // 
            // FormAccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 484);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.textBox_Select);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button_CancelSelect);
            this.Name = "FormAccountManage";
            this.Text = "帐户管理";
            this.Load += new System.EventHandler(this.FormAccountManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip_ListViewRightClick.ResumeLayout(false);
            this.contextMenuStrip_ListViewItemRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Del;
        private System.Windows.Forms.ToolStripButton toolStripButton_Modify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_DataInput;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_Num;
        private System.Windows.Forms.ColumnHeader columnHeader_Owner;
        private System.Windows.Forms.ColumnHeader columnHeader_CardNum;
        private System.Windows.Forms.ColumnHeader columnHeader_Bank;
        private System.Windows.Forms.ColumnHeader columnHeader_IniBalance;
        private System.Windows.Forms.ColumnHeader columnHeader_Balance;
        private System.Windows.Forms.ColumnHeader columnHeader_About;
        private System.Windows.Forms.ColumnHeader columnHeader_MoneyType;
        private System.Windows.Forms.ColumnHeader columnHeader_AccountType;
        private System.Windows.Forms.ColumnHeader columnHeader_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_BankBoolNum;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton_Add;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox_Select;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListViewRightClick;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Import;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ListViewItemRightClick;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Modify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Del;
        private System.Windows.Forms.Button button_CancelSelect;
        private System.Windows.Forms.ToolStripButton toolStripButton_DataOutput;
    }
}