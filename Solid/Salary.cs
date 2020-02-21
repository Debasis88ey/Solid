using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class CalculateSalary
    {
        public double perDaySalary { get; set; }
        public int numberOfDays { get; set; }
        public double CalculateSal()
        {
            return this.numberOfDays * this.perDaySalary;
        }
       

    }

    public class PrintSalary
    {
        public void PrintSal(double salary)
        {
            Console.WriteLine(salary);
        }
    }

}
