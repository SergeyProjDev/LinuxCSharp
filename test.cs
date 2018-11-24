using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
		Console.Write("Your name: ");
		string name = Console.ReadLine();

		Console.Write("Your surname: ");
		string sname = Console.ReadLine();

		Console.WriteLine("You are " + name + " " + sname);
        }

    }
}


