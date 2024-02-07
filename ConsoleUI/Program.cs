using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What is your first name: ");
			string firstname = Console.ReadLine();

			Console.Write("How old are you: ");
			string agetext = Console.ReadLine();

			bool isagevalid = int.TryParse(agetext, out int age);

			if ( firstname.ToLower() == "bob" || firstname.ToLower() == "sue" )
			{
				Console.WriteLine($"Hello Professor {firstname}");
			}
			else
			{
				Console.WriteLine($"Hello {firstname}");
			}

			if ( isagevalid )
			{
				if ( age < 21 )
				{
					int yearstowait = 21 - age;
					Console.WriteLine($"I recommend you wait {yearstowait} years before starting this class");
				}
			}
			else
			{
				Console.WriteLine("You must enter your age in digits");
			}

			_ = Console.ReadLine();
		}
	}
}
