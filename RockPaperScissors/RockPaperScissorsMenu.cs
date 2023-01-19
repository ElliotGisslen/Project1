using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissorsMenu
    {
        private readonly ApplicationDbContext _dbContext;

        public RockPaperScissorsMenu(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void ShowRockPaperScissorsMenu()
        {
            var random = new Random();
            var rockPaperScissors = random.Next(0, 3);
            string[] rockPaperScissorsOptions = {"Sten", "Sax", "Påse"};
            Console.WriteLine("Vilken väljer du\n1. Sten\n2. Sax\n3. Påse");
            var option = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if(option == 1 && rockPaperScissorsOptions[rockPaperScissors] == "Sax")
                {
                    Console.WriteLine("Du vann!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Win",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{((100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count() + 1) / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 1 && rockPaperScissorsOptions[rockPaperScissors] == "Påse")
                {
                    Console.WriteLine("Du förlorade!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Loss",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{((100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count()) / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 1 && rockPaperScissorsOptions[rockPaperScissors] == "Sten")
                {
                    Console.WriteLine("Oavgjort! Kör igen.");
                    ShowRockPaperScissorsMenu();
                }
                if (option == 2 && rockPaperScissorsOptions[rockPaperScissors] == "Påse")
                {
                    Console.WriteLine("Du vann!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Win",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{((100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count() + 1) / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 2 && rockPaperScissorsOptions[rockPaperScissors] == "Sten")
                {
                    Console.WriteLine("Du förlorade!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Loss",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{(100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count() / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 2 && rockPaperScissorsOptions[rockPaperScissors] == "Sax")
                {
                    Console.WriteLine("Oavgjort! Kör igen.");
                    ShowRockPaperScissorsMenu();
                }
                if (option == 3 && rockPaperScissorsOptions[rockPaperScissors] == "Sten")
                {
                    Console.WriteLine("Du vann!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Win",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{((100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count() + 1) / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 3 && rockPaperScissorsOptions[rockPaperScissors] == "Sax")
                {
                    Console.WriteLine("Du förlorade!");
                    _dbContext.RockPaperScissorsResults.Add(
                        new MyClassLibrary.Models.RockPaperScissorsResult
                        {
                            WinOrLoss = "Loss",
                            Date = DateTime.Now,
                            CurrentWinRatio = $"{(100 * (_dbContext.RockPaperScissorsResults.Select(n => n.WinOrLoss == "\\Win\\").Count() / (_dbContext.RockPaperScissorsResults.Count() + 1)))}%"
                        });
                    Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                    Console.ReadLine();
                }
                else if (option == 3 && rockPaperScissorsOptions[rockPaperScissors] == "Påse")
                {
                    Console.WriteLine("Oavgjort! Kör igen.");
                    ShowRockPaperScissorsMenu();
                }
                _dbContext.SaveChanges();
                break;

            }

        }
    }
}
