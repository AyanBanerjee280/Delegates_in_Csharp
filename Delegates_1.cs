using System;
namespace CsharpDelegates
{//A delegate is a type that represents references to methods with a particular
 //parameter list and return type. When you instantiate a delegate, you can associate its
 //instance with any method with a compatible signature and return type. You can invoke (or call)
 //the method through the delegate instance.
    public delegate void Calculation(int a, int b);
    class Delegates_1
    {
        public static void sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum = {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Delegates_1.sum);
            obj.Invoke(45,62); //Invoke is a keyword to call methods via delegates
            Console.ReadLine();
        }
    }
}
//Delegates are similar to C++ function pointers, but delegates are fully object-oriented, and
//unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.
