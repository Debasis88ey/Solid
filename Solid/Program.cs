using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRP ==> Single Responsibility Principal
            //Console.WriteLine("Hello World!");
            //CalculateSalary calsal = new CalculateSalary { perDaySalary = 3000, numberOfDays = 30 };
            //double sal = calsal.CalculateSal();
            //PrintSalary printSalary = new PrintSalary();
            //printSalary.PrintSal(sal);
            List<Shape> shapes = new List<Shape>
            {
            new Rectangle(),
            new Squre()
            };
            foreach(var s in shapes)
            {
                s.Print();
            }
            Console.ReadKey();
        }
    }
}
