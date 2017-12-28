using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Financial
{
    /// <summary>
    /// ��ʾ��Account������ɵļ��ϣ���Account���й�����ɾ�������
    /// </summary>
    public class AccountCollection:ICollection
    {

         private ArrayList list = new ArrayList();


        public AccountCollection()
        {
        }

        public Account this[int index]
        {
            get
            {
                return (Account)this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        /// <summary>
        /// �򼯺������Ԫ��
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public int Add(Account acc)
        {
            return this.list.Add(acc);
        }

        /// <summary>
        /// �Ӽ������Ƴ�ָ��Ԫ��
        /// </summary>
        /// <param name="acc"></param>
        public void Remove(Account acc)
        {
            this.list.Remove(acc);
        }

        /// <summary>
        /// �Ӽ������Ƴ�ָ��������Ԫ��
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        /// <summary>
        /// ȡ�ü���Ԫ�ظ���
        /// </summary>
        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        #region ICollection ��Ա

        void ICollection.CopyTo(Array array, int index)
        {
            this.list.CopyTo(array, index);
        }

        int ICollection.Count
        {
            get { return this.list.Count; }
        }

        bool ICollection.IsSynchronized
        {
            get { return this.list.IsSynchronized;}
        }

        object ICollection.SyncRoot
        {
            get {return this.list.SyncRoot; }
        }

        #endregion

        #region IEnumerable ��Ա

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        #endregion
    }
}
