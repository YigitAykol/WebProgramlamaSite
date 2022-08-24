using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data;

public class ApplicationDbContext:DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<WebApplication4.Models.Album>? Album { get; set; }
        public DbSet<WebApplication4.Models.Category>? Category { get; set; }
        public DbSet<WebApplication4.Models.Admin>? Admin { get; set; }
        
       
        

}

