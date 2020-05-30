using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodD();
        }

        public static int MethodA()
        {
            int[] arr = { 1, 3, 5, 8, 13, 21, 34 };
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 1)
                    sum += arr[i];
            }
            return sum;
        }

        public static int MethodB()
        {
            int[] arr = { 1, 3, 5, 8, 13, 21, 34 };
            int sum = arr.Where(x => x % 2 == 1).Sum();

            int sum2 = (from x in arr
                       where x % 2 == 1
                       select x).Sum();
            return sum;
        }

        public static void MethodC()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");

        }

        public static void MethodD()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            var myLinqQuery = from name in names
            where name.Contains('a')
            select name;

            foreach (var item in myLinqQuery)
            {
                Console.WriteLine(item);
            }
            
        }
    }

}
