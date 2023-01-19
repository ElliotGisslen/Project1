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
                    Input1 = 2,
                    Input2 = 2,
                    Input3 = 2,
                    Area = 1.73,
                    Perimeter = 6,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Triangel,
                    Shape = "Triangel"
                },
                new ShapeResult()
                {

                    Id = 3,
                    Input1 = 1,
                    Input2 = 2,
                    Input3 = 1,
                    Area = 4,
                    //0.5 * b * Math.Sqrt((4 * a * a) - (b * b))
                    Perimeter = 6,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Romb,
                    Shape = "Romb"
                },
                new ShapeResult()
                {

                    Id = 4,
                    Input1 = 1,
                    Input2 = 2,
                    Input3 = 0,
                    Area = 2,
                    Perimeter = 6,
                    Date = DateTime.Now,
                    ShapeType = ShapeType.Parallelogram,
                    Shape = "Parallelogram"
                });
            //builder.Entity<Room>().HasData(
            //    new Room(RoomType.Enkelrum, 1, 15)
            //    {
            //        Id = 1
            //    },
            //    new Room(RoomType.Dubbelrum, 1, 22)
            //    {
            //        Id = 2
            //    },
            //    new Room(RoomType.Enkelrum, 1, 19)
            //    {
            //        Id = 3
            //    },
            //    new Room(RoomType.Dubbelrum, 1, 35)
            //    {
            //        Id = 4
            //    });
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
