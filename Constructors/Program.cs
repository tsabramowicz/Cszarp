using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			Person person2 = new Person(1, "Tomek");
			Person person3 = new Person(2, "Tomek", "Sabram");
			Person person4 = new Person(3, "Tomek", "Mężczyzna", "Sabramowicz", "Katowice", 18);
			Person person5 = new Person(4, "Łukasz");
			Person person6 = new Person(5, "Marcin", "Mężczyzna", "Sabramowicz", "Chorzów", 35);

		}
	}
}
