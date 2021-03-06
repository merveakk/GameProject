using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer = new Gamer { Id = 1, FirstName = "MERVE", LastName = "AK", BirthYear = 1999, IdentityNumber = 12656564590 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            Gamer gamer2 = new Gamer { Id = 1, FirstName = "FURKAN", LastName = "AK", BirthYear = 2005, IdentityNumber = 1426420087 };
            gamerManager.Add(gamer2);
            Gamer gamer3 = new Gamer { Id = 1, FirstName = "AYŞE", LastName = "AK", BirthYear = 1974, IdentityNumber = 1426763928 };
            gamerManager.Add(gamer3);
            // gamerManager.Delete(1314568265);

            Game game1 = new Game { GameName = "PUBG", Price = 106.5, GameReviewScore = 9.1 };
            Game game2 = new Game { GameName = "MINECRAFT", Price = 86, GameReviewScore = 5.3 };
            Game game3 = new Game { GameName = "LOL", Price = 12.90, GameReviewScore = 6.4 };
            Game game4 = new Game { GameName = "CS GO", Price = 74, GameReviewScore = 7.8 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.Add(game4);
            // gameManager.Delete(game3);

            Campaign campaign1 = new Campaign { CampaignName = "%50 indirim", AmountOfDiscount = 0.5 };
            Campaign campaign2 = new Campaign { CampaignName = "%10 indirim", AmountOfDiscount = 0.1 };
            Campaign campaign3 = new Campaign { CampaignName = "%70 indirim", AmountOfDiscount = 0.7 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            // campaignManager.Delete(campaign1);

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(game1, gamer3, campaign2);
            orderManager.Sell(game2, gamer2, campaign1);
            orderManager.Sell(game3, gamer, campaign3);
        }
    }
}
