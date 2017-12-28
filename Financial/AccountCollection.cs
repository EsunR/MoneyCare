using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Financial
{
    /// <summary>
    /// 表示由Account对象组成的集合，对Account进行管理，如删除、添加
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
        /// 向集合中添加元素
        /// </summary>
        /// <param name="acc"></param>
        /// <returns></returns>
        public int Add(Account acc)
        {
            return this.list.Add(acc);
        }

        /// <summary>
        /// 从集合中移出指定元素
        /// </summary>
        /// <param name="acc"></param>
        public void Remove(Account acc)
        {
            this.list.Remove(acc);
        }

        /// <summary>
        /// 从集合中移出指定索引的元素
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

        /// <summary>
        /// 取得集合元素个数
        /// </summary>
        public int Count
        {
            get
            {
                return this.list.Count;
            }
        }

        #region ICollection 成员

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

        #region IEnumerable 成员

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        #endregion
    }
}
