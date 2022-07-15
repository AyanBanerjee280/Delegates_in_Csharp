using System;
namespace CsharpDelegates
{//encapsulating methods with delegates and calling methods in an indirect way.
    public delegate void Rect_Del(double length, double breadth);
    class Delegates_2
    {
        public static void area(double length,double breadth)
        {
            double result = length*breadth;
            Console.WriteLine("length = {0}; breadth = {1}", length,breadth);
            Console.WriteLine("Area = {0}", result);
        }
        public static void perimeter(double length, double breadth)
        {
            double result = (length + breadth)*2;
            Console.WriteLine("Perimeter = {0}", result);
        }
        public static void Diagonal(double length, double breadth)
        {
            double result = Math.Sqrt(length*length + breadth*breadth);
            Console.WriteLine("Length of Diagonal = {0}", result);
        }
        public static void quotient(double a, double b)
        {
            double result = a / b;
            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("Quotient = {0}", result);
        }
        static void Main(string[] args)
        {
            Rect_Del obj = new Rect_Del(Delegates_2.area);
            Console.WriteLine("**********Measurements of a Rectangle**********");
            Console.WriteLine(" ");
            obj.Invoke(75, 63);
            obj = perimeter;
            obj(75, 63);
            obj = Diagonal;
            obj(75, 63);
            Console.ReadLine();

        }
    }
}

