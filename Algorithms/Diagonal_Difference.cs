using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];

            secondaryDiagonalSum += arr[i][n - 1 - i];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}