using System;

namespace POP___class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
        }
        static void Task1()
            
        {
            Console.WriteLine("How old are you ?");
            int age = Convert.ToInt32(Console.ReadLine());
            age = age + 10;
            Console.WriteLine($"In 10 years you will be {age}"); 

        }
        static void Task2()
        {
            Console.WriteLine("RECTANGLE\n____________");
            
            Console.WriteLine("What's the size of face a ?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the size of face b ?");
            int b = Convert.ToInt32(Console.ReadLine());
            int area = a * b;
            int perimeter = 2 * a + 2 * b;
            Console.WriteLine($"The area of this rectangle is {area} and the perimeter is {perimeter}");

            Console.WriteLine("TRIANGLE\n__________");
            Console.WriteLine("What's the base of your triangle ? ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the height ?");
            int hauteur = Convert.ToInt32(Console.ReadLine());
            int areaT = (bas * hauteur) / 2;
            Console.WriteLine("What's the size of side a ? ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the size of side b ? ");
            int d = Convert.ToInt32(Console.ReadLine());
            int perimeterT = bas + c + d;
            Console.WriteLine($"The area of this triangle is {areaT} and the perimeter is {perimeterT}");

            Console.WriteLine("CIRCLE\n__________");
            Console.WriteLine("What's the radius of your circle ? ");
            int r = Convert.ToInt32(Console.ReadLine());
            double areaC =  Math.PI * (r * r);
            double perimeterC = 2 * Math.PI;
            Console.WriteLine($"The area of this cercle is {areaC} and the perimeter is {perimeterC}");


        }
        static void Task3()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine($" Today date and time is {date}");
            Console.WriteLine($"In ten years it will be {date.AddYears(10)}");
            Console.WriteLine("Tell me a number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"In {X} years it will be {date.AddYears(X)}");
            
        }
    }
}
