﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {

            NewCustomList<int> list = new NewCustomList<int>();

            list.Add(2);
            list.Add(5);
            list.Add(3);

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
