using Microsoft.EntityFrameworkCore;
using StudentWebApi.Model;

namespace StudentWebApi.Data
{
    public class ApplicationDbContext: DbContext    
    {

       

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
            {
            }


            public DbSet<Student> Students { get; set; }
        }
    }
