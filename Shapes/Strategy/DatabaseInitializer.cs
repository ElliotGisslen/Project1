using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyClassLibrary.Models;
using Shapes.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class DatabaseInitializer
    {
        public static void Seed(IApplicationBuilder applicationbuilder)
        {
            using(var serviceScope = applicationbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>(); 

                if(!context.ShapeResults.Any())
                {
                    var _context = new Context();
                    context.ShapeResults.AddRange(new ShapeResult()
                    {
                        Input1 = 1,
                        Input2 = 2,
                        Input3 = 3,
                        Perimeter = _context.ExecuteStrategy(1, 2, 3).Perimiter,
                        Area = _context.ExecuteStrategy(1, 2, 3).Area,
                        Date = DateTime.Now,
                    },
                    new ShapeResult
                    {
                        Input1 = 2,
                        Input2 = 2,
                        Input3 = 0,
                        Perimeter = _context.ExecuteStrategy(2, 2, 0).Perimiter,
                        Area = _context.ExecuteStrategy(2, 2, 0).Area,
                        Date = DateTime.Now,
                    },
                    new ShapeResult
                    {
                        Input1 = 3,
                        Input2 = 3,
                        Input3 = 3,
                        Perimeter = _context.ExecuteStrategy(3, 3, 3).Perimiter,
                        Area = _context.ExecuteStrategy(3, 3, 3).Area,
                        Date = DateTime.Now,
                    },
                    new ShapeResult
                    {
                        Input1 = 1,
                        Input2 = 2,
                        Input3 = 3,
                        Perimeter = _context.ExecuteStrategy(1, 2, 3).Perimiter,
                        Area = _context.ExecuteStrategy(1, 2, 3).Area,
                        Date = DateTime.Now,
                    });
                    context.SaveChanges();

                }
            }
        }
        //private readonly ApplicationDbContext _context; 

        //public DatabaseInitializer(ApplicationDbContext context)
        //{
        //    _context = context;
        //}   
        //public async Task SeedSampleData()
        //{
        //    await _context.Database.EnsureCreatedAsync();

        //    if(!_context.ShapeResults.Any())
        //    {
        //        var context = new Context();
        //        context.SetStrategy(new RhombusStrategy());
        //        var rhombus = new ShapeResult
        //        {
        //            Id = 1,
        //            Input1 = 1,
        //            Input2 = 2,
        //            Input3 = 3,
        //            Perimeter = context.ExecuteStrategy(1, 2 ,3).Perimiter,
        //            Area = context.ExecuteStrategy(1, 2, 3).Area,
        //            Date = DateTime.Now,
        //        };
        //        context.SetStrategy(new RectangleStrategy());
        //        var rectangle  = new ShapeResult
        //        {
        //            Id = 2,
        //            Input1 = 2,
        //            Input2 = 2,
        //            Input3 = 0,
        //            Perimeter = context.ExecuteStrategy(2, 2, 0).Perimiter,
        //            Area = context.ExecuteStrategy(2, 2, 0).Area,
        //            Date = DateTime.Now,
        //        };
        //        context.SetStrategy(new TriangelStrategy());    
        //        var triangle = new ShapeResult
        //        {
        //            Id = 3,
        //            Input1 = 3,
        //            Input2 = 3,
        //            Input3 = 3,
        //            Perimeter = context.ExecuteStrategy(3, 3, 3).Perimiter,
        //            Area = context.ExecuteStrategy(3, 3, 3).Area,
        //            Date = DateTime.Now,
        //        };
        //        context.SetStrategy(new ParallelogramStrategy());
        //        var parallelogram = new ShapeResult
        //        {

        //            Id = 4,
        //            Input1 = 1,
        //            Input2 = 2,
        //            Input3 = 3,
        //            Perimeter = context.ExecuteStrategy(1, 2, 3).Perimiter,
        //            Area = context.ExecuteStrategy(1, 2, 3).Area,
        //            Date = DateTime.Now,
        //        };
        //        _context.ShapeResults.Add(rectangle);
        //        _context.ShapeResults.Add(rhombus);
        //        _context.ShapeResults.Add(triangle);
        //        _context.ShapeResults.Add(parallelogram);

        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}
