using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Beginner_Course_Exercise
{
    internal class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisterAirMail = 2,
            Express = 3

        }
        static void Main(string[] args)
        {
            //ValidInvalidTask();
            // Maxminfunction();
            //arraylenght();
            //arraylenght();
            //arrayclear();
            //arrayindex();
            //arraycopy();
            //EumsExe();
            //Countnumonehundard();
            //continuouslyenternum();
            //Secretnum();
            ReversedTheName();


        }

        private static void ReversedTheName()
            {
            Console.WriteLine("The Enter the name to Reverse it:");
            var name = Console.ReadLine();

            for(int i = name.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }


        }

        // LOOP
        private static void Secretnum()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }

            Console.WriteLine("You lost!");


        }
        private static void continuouslyenternum()
        {
            // 2- Write a program and continuously ask the user to enter a number or "ok"
            // to exit. Calculate the sum of all the previously entered numbers and display it on the console.


            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number to conutinue and ok to exist");

                var input = Console.ReadLine();

                if (input.ToLower() == "ok")

                    break;


                sum += Convert.ToInt32(input);


            }
            Console.WriteLine("Sum of all numbers is " + sum);

        }


        private static void Countnumonehundard()
        {
            // 1- Write a program to count how many numbers between 1 and 100 are divisible
            // by 3 with no remainder. Display the count on the console.

            int count1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count1 = count1 + 1;
                }

            }

            Console.WriteLine("Count = " + count1);

        }


        // EUMS
        private static void EumsExe()
        {
            var method = ShippingMethod.RegularAirMail;
            Console.WriteLine((int)method);
        }
        // ARRAYS
        private static void arraycopy()
        {
            var numbers = new[] { 3, 8, 2, 6, 9, 1 };
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of copy()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
        private static void arrayclear()
        {
            var numbers = new[] { 3, 8, 2, 6, 9, 1 };
            Array.Clear(numbers, 1, 2);
            Console.WriteLine("Effect of clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }

        private static void arrayindex()
        {
            var numbers = new[] { 3, 8, 2, 6, 9, 1 };
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9 is: " + index);
        }
        private static void arraylenght()
        {
            var numbers = new[] { 3, 8, 2, 6, 9, 1 };

            Console.WriteLine("Lenght: " + numbers.Length);

        }

        // CONDITIONAL STATEMENT
        private static void ValidInvalidTask()
        {
            //  1- Write a program and ask the user to enter a
            //  number. The number should be between 1 to 10.
            //  If the user enters a valid number, display "Valid"
            //  on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input
            //  boxes need to be validated.)

            Console.Write("Enter a number between 1 to 10: ");
            var enter_num = Console.ReadLine();
            int num = Convert.ToInt32(enter_num);
            if (num <= 10)
            {

                Console.WriteLine("Vaild");
            }
            else
                Console.WriteLine("invaild");
        }

        private static void Maxminfunction()
        {

            //2- Write a program which takes two numbers from the
            //console and displays the maximum of the two.

            Console.WriteLine("Enter two number");
            var num_one = Convert.ToInt32(Console.ReadLine());

            var num_two = Convert.ToInt32(Console.ReadLine());

            if (num_one < num_two)
            {

                Console.WriteLine(num_two + " is maximum");

            }
            else
                Console.WriteLine(num_one + " is maximum");
        }
    }
}
