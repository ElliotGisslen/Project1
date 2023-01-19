using Calculations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using MyClassLibrary;
using RockPaperScissors;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesStrategyPlusLibrary
{
    public class App
    {
        private ApplicationDbContext _dbContext;
        public void GoGoGo()
        {
            var build = new Build();
            _dbContext = build.BuildDb();
            runMenu();
        }

        private void runMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("1: Shapes");
                Console.WriteLine("2: Calculator");
                Console.WriteLine("3: Rock Paper Scissors");
                Console.WriteLine("0: Exit");

                var userAnswer = Console.ReadLine();
                if (userAnswer == "0") break;
                goSection(userAnswer);
            }
        }

        private void goSection(string? userAnswer)
        {
            try
            {
                switch (userAnswer)
                {
                    case "1":
                        var goShapesMenu = new ShapesMenu(_dbContext);
                        goShapesMenu.ShowShapesMenu();
                        //Console.ReadLine();
                        break;
                    case "2":
                        //Console.WriteLine("These are not the droids you are looking for!");
                        //Console.ReadLine();
                        var goCalculationsMenu = new CalculationsMenu(_dbContext);
                        goCalculationsMenu.ShowCalculationsMenu();
                        break;
                    case "3":
                        var goRockPaperScissorsMenu = new RockPaperScissorsMenu(_dbContext);
                        goRockPaperScissorsMenu.ShowRockPaperScissorsMenu();
                        break;
                    case "0":
                        Console.WriteLine("Case 0");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ogiltig inmatning!");

                Console.WriteLine("Tryck på valfri tangent för att gå vidare.");
                Console.ReadLine();
            }


            
        }
    }
}
