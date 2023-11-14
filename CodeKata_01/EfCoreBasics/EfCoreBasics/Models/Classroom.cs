using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public IList<Student>  Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
        }
    }
}
