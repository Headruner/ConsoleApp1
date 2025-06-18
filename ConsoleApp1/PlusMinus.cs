using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<decimal> ratios = new List<decimal> { 0, 0, 0 };
        List<int> arr2 = new List<int> { 0, 0, 0 };        for( int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] > 0)
            {
                arr2[0]++;
            }
            else
            {
                if (arr[i] < 0)
                {
                    arr2[1]++;
                }
                else
                {
                    arr2[2]++;
                }
            }
        }
        ratios[0] = Math.Round((decimal)arr2[0] / arr.Count(), 6);
        ratios[1] = Math.Round((decimal)arr2[1] / arr.Count(), 6); 
        ratios[2] = Math.Round((decimal)arr2[2] / arr.Count(), 6);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
