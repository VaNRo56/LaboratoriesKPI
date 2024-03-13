using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Join(" ",Console.ReadLine().ToLower());

            Dictionary<char, int> letterCount = CountLet(str);

           
            SortedDictionary<char, int> sort = new SortedDictionary<char, int>(letterCount);

            
            foreach (var p in sort)
            {
                Console.WriteLine($"'{p.Key}': {p.Value}");
            }

            
            string json = JsonSerializer.Serialize(sort);
            File.WriteAllText("result.json", json);

            Console.WriteLine("OK");
        }

        static Dictionary<char, int> CountLet(string input)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount[c] = 1;
                    }
                }
            }

            return letterCount;
        }
    }
}