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
        }
        //public static int Add(int firstNumber, int secondNumber)
        //{
        //    int sum = firstNumber + secondNumber;

        //    return sum;
        //    //is not like a consoleWriteLine, just holds it           


        //}
        public static void FavFood(string name, string food)
        {
            Console.WriteLine(name + " " + food);

        }

        public static int RetirementCalculator(int age, int rAge)
        {
            rAge = 65;
            age = int.Parse(Console.ReadLine());
            int retirementAge = rAge - age;
            
            return retirementAge;       
        }

        
    }

    }


