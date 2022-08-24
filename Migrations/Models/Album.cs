using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
