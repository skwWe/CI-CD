using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayMethods
{
    public class ArrayClass
    {
        public int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public int[] ArraySort()
        {
            Array.Sort(array);
            //Console.WriteLine("");
            foreach (var value in array)
                Console.WriteLine(value + " ");
            return array;
        }

        public void ArrayFilter()
        {
            var DivisibleByThree = from i in array
                                   where i % 3 == 1
                                   select i;
        }
    }
}
