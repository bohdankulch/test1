using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeTest.Models
{
    public class ContactManager
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Married { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
