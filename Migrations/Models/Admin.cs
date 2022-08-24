using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
