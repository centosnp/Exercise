using System;

namespace Exercise
{
	public struct Person{
		public string fName;
		public int Age;
		public int wtg;

	} 

    class Program
    {
        static void Main(string[] args)
        {
        	ConstOverLoad con1 = new ConstOverLoad("Santosh", 23);
        	ConstOverLoad con2 = new ConstOverLoad("Santosh");
        	Console.WriteLine(con1.Show());
        	Console.WriteLine(con2.Show());
        	// For struct
        	Person p1;
        	Console.WriteLine("Enter the First Name");
        	p1.fName = Console.ReadLine();
        	Console.WriteLine("Enter the Age");
        	p1.Age = Convert.ToInt32(Console.ReadLine());
        	Console.WriteLine("Enter the Weight");
        	p1.wtg = Convert.ToInt32(Console.ReadLine());
        	Console.WriteLine($"First Name is : {p1.fName}, Age is {p1.Age} and Weigh is : {p1.wtg}");
        }
    }
}
