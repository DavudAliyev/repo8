using System;
using System.Resources;
using System.Threading.Channels;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Texti daxil et: ");
            string text= Console.ReadLine();

            bool check = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    check = true;
                    break;
                }
            }

            if(check)
            {
                Console.WriteLine("a herfi var");
            }
            else
            {
                Console.WriteLine("a herfi yoxdur");
            }




















           /* bool check = false;
            char[] text = {'a', 'b', 'c', 'd', 'e' };
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a') ;
                break;
            }
            Console.WriteLine("a herfi var");*/
        }
    }
}
