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
namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    int input =Convert.ToInt32(Console.ReadLine());
        //    List<int> arr = new List<int>();
        //    for (int i=0; i< input; i++)
        //    {
        //        arr.Add(Convert.ToInt32(Console.ReadLine()));
        //    }
        //    int k = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine( findNumber(arr, k));
        //    Console.Read();
        //}

        static void Main1(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int l = Convert.ToInt32(Console.ReadLine().Trim());

            int r = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> res = oddNumbers(l, r);

            //textWriter.WriteLine(String.Join("\n", res));
            Console.WriteLine(String.Join("\n", res));
            Console.Read();

            //textWriter.Flush();
            //textWriter.Close();
        }

        // Complete the oddNumbers function below.
        static List<int> oddNumbers(int l, int r)
        {
            List<int> oddResults = new List<int>();
            for (int k=l; k<=r; k++)
            {
                if(k % 2 !=0)
                {
                    oddResults.Add(k);
                }
            }
            return oddResults;

        }

        // Complete the findNumber function below.
        static string findNumber(List<int> arr, int k)
        {
            int result = arr.Find(x => x.Equals(k));
            return result > 0 ? "YES" : "NO";
            

        }


    }



class Solution
    {



        // Complete the birthdayCakeCandles function below.
        static int birthdayCakeCandles(int[] ar)
        {
            //DateTime.Today
            List<int> result = new List<int>();
            int max = 0;
            foreach(int i in ar)
            {
                if(result.Contains(i))
                {
                    continue;

                }
                int cnt= ar.Where(x => x == i).Count();
                max = max < cnt ? cnt : max;
                result.Add(i);
            }

            return max;

        }


        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            //int counter = n - 1;
            List<Int64> result = new List<Int64>();
            Int64 sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(i==j)
                    {
                        continue;
                    }
                    else
                    {
                        sum += arr[j];
                    }
                }
                result.Add(sum);
                sum = 0;
            }

            Console.WriteLine(result.Min() + " " + result.Max());
        }



        // Complete the staircase function below.
        static void staircase(int n)
        {
            int counter = n-1;

            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(j>= counter)
                    {
                        Console.Write("#");
                    }
                    else
                        Console.Write(" ");

                }
                counter--;
                Console.WriteLine();
            }

        }


        static void plusMinus(int[] arr)
        {
            int totalPositive = arr.Where(x => x > 0).Count(); 
            int totalNegative = arr.Where(x => x < 0).Count(); 
            int totalZero = arr.Where(x => x == 0).Count();
            decimal totalNumber = Convert.ToDecimal(arr.Length);

            decimal OuputPositive = totalPositive / totalNumber;
            decimal OuputNegative = totalNegative / totalNumber;
            decimal OuputZero = totalZero / totalNumber;

            Console.WriteLine(string.Format("{0:0.000000}", OuputPositive));
            Console.WriteLine(string.Format("{0:0.000000}", OuputNegative));
            Console.WriteLine(string.Format("{0:0.000000}", OuputZero));


        }

        static int diagonalDifference(int[][] arr)
        {
            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i =0; i<arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if(i==j)
                    {
                        firstDiagonal += arr[i][j];
                    }

                    if(i + j == arr.Length-1)
                    {
                        secondDiagonal += arr[i][j];
                    }
                }
            }

            int sum = firstDiagonal + secondDiagonal;
            return sum < 0 ? (-1 * sum) : sum;
        }

        // Complete the aVeryBigSum function below.
        static long aVeryBigSum(long[] ar)
        {

            return ar.Sum();
            
        }

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> output = new List<int>();
            int alice = 0;
            int bob = 0;

            for (int i = 0; i<a.Count; i++)
            {
                if(a[i] > b[i])
                {
                    alice++;
                }
                if (a[i] < b[i])
                {
                    bob++;
                }
            }

            output.Add(alice);
            output.Add(bob);

            return output;
        }

        static void Main(string[] args)
        {

            processData(new List<int>() { 4,10,7,9,8 });
            //38,46

            //int num = int.Parse(Console.ReadLine());
            //List<string> lstInputs = new List<string>();
            //for (int i=0; i< num; i++)
            //{
            //    var currentInstruction = Console.ReadLine();
            //    lstInputs.Add(currentInstruction);
            //}

            //string result = processData(lstInputs);

            //Console.WriteLine(result);

            Console.ReadLine();

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            //List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //List<int> result = compareTriplets(a, b);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }

        static List<int> processData(List<int> inputArray)
        {
            List<int> result = new List<int>();
            result.Add(inputArray.Sum());
            var s = inputArray.Where(x => x % 2 == 0).Count() * 3;
            result.Add(inputArray.Sum() + s -1);

            return result.OrderBy(x=>x).ToList();
        }


        static List<int> processData1(List<int> inputArray)
        {
            List<int> result = new List<int>();
            result.Add(inputArray.Sum() + inputArray[0]);
            var s = (inputArray.Where(x => x % 2 == 0).Count() + 1) * 3;
            result.Add(inputArray.Sum() + s - 1);

            return result.OrderBy(x => x).ToList();
        }

        static string processData(List<string> input)
        {
            var str = "";
            Stack stack = new Stack();

            foreach (var line in input)
            {
                var parts = line.Split(' ');
                var command = parts[0];
                string param = parts.Length > 1  ? "" :  parts[1];

                switch (command)
                {
                    case "add":
                        {
                            // Append.
                            stack.Push(str);
                            str += param;
                            break;
                        }
                    case "delete":
                        {
                            // Delete.
                            stack.Push(str);
                            if (str.Length > 0)
                            {
                                if (str.Length == int.Parse(param))
                                {
                                    str = str.Substring(0, int.Parse(param) - 1);
                                }
                                else
                                {
                                    str = str.Substring(0, str.Length - int.Parse(param));
                                }
                                
                            }
                            break;
                        }
                    case "print":
                        {
                            // Print.
                            if (str == "")
                            {
                                Console.WriteLine("cannot print");
                            }
                            else
                            {
                                Console.WriteLine(str[int.Parse(param) - 1]);
                            }
                            break;
                        }
                    case "undo":
                        {
                            // Undo.
                            if (stack.Count > 0)
                            {
                                str = stack.Pop().ToString();
                            }
                            break;
                        }
                    default:
                        break;
                        
                };
            }

            return str;
        }
    }
}
