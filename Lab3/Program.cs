using System;

namespace Lab3
{

    public class TCircle
    {
        private double radius, square, length;

        public TCircle()
        {
            radius = 0;
            square = 0;
            length = 0;
        }

        public TCircle(double radius, double square, double length)
        {
            this.radius = radius;
            this.square = square;
            this.length = length;
        }

        public TCircle(TCircle newCircle)
        {
            Console.WriteLine("Duplicated circle:");
            this.radius = newCircle.radius;
            this.square = newCircle.square;
            this.length = newCircle.length;
        }
        public void SetData()
        {
            Console.Write("Enter the radius:");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public void OutputData()
        {
            Console.WriteLine("The radius = " + radius);
            Console.WriteLine("The square = " + square);
            Console.WriteLine("The length = " + length);
        }
        public double Square()
        {
            square = Math.Pow(radius, 2) * Math.PI;
            return square;
        }

        public double LenghtOfCircle()
        {
            length = 2 * radius * Math.PI;
            return length;
        }

        public void ComparisonOfCircles(TCircle circle2)
        {
            Console.WriteLine("The radius:");
            if (radius > circle2.radius)
            {
                Console.WriteLine("first circle > second circle" );
            }
            else
            {
                Console.WriteLine("first circle < second circle");
            }
            Console.WriteLine("The square:");
            if (square > circle2.square)
            {
                Console.WriteLine("first circle > second circle");
            }
            else
            {
                Console.WriteLine("first circle < second circle");
            }
            Console.WriteLine("The length:");
            if (length > circle2.length)
            {
                Console.WriteLine("first circle > second circle");
            }
            else
            {
                Console.WriteLine("first circle < second circle");
            }
        }

        public static TCircle operator +(TCircle temp, double radius) => new TCircle(temp.radius + radius, temp.square, temp.length);

        public static TCircle operator -(TCircle temp, double radius) => new TCircle(temp.radius - radius, temp.square, temp.length);

        public static TCircle operator *(TCircle temp, double num) => new TCircle(temp.radius * num, temp.square, temp.length);
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Constructor without parameters:");
            Console.WriteLine("First circle:");
            TCircle firstCircle = new TCircle();
            firstCircle.SetData();
            firstCircle.Square();
            firstCircle.LenghtOfCircle();
            Console.WriteLine(" ");
            Console.WriteLine("Info:");
            firstCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Second circle:");
            TCircle secondCircle = new TCircle();
            secondCircle.SetData();
            secondCircle.Square();
            secondCircle.LenghtOfCircle();
            Console.WriteLine(" ");
            Console.WriteLine("Info:");
            secondCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Comparison of circles:");
            firstCircle.ComparisonOfCircles(secondCircle);

            //
            Console.WriteLine(" ");
            Console.WriteLine("Constructor with parameters:");
            TCircle tempCircle = new TCircle(6, 113, 37.7);
            tempCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Copy constructor:");
            TCircle copyTempCircle = new TCircle(tempCircle);
            copyTempCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Adding of radiuses:");
            TCircle thirdCircle = tempCircle + 10.0;
            thirdCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Subtraction of radiuses:");
            TCircle fourthCircle = tempCircle - 3.0;
            fourthCircle.OutputData();

            //
            Console.WriteLine(" ");
            Console.WriteLine("Multiplying the radius by a number:");
            TCircle fifthCircle = tempCircle * 7;
            fifthCircle.OutputData();
        }
    }
}