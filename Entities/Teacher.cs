using System;
using System.Collections.Generic;
using System.Text;

namespace practiceEFDapper.Entities
{
    internal class Teacher
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
        public List<Subject> Subjects { get; set; }
        public override string ToString()
        {
            return $"{Id} {FullName} {Salary} {Subjects.Count}";
        }
    }
}
