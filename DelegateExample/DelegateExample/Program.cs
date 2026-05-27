using System.Numerics;

namespace DelegateEx
{
    public class Program
    {
        public delegate void CalAdd(int a, int b);

        public static void Addition(int a, int b)
        {
            int resul = a + b;
            Console.WriteLine("Addition of {0} and {1} is {2}", a,b,resul);
        }
        public static void Substraction(int a, int b)
        {
            int resul = a - b;
            Console.WriteLine("Subtraction is {0}", resul);
        }
        public static void Multiplication(int a, int b)
        {
            int resul = a * b;
            Console.WriteLine("Multiplication is {0}", resul);
        }
        public static void Main(string[] args)
        {
            //Program obj = new Program();
            //obj.Addition(2, 3);

            CalAdd delobj = new CalAdd(Program.Addition);
            delobj.Invoke(10, 10);

            delobj = Substraction;
            delobj.Invoke(10, 10);

            delobj = Multiplication;
            delobj.Invoke(10, 10);

        }
    }
   
}