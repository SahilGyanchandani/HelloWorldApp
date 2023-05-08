using System.Diagnostics.CodeAnalysis;

namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program pg= new Program();
            pg.Sum(10, 20);
            //Console.WriteLine("Enter The First Value:");
            //string val1=Console.ReadLine();
            //Console.WriteLine("Enter the Second Value:");
            //string val2=Console.ReadLine();

            //int no1 = Convert.ToInt32(val1);
            //int no2=Convert.ToInt32(val2);

            //int result=pg.Sum(no1,no2);
            //Console.WriteLine(result); 

            
        }
        public int Sum(int no1,int no2)
        {
            int add = 0;
            add = no1 + no2;
            Console.WriteLine(add);
            return add;

        }
    }
}