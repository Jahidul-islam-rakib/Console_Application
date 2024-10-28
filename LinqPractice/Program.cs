
using LinqPractice;
using LinqPractice.OOPUse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarayManagement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library();

			List<Student> students = new List<Student>
			{
				new Student(2, "hanjal", 44),
				new Student(1, "Habib", 20),
				new Student(12, "hanjal", 33),
				new Student(3, "rashed", 22),
				new Student(13, "hanjal", 12),
				new Student(5, "rajjib", 22),
				new Student(33, "hanjal", 20),
				new Student(14, "ujan", 2)

			};

			// Display the students
			//foreach (Student student in students)
			//{
			//	Console.WriteLine($"Id: {student.Id}, Student Name: {student.Name}, Age: {student.Age}");
			//}


			Librarian admin1 = new Librarian(1, "aminul", 22);
			Librarian admin2 = new Librarian(2, "Jahid", 12);
			Librarian admin3 = new Librarian(3, "aminul", 44);
			Librarian admin4 = new Librarian(4, "aminul", 27);
			Librarian admin5 = new Librarian(5, "onu", 87);
			Librarian admin6 = new Librarian(6, "rakhi", 29);
			Librarian admin7 = new Librarian(7, "galib", 10);

			library.AddLPerson(admin1);
			library.AddLPerson(admin2);
			library.AddLPerson(admin3);
			library.AddLPerson(admin4);
			library.AddLPerson(admin5);
			library.AddLPerson(admin6);
			library.AddLPerson(admin7);




			List<Book> books = new List<Book>
			{
				new Book(1, "bachi na" , "Hablu", 2322),
				new Book(2, "oi j tal gas", "Babul",  453),
				new Book(3, "jabira kagara", "Kabila", 2345),
				new Book(4, "aj kew nai", "hasina",  324),
				new Book(5,"cholo na ghure asi india te", "hasina",  745),
				new Book(6, "ei bar koi jaba", "hasina", 1234),
				new Book(8, "palabo na", "kader kawa", 145)

			};

			books.Add(new Book(7, "kal nagini", "hasina",122));

			// Display the books
			//foreach (var book in books)
			//{
			//	Console.WriteLine($"Id: {book.BId}, Book Name: {book.BTitle}, Author: {book.Auther}");
			//}


			// ------------------ student more than 20 years
			//var AgeMoreThan20 = students.Where(student => student.Age > 20);

			//Console.WriteLine($"no of student whose age is greater than 20 ={AgeMoreThan20.Count()}");
			//foreach(Student stu in AgeMoreThan20)
			//{
			//             Console.WriteLine($"name = {stu.Name}, Age = {stu.Age}");
			//         }

			//var EvenId = students.Where(stud => stud.Id % 2 == 0);

			//  foreach(Student student in EvenId)
			//{
			//             Console.WriteLine($"name = {student.Name}, id = {student.Id}");
			//         }


			//-------------------- name diye check ----------------------
			var EvenId = students.Where(stud => stud.Name =="hanjal" );


			foreach (Student student in EvenId)
			{

				Console.WriteLine($"name = {student.Name}, id = {student.Id}");
			}









			Console.WriteLine("hi there");
		}
	}
}
