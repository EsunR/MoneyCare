using System;
using System.Collections.Generic;
using System.Text;

namespace Financial
{
    /// <summary>
    /// �ʻ����ͣ�������Ż��������ۺš����š��������ڵ���Ϣ�����Ϊÿ���û����ļ����µ�account.xml
    /// </summary>
    public class Account
    {
        private string ownerName = String.Empty;//����
        private string bankbookNum = "0";//���ۺ�
        private string cardNum = "0";//����
        private DateTime startDate;//��������
        private string bank = string.Empty;//��������
        private string moneyType = string.Empty;//��������
        private string accountType = string.Empty;//�ʻ�����
        private double iniBlance = 0.0;//��ʼ��
        private double remainBlance = 0.0;//���
        private string remark = string.Empty;//��ע


        /// <summary>
        /// ��ȡ�����ʻ���������
        /// </summary>
        public string OwnerName
        {
            get //�ɶ�
            {
                return this.ownerName;
            }
            set //��д
            {
                this.ownerName = value;
            }
        }

        /// <summary>
        /// ��ȡ�����ÿ���
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
        /// ��ȡ�����ô��ۺ�
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
        /// ��ȡ�����ÿ�������
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
        /// ��ȡ��������������
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
        /// ��ȡ�����û�������
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
        /// ��ȡ�������ʻ�����
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
        /// ��ȡ�����ó�ʼ���
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
        /// ��ȡ���������
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
        /// ��ȡ�����ñ�ע��Ϣ
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
