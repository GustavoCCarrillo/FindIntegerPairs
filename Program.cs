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

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int pairs = 0;
        int[] pairFrequency = new int[n];
        int temp = -1;

        for (int i = 0; i < ar.Length; i++)
        {
            int count = 1;

            for (int j = i + 1; j < ar.Length; j++)
            {
                if (ar[i] == ar[j])
                {
                    count++;
                    pairFrequency[j] = temp;
                }
            }

            if (pairFrequency[i] != temp)
            {
                pairFrequency[i] = count;
            }
        }
        for (int i = 0; i < pairFrequency.Length; i++)
        {
            if (pairFrequency[i] != temp)
            {
                int divide = pairFrequency[i] / 2;
                pairs += divide;
            }
        }
        return pairs;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
