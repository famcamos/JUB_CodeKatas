using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Classroom
    {
        [Column(TypeName ="ClassroomNumber")]
        [Key]
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        [Required]
        public int Seats { get; set; }
        public IList<Student>  Students { get; set; }

        public Classroom()
        {
            Students = new List<Student>();
        }
    }
}
