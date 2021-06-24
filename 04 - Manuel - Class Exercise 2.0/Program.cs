using System;
using Entities;
namespace _04___Manuel___Class_Exercise_2._0 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            Calculator calculator = new Calculator(width, height);
            Console.WriteLine(calculator);
            


        }
    }
}
