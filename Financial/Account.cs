using System;
using System.Collections.Generic;
using System.Text;

namespace Financial
{
    /// <summary>
    /// 帐户类型，用来存放户主、存折号、卡号、开户日期等信息，存放为每个用户名文件夹下的account.xml
    /// </summary>
    public class Account
    {
        private string ownerName = String.Empty;//户主
        private string bankbookNum = "0";//存折号
        private string cardNum = "0";//卡号
        private DateTime startDate;//开户日期
        private string bank = string.Empty;//开户银行
        private string moneyType = string.Empty;//货币种类
        private string accountType = string.Empty;//帐户类型
        private double iniBlance = 0.0;//初始额
        private double remainBlance = 0.0;//余额
        private string remark = string.Empty;//备注


        /// <summary>
        /// 获取设置帐户户主名称
        /// </summary>
        public string OwnerName
        {
            get //可读
            {
                return this.ownerName;
            }
            set //可写
            {
                this.ownerName = value;
            }
        }

        /// <summary>
        /// 获取活设置卡号
        /// </summary>
        public string CardNum
        {
            get
            {
                return this.cardNum;
            }
            set
            {
                this.cardNum = value;
            }
        }

        /// <summary>
        /// 获取或设置存折号
        /// </summary>
        public string BankbookNum
        {
            get
            {
                return this.bankbookNum;
            }
            set
            {
                this.bankbookNum = value;
            }
        }

        /// <summary>
        /// 获取或设置开户日期
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                this.startDate = value;
            }

        }

        /// <summary>
        /// 获取或设置银行名称
        /// </summary>
        public string BankName
        {
            get
            {
                return this.bank;
            }
            set
            {
                this.bank = value;
            }
        }

        /// <summary>
        /// 获取或设置货币类型
        /// </summary>
        public string MoneyType
        {
            get
            {
                return this.moneyType;
            }
            set
            {
                this.moneyType = value;
            }
        }

        /// <summary>
        /// 获取或设置帐户类型
        /// </summary>
        public string AccountType
        {
            get
            {
                return this.accountType;
            }
            set
            {
                this.accountType = value;
            }
        }

        /// <summary>
        /// 获取或设置初始金额
        /// </summary>
        public double IniBlance
        {
            get
            {
                return this.iniBlance;
            }
            set
            {
                this.iniBlance = value;
            }
        }

        /// <summary>
        /// 获取或设置余额
        /// </summary>
        public double RemainBlance
        {
            get
            {
                return this.remainBlance;
            }
            set
            {
                this.remainBlance = value;
            }
        }

        /// <summary>
        /// 获取或设置备注信息
        /// </summary>
        public string Remark
        {
            get
            {
                return this.remark;
            }
            set
            {
                this.remark = value;
            }
        }

    }
}
