using System;

namespace Arithmetic_Operations
{
    class Program
    {
        static int add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static int multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        static int divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        static int subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Arithmetica!");
            Console.WriteLine("Enter two numbers: ");

            int firstNumber, secondNumber;
            firstNumber = Int32.Parse(Console.ReadLine());
            secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + add(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + " * " + secondNumber + " = " + multiply(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + divide(firstNumber, secondNumber));
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + subtract(firstNumber, secondNumber));
        }
    }
}
