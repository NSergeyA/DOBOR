using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOBOR
{
   public static class ArrayExtension
    {
            public static int[] Square(this int[] arr)
            {
                int[] result = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = arr[i] * arr[i];
                }
                return result;
            }

            public static int[] Cube(this int[] arr)
            {
                int[] result = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = arr[i] * arr[i] * arr[i];
                }
                return result;
            }

            public static double Average(this int[] arr)
            {
                if (arr.Length == 0)
                {
                    return double.NaN;
                }
                return arr.Sum() / (double)arr.Length;
            }

            public static int Sum(this int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }

            public static int[] Even(this int[] arr)
            {
                List<int> evenList = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenList.Add(arr[i]);
                    }
                }
                return evenList.ToArray();
            }

            public static int[] Odd(this int[] arr)
            {
                List<int> oddList = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        oddList.Add(arr[i]);
                    }
                }
                return oddList.ToArray();
            }
        }
    }

