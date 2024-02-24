using EF_Lab1.DLL;
using EF_Lab1.DLL.Modules;
using Microsoft.EntityFrameworkCore.Internal;

namespace EF_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Hello!\n\t1)Show list of games\n\t0)Exit");
                string responce = Console.ReadLine();
                switch (responce)
                {
                    case "1":
                        using (var context = new Context())
                        {
                            var games = context.Games;
                            Console.WriteLine($"Title | Studio | Genre | Release Date | Style | Copies Sold");

                            foreach (Game game in games)
                            {
                                Console.Write($"\n{game.ID}){game.Title} | {game.Studio} | {game.Genre} | {game.ReleaseDate.ToShortDateString()} | ");
                                Console.Write((game.Style == null ? "No data " : game.Style) + "| ");
                                Console.Write(game.CopiesSold == null ? "No data" : game.CopiesSold);

                            }
                        }
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine($"Goodbye!");
                        exit = true;
                        break;
                    default: break;

                }
            }
            


            
        }
    }
}
