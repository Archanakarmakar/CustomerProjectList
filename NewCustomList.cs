﻿using System;
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
        int Maxindex;
        T lastElementRemoved;
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
                if (number < count)
                {
                    return data[number];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

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

        public T LastElementRemoved
        {
            get
            {
                return lastElementRemoved;
            }
        }
        public void Add(T value)
        {
            if (count == capacity)
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
        public void Remove(T value)
        {
            int j = 0;
            int countHolder = count;
            for (int i = 0; i < countHolder; i++)
            {
                if (data[i].Equals(value))
                {
                    count--;
                    lastElementRemoved = value;
                }
                else
                {
                    data[j] = data[i];
                    j++;
                }
            }
        }
        public override string ToString()
        {
            string NewString = "";
            for (int i = 0; i < count; i++)
            {
                NewString += data[i] + "";

            }
            return NewString;

        }
        ///overloading + operator
        //overloading - operator
        //method zip
        //txt documantation for - operator
        //iterable
        //
        public static NewCustomList<T> operator +(NewCustomList<T> list1, NewCustomList<T> list2)
        {
            NewCustomList<T> newlist = new NewCustomList<T>();
            foreach (T item in list1)
            {
                newlist.Add(item);
            }
            foreach (T item in list2)
            {
                newlist.Add(item);
            }
            return newlist;
        }
        public static NewCustomList<T> operator -(NewCustomList<T> list1, NewCustomList<T> list2)
        {
            NewCustomList<T> newlist = new NewCustomList<T>();
            foreach (T item in list1)
            {
                newlist.Add(item);
            }
            foreach (T item in list2)
            {
                newlist.Remove(item);
            }
            return newlist;

        }
        public static NewCustomList<T> Zip(NewCustomList<T> list1, NewCustomList<T> list2)
        {
            NewCustomList<T> newlist = new NewCustomList<T>();

            int Count = list1.Count < list2.Count ? list1.Count : list2.Count;

            for (int i = 0; i < Count; i++)
            {
                newlist.Add(list1[i]);
                newlist.Add(list2[i]);
            }
            return newlist;
        }

        public static NewCustomList<T> Sort<T>(NewCustomList<T> list) where T : IComparable
        {
            bool didSwap = false;
            for (int i = 0; i < list.Count - 2; i++)
            {
                for (int j = list.count - 1; j >= 1; j--)
                {
                    if (list[j].CompareTo(list[j - 1]) < 0)
                    {
                        didSwap = true;
                        T temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                }
            }
            if (didSwap)
            {
                return NewCustomList<T>.Sort(list);
            }
            else
            {
                return list;
            }
        }
    }
}


//overloading + operator
//overloading - operator
//method zip
//txt documantation for - operator
//iterable
//



