using Microsoft.EntityFrameworkCore;

namespace Exercise.MedicineTracker.API.Models
{
    public class MedicineDbContext : DbContext
    {
        public MedicineDbContext(DbContextOptions<MedicineDbContext> options)
            : base(options)
        {
           
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}
