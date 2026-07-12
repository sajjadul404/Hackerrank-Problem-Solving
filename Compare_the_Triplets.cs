using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int alice = 0, bob = 0;

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
                alice++;
            else if (a[i] < b[i])
                bob++;
        }

        Console.WriteLine(alice + " " + bob);
    }
}