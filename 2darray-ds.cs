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

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
            
            int rowLenght = arr.Length;
            int colLenght = arr.OrderBy(x => x.Length).First().Length;
            int max = Int32.MinValue;
            //int[,] result = new int[rowLenght - 2, colLenght - 2];

            if (rowLenght < 3 || colLenght < 3)
            {
                throw new Exception("hour glases must have at least 3x3");
            }

            for (int row = 0; row < rowLenght - 2; row++)
            {
                for (int col = 0; col < colLenght - 2; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        sum = sum + arr[row][col + i] + arr[row + 2][col + i];
                    }
                    sum += arr[row + 1][col + 1];
                    //result[row, col] = sum;
                    if (sum > max) max = sum;
                }
            }

            return max;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
