using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reader.Model.Types
{
    public class BaseList<T> : IList<T> where T : class
    {
        private readonly IList<T> ts;

        public BaseList()
        {
            ts = new List<T>();
        }

        public T this[int index] { get => ts[index]; set => ts[index] = value; }

        public int Count => ts.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            ts.Add(item);
        }

        public void Clear()
        {
            ts.Clear();
        }

        public bool Contains(T item)
        {
            return ts.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ts.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ts.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return ts.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            ts.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return ts.Remove(item);
        }

        public void RemoveAt(int index)
        {
            ts.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ts.GetEnumerator();
        }
    }
}
