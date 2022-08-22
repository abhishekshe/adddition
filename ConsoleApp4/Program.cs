using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrr = new string[7];
            for(int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine("Enter the days");
                
                arrr[i] = Console.ReadLine();
                

                
            }
            Console.WriteLine(arrr);
        }
    }
}
