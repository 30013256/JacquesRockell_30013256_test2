using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to staff payroll system \nenter 1. to dysplay salary \nenter 2. to dysplay wages");
            //see what the user imputed and makes sure the didnt imput any besides an int
            int app = int.Parse(Console.ReadLine());
            
            if (app == 1)
            {
                Console.WriteLine("\n \n");
                Sal();
            }
            else if (app == 2)
            {
                Console.WriteLine("\n \n");
                Wag();
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Console.WriteLine("Enter to exit");
                Console.ReadLine();
            }

        }


        public static void Sal()
        {
            Salary s1 = new Salary(80000, 0);

            Console.WriteLine(s1.DisplaySalary());
            
            Console.WriteLine("\n \n \nPress Enter to exit");

            Console.ReadLine();

        }

        public static void Wag()
        {
            Wages w1 = new Wages(33.72,0,0);
            //sets ammount of hours worked
            Console.Write("Enter number of hours worked: ");
            w1.NumHours = int.Parse(Console.ReadLine());

            Console.WriteLine(w1.DisplayWages());


            Console.WriteLine("\n \n \nPress Enter to exit");
            Console.ReadLine();
        }

    }

}
