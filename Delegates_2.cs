using System;
namespace CsharpDelegates
{//encapsulating methods with delegates and calling methods in an indirect way.
    public delegate void Calculation(int a, int b);
    class Delegates_1
    {
        public static void sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("Sum = {0}", result);
        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("Substraction = {0}", result);
        }
        public static void product(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("a = {0}; b = {1}", a,b);
            Console.WriteLine("Product = {0}", result);
        }
        public static void quotient(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("a = {0}; b = {1}", a, b);
            Console.WriteLine("Quotient = {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Delegates_1.sum);
            obj.Invoke(45,62); //Invoke is a keyword to call methods via delegates
            obj = substraction;
            obj(51, 7);
            obj = product;
            obj(7, 9);
            obj = quotient;
            obj(80, 10);
            Console.ReadLine();
        }
    }
}

