using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>();

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("{0} isimli oyun eklendi.", game.GameName);
            Console.WriteLine("-------------------");
        }

        public void Delete(Game game)
        {
            foreach (var item in games)
            {
                if (item.GameName == game.GameName)
                {
                    games.Remove(item);
                    Console.WriteLine("{0} isimli oyun silindi.", item.GameName);
                    Console.WriteLine("-------------------");
                    break;
                }

                else
                {
                    continue;
                }
            }
        }



        public void Update(Game game)
        {
            Console.WriteLine("oyun güncellendi.");
            Console.WriteLine("-------------------");
        }
    }
}
