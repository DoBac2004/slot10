﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot10.c4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test in case return null
            Console.WriteLine("{0}", Min(null));

            //Add data to list
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(1);
            list.Add(1230);
            //Test in case does not return null
            Console.WriteLine("{0}", GetFirst(list));
        }

        private static int Min(object p)
        {
            throw new NotImplementedException();
        }

        private static int? GetFirst(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return null;
            }
            return list[0];

        }
    }
}
