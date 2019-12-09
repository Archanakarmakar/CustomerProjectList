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
        T lastElementRemoved;
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
        public void Remove(T value)
        {
            // int j = 0;
            int countHolder = count;
            for (int i = 0; i < countHolder; i++)
            {
                if (data[i].Equals(value))
                {
                    data[i] = data[i + 1];
                    count--;
                    lastElementRemoved = value;
                }
            }
        }
        public string StringToString()
        {
            string NewString = "";
            for (int i = 0; i < count; i++)
            {
                NewString = NewString + data[i] + "";

            }
            return NewString;

        }
    }
}
        /*  public void Sort()
          {
              for (int i = 0; i <data.count; i++)
              {
                  for (int j = 0; j < data.count; j++)
                  {
                      try
                      {
                       int  first  = Convert.ToInt32(data[j]);
                        int second = Convert.ToInt32(myArray[j + 1]);
                          if (first.CompareTo(second) > 0)
                          {
                              T firstElement = data[j];
                              T secondElement =data[j + 1];
                              data[j] = secondElement;
                              myArray[j + 1] = firstElement;
                          }
                      }
                      catch
                      { }
                  }
              }
          }*/
