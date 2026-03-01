using System;
using System.Collections.Generic;
using System.Text;

namespace practiceEFDapper.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; } = null;
        public override string ToString()
        {
            return $"{Id}. {FirstName} {LastName} {Email} {BirthDate:d} -- {Group.Name}";
        }
    }
}
