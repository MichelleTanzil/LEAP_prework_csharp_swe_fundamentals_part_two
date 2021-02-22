using System;

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
        static void Main(string[] args)
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
            while (m < arr2.Length - 1)
            {
                arr2[m++] = n++;
            }

            foreach (var k in arr2)
            {
                Console.WriteLine(k);
            }
        }
    }
}

