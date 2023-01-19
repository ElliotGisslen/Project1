using MyClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly ShapeResult _shapeResult;

        public DbInitializer(ApplicationDbContext context, ShapeResult shapeResult)
        {
            _context = context;
            _shapeResult = shapeResult;
        }
    
        public void Initialize()
        {


        }
    }
}
