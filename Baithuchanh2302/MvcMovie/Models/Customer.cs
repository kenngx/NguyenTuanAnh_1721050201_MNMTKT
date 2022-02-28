using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.models{
    public class customer:Person{
        [StringLength(50)]
        [Key]
        public string CustomerID { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        [Required]
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
    }
}