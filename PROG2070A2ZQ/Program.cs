using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A2ZQ
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chosen = false;
            bool isAnInt;
            int a = 0;
            int b = 0;
            int c = 0;
            string chosenString;

            do
            {
                Console.WriteLine("Please chooose one of the following\n1.Enter triangle dimensions\n2.Exit");//the main menu
                chosenString = Console.ReadLine();
                if(chosenString=="1")
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 1st number");//enter the first number
                            a = int.Parse(Console.ReadLine());
                            isAnInt = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("that's not a integer! try again!");
                            isAnInt = false;
                        }
                    }
                    while (!isAnInt);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 2nd number");//enter the second number
                            b = int.Parse(Console.ReadLine());
                            isAnInt = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("that's not a integer! try again!");
                            isAnInt = false;
                        }
                    }
                    while (!isAnInt);
                    do
                    {
                        try
                        {
                            Console.WriteLine("Please enter the 3rd number");//enter the third number
                            c = int.Parse(Console.ReadLine());
                            isAnInt = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("that's not a integer! try again!");
                            isAnInt = false;
                        }
                    }
                    while (!isAnInt);
                    TriangleFinder testTri = new TriangleFinder();
                    Console.WriteLine(testTri.Analyze(a,b,c));

                }
                else if(chosenString=="2")
                {
                    Environment.Exit(0);//quit
                }
                else
                {
                    Console.WriteLine("Please only choose 1 or 2, try again!\n--------------------------------------------------------------------------------------------------");
                }
            }
            while (!chosen);
        }
    }
}
