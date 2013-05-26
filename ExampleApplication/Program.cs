using System;
using CSharpProject;

namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = new Number { Value = "123.456" };
            var secondNumber = new Number { Value = "654.321" };

            var calculator = new Calculator();
            var result = calculator.Add(firstNumber, secondNumber);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
