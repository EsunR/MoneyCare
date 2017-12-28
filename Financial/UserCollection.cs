using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Financial
{
    /// <summary>
    /// ��ʾ��User������ɵļ���
    /// </summary>
    public class UserCollection:ICollection
    {

        private ArrayList list = new ArrayList();

        public UserCollection()
        {
        }

        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public User this[int index]
        {
            get
            {
                return (User)this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        /// <summary>
        /// ���Ԫ��
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Add(User user)
        {
            return this.list.Add(user);
        }

        /// <summary>
        /// ɾ��Ԫ��
        /// </summary>
        /// <param name="user"></param>
        public void Remove(User user)
        {
            this.list.Remove(user);
        }

        /// <summary>
        /// ��������ɾ��Ԫ��
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            this.list.RemoveAt(index);
        }

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
            get
            {
                return this.list.Count;
            }

        }

        bool ICollection.IsSynchronized
        {
            get { return this.list.IsSynchronized; }
        }

        object ICollection.SyncRoot
        {
            get { return this.list.SyncRoot; }
        }

        #endregion

        #region IEnumerable ��Ա

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator(); ;
        }

        #endregion
    }
}
