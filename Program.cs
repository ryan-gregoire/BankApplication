using System;


namespace App
{

    public class App
    {

        private static double Sub(double a, double b)
        {
            double Sub = Convert.ToDouble(a - b);
            return Sub;

        }

        private static double Add(double a, double b)
        {
            double Add = Convert.ToDouble(a + b);
            return Add;

        }

        private static double Mul(double a, double b)
        {
            double Mul = Convert.ToDouble(a * b);
            return Mul;

        }

        private static double Div(double a, double b)
        {
            double Div = Convert.ToDouble(a / b);
            return Div;

        }


        public static void AddTitle()
        {
            Console.WriteLine("Bank Add Section");
            Console.WriteLine("\n");

        }


        public static void SubTitle()
        {
            Console.WriteLine("Bank Sub Section");
            Console.WriteLine("\n");

        }

        public static void MulTitle()
        {
            Console.WriteLine("Bank Mul Section");
            Console.WriteLine("\n");

        }


        public static void DivTitle()
        {
            Console.WriteLine("Bank Div Section");
            Console.WriteLine("\n");

        }



        static void Main(string[] _)
        {
            App p = new App();
            Console.WriteLine("Enter Choice? ");
            var choice = Console.ReadLine();
            switch(choice)
            {

                case "/Sub":
                    Console.WriteLine("\n");

                    App.SubTitle();

                    Console.WriteLine("Enter Number 1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double b = Math.Truncate(Sub(num1, num2));

                    Console.WriteLine($"You Will Have: ${-Math.Abs(b)} Left in Your Bank");

                    break;
                case "/Add":
                    Console.WriteLine("\n");
                    App.AddTitle();

                    Console.WriteLine("Enter Number 1: ");
                    double num3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num4 = Convert.ToDouble(Console.ReadLine());

                    double b1 = Math.Truncate(Add(num3, num4));

                    Console.WriteLine($"You Will Have: ${Math.Abs(b1)} Left in Your Bank");
                    break;

                case "/Mul":

                    Console.WriteLine("\n");
                    App.MulTitle();
                    Console.WriteLine("Enter Number 1: ");
                    double num5 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num6 = Convert.ToDouble(Console.ReadLine());

                    double b2 = Math.Truncate(Mul(num5, num6));

                    Console.WriteLine($"You Will Have: ${Math.Abs(b2)} Left in Your Bank");
                    break;

                case "/Div":
                    Console.WriteLine("\n");
                    App.DivTitle();


                    Console.WriteLine("Enter Number 1: ");
                    double num7 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Number 2: ");
                    double num8 = Convert.ToDouble(Console.ReadLine());

                    double b3 = Math.Truncate(Div(num7, num8));

                    Console.WriteLine($"You Will Have: ${Math.Abs(b3)} Left in Your Bank");
                    break;
            }

            Console.ReadLine();
           
        }
    }
}
