using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            Console.WriteLine("Your salary per week is $" + salary.DisplaySalary());
            Console.WriteLine("\n"); //two blank lines???
            Wages wages = new Wages();
            Console.Write("Enter the number of hours worked: ");
            int numHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Your wages per week is $" + wages.DisplayWages(numHours));
            Console.ReadKey();
        }
    }
    class Salary
    {
        private double annualSalary = 80000; //initialised
        private double weeklySalary;
        public Salary() //constructor
        {
            Console.WriteLine($"Your salary is set to {annualSalary} per year");
        }
        public double WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }
        public double DisplaySalary()   //method
        {
            double weeklySalary = annualSalary / 52;
            return Math.Round((weeklySalary), 2);
        }
    }
    class Wages
    {
        private double hourlyRate = 33.72;  //initialised
        private int numHours;
        private double weeklyWages;
        public int NumHours
        {
            get { return numHours; }
            set { numHours = value; }
        }
        public double DisplayWages(int _numHours)    //method
        {
            weeklyWages = _numHours * hourlyRate;
            return Math.Round((weeklyWages), 2);    //Must learn how do display properly
        }
        public Wages() //constructor
        {
            Console.WriteLine("I will calculate your wages");
        }
    }
}
