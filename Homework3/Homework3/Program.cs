using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil et: ");
            string text = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a') 
                count++;
            }
            Console.WriteLine(count);

        }
    }
}
