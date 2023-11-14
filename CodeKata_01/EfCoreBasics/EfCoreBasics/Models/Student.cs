using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Classyear { get; set; }

        public DateTime Birthdate { get; set; }

        public Classroom Classroom { get; set; }
    }
}
