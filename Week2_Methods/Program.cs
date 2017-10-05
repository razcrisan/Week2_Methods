using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            //    int fNum = int.Parse(Console.ReadLine());
            //    int sNum = int.Parse(Console.ReadLine());


            //    Console.WriteLine(Add(fNum, sNum));
            //}

           
            //Console.WriteLine("Please enter ur name");
            //string name = Console.ReadLine();
            //Console.WriteLine("please enter ur fav food");
            //string food = Console.ReadLine();
            //FavFood(name, food);
            //FavFood("Bob", "Pizza");
            //FavFood("raz", "burger");
            //FavFood("Moni", "shakes");

            
            //retirementcalculator(60);

            Console.WriteLine("Please type in your hours worked");
            double hoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Please type in your hourly wage");
            double hourlyWage = double.Parse(Console.ReadLine());

            Console.WriteLine(WageCalculator(hoursWorked, hourlyWage));




            Console.WriteLine("How much did you make this month?");
            double income = double.Parse(Console.ReadLine());

            Console.WriteLine("How much did you spend this month?");
            double expenses = double.Parse(Console.ReadLine());

            SavingsCalculator(income, expenses);
        }

        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;
        //    return sum;          
        //}


        //public static void FavFood(string name, string food)
        //{
        //    Console.WriteLine("**********************************");          
        //    Console.WriteLine(name + "'s favorite food is " + food);
        //    Console.WriteLine();
        //}

        //public static void retirementcalculator(int age)
        //{
        //    int retirementage = Math.Max(0, 65 - age);
        //    Console.WriteLine("The user will retire in " + retirementage +" years");         
        //}

        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double moneyMade = hoursWorked * hourlyWage;           
            return moneyMade;
        }

        public static double SavingsCalculator( double income, double expenses)
        {
            if (income > expenses)
            {
                double savings = (income - expenses) * .15;
                Console.WriteLine("you should set aside $" + savings + " this month");
                return savings;
            }
            else
            {
                Console.WriteLine("Nothing to save this month. Easy on the Starbucks");
                return 0;
            }
        }


    }

    }


