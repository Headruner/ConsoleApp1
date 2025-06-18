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
/*
class Result
{

    
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     

    public static int diagonalDifference(List<List<int>> arr)
    {
        int ltr = 0;
        int rtl = 0;
        int k = arr[0].Count() - 1;
        for (int i = 0; i <= k; i++) //top to bottom
        {
            for (int j = 0; j <= k; j++) // left to right
            {
                if (i == j)
                {
                    ltr += arr[i][j];
                }
            }
            for (int l = k; l >= 0; l--) // right to left
            {
                if (i == k - l)
                {
                    rtl += arr[i][l];
                }
            }
        }
       int diff = Math.Abs(ltr - rtl);
       return diff;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
*/