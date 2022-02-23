using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.models{
    [Table("Students")]
    public class student{
        [StringLength(50)]
        [Key]
        public string StudentID { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        [Required]
        public string StudentName { get; set; }
    }
}