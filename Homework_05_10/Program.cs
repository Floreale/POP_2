using System;

namespace Homework_05_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //name();
            //Sum();
            //operation();
            //multiplication();
            //MultiplicationTable(); 
            //average(); 
            //encadrement();
            //birthdate();
            xyz(); 
            Console.ReadKey();
        }
        static void name()
        {
            Console.WriteLine("Hello\nMy name is Floréale Barraud.");
        }
        static void Sum()
        {
            Console.WriteLine("Tell me one number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me another number.");
            int b = Convert.ToInt32(Console.ReadLine());
            int Sum = a + b;
            Console.WriteLine($"The sum of these number is {Sum}"); 
        }
        static void operation()
        {
            int ope1 = -1 + 4 * 6;
            int ope2 = (35 + 5) % 7;
            int ope3 = 14 + -4 * 6 / 11;
            int ope4 = 2 + 15 / 6 * 1_7 % 2;
            Console.WriteLine($"The résult of the first operation is {ope1}\nThe result of the second operation is {ope2}\nThe result of the third operation is {ope3}\nThe result of the fourth operation is {ope4}");

        }
        static void multiplication()
        {
            Console.WriteLine("Tell me one number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me another number.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a final number.");
            int c = Convert.ToInt32(Console.ReadLine());

            int multiplication = a * b * c;
            Console.WriteLine($"The result of the multiplication of these 3 numbers is {multiplication}");

        }
        static void MultiplicationTable()
        {
            Console.WriteLine("Tell me a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10 ; i++)
            {
                int result = n * i;
                Console.WriteLine($"{n}*{i}={result}");
            }
        }
        static void average()
        {
            Console.WriteLine("Tell me a number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a number.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a number.");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a number.");
            int d = Convert.ToInt32(Console.ReadLine());

            int result = (a + b + c + d) / 4;
            Console.WriteLine($"The average of those 4 numbers is {result} ");
        }
        static void encadrement()
        {
            Console.WriteLine("Tell me a number.");
            double n = Convert.ToInt32(Console.ReadLine());
            if  (n > 100 && n <200 )
            {
                Console.WriteLine($"{n} is range between 100 and 200.");
            }
            else
            {
                Console.WriteLine($"{n} is not range between 100 and 200.");
            }
        }
        static void date()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine($"La date est {date}");
        }
        
        static void birthdate()
        {
            Console.WriteLine("How old are you ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime();
            date = DateTime.Now; 
            int year = date.Year;
            int birthdate = year - age;
            Console.WriteLine($"Your birthdate is {birthdate}");
            
        }

        static void xyz()
        {
            Console.WriteLine("Tell me a number input as a x.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a number input as an y.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tell me a numbet input as a z");
            int z = Convert.ToInt32(Console.ReadLine());
            int ope1 = (x + y) * z;
            int ope2 = x * y + y * z;
            Console.WriteLine($"({x}+{y})*{z}={ope1} et {x}*{y}+{y}*{z}={ope2}");
        }
    }
}

