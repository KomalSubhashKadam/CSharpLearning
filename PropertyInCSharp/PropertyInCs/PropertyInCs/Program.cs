namespace Property
{
    public class Student
    {
        private int _stdid;
        private string _name;
        private int _age;
        private int _fees;

        public int stdid
        {
            //set accessor used to set the data or value into a field _stdid we can only set the data, we cannot get the data.
            set
            {
                this._stdid = value;
            }

            get
            {
                //get accessor used to get the data or value from the data field _stdid we can only get the data, we cannot set the data.
                return this._stdid;
            }
        }

        public string sname
        {
            get { return this._name; }
            set { this._name = value; }

        }

        public int age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        

       
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.stdid = 1;
            Console.WriteLine("id is "+s.stdid);
            s.sname = "komal";
            Console.WriteLine($"name is {s.sname}");
            s.age = 10;
            Console.WriteLine($"age is  {s.age}");
            
        }
    }
}