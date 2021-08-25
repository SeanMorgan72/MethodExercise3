using System;

namespace MethodsExcercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ThousandCount();

            TrippleCount();

            int num1, num2;
            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            CheckValue(num1, num2);

            OddOrEven(num1);

            PosNeg(num2);

            VoteCandidateAge();

            RangeCheck();

            MultiplicationTable();
        }
        /*Write a method that will print to the 
         * console all numbers 1000 through -1000.*/
        public static void ThousandCount()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine("{0}", i);
            }
        }

        /*Write a method that will print to the 
         * console numbers 3 through 999 by 3 each time.*/
        public static void TrippleCount()
        {
            for(int j = 3; j <= 999; j += 3)
            {
                Console.WriteLine("{0}", j);
            }
        }

        /*Write a method to accept two integers as parameters
         * and check whether they are equal or not.*/
        public static void CheckValue(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine("Numbers are equal.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Numbers are not equal.");
                Console.WriteLine("\n");
            }
        }

        /*Write a method to check whether a
         * given number is even or odd.*/
        public static void OddOrEven(int num)
        {
            int rem1 = num % 2;
            if(rem1 == 0)
            {
                Console.WriteLine($"{num} is even.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
                Console.WriteLine("\n");
            }
        }

        /*Write a method to check whether a given 
         * number is positive or negative.*/
        public static void PosNeg(int num)
        {
            if(num >= 0)
            {
                Console.WriteLine($"{num} is positive.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"{num} is negative.");
                Console.WriteLine("\n");
            }
        }

        /*Write a method to read the age of a candidate and determine 
         * whether they can vote. Hint: use Parse()... 
         * or the safer TryParse() for an extra challenge!!*/
        public static void VoteCandidateAge()
        {
            int voteAge;

            Console.WriteLine("Enter the age of the candidate: ");
            voteAge = int.Parse(Console.ReadLine());

            if(voteAge >= 18)
            {
                Console.WriteLine("Candidate is old enough to vote.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Candidate is not old enough to vote.");
                Console.WriteLine("\n");
            }
         
        }

        /*Write a method to check if an integer (from the user) is in the range -10 to 10.*/
        public static void RangeCheck()
        {
            int value = 0;

            Console.WriteLine("Enter a number: ");
            value = int.Parse(Console.ReadLine());

            if(value >= -10 && value <= 10)
            {
                Console.WriteLine($"{value} is within the range of integers.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"{value} is not within the range of integers.");
                Console.WriteLine("\n");
            }
        }

        /*Write a method to display the multiplication table(from 1 to 12) of a given integer.*/
        public static void MultiplicationTable()
        {
            int num1, num2;

            for(num1 = 1; num1 <= 12; num1++)
            {
                Console.WriteLine($"Multiplication Table : {num1}");

                for (num2 = 0; num2 <= 10; num2++)
                {
                    Console.WriteLine("{0} * {1} = {2}\n", num1, num2, num1 * num2);
                }
                Console.WriteLine("\n");
            }
        }

    }
}