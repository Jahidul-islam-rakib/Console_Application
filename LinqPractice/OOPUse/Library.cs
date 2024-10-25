using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.OOPUse
{
	public class Library
	{
		public List<Person> TPerson = new List<Person>();
		public List<Person> SPerson = new List<Person>();
		public List<Person> LPerson = new List<Person>();


		public void AddTPerson(Person ple)
		{
			TPerson.Add(ple);
			//Console.WriteLine($"Teacher person has been added : {ple.Name}");
		}

		public void AddSPerson(Person ple)
		{
			SPerson.Add(ple);
			//Console.WriteLine($"Teacher person has been added : {ple.Name}");
		}

		public void AddLPerson(Person ple)
		{
			LPerson.Add(ple);
			//Console.WriteLine($"Teacher person has been added : {ple.Name}");
		}

		public void printOfTeacher()
		{
			Console.WriteLine("Persons are:");
			foreach (Person person in TPerson)
			{
				Console.WriteLine($"person : {person.Name}");
			}

			Console.WriteLine("----------------------***------------------");
		}

		public void printOfStudent()
		{
			Console.WriteLine("Students are:");
			foreach (Person person in SPerson)
			{
				Console.WriteLine($"Student : {person.Name}");
			}

			Console.WriteLine("----------------------***------------------");
		}

		public void printOfLibrarian()
		{
			Console.WriteLine("Librarian are:");
			foreach (Person person in LPerson)
			{
				Console.WriteLine($"Librarian : {person.Name}");
			}

			Console.WriteLine("----------------------***------------------");
		}

	}
}
