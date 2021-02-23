using System;
using System.Collections.Generic;
using System.Text;

namespace swe_fundamentals_part_2
{
    public enum Mood
    {
        Hungry,
        Sleepy,
        Anxious,
        Happy,
        Sad
    }

    class Program
    {
        public static List<List<int>> GetPermutations(List<int> array)
        {
            List < List<int> > permutations = new List<List<int>>();
            GetPermutations(0, array, permutations);
            return permutations;
        }
        public static void GetPermutations(int idx, List<int> array, List<List<int>> permutations)
        {
            if (idx == array.Count - 1)
                permutations.Add(new List<int>(array));
            else
            {
                for (int j = idx; j < array.Count; j++)
                {
                    Swap(array, idx, j);
                    GetPermutations(idx + 1, array, permutations);
                    Swap(array, idx, j);
                }
            }
        }

        public static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void PrintMessageString(string msg)
        {
            if (string.IsNullOrEmpty(msg))
                return;
            Console.WriteLine(msg);
        }
        public static string JoinMessages(string str1, string str2, string str3)
        {
            return String.Concat(str1, str2, str3);
        }

        public static void UpdateArray(int[] arrayToBeUpdated, int idx, int val)
        {
            if (idx >= 0 && idx < arrayToBeUpdated.Length - 1)
            {
                arrayToBeUpdated[idx] = val;
                Console.WriteLine($"arrayToBeUpdated's index #{idx} was changed to {arrayToBeUpdated[idx]}");
            }
            else
            {
                Console.WriteLine("The index is out of range");
            }
        }

        public static string SubString(string str, int idx = 0, int length = 0)
        {
            //other method:
            //string result = "";
            //return result = length == 0 ? str.Substring(idx) : str.Substring(idx, length)

            if (idx < 0 || idx > str.Length - 1 || length < 0 || ((idx + length) > str.Length - 1))
                return "";

            string result = "";
            if (length == 0)
            {
                while (idx < str.Length)
                {
                    result += str[idx++];
                }
            }
            else
            {
                while (length > 0)
                {
                    result += str[idx++];
                    length--;
                }
            }
            return result;
        }

        public static string EveryOtherWord(string example)
        {
            StringBuilder result = new StringBuilder();
            string[] words = example.Split(' ');
            for (int i = 0; i < words.Length; i += 2)
            {
                result.Append(words[i] + " ");
            }
            return result.Remove(result.Length - 1, 1).ToString();
        }

        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;
            int runner = 0;
            while (runner < arr1.Length && runner < arr2.Length)
            {
                if (arr1[runner] != arr2[runner++])
                    return false;
            }
            return true;
        }

        public static char ReferenceParameters(string str, ref int num)
        {
            if (num < 0)
            {
                num = 0;
                return str[0];
            }
            if (num > str.Length - 1)
            {
                num = str.Length - 1;
                return str[str.Length - 1];
            }
            return str[num];
        }

        public static void OutputParameters(int num1, int num2, out int sum, out int difference, out int product, out int quotient)
        {
            sum = num1 + num2;
            difference = Math.Abs(num1 - num2);
            product = num1 * num2;
            quotient = num1 / num2;
        }

        public static void Main(string[] args)
        {
            int x = 1;
            if (x == 100)
                Console.WriteLine("x is 100");
            else if (x < 100)
                Console.WriteLine("x is less than 100");
            else
                Console.WriteLine("x is greater than 100");

            Mood mood = (Mood)(new Random()).Next(0, 5);

            switch (mood)
            {
                case Mood.Sad:
                case Mood.Happy:
                    Console.WriteLine("You must be happy or sad");
                    break;

                case Mood.Hungry:
                    Console.WriteLine("You're hungry! Go eat something");
                    break;

                case Mood.Sleepy:
                case Mood.Anxious:
                    Console.WriteLine("Sorry to hear you're sleepy or anxious");
                    break;

                default:
                    Console.WriteLine("Your mood is invalid");
                    break;
            }
            string str = "Bunny is the cutest!";

            //Option 1
            //if ((str.Length < 5 && (str.Length % 2 != 0)) || (str.Length >= 10 && (str.Length % 2 == 0)))
            //    Console.WriteLine("The bunny string length matches the conditionals");

            //Option 2
            if (str.Length < 5)
            {
                if (str.Length % 2 != 0)
                    Console.WriteLine("The bunny string length matches the conditionals");
            }
            else if (str.Length >= 10)
            {
                if (str.Length % 2 == 0)
                    Console.WriteLine("The bunny string length matches the conditionals");
            }

            //Infinite Loop
            //while (true)
            //    Console.WriteLine("running an infinite loop");

            string str1 = "0123456789";
            int runner = 0;

            while (runner < str1.Length)
            {
                if (runner % 2 != 0)
                    Console.Write(str1[runner]);
                runner++;
            }

            int runner2 = 0;
            do
            {
                if (runner2 % 2 != 0)
                    Console.Write(str1[runner2]);
                runner2++;
            }
            while (runner2 < str1.Length);

            for (int i = 0; i < str1.Length; i++)
            {
                if (i % 2 != 0)
                    Console.Write(str1[i]);
            }

            int runner3 = 0;
            foreach (char j in str1)
            {
                if (runner3 % 2 != 0)
                    Console.Write(j);
                runner3++;
            }

            Console.WriteLine();
            int[] arr1 = { 1, 2, 3, 4, 5 };

            //Option 1
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr1[i]);
            //    int j = i + 1;
            //    if (j == arr1.Length)
            //        j = 0;
            //    while (j != i)
            //    {
            //        Console.Write(arr1[j]);
            //        if (j == arr1.Length - 1)
            //            j = -1;
            //        j++;

            //    }
            //    Console.WriteLine();
            //}

            //Option 2

            string str2 = "Bunny is the Best!";
            for (int i = 1; i < str2.Length; i++)
            {
                if (str2[i] == str2[0])
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            int[] arr2 = new int[10];
            int m = 0, n = 1;
            while (m < arr2.Length)
            {
                arr2[m++] = n++;
            }

            //Print array in reverse order with a loop
            int sum = 0;
            for (int i = arr2.Length - 1; i >= 0; i--)
            {
                sum += arr2[i];
                Console.Write(arr2[i]);
            }
            Console.WriteLine("\nsum: " + sum);

            //Print array as a string
            string arrayContents = string.Join(",", arr2);
            Console.WriteLine(arrayContents);

            int[,] arr3 = new int[5, 4];
            int b = 0, c = 0;
            while (b < 5 && c < 4)
            {
                int temp = b * c;
                arr3[b, c++] = temp;
                if (c == 4)
                {
                    c = 0;
                    b++;
                }
            }

            foreach (var u in arr3)
            {
                Console.WriteLine(u);
            }

            PrintMessageString("This is a message");
            Console.WriteLine(JoinMessages("My name ", "is ", "Michelle."));
            UpdateArray(new int[] { 1, 2, 3, 4, 5 }, 2, 5);
            Console.WriteLine(EveryOtherWord("to be or not to be"));
            Console.WriteLine(SubString("to be or not to be", 5, 3));
            Console.WriteLine(AreArraysEqual(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5 }));
            int num = 6;
            Console.WriteLine(ReferenceParameters("Bunny is the most adorable bunny!", ref num));
            int added, difference, product, quotient;
            OutputParameters(4, 2, out added, out difference, out product, out quotient);
            Console.WriteLine("added: {0}", added);
            Console.WriteLine("difference: {0}", difference);
            Console.WriteLine("product: {0}", product);
            Console.WriteLine("quotient: {0}", quotient);
            GetPermutations(new List<int> { 1, 2, 3, 4, 5 });
        }

    }

}