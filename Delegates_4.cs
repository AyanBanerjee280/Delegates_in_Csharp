using System;
namespace DelegatesinCSharp
{
    class Del3
    {
        public delegate void addnum(int num1);
        
        public void table(int num1)
        {
            for (int i = 1; i <= 200; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",num1, i, num1*i);
            }
        }
        

   
        public static void Main(string[] args)
        {
            Del3 obj = new Del3();
            addnum del_obj1 = new addnum(obj.table);
            del_obj1(9);
            Console.ReadLine();
        }
    }
}
