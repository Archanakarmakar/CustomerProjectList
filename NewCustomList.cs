using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class NewCustomList<T>
    {
        T[] data;
        int count;
        int capacity;
        int index;
        public NewCustomList()
        {
            count = 0;
            data = new T[5];
            capacity = 5;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return data[index];
                }

                throw new ArgumentOutOfRangeException();
            }

            set
            {
                if (index >= 0 && index < count)
                {
                    data[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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
                
          data[count] = value;



            

        }
    }
}

