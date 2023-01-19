using Calculations.Strategy;
using MyClassLibrary;
using MyClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class CalculationsMenu
    {
        private readonly ApplicationDbContext _dbContext;

        public CalculationsMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ShowCalculationsMenu()
        {
            Console.Clear();
            Console.WriteLine("Calculations Menu");
            Console.WriteLine("===========");
            Console.WriteLine("1: Addition(+)");
            Console.WriteLine("2: Subtraktion(-)");
            Console.WriteLine("3: Multiplikation(*)");
            Console.WriteLine("4: Division(/)");
            Console.WriteLine("5. Lista alla uträkningar");
            Console.WriteLine("6. Uppdatera uträkning");
            Console.WriteLine("7. Radera uträkning");
            Console.WriteLine("0: Huvudmenyn");

            var shapesMenuAnswer = Console.ReadLine();
            if (shapesMenuAnswer == "0") return;

            checkCalculationsMenuAnswer(shapesMenuAnswer);
        }
        public void checkCalculationsMenuAnswer(string? menuChoice)
        {
            var context = new CalculationContext();

            switch (menuChoice)
            {
                case "1":
                    context.SetStrategy(new AdditionStrategy());
                    Console.WriteLine("Ange första talet:");
                    var input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange andra talet");
                    var input2 = Convert.ToDouble(Console.ReadLine());
                    var showResult = context.ExecuteStrategy(input1, input2);
                    Console.WriteLine($"Addition: Tal 1: {input1}, Tal 2: {input2} Summa = {showResult.CalculationOutcome}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.CalculationResults.Add(new CalculationResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Operator = "+",
                        Result = showResult.CalculationOutcome,
                        Date = DateTime.Now
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "2":
                    context.SetStrategy(new SubtractionStrategy());
                    Console.WriteLine("Ange första talet:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange andra talet");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2);
                    Console.WriteLine($"Subtraktion: Tal 1: {input1}, Tal 2: {input2} Summa = {showResult.CalculationOutcome}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.CalculationResults.Add(new CalculationResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Operator = "-",
                        Result = showResult.CalculationOutcome,
                        Date = DateTime.Now
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "3":
                    context.SetStrategy(new MultiplicationStrategy());
                    Console.WriteLine("Ange första faktorn:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange andra faktorn");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2);
                    Console.WriteLine($"Multiplikation: Faktor 1: {input1}, Faktor 2: {input2}, Produkt = {showResult.CalculationOutcome}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.CalculationResults.Add(new CalculationResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Operator = "*",
                        Result = showResult.CalculationOutcome,
                        Date = DateTime.Now
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "4":
                    context.SetStrategy(new DivisionStrategy());
                    Console.WriteLine("Ange täljare:");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ange nämnare:");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    showResult = context.ExecuteStrategy(input1, input2);
                    Console.WriteLine($"Division: Täljare: {input1}, Nämnare: {input2}, kvot = {showResult.CalculationOutcome}");

                    // Nu sparar vi all data till Db :)
                    _dbContext.CalculationResults.Add(new CalculationResult
                    {
                        Input1 = input1,
                        Input2 = input2,
                        Operator = "/",
                        Result = showResult.CalculationOutcome,
                        Date = DateTime.Now
                    });
                    _dbContext.SaveChanges();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "5":
                    ListAllCalculations();
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Ange id för den uträkning du vill uppdatera:");
                    var updateShapeId = Convert.ToInt32(Console.ReadLine());
                    foreach (var calculation in _dbContext.CalculationResults)
                    {
                        if (calculation.Id == updateShapeId)
                        {
                            Console.WriteLine("Vad vill du ändra?\n1. Tal 1\n2. Tal 2\n 0. Avsluta");
                            var changeCalculationOption = Convert.ToInt32(Console.ReadLine());
                            if(changeCalculationOption == 1)
                            {
                                if (calculation.Operator == "+")
                                    context.SetStrategy(new AdditionStrategy());
                                else if (calculation.Operator == "-")
                                    context.SetStrategy(new SubtractionStrategy());
                                else if (calculation.Operator == "*")
                                    context.SetStrategy(new MultiplicationStrategy());
                                else if (calculation.Operator == "+")
                                    context.SetStrategy(new DivisionStrategy());
                                Console.WriteLine("Vad vill du ändra talet till?");
                                var newInput = Convert.ToDouble(Console.ReadLine());
                                calculation.Input1 = newInput;
                                var newValues = context.ExecuteStrategy(calculation.Input1, calculation.Input2);
                                calculation.Result = newValues.CalculationOutcome;


                            }
                            if (changeCalculationOption == 2)
                            {
                                if (calculation.Operator == "+")
                                    context.SetStrategy(new AdditionStrategy());
                                else if (calculation.Operator == "-")
                                    context.SetStrategy(new SubtractionStrategy());
                                else if(calculation.Operator == "*")
                                    context.SetStrategy(new MultiplicationStrategy());
                                else if (calculation.Operator == "+")
                                    context.SetStrategy(new DivisionStrategy());
                                Console.WriteLine("Vad vill du ändra talet till?");
                                var newInput = Convert.ToDouble(Console.ReadLine());
                                calculation.Input2 = newInput;
                                var newValues = context.ExecuteStrategy(calculation.Input1, calculation.Input2);
                                calculation.Result = newValues.CalculationOutcome;

                            } 
                            if (changeCalculationOption == 0)
                            {
                                break;
                            }
                        }
                    }
                    _dbContext.SaveChanges();
                    break;
                case "7":
                    Console.WriteLine("Ange id för den uträkning du vill radera:");
                    var deleteCalculationId = Convert.ToInt32(Console.ReadLine());
                    foreach (var calculation in _dbContext.CalculationResults)
                    {
                        if (calculation.Id == deleteCalculationId)
                        {
                            _dbContext.CalculationResults.Remove(calculation);
                            break;
                        }
                    }
                    _dbContext.SaveChanges();
                    break;
                case "0":
                default:
                    break;
            }
            ShowCalculationsMenu();


        }
        public void ListAllCalculations()
        {
            foreach (var calculation in _dbContext.CalculationResults)
            {
                if (calculation.Operator == "+")
                {
                    Console.WriteLine($"Addition: Tal 1: {calculation.Input1}, Tal 2: {calculation.Input2}, Summa: {calculation.Result}");
                }
                if (calculation.Operator == "-")
                {
                    Console.WriteLine($"Subtraktion: Tal 1: {calculation.Input1}, Tal 2: {calculation.Input2}, Summa: {calculation.Result}");
                }
                if (calculation.Operator == "*")
                {
                    Console.WriteLine($"Multiplikation: Faktor 1: {calculation.Input1}, Faktor 2: {calculation.Input2}, Produkt: {calculation.Result}");
                }
                if (calculation.Operator == "/")
                {
                    Console.WriteLine($"Divisionn: Täljare: {calculation.Input1}, Nämnare: {calculation.Input2}, Kvot: {calculation.Result}");
                }

            }
        }
    }
}
