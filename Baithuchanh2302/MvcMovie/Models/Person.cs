using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.models{
    [Table("Persons")]
    public class Person{
        [StringLength(50)]
        [Key]
        public string PersonID { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        [Required]
        public string PersonName { get; set; }
        public string Address { get; set; }
        
    }
}