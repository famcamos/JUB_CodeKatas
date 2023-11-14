using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName ="nvarchar(max)")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName ="varchar(15)")]
        [MaxLength(15)]
        [Required]
        public string Classyear { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public Classroom Classroom { get; set; }

        public string? Country { get; set; }

        public string? City { get; set; }

        public string? Street { get; set; }

        public int? HouseNumber { get; set; }
    }
}
