using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required(ErrorMessage = "Name is required")]
		[StringLength(255)]
		public string Name { get; set; }
		[Required(ErrorMessage = "Author name is required")]
		public string AuthorName { get; set; }
		[Required(ErrorMessage = "Genre is required")]
		public DateTime DateAdded { get; set; }
		[Required]
		public DateTime ReleaseDate { get; set; }
		[Range(1,20)]
		[Required(ErrorMessage = "This field is required")]
		public int NumberInStock { get; set; }
		[Required]
		public int NumberAvailable { get; set; }
		[Required]
		public Genre Genre { get; set; }
		[Required]
		public byte GenreId { get; set; }
	}
      
}
