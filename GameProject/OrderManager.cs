using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            double PrevPrice = game.Price;
            game.Price -= game.Price * (campaign.AmountOfDiscount);
            Console.WriteLine("-------------------");
            Console.WriteLine("{0} isimli oyun {1} {2} isimli kullanıcı tarafından alındı.", game.GameName, gamer.FirstName, gamer.LastName);
            Console.WriteLine("Kampanyanın adı: " + campaign.CampaignName);
            Console.WriteLine("Uygulanan indirimle {0} TL'den {1} TL'ye düştü.", PrevPrice, game.Price);
        }
    }
}
