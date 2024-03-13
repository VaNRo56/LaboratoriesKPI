using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Write integer numbers with ',': ");
            string input = Console.ReadLine();

            
            List<int> numbers = input.Split(',').Select(num => int.Parse(num.Trim())).ToList();

           
            var resultSeq = numbers.Select((num, index) => num * (index + 1));

           
            var filteredSeq = resultSeq.Where(num => num >= 10 && num <= 99);

           
            var reversedSeq = filteredSeq.Reverse();

          
            Console.WriteLine("Result:");
            foreach (var num in reversedSeq)
            {
                Console.WriteLine(num);
            }
        }
    }
}