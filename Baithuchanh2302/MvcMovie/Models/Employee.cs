using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.models{
    [Table("Employees")]
    public class Employee{
        [StringLength(50)]
        [Key]
        public string EmployeeID { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        [Required]
        public string EmployeeName { get; set; }
        public string Address { get; set; } 
    }
}