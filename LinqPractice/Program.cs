
using LinqPractice;
using LinqPractice.OOPUse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
				new Student(12, "hanjal", 44),
				new Student(3, "rashed", 22),
				new Student(13, "hanjal", 12),
				new Student(5, "rajib", 22),
				new Student(33, "anoar", 20),
				new Student(14, "rajib", 2)

			};

			List<Student> students2 = new List<Student>
			{
				new Student(2, "kabil", 2),
				new Student(11, "kajim", 43),
				new Student(12, "kased", 12),
				new Student(52, "rashed", 4),
				new Student(13, "yamin", 2),
				new Student(52, "rajib", 43),
				new Student(33, "hanjal", 15),
				new Student(14, "kased", 2)

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
			//var EvenId = students.Where(stud => stud.Name == "hanjal");


			//foreach (Student student in EvenId)
			//{

			//	Console.WriteLine($"name = {student.Name}, id = {student.Id}");
			//}


			// ==================== > select operator
			//var SelectedProperty = students.Select(s => s.Name).ToList();
			//var SelectMultipleProperty = students.Select(s => new { s.Name, s.Age }).ToList();

			//foreach (var obj in SelectedProperty)
			//{
			//	Console.WriteLine($"name = {obj}"); // single property
			//}
			//foreach (var obj in SelectMultipleProperty)
			//{
			//	Console.WriteLine($"name = {obj.Name }, age= {obj.Age}"); // multiple property
			//}

			//=======================OfType operator 

			//var stringtype = students.select(s => s.name).oftype<string>().tolist();

			//foreach(var st in stringtype)
			//{
			//             console.writeline(st); // see all string variable in name property of students
			//         }

			// ======================== distinct() method
			//var Individualobj = students.Select(s => s.Name).Distinct().ToList();
			//foreach (var singleobj in Individualobj)
			//{
			//	Console.WriteLine($"name = {singleobj}"); // if any double named value in name column , it will be singled that means remove that item.
			//}






			//======================== Except() method
			var nonCommon = students.Select(x => x.Name).Except(students2.Select(sName => sName.Name)).ToList() ;
			foreach (var st in nonCommon)
			{
				Console.WriteLine($"name = {st}"); //Returns the difference between two collections.
			}











			Console.WriteLine("hi there");
			Console.ReadLine(); // KEEPS THE CONSOLE OPEN UNTIL YOU PRESS ANY KEY
			//Console.ReadLine(); // Keeps the console open until you press Enter
		}
	}
}
