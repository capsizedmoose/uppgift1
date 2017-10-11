using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    public class ItemStorage<T> : IEnumerable<T>
    {
        T[] items;
        public T this[int index]{
            get { CheckBoundaries(index); return items[index]; }
            set { CheckBoundaries(index); items[index] = value; }
        }
        public int Capacity {get { return items.Length;}}
        public int Count { get; private set; }

        public void Add(T item) {
            EnsureCapacity();
            items[Count++] = item;
        }


        public bool Remove(T item) {
            int index = Array.IndexOf(items,item);
            if (index >= 0) {
                RemoveAt(index);
                return true;
            }
            return false;

        }
        public void RemoveAt(int index) {
            Array.Copy(items, index + 1, items, index, Count - (index + 1));
            Count--;
        }
        public void RemoveAll(Predicate<T> predicate) {
            for (int i = 0; i < Count; i++) {
                if (predicate(items[i]))
                {
                    RemoveAt(i);
                    i--;
                }
            }

        }

        public void Clear() {

            for (int i = 0; i < Count; i++) {
                items[i] = default(T);
            }
            Count = 0;
        }
        public void TrimExcess() {
            T[] newArray = new T[Count];
            Array.Copy(items, newArray, Count);
            items = newArray;
        }

        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }


        public ItemStorage(int capacity = 4)
        {
            items = new T[capacity];
        }
        public ItemStorage(T[] newList)
        {
            items = new T[newList.Length];
            foreach (T t in newList) {
                Add(t);
            }
        }

        public T[] GetAllItems(){
            return items;
        }



        void CheckBoundaries(int index)
        {

            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
        void EnsureCapacity()
        {
            if (Count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
        }

    
     }
}
