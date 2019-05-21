using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Salary
    {
        //private variables
        private double annualSalary = 80000;
        private double weeklySalary;


       
        //allow you to access private variables
        public double AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }
        
        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }


        //constuctor
        public Salary(double _AnnualSalary, double _WeeklySalary)
        {
            Console.WriteLine("Your salary is set at $80000 a year");

            annualSalary = _AnnualSalary;

            weeklySalary = _WeeklySalary;

        }

        public Salary()
        {

        }

        //method to calculate salary
        public string DisplaySalary()
        {
            return "Your salary per week is $" + Math.Round(annualSalary / 54,2);

        }

    }

}
