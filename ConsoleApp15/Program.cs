using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 */
            string path = @"C:\Users\ЕрзатулыТ\source\repos\ConsoleApp15\ConsoleApp15\Fibo.txt";
            string[] words;
            List<int> numbers = new List<int>();
            using (var stream = new StreamReader(path))
            {
                var text = stream.ReadToEnd();
                words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            int counter = 0;
            foreach (var element in words)
            {
                if (int.TryParse(element, out int number))
                {
                    numbers.Add(number);
                    counter++;
                }
            }

            for (int i = 0; i < counter; i++)
            {
                numbers.Add(numbers[counter - 2 + i] + numbers[counter - 1 + i]);
            }


            using (var stream = new StreamWriter(path))
            {
                foreach (var number in numbers)
                {
                    stream.Write(number+" ");
                }
            }
            /*2. string path = @"C:\Users\ПК\source\repos\ConsoleApp1\ConsoleApp1\1.txt";
            string[] words;
            List<int> numbers = new List<int>();
            using (var stream = new StreamReader(path))
            {
                var text = stream.ReadToEnd();
                words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            int counter = 0;
            foreach (var element in words)
            {
                if (int.TryParse(element, out int number))
                {
                    numbers.Add(number);
                    counter++;
                }
            }
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Summa = " + sum);
            */

        }
    }
}
