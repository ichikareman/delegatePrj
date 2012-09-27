using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace delegatePrj
{
    public static class Program
    {
        private delegate int SampleDelegate(int x);

        public delegate bool WhereDelegate(int x);


        static void Main(string[] args)
        {
            var list = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var filterBelow6 = new WhereDelegate(FilterOdd);

            //var newList = list.WhereClause(filterBelow6);
            //var newList = list.Where(x => x % 2 != 0);
            var newList = list.Select(x => new {intValue = x, stringValue = x.ToString()});
            
            foreach (var i in newList)
            {
                Console.WriteLine(i.intValue.ToString() + " :" + i.stringValue);
            }

            Console.ReadKey();
        }

        public static int[] WhereClause(this int[] list, WhereDelegate filter)
        {
            var newList  = new List<int>();
            foreach (var item in list)
            {
                if(filter(item))
                {
                    newList.Add(item);
                }
            }
            return newList.ToArray();
            
        }

        public static bool FilterBelow6(int x)
        {
            return x <= 5;
        }

        public static bool FilterOdd(int x)
        {
            return (x % 2) != 0;
        }

    }
}
