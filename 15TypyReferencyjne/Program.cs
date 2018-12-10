using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15TypyReferencyjne
{
	class Program
	{
		static void GiveName(Diary diary)
		{
			diary.Name = "Dzienniczek Marcina";
		}


		
		static void Main(string[] args)
		{
			
			Diary dziennik1 = new Diary();
			Diary dziennik2 = dziennik1;
			Diary dziennik3 = new Diary();
			dziennik3.Name = "Dziennik Zosi";

			GiveName(dziennik1);

			Console.WriteLine(dziennik2.Name);
			

	

			int liczba1 = 5;
			int liczba2 = liczba1;
			liczba1 = liczba2 + 2;
			Console.WriteLine(liczba1);
			Console.WriteLine(liczba2);
			Console.WriteLine(liczba1);

			Console.ReadKey();




		}
	}
}
