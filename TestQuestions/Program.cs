using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestions
{
    class Program
    {
        public static void IsPrime(int Isprime)
        {
            bool check = true;
            if (Isprime <= 1)
            {
                Console.WriteLine("Entered number is Not a Prime number");
            }
            else
            {
                for (int i = 2; i < Isprime / 2; i++)
                {
                    if (Isprime % i == 0)
                    {
                        check = false;
                        if (check == false)
                        {
                            Console.WriteLine("Entered Number is Not a Prime number");
                            break;
                        }

                    }
                }
                if (check == true)
                {
                    Console.WriteLine("Entered Number is a Prime number " + Isprime);
                }
                if (check == false)
                {
                    for (int i = 2; i < Isprime; i++)
                    {
                        if (Isprime % i == 0)
                        {
                            Isprime++;
                            i = 2;
                        }

                    }
                    Console.WriteLine("Next Prime Number is :" + Isprime);
                }
            }

        }

        public static void SumOfSeries(int val)
        {
            /*Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
            Test Data:
            Input the number of terms: 5
            Expected Output :
            1 + 11 + 111 + 1111 + 11111 +
            The Sum is : 12345
            */
            Console.WriteLine("OutPut Is");
            for (int i = 1; i <= val; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("1");
                }
                Console.Write("+ ");
            }
            Console.WriteLine();

            //Printing Sum
            Console.WriteLine("Sum is ");
            int sum = 0;
            for (int i = 1; i <= val; i++)
            {
                sum = sum + 1;
                Console.Write(sum);
            }
        }

        public static void PatternofA()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 3)
                        Console.Write("*");
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void ArrayOfMultiples(int number, int length)
        {
            /*
            Create a function that takes two numbers as arguments (num, length) and returns an 
            array of multiples of num until the array length reaches length.
            Examples
            ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
            ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
            ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
            */
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = number * (i + 1);
            }
            Console.Write("[");
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("]");
        }

        public static void CountSaces(string text)
        {
            /*
            Create a program in C# that implements a function called CountSpaces that receives as a parameter a text 
            requested from the user. Then show the total spaces that the text has.
            */
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Spaces in string are : " + count);

        }

        public static void PrintGrid(int rows, int columns)
        {
            /*Write a method that accepts two integer parameters rows and cols.The output is
            a 2d array of numbers displayed in column - major order, meaning the numbers shown 
            increase sequentially down each column and wrap to the top of the next column to the right 
            once the bottom of the current column is reached.

             Examples
             PrintGrid(3, 6) ➞ new int[,] {
              new int[] { 1, 4, 7, 10, 13, 16 },
              new int[] { 2, 5, 8, 11, 14, 17 },
              new int[] { 3, 6, 9, 12, 15, 18 }
            ]
            PrintGrid(5, 3) ➞ new int[,] {
              new int[] { 1, 6, 11 },
              new int[] { 2, 7, 12 },
              new int[] { 3, 8, 13 },
              new int[] { 4, 9, 14 },
              new int[] { 5, 10, 15 }
            ]
            PrintGrid(4, 1) ➞ new int[,] {
              new int[] { 1 },
              new int[] { 2 },
              new int[] { 3 },
              new int[] { 4 }
            ]*/
            int[,] arr = new int[rows, columns];
            Console.WriteLine("OutPut Is");


            for (int i = 0; i < arr.GetLength(0); i++) // Rows
            {
                int temp = i + 1;
                for (int j = 0; j < arr.GetLength(1); j++) // Columns
                {
                    
                        temp = temp + rows;
                        arr[i, j] = temp;
                        Console.Write(arr[i, j] + ", ");
                    
                }
                Console.WriteLine(" ");
            }

        }

        static void Main(string[] args)
        {
            //Question1
            //int num = 0;
            //int Isprime = 0;
            //Console.WriteLine("Enter Number");
            //Isprime = Convert.ToInt32(Console.ReadLine());
            //IsPrime(Isprime);

            //Question 2
            //Console.WriteLine("Question 2");
            //Console.WriteLine("Enter value");
            //int val = Convert.ToInt32(Console.ReadLine());
            //SumOfSeries(val);



            //Question 3
            //PatternofA();



            //Question 4
            //int number = 0;
            //int length = 0;
            //Console.WriteLine("Enter Number");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Length");
            //length = Convert.ToInt32(Console.ReadLine());
            //ArrayOfMultiples(number, length);


            //Question 5
            //string text;
            //Console.WriteLine("Enter Text");
            //text = Convert.ToString(Console.ReadLine());
            //CountSaces(text);

            //Question 6
            
            int rows, columns;
            Console.WriteLine("Enter Number of Rows");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Columns");
            columns = Convert.ToInt32(Console.ReadLine());
            PrintGrid(rows,columns);

            Console.ReadLine();
        }
    }
}
