
using System;
using System.Collections.Generic;

namespace DOBOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            string diamond = PrintDiamond(5);
            Console.WriteLine(diamond);



            Console.WriteLine("Задача 2");
            string[] Unsortedarray = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            string[] sortedArray = SortStringsByLength(Unsortedarray);

            foreach (string words in sortedArray)
            {
                Console.WriteLine(words);
            }
            Console.WriteLine("Задача 3");
            int[] array = new int[5]
            { 1, 2, 3, 4, 5 };
            Console.Write("Исходный массив:  ");
            foreach (int i in array) { Console.Write(i + " "); }



            Console.WriteLine();
            Console.Write($"Массив, возведённый в квадрат:");
            int[] Squarearray = array.Square();
            foreach (int i in Squarearray) { Console.Write(i + " "); }
            Console.WriteLine();


            Console.Write($"Массив, возведённый в куб:");
            int[] Cubearray = array.Cube();
            foreach (int i in Cubearray) { Console.Write(i + " "); }
            Console.WriteLine();


            double Average = array.Average();
            Console.WriteLine("Среднее значение массива: " + Average);

            int Sum = array.Sum();
            Console.WriteLine("Сумма массива:" + Sum);

            int[] Evenarray = array.Even();
            Console.Write("Чётный значения массива: ");
            foreach (int i in Evenarray) {  Console.Write(i + " "); }
            Console.WriteLine();


            int[] Oddarray = array.Odd();
            Console.Write("Нечётный значения массива: ");
            foreach (int i in Oddarray) { Console.Write(i + " "); }
            Console.WriteLine();


            Console.WriteLine("Задача 4");
            string[] smiles = { ":)", ";D", ":-)", ":~)", ";-D", "^0", ":D", ";(", ":>", ":}", ":]" };
            foreach (string s in smiles)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("\nКоличество правильных смайлов: " + CountSmileys(smiles));

            Console.WriteLine("Задача 5");
            List<int> ListNearestToZero = new List<int> { 1, 2, -3, -4, 5, 6, -7, -9 };
            Console.Write("Исходный список: ");
            foreach (int i in ListNearestToZero) {  Console.Write(i + " "); }
            Console.WriteLine();
            Console.WriteLine($"Ближейшее число к нулю из списка: {FindNearestToZero(ListNearestToZero)}");




        }

        public static string[] SortStringsByLength(string[] array)
        {
            Array.Sort(array, (a, b) => a.Length.CompareTo(b.Length));
            return array;
        }
        public static string PrintDiamond(int size)
        {
            if (size % 2 == 0 || size < 0)
            {
                return null;
            }

            string diamond = "";
            int spaces = size / 2;
            int stars = 1;

            // Верхняя часть ромба
            for (int i = 0; i < size / 2 + 1; i++)
            {
                diamond += new string(' ', spaces);
                diamond += new string('*', stars);
                diamond += "\n";
                spaces--;
                stars += 2;
            }

            // Нижняя часть ромба
            spaces = 1;
            stars = size - 2;
            for (int i = 0; i < size / 2; i++)
            {
                diamond += new string(' ', spaces);
                diamond += new string('*', stars);
                diamond += "\n";
                spaces++;
                stars -= 2;
            }

            return diamond;
        }
        public static int CountSmileys(string[] arr)
        {
            int count = 0;
            foreach (string smiley in arr)
            {
                if (IsSmiley(smiley))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsSmiley(string str)
        {
            if (str.Length == 2)
            {
                if ((str[0] == ':' || str[0] == ';') &&
                    (str[1] == ')' || str[1] == 'D'))
                {
                    return true;
                }
            }
            else if (str.Length == 3)
            {
                if ((str[0] == ':' || str[0] == ';') &&
                    (str[1] == '-' || str[1] == '~') &&
                    (str[2] == ')' || str[2] == 'D'))
                {
                    return true;
                }
            }
            return false;
        }
        public static int? FindNearestToZero(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return null;
            }

            int nearest = numbers[0];
            foreach (int number in numbers)
            {
                if (Math.Abs(number) < Math.Abs(nearest) || (Math.Abs(number) == Math.Abs(nearest) && number > 0))
                {
                    nearest = number;
                }
            }

            return nearest;
        }
    }
}
