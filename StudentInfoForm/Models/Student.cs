using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StudentInfoForm.Models
{
    public class Student
    {
       

       
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        
        public string Department { get;  set; }
       
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        
        public float Height { get; set; }

        public float Weight { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int Age { get; set; }

    }
}
