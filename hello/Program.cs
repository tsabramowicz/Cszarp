using System;

namespace hello
{
	class Program
	{
		static void Main(string[] args)
		{
			ValueTypes();


			for (;;)
			{
				Greeting();
				Age();
				Settings();
			}
		}

		private static void ValueTypes()
		{
			int maxInt = int.MaxValue;
			int minInt = int.MinValue;
			long maxLong = long.MaxValue;
			long minLong = long.MinValue;

			Console.WriteLine(maxInt);
			Console.WriteLine(minInt);
			Console.WriteLine(maxLong);
			Console.WriteLine(minLong);
		}

		private static void Settings()
		{
			Console.ReadKey();
			Console.Clear();
			Console.ResetColor();
		}

		private static void Age()
		{
			Console.WriteLine("Ile masz lat?");
			int age;
			bool result = int.TryParse(Console.ReadLine(), out age);
			{
				Console.WriteLine();
			}
			if (age >= 18)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Możesz już wypić browara");
			}
			else if (result == false)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Podaj liczby z zakresu 1 w gore");

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Nie możesz jeszcze wypić browara");
			}
		}
		/// <summary>
		/// Powitanie usera
		/// </summary>summary>
		private static void Greeting()
		{
			Console.WriteLine("Wpisz imię");
			string name = Console.ReadLine();
			Console.WriteLine("Witaj " + name);
		}
	}
}
