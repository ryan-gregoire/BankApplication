using System;


namespace App
{

    public class App
    {

        private static double Subtract(double a, double b)
        {
            double sub = Convert.ToDouble(a - b); 
            return sub;

        }

        private static double Add(double a, double b)
        {
            double Add = Convert.ToDouble(a + b);
            return Add;

        }

        static void Main(string[] _)
        {
            Console.WriteLine("Enter Choice? ");
            var choice = Console.ReadLine();
            switch(choice)
            {

                case "/Sub":


                    Console.WriteLine("Enter Number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double b = Math.Truncate(Subtract(num1, num2));

                    Console.WriteLine($"You Will Have: ${-Math.Abs(b)} Left in Your Bank");

                    break;
                case "/Add":
                    Console.WriteLine("Enter Number 1: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num4 = Convert.ToDouble(Console.ReadLine());

                    double b1 = Math.Truncate(Add(num3, num4));

                    Console.WriteLine($"You Will Have: ${Math.Abs(b1)} Left in Your Bank");
                    break;

            }

            Console.ReadLine();
           
        }
    }
}
