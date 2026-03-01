using System;
using System.Collections.Generic;
using System.Text;

namespace practiceEFDapper.Entities
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Teacher> Teacers { get; set; }
        public override string ToString()
        {
            return $"{Id}. {Name} {Description}"; 
        }
    }
}
