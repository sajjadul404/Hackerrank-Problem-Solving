using System;
using System.Linq;

class Solution
{
    static int SimpleArraySum(int[] ar)
    {
        int sum = 0;

        foreach (int num in ar)
        {
            sum += num;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray();

        int result = SimpleArraySum(ar);

        Console.WriteLine(result);
    }
}