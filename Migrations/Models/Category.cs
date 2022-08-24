using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }   
        public int DisplayOrder { get; set; }  
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public ICollection<Album>? Albums { get; set; } 

    }
}
