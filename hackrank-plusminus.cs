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
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with

places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to
10^-4 are acceptable.


*/

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double ratPlus = 0, ratMin = 0, ratNol = 0, n = arr.Count();
        foreach (var item in arr)
        {
            if (item < 0)
            {
                ratMin += 1;
            }
            else if (item > 0)
            {
                ratPlus += 1;
            }
            else
            {
                ratNol += 1;
            }

        }
        ratPlus /= n;
        ratMin /= n;
        ratNol /= n;
        Console.WriteLine(Math.Round((ratPlus), 5));
        Console.WriteLine(Math.Round((ratMin), 5));
        Console.WriteLine(Math.Round((ratNol), 5));
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
