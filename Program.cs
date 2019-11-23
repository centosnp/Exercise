using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
        	ConstOverLoad con1 = new ConstOverLoad("Santosh", 23);
        	ConstOverLoad con2 = new ConstOverLoad("Santosh");
        	Console.WriteLine(con1.Show());
        	Console.WriteLine(con2.Show());
        }
    }
}
