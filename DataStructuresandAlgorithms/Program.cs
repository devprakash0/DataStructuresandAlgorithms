using DataStructuresandAlgorithms.ADT;
using System.Collections;

namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Line#12 and Line#13 are doing the same thing interally
            Stack stack = new Stack();

            AbstractDataType adt = new AbstractDataType();

            Console.WriteLine("Hello, World!");

            // O(N) - "Linear"
            // loop through each item in a collection 
            //only one loop
            int total = 0;
            int i = 2;

            while(i<10)
            {
                total += i;
                i++;
            }

            // O(N^2) - "Quadratic"
            // loop through a collection for each item in a collection
            // more than one loop
            // nested loops
            var n = int.Parse(Console.ReadLine());

            for (var r = 1; r <= n; r++)
            {
                for (var c = 1; c <= n; c++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }

            // O(log n) - "Logarithmic"
            // loop through a collection and cut the problem in half each iteration
            // binary search & Trees
            var j = 1;
            while (j < n)
            {
                Console.WriteLine(j);
                j = j * 2;
            }

            // O(n log n) - "Linearithmic"
            // loop through a collection and cut the problem in half each iteration
            // then loop through the collection again
            // merge sort, shell sort, cube sort & quick sort
            for (var p = 1; p <= n; p++)
            {
                var m = 1;
                while (m < n)
                {
                    Console.WriteLine(m);
                    m = m * 2;
                }
            }
        }

        // O(1) - "Constant"
        public void Insert( int item)
        {
            // naything that can be done in a fixed amount of time
            //like assignment 
            var a = item;
        }
    }
}
