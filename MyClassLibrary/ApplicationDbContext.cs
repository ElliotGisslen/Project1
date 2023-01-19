using Microsoft.EntityFrameworkCore;
using MyClassLibrary.Models;

namespace MyClassLibrary
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ShapeResult> ShapeResults { get; set; }

        public DbSet<CalculationResult> CalculationResults { get; set; }
        public DbSet<RockPaperScissorsResult> RockPaperScissorsResults { get; set; }

        public ApplicationDbContext()
        {
            // en tom konstruktor behövs för att skapa migrations
        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ShapeResult>().HasData(
                new ShapeResult()
                {
                    Id = 1,
                    Input1 = 1,
                    Input2 = 2,
                    Input3 = 0,
                    Area = 2,
                    Perimeter = 6,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Rektangel,
                    Shape = "Rektangel"
                },
                new ShapeResult()
                {

                    Id = 2,
                    Input1 = 5,
                    Input2 = 5,
                    Input3 = 7,
                    Area = 12.5,
                    Perimeter = 17,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Triangel,
                    Shape = "Triangel"
                },
                new ShapeResult()
                {

                    Id = 3,
                    Input1 = 13,
                    Input2 = 24,
                    Input3 = 10,
                    Area = 120,
                    //0.5 * b * Math.Sqrt((4 * a * a) - (b * b))
                    Perimeter = 52,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Romb,
                    Shape = "Romb"
                },
                new ShapeResult()
                {

                    Id = 4,
                    Input1 = 12,
                    Input2 = 8,
                    Input3 = 6,
                    Area = 72,
                    Perimeter = 40,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Parallelogram,
                    Shape = "Parallelogram"
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=ShapesStrategy;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

    }
}
