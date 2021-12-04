using System;
using System.Collections.Generic;
using System.Linq;

namespace FindElement
{
    class Program
    {

        private static void FindElementsForSumTest(List<uint> list, ulong sum, out int start, out int end)
        {
            start = 0;
            end = 0;
            int control = 0; 
            
            list.Sort();

            foreach (var a in list)
            {
                int countOfList = list.Count - 1;
                var b = a;
                var m = 1;


                for (int i = 0; i < countOfList; i++)
                {


                    var indexOfEnd = list.IndexOf(a) + m++;

                    if (countOfList < indexOfEnd)
                    {
                        break;
                    }
                    b = b + list.ElementAt(indexOfEnd);

                    
                    if (b == sum)
                    {
                        start = list.IndexOf(a);
                        end = indexOfEnd + 1;
                        Console.WriteLine($"Start = {start}. End = {end}");
                        control = 1;
                        break;
                    }
                    var test = list.IndexOf(a);
                    if ((b != sum) && (countOfList == list.IndexOf(a +1 )))
                    {

                        Console.WriteLine($"Start = {start}. End = {end}");
                        break;
                    }

                }
                if (control == 1)
                {
                    break;
                }
            }
            
        }

        static void Main(string[] args)
        {
            int end;
            int start;

            FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end);
            FindElementsForSumTest(new List<uint> { 4, 5, 6, 7 }, 18, out start, out end);
            FindElementsForSumTest(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out start, out end);
            Console.ReadKey();
        }


    }
}
