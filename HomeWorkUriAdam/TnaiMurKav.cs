using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkUriAdam
{
    class TnaiMurKav
    {
        //  static void Main(string[] args)
        //    {


        //  TNAIMURKAV
        //TODO : remove // to start
        //ex1();
        /*  
        enter zlaot
        23
        21
        19
        triangle
        Press any key to continue . . .

        */

        //ex2();

        /*  
           enter age
           23
           you got 97 years to go :))))
           Press any key to continue . . .

          */

        //ex3();

        /*  
           insert boys
           24
           Girls?
           25
           great
           Press any key to continue . . .

          */
        //ex4();

        /*  
           insert pos num
           26
           B O O M
           Press any key to continue . . .

          */
        //ex5();

        /*  
          enter three numbers
          34
          21
          56
          num 2 /2  - 10)
          Press any key to continue . . .

          */


        //ex6();

        /*      
          enter hours you worked
          60
          780
          Press any key to continue . . .
          */
        //   }
        public static void ex1()
        {
            int num1, num2, num3;//אורך צלעות
            Console.WriteLine("enter zlaot");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 + num2 > num3)
            {

                if (num1 == num2 && num3 == num1)
                {
                    Console.WriteLine("sheve zlaot");
                }
                else if (num1 != num2 && num2 != num3 && num1 != num3)
                {
                    Console.WriteLine("triangle");
                }
                else
                {
                    Console.WriteLine("shokaim");
                }

            }
            else if (num2 + num3 > num1)
            {
                if (num1 == num2 && num3 == num1)
                {
                    Console.WriteLine("sheve zlaot");
                }
                else if (num1 != num2 && num2 != num3 && num1 != num3)
                {
                    Console.WriteLine("triangle");
                }
                else
                {
                    Console.WriteLine("shokaim");
                }


            }
            else if (num3 + num1 > num2)
            {
                if (num1 == num2 && num3 == num1)
                {
                    Console.WriteLine("sheve zlaot");
                }
                else if (num1 != num2 && num2 != num3 && num1 != num3)
                {
                    Console.WriteLine("triangle");
                }
                else
                {
                    Console.WriteLine("shokaim");
                }

            }
            else
            {
                Console.WriteLine("not a triangle");
            }



        }

        public static void ex2()
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());//גיל
            if (age > 120 || age < 0)
            {
                Console.WriteLine("wrong age ( immortal?)");
            }
            else
            {
                Console.WriteLine("you got {0} years to go :))))", 120 - age);
            }


        }

        public static void ex3()
        {
            int numB;//מספר בנים
            int numG;//מספר בנות
            Console.WriteLine("insert boys");
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("Girls?");
            numG = int.Parse(Console.ReadLine());

            if (numG == numB)
            {
                Console.WriteLine("ideal");
            }
            else if (numG > numB)
            {
                Console.WriteLine("great");

            }
            else if (numG < numB)
            {
                Console.WriteLine("need more G");

            }


        }

        public static void ex4()
        {
            Console.WriteLine("insert pos num");
            int num = int.Parse(Console.ReadLine());//מספר שלם
            if ((num > 1 && num < 50) || (num > 90 && num < 99))
            {


                Console.WriteLine("B O O M");

            }
            else if (num > 100 && num < 0)
            {
                Console.WriteLine(" E R R O R ");
            }
            else
            {
                Console.WriteLine("WHOOPS");
            }
        }

        public static void ex5()
        {


            int num1, num2, num3;//שלושה מספרים
            Console.WriteLine("enter three numbers ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if ((num1 + num2 + num3) / 3 > 100)
            {
                Console.WriteLine(" num 1 - {0}  num 3 - {1}", num1, num3);
            }
            else if ((num1 + num2 + num3) / 3 < 100)
            {
                Console.WriteLine(" num 2 /2  - {0})", num2 / 2);
            }

        }

        public static void ex6()
        {
            int hours;//שעות עבודה
            Console.WriteLine("enter hours you worked");
            hours = int.Parse(Console.ReadLine());
            if (hours < 40 && hours > 0)
            {
                Console.WriteLine(hours * 12);
            }
            else if (hours < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine((40 * 12) + (15 * (hours - 40)));
            }


        }

    }
}