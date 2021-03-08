using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkUriAdam
{
    class TnaiPashut
    {
      //  static void Main(string[] args)
     //   {


            //Tnaipashut

            //TODO : remove // to start

            ex1();
            /*  


                enter number
                50
                small
                Press any key to continue . . .

            */

            //ex2();

            /*  
               enter number
               30
               many
               Press any key to continue . . .

              */

            //ex3();

            /*  
               enter a number
               34
               positive
               Press any key to continue . . .

              */
            //ex4();

            /*  
               enter two numbers
               34
               54
               number 2 is the bigger
               Press any key to continue . . .

              */
            //ex5();

            /*  
              enter price of shirt
              93
              enter price of pants
              94
              the shirt is good
              dumbass pants
              Press any key to continue . . .

              */


            //ex6();

            /*      
              enter two numbers
              90
              49
              90 BIG
              49 SMALL
              Press any key to continue . . .

              */
            //ex7();

            /*  
               enter number
              90
              900
               Press any key to continue . . .

              */
            //ex8();

            /*  
               enter number
               4
               2
               5
               5
                Press any key to continue . . .

              */
            //ex9();

            /*  
              enter how many boys in your class
              23
              enter how many girls in your class
              54
              great
              Press any key to continue . . .
              */
            //טענת כניסה: הפונק' לא מקבלת כלום
            //  טענת יציאה: לא מחזירה
   //     }

        public static void ex1()
        {
            //
            int num1;//מספר שלם יכיל את המספר
            Console.WriteLine("enter number");
            num1 = int.Parse(Console.ReadLine());
            if (num1 <= 100)
            {
                Console.WriteLine("small");

            }
            else
            {
                Console.WriteLine("big");
            }
        }


        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex2()
        {
            int num;//מספר שלם
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            if (num > 7)
            {
                Console.WriteLine("many");
            }
            else if (num < 7)
            {
                Console.WriteLine("ktzat");
            }
            else
            {
                Console.WriteLine("B I N G O ! ! !");
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex3()
        {
            int num1;//מספר שלם
            Console.WriteLine("enter a number");
            num1 = int.Parse(Console.ReadLine());
            if (num1 >= 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex4()
        {
            int num1, num2;//מספרים שלמים
            Console.WriteLine("enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("number 1 is the bigger");
            }
            else
            {
                Console.WriteLine("number 2 is the bigger");
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex5()
        {
            int shirt, pants;//מחיר חולצה ומכנסיים
            Console.WriteLine("enter price of shirt");
            shirt = int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of pants");
            pants = int.Parse(Console.ReadLine());
            if (pants * 0.5 < shirt)
            {
                Console.WriteLine("the shirt is good");
            }
            if (pants > shirt * 0.666666)
            {
                Console.WriteLine("dumbass pants");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex6()
        {
            int num1, num2;//מספרים שלמים
            Console.WriteLine("enter two numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("{0} BIG", num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("{0} BIG", num2);

            }
            if (num2 < num1)
            {
                Console.WriteLine("{0} SMALL", num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("{0} SMALL", num1);
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex7()
        {
            int num;//מספר שלם
            Console.WriteLine("enter a number");
            num = int.Parse(Console.ReadLine());
            if (num >= 10 && num < 100)
            {
                Console.WriteLine(num * 10);
            }

        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex8()
        {
            int num1, num2, num3;//מספרים שלמים
            Console.WriteLine("enter 3 numbers");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine(num2);
            }
            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        //טענת כניסה: הפונק' לא מקבלת כלום
        //  טענת יציאה: לא מחזירה
        public static void ex9()
        {
            int boys, girls;//מספר בנים ובנות
            Console.WriteLine("enter how many boys in your class");
            boys = int.Parse(Console.ReadLine());
            Console.WriteLine("enter how many girls in your class");
            girls = int.Parse(Console.ReadLine());
            if (boys > girls)
            {
                Console.WriteLine("need more girls");
            }
            else if (girls > boys)
            {
                Console.WriteLine("great");
            }
            else
            {
                Console.WriteLine("idial");
            }

        }
    }
}


