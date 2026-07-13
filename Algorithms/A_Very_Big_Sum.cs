using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    
    public static long aVeryBigSum(List<long> ar)
    {
       
        return ar.Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
    
        int Convert.ToInt32(Console.ReadLine().Trim());

        
        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        
        Console.WriteLine(result);
    }
}