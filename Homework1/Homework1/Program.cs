using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 10, 15 };

            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max) 
                max = nums[i];
            }
            Console.WriteLine("En boyuk eded: "+max);

        }
    }
}
