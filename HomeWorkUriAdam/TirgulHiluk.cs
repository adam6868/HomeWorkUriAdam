using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkUriAdam
{
    class TirgulHiluk
    {
        //        static void Main(string[] args)
        //      {


        //TNAIHILUK:
        //TODO : remove // to start
        //ex1();
        /*  

        enter how many people
        23
        the number of peoples who stay in the line after the taxies filled is 5
        the number of taxies that get out tho their way is 3
        Press any key to continue . . .

        */

        //ex2();

        /*  
           enter a du sifrati
           35
           ahadot is 5
           asarot is 3
           asarot + ahadot = 8
           Press any key to continue . . .

          */

        //ex3();

        /*  
           enter tlat sifrati
           103
           3
           0
           1
           0
           Press any key to continue . . ..

          */
        //ex4();

        /*  
           write du sifrati
           23
           32
           Press any key to continue . . .

          */
        //ex5();

        /*  
          enter number of stundets
          80
          how many buses 2
          Press any key to continue . . .

          */


        //ex6();

        /*      
          enter how many days
          23
          weeks 3
          days 2
          Press any key to continue . . ..

          */
        //ex7();

        /*  
           enter how much money
           30000
           how many amood cost
           200
           mispar amoodim 150
           money left 0
           Press any key to continue . . .

          */
        //ex8();

        /*  
           enter number
           40
           not tnay
           Press any key to continue . . .

          */





        //}





        public static void ex1()
        {
            int num;//מספר אנשים בתחנה
            Console.WriteLine("enter how many people");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("the number of peoples who stay in the line after the taxies filled is {0}", num % 6);
            Console.WriteLine("the number of taxies that get out tho their way is {0}", num / 6);
        }
        public static void ex2()
        {
            int num;//מספר דו ספרתי
            Console.WriteLine("enter a du sifrati");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("ahadot is {0}", num % 10);
            Console.WriteLine("asarot is {0}", num / 10);
            Console.WriteLine("asarot + ahadot = {0}", (num / 10) + (num % 10));
        }
        public static void ex3()
        {
            int num;//מספר תלת ספרתי
            int units, tens, hundreds;//אחדות,עשרות ומאות
            Console.WriteLine("enter tlat sifrati");
            num = int.Parse(Console.ReadLine());
            units = num % 10;
            tens = num / 10 % 10;
            hundreds = num / 100;
            Console.WriteLine(units);
            Console.WriteLine(tens);
            Console.WriteLine(hundreds);
            Console.WriteLine(hundreds * tens * units);
        }
        public static void ex4()
        {
            int num;//מספר דו ספרתי
            int units, tens;//אחדות ומאות
            Console.WriteLine("write du sifrati");
            num = int.Parse(Console.ReadLine());
            units = num % 10;
            tens = num / 10;
            Console.WriteLine("{0}{1}", units, tens);
        }
        public static void ex5()
        {
            int num;//מספר סטודנטים
            Console.WriteLine("enter number of stundets");
            num = int.Parse(Console.ReadLine());


            if (num % 46 != 0)
            {
                Console.WriteLine("how many buses {0}", (num / 46) + 1);
            }
            else
            {
                Console.WriteLine("how many buses {0}", (num / 46));
            }

        }
        public static void ex6()
        {
            int num;//מספר ימים
            Console.WriteLine("enter how many days");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("weeks {0}", num / 7);
            Console.WriteLine("days {0}", num % 7);
        }
        public static void ex7()
        {
            int num, num2;//כסף ומחיר עמוד
            Console.WriteLine("enter how much money");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("how many amood cost");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("mispar amoodim {0} ", num / num2);
            Console.WriteLine("money left {0} ", num % num2);
        }
        public static void ex8()
        {
            int num;//מספר שלם
            int units, tens, hundreds;//אחדות, עשרות ומאות
            Console.WriteLine("enter number");
            num = int.Parse(Console.ReadLine());
            units = num % 10;
            tens = num / 10 % 10;
            hundreds = num / 100;
            if (num / 100 != 0 && (hundreds + units) / 2 == tens && Math.Pow(units, 2) == Math.Sqrt(hundreds))

            {
                Console.WriteLine("tnay x");
            }
            else
            {
                Console.WriteLine("not tnay");
            }














        }
    }
}
