using MyClassLibrary;
using MyClassLibrary.Models;
using Shapes.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class ShapesMenu
    {
        private readonly ApplicationDbContext _dbContext;

        public ShapesMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
      
        public void ShowShapesMenu()
        {
            Console.Clear();
            Console.WriteLine("Shapes Menu");
            Console.WriteLine("===========");
            Console.WriteLine("1: Rektangel");
            Console.WriteLine("2: Triangel");
            Console.WriteLine("3: Romb");
            Console.WriteLine("4: Parallelogram");
            Console.WriteLine("5. Lista alla shapes");
            Console.WriteLine("6. Uppdatera shape");
            Console.WriteLine("7. Radera shape");
            Console.WriteLine("0: Huvudmenyn");

            var shapesMenuAnswer = Console.ReadLine();
            if (shapesMenuAnswer == "0") return;
            
            checkShapesMenuAnswer(shapesMenuAnswer);
        }

        private void checkShapesMenuAnswer(string? menuChoice)
        {
            var context = new Context();

            switch (menuChoice)
            {
                case "1":
                    context.SetStrategy(new RectangleStrategy());
                    Console.WriteLine("Vad är bredden på din rektangel?");
                    var input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("... och vad är höjden på din rektangel?");
                    var input2 = Convert.ToDouble(Console.ReadLine());
                    var input3 = 0.0; // Används EJ!
                    var showResult = context.ExecuteStrategy(input1, input2, input3);
                    Console.WriteLine($"Rektangel: Bredd: {input1}, Höjd: {input2} Area = {showResult.Area}");
                    Console.WriteLine($"Rektangel: Bredd: {input1}, Höjd: {input2} Omkrets = {showResult.Perimiter}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.ShapeResults.Add(new ShapeResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Input3 = input3,
                        Area = showResult.Area,
                        Perimeter = showResult.Perimiter,
                        Date = DateTime.Now,
                        ShapeType = ShapeType.Rektangel,
                        Shape = "Rektangel"
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "2":
                    context.SetStrategy(new TriangelStrategy());
                    Console.WriteLine("Ange länden på en sida av triangeln:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange länden på en annan sida av triangeln:");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange länden på den sista sidan av triangeln:");
                    input3 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2, input3);
                    Console.WriteLine($"Triangel: Sida 1: {input1}, Sida 2: {input2}, Sida 3: {input3} Area = {showResult.Area}");
                    Console.WriteLine($"Triangel: Sida 1: {input1}, Sida 2: {input2}, Sida 3: {input3} Omkrets = {showResult.Perimiter}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.ShapeResults.Add(new ShapeResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Input3 = input3,
                        Area = showResult.Area,
                        Perimeter = showResult.Perimiter,
                        Date = DateTime.Now,
                        ShapeType = ShapeType.Triangel,
                        Shape = "Triangle"
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "3":
                    context.SetStrategy(new RhombusStrategy());
                    Console.WriteLine("Ange sidlängden för romben:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange vertikala längden för romben:");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange diagonala längden för romben:");
                    input3 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2, input3);
                    Console.WriteLine($"Romb: Sidalängd: {input1}, Vertikal: {input2}, Diagonal: {input3} Area = {showResult.Area}");
                    Console.WriteLine($"Romb: Sidalängd: {input1}, Vertikal: {input2}, Diagonal: {input3} Omkrets = {showResult.Perimiter}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.ShapeResults.Add(new ShapeResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Input3 = input3,
                        Area = showResult.Area,
                        Perimeter = showResult.Perimiter,
                        Date = DateTime.Now,
                        ShapeType = ShapeType.Romb,
                        Shape = "Rhombus"
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "4":
                    context.SetStrategy(new ParallelogramStrategy());
                    Console.WriteLine("Ange längden för en sida av parallelogrammet:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange längden för den andra sidan av parallelogrammet:");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange höjden av parallelogrammet:");
                    input3 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2, input3);
                    Console.WriteLine($"Parallelogram: Sida 1: {input1}, Sida 2: {input2}, Höjd: {input3} Area = {showResult.Area}");
                    Console.WriteLine($"Parallelogram: Sida 1: {input1}, Sida 2: {input2}, Höjd: {input3} Omkrets = {showResult.Perimiter}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.ShapeResults.Add(new ShapeResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Input3 = input3,
                        Area = showResult.Area,
                        Perimeter = showResult.Perimiter,
                        Date = DateTime.Now,
                        ShapeType = ShapeType.Parallelogram,
                        Shape = "Parallelogram"
                    }); ;
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "5":
                    ListAllShapes();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Ange id för den shape du vill uppdatera:");
                    var updateShapeId = Convert.ToInt32(Console.ReadLine());
                    foreach(var shape in _dbContext.ShapeResults)
                    {
                        if(shape.Id == updateShapeId)
                        {
                            if(shape.ShapeType == ShapeType.Rektangel)
                            {
                                context.SetStrategy(new RectangleStrategy());
                                
                                Console.WriteLine("Vad vill du uppdatera?\n1. Bredd\n2. Höjd\n0. Avsluta");
                                var updateAnswer = Convert.ToInt32(Console.ReadLine());
                                if(updateAnswer == 1)
                                {
                                    
                                    Console.WriteLine("Vad är den nya bredden?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input1 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 2)
                                {
                                    Console.WriteLine("Vad är den nya höjden?");
                                    var newInput = Convert.ToInt32(Console.ReadLine());
                                    shape.Input2 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                            }
                            if (shape.ShapeType == ShapeType.Triangel)
                            {
                                context.SetStrategy(new TriangelStrategy());

                                Console.WriteLine("Vad vill du uppdatera?\n1. Sida 1\n2. Sida 2\n3. Sida 3\n0. Avsluta");
                                var updateAnswer = Convert.ToInt32(Console.ReadLine());
                                if (updateAnswer == 1)
                                {

                                    Console.WriteLine("Vad är den nya längden för sida 1?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input1 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 2)
                                {
                                    Console.WriteLine("Vad är den nya längden för sida 2?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input2 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 3)
                                {
                                    Console.WriteLine("Vad är den nya längden för sida 3?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input2 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if(updateAnswer == 4)
                                {
                                    break;
                                }
                            }
                            if (shape.ShapeType == ShapeType.Romb)
                            {
                                context.SetStrategy(new RhombusStrategy());

                                Console.WriteLine("Vad vill du uppdatera?\n1. Sidlängd\n2. Vertikallängd\n3. Diagonallängd\n0. Avsluta");
                                var updateAnswer = Convert.ToInt32(Console.ReadLine());
                                if (updateAnswer == 1)
                                {

                                    Console.WriteLine("Vad är den nya sidlängden?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input1 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 2)
                                {
                                    Console.WriteLine("Vad är den nya vertikallängden?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input2 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 3)
                                {
                                    Console.WriteLine("Vad är den nya diagonallängden?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input3 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 4)
                                {
                                    break;
                                }
                            }
                            if (shape.ShapeType == ShapeType.Parallelogram)
                            {
                                context.SetStrategy(new RhombusStrategy());

                                Console.WriteLine("Vad vill du uppdatera?\n1. Sida 1\n2. Sida 2\n3. Höjd\n0. Avsluta");
                                var updateAnswer = Convert.ToInt32(Console.ReadLine());
                                if (updateAnswer == 1)
                                {

                                    Console.WriteLine("Vad är den nya länden för sida 1?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input1 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 2)
                                {
                                    Console.WriteLine("Vad är den nya längden för sida 2?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input2 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 3)
                                {
                                    Console.WriteLine("Vad är den nya höjden?");
                                    var newInput = Convert.ToDouble(Console.ReadLine());
                                    shape.Input3 = newInput;
                                    var newValues = context.ExecuteStrategy(shape.Input1, shape.Input2, shape.Input3);
                                    shape.Area = newValues.Area;
                                    shape.Perimeter = newValues.Perimiter;


                                }
                                if (updateAnswer == 4)
                                {
                                    break;
                                }
                            }



                        }
                    }
                    _dbContext.SaveChanges();
                    break;
                case "7":
                    Console.WriteLine("Ange id för den shape du vill radera:");
                    var deleteShapeId = Convert.ToInt32(Console.ReadLine());
                    foreach(var shape in _dbContext.ShapeResults)
                    {
                        if(shape.Id == deleteShapeId)
                        {
                            _dbContext.ShapeResults.Remove(shape);
                            break;
                        }
                    }
                    _dbContext.SaveChanges();
                    break;
                case "0":
                default:
                    break;
            }
        }
        public void ListAllShapes()
        {
            foreach(var shape in _dbContext.ShapeResults)
            {
                if(shape.ShapeType == ShapeType.Triangel)
                {
                    Console.WriteLine($"Form: {shape.Shape}, Sida1: {shape.Input1}, Sida2: {shape.Input2}, Sida3: {shape.Input3}, Area: {shape.Area}, Omkrets {shape.Perimeter} ");
                }
                if (shape.ShapeType == ShapeType.Rektangel)
                {
                    Console.WriteLine($"Form: {shape.Shape}, Sida1: {shape.Input1}, Sida2: {shape.Input2}, Area: {shape.Area}, Omkrets {shape.Perimeter} ");
                }
                if (shape.ShapeType == ShapeType.Romb)
                {
                    Console.WriteLine($"Form: {shape.Shape}, Sidlängd: {shape.Input1}, Diagonal: {shape.Input2}, Vertikal: {shape.Input3}, Area: {shape.Area}, Omkrets {shape.Perimeter} ");
                }
                if (shape.ShapeType == ShapeType.Parallelogram)
                {
                    Console.WriteLine($"Form: {shape.Shape}, Sida1: {shape.Input1}, Sida2: {shape.Input2}, Höjd: {shape.Input3}, Area: {shape.Area}, Omkrets {shape.Perimeter} ");
                }
            }
        }
    }
}

