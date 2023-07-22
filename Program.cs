using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_7_23_Assign_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Hello, World!
            Console.WriteLine("Hello, World!");

            //Task 2:Variables and User Input
            string name;
            Console.Write("Please enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            //Task 3:Basic Arithmetic

           /* double firstNumber = 1.40, secondNumber = 3.60, result;
            int num1 = 2, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);*/


            //Task 4: Control Structures
/*
            int n;
            Console.WriteLine("Enter an integer number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");*/


           /* //Task 5: Loops
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
*/

            //Task 6: Arrays
/*
            int[] arraynumbers = new int[5];
            Console.WriteLine("Enter 5 numbers");

            for (int i = 0; i < arraynumbers.Length; i++)
            {
                arraynumbers[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (int i in arraynumbers)
            {
                total += i;
            }

            Console.WriteLine("Total of arrays:" + total);

            double average = (double)total / arraynumbers.Length;
            Console.WriteLine("Average of the arrays: " + average);
            Console.ReadKey();*/



            //Task 7: Methods
/*
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                int factorial = CalculateFactorial(number);
                Console.WriteLine($"The factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            Console.ReadKey();
        }
        static int CalculateFactorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalculateFactorial(n - 1);
                }            
*/


                //Task 8: Exception Handling

               int age;
                while (true)
                {
                    Console.Write("Enter your age: ");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        if (age < 0)
                        {
                            Console.WriteLine("Invalid age. Please enter a positive number.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                   
                }
            Console.ReadKey();
        }
        }
   } 

