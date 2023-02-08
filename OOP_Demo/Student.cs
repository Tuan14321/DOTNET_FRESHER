using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    internal class Student
    {
        public int Id { get; set; }

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Student(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public Student()
		{
		}

		public override string? ToString()
		{
			return $"Id: {Id}, Name: {Name}";
		}
	}
}
