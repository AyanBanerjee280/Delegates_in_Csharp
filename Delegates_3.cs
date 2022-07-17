using System;
namespace DelegatesinCSharp
{
    class Del3
    {
        public delegate void addnum(int num1, int num2);
        public delegate void subnum(int num1, int num2);
        public delegate void mulnum(int num1, int num2);
        public delegate void remnum(int num1, int num2);
        public delegate void divnum(int num1, int num2);
        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void product(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void remainder(int a, int b)
        {
            Console.WriteLine(a % b);
        }
        public void quotient(int a, int b)
        {
            Console.WriteLine(a / b);
        }

   
        public static void Main(string[] args)
        {
            Del3 obj = new Del3();
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.sub);
            mulnum del_obj3 = new mulnum(obj.product);
            remnum del_obj4 = new remnum(obj.remainder);
            divnum del_obj5 = new divnum(obj.quotient);
            del_obj1(100, 4);
            del_obj2(100, 4);
            del_obj3(100, 4);
            del_obj4(100, 4);
            del_obj5(100, 4);
            Console.ReadLine();
        }
    }
}
