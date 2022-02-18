using App.Domain;
using Microsoft.EntityFrameworkCore;


namespace App.Data
{
    public class WarriorContext:DbContext
    {
        public DbSet<Warrior> Warriors { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=WarriorAppData");
           
        }
    }
}
