using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace MvcMovie.Models
{

       [Table("Movies")]
    public class Movie
    {
        [Key]
        [Display(Name="Mã id")]
        public int Id { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        [Required (ErrorMessage = "warring!")]

        [Display(Name="Tiêu_đề")]
        public string? Title { get; set; }

        [Display(Name="Ngày_phát_hành")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Thể_loại")]
        public string? Genre { get; set; }

        [Display(Name="Giá_bán")]
        public decimal Price { get; set; }
    }
}
