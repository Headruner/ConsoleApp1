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

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> score = new List<int> { 0, 0 };
        for (int i = 0; i < a.Count(); i++)
        {
            if (a[i] > b[i]) 
            {
                score[0] = score[0] + 1;
            }
            else
            {
                if (a[i] < b[i]) 
                {
                    score[1] = score[1] + 1;
                }
            }
        }
        return score;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        try {
            // Check if OUTPUT_PATH environment variable is set
            string outputPath = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");

                if (string.IsNullOrEmpty(outputPath))
                {
                    Console.WriteLine("Error: OUTPUT_PATH environment variable is not set.");
                    return; // Exit the program if OUTPUT_PATH is not set
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return; // Exit the program if an exception occurs
        }
        
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
*/