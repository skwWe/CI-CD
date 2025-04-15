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
            try
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array cannot be null or empty for sorting.");
                }
                Array.Sort(array);
                //Console.WriteLine("");
                foreach (var value in array)
                    Console.WriteLine(value + " ");
                return array;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка сортировки массива: {ex.Message}");
                return null; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка возникшая при сортировке: {ex.Message}");
                return null; 
            }
        }

        public void ArrayFilter()
        {
            try
            {
                if (array == null)
                {
                    throw new ArgumentNullException("Array cannot be null for filtering.");
                }
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 3 == 0)
                    {
                        array[j] = array[i];
                        j++;
                    }
                }


                if (j < array.Length)
                {
                    Array.Resize(ref array, j);
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Ошибка фильтрации массива: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка возникшая при фильтрации: {ex.Message}");
            }
        }
    }
}

