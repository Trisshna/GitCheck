using System;
using System.Collections.Generic;
namespace EvaluationTest_3Project
{
    class Program
    {
        void DivisibleBySeven()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the numbers");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Numbers that are divisible by 7 in the entered list:");
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 7 == 0)
                {
                    Console.WriteLine(arr[j]);
                }
            }
        }


        void PrintNumbers()
        {
            int number, i, a, b, count;
            Console.Write("Enter lower bound of the interval ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper bound of the interval ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < a)
            {
                Console.WriteLine("Invalid Entry");
            }
            else
            {
                for (number = a; number <= b; number++)
                {
                    count = 0;
                    for (i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count == 0 && number != 1)
                        Console.Write("{0} ", number);
                }
                Console.Write("The prime numbers between {0} and {1} are : ", a, b);
                if (count == 1)
                    Console.WriteLine(i);
            }
        }
        }


        static void CheckRepetation()
        {
           List<int> num = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    num.Add(i);
            }
            IEnumerable<int> repeats = num.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            Console.WriteLine("The repeated numbers are:");
            foreach (var item in repeats)
            {
                Console.WriteLine(item);
            }
        }

        static void SortAscending()
        {
            var NumberList = new List<int>();
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                if (number > 0)
                    NumberList.Add(number);
                number = Convert.ToInt32(Console.ReadLine());

            }
            NumberList.Sort();
            foreach (var item in NumberList)

            {
                Console.WriteLine(item);
            }
        }

        static void CheckCredentials()
        {
            string username, password;
            int count = 0;
            do
            {
                Console.Write("Enter the username:");
                username = Console.ReadLine();
                Console.Write("Enter the password: ");
                password = Console.ReadLine();
                if (username != "Admin" || password != "admin")
                    count = count + 1;
                else
                    count = 1;
                Console.WriteLine("Invalid username or password.Two more attempts left");
            }
            while ((username != "Admin" || password != "admin") && (count != 3));
            if (count == 3)
                Console.Write("You cannot try again since you have exceeded the number of attempts allowed");

            else
                Console.Write("Welcome !!!");
        }

        static void CowsBullsGame()
        {
            string[] arr = ["kite", "four", "neat", "play", "goal" ];

            Console.WriteLine("Play..");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter your guess");
                string Guess = Console.ReadLine();
                string guess = arr[i];
                int cows = 0, bulls = 0;
                if (guess.Length == Guess.Length)
                {
                    
                    for (i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == Guess[i])
                        {
                            cows += 1;
                        }
                        else
                        {
                            for (int j = 0; j < guess.Length; j++)
                            {
                                if (guess[i] == Guess[j] && i != j)
                                {
                                    bulls += 1;
                                }
                            }
                        }
                        Console.WriteLine("Cows = " + cows + " Bulls = " + bulls);
                    }
                   
                    if (cows == guess.Length)
                    {
                        Console.WriteLine("You Won !!!");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Your guess should have" + guess.Length + " letters in it");
                }
            }
            
        }
        static void CardValidation()
        {
            Console.WriteLine("Enter the card Number");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int Day = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(Year, Month, Day);
            Console.WriteLine("Enter the CVV on the card");
            string num2 = Console.ReadLine();
            string RevrerseString = string.Empty;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                RevrerseString += num1[i];
            }
            Console.WriteLine(RevrerseString);
            int num, num3, sum = 0, num4 = 0, num5 = 0;
            for (int i = 0; i < RevrerseString.Length; i++)
            {
                char v = RevrerseString[i];
                num = (int)Char.GetNumericValue(v);
                if (i % 2 == 0)
                {
                    num3 = num * 2;
                    num5 += num3;
                }
                else
                {
                    num4 += num;
                }
                sum = num5 + num4;
            }
            int value = dt.CompareTo(DateTime.Today);
            if ((num1.Length == 16 || num1.Length == 15) && (value > 0) && (num2.Length == 3) && (sum % 10 == 0))
            {
                Console.WriteLine("Your Credit card has been validated");
            }
            else if ((num1.Length != 16 & num1.Length > 16) || (num1.Length != 15 & num1.Length < 15))
            {
                Console.WriteLine("Invalid Card Number");
            }
            else if (num2.Length != 3)
            {
                Console.WriteLine("Invalid CVV number ");
            }
            else if (value < 0)
            {
                Console.WriteLine("Your card has expired");
            }
            else if (sum % 10 != 0)
            {
                Console.WriteLine("Incorrect Card Number");
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
        
        static void Main(string [] a)
        {
            Program p = new Program();
            p.DivisibleBySeven();
            p.PrintNumbers();
            p.CheckRepetation();
            p.SortAscending();
            p.CheckCredentials();
            p.CowsBullsGame();
            p.CardValidation();
        }
    }
}
