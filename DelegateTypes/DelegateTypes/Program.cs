namespace TypesDelegates
{
    public class Program
    {
        //1. multiple delegates which means we can create multiple delegates with different parameters 

        public delegate void CalculateFirst(int a,int b);
        public delegate void CalculateSecond(int a);
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is {0}", result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is {0}", result);
        }
        public static void Square(int a)
        {
            int result = a * a;
            Console.WriteLine("square is {0}", result);
        }
        public static void Cube(int a)
        {
            int result = a * a * a;
            Console.WriteLine("Cube is {0}", result);
        }

        //2 . Single cast deletegate means only one delegate ,one method, one obj calling

        public delegate void ShowDelegate();
        public static void showMesg()
        {
            Console.WriteLine("Single cast deletegate means only one delegate ,one method, one obj calling");
        }

        //3. MultiCast Delegate is wrapped with more than one method that , which means they can point to more than one 
        //function at a time. And they are derived  from System.MulticastDelegate class. we can use += and -= to implement multicast delegate

        public delegate void MulticastDelegate(int a, int b, int c);
        public static void Add(int a, int b, int c)
        {
            int result = a + a + a;
            Console.WriteLine("add is {0}", result);
        }
        public static void Sub(int a, int b, int c)
        {
            int result = a - a - a;
            Console.WriteLine("sub is {0}", result);
        }
        public static void Multi(int a, int b, int c)
        { 
            int result = a * a * a;
            Console.WriteLine("multi is {0}", result);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("\n\n Multiple Delegate");
            //1 . multiple delegate calling 
            CalculateFirst obj1 = new CalculateFirst(Program.Addition);
            obj1(10,10);

            //we can call by creating new obj and can call using same previous obj as well
            CalculateFirst obj2 = new CalculateFirst(Program.Subtraction);
            obj2(10,10);

            //like this
            obj1 = Subtraction;
            obj1(10,10);

            
            CalculateSecond obj3 = new CalculateSecond(Program.Square);
            obj3(10);
            
            obj3 = Cube;
            obj3(10);

            Console.WriteLine("\n\n Single Cast Delegate");
            //2. Single Cast Delegate calling
            ShowDelegate showobj = new ShowDelegate(showMesg);
            showobj();

            // 3. MultiCast Deelgate Calling
            Console.WriteLine("\n\nMulticast Delegate");
            MulticastDelegate obj = new MulticastDelegate(Add);
            obj += Sub;
            obj += Multi;
            obj(2, 2, 2);


            
        }
    }
}