using System;
using System.Collections.Generic;
using System.Text;

namespace practiceEFDapper.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
