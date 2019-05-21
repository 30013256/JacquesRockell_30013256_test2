using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Wages
    {
        //instance variables
        private double hourlyRate = 33.72;
        private int numHours;
        private double weeklyWages;

   

        //allows you to access the private variables
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public int NumHours
        {
            get { return numHours; }
            set { numHours = value; }
        }
        public double WeeklyWages
        {
            get { return weeklyWages; }
            set { weeklyWages = value; }
        }


        public Wages(double _HourlyRate, int _NumHours, double _WeeklyWages)
        {
            Console.WriteLine("I will calculate your wages");

            hourlyRate = _HourlyRate;
            numHours = _NumHours;
            weeklyWages = _WeeklyWages;

        }


        //method to calculate wages
        public string DisplayWages()
        {
                                               //rounds it to 2 decimal places
            return "Your wages per week is $"+  Math.Round(numHours* hourlyRate, 2);
        }

    }

}
