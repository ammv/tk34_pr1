using System;

namespace pr2
{
	class Person
	{
		public int age;
		public string name;

		public Person(){name = "Anonim"; age=10;}

		public Person(string n){name = n; age=30;}

		public Person(int a){name = "Anonim"; age = a;}

		public Person(string n, int a){name = n; age = a;}
		
		public void GetInfo()
		{
			Console.WriteLine($"Name: {name}, Age: {age}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person man = new Person("Artem", 20);
			man.GetInfo();
		}
	}
}
