using System;
using ADO_NET_7.DataAccess;
using ADO_NET_7.Models;

namespace ADO_NET_7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameContext())
            {
                var game1 = new Game { Name = "Game1", Studio = "Studio1", Style = "Style1", ReleaseDate = DateTime.Now };
                var game2 = new Game { Name = "Game2", Studio = "Studio2", Style = "Style2", ReleaseDate = DateTime.Now };

                context.Games.AddRange(game1, game2);
                context.SaveChanges();

                foreach (var game in context.Games)
                {
                    Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Style: {game.Style}, Release Date: {game.ReleaseDate}");
                }
            }
        }
    }
}

