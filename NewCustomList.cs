using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class NewCustomList<T> : IEnumerable
    {
        T[] data;
        int count;
        int capacity;
        int MaxIndex;
        T[] temporaryArray;
        public NewCustomList()
        {
            count = 0;
            capacity = 5;
            data = new T[5];

        }
        public T this[int number]
        {
            get
            {
                return data[number];
            }
            set
            {
                data[number] = value;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
        public void Add(T value)
        {
            if (count == MaxIndex)
            {
                CreateLargerArray();
            }
            data[count] = value;
            count++;
        }

        public void CreateLargerArray()
        {
            T[] temporaryArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = data[i];
            }
            capacity = capacity * 2;
            data = temporaryArray;

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return data[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

