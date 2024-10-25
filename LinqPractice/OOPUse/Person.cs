using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.OOPUse
{
	public abstract class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Age { get; set; }

        public Person(int PId, string PName, double PAge)
        {
            Id =PId;
			Name = PName;
			Age = PAge;
        }
    }
}
