using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SellGameManager : ISellGames
    {
        public void SellingGames(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu, oyun satın aldı.", gamer.FirstName);
        }

        public void SellingGamesWithCampaign(Gamer gamer)
        {
            Console.WriteLine("{0} isimli oyuncu, {1} kampanyasıyla oyun satın aldı.", gamer.FirstName);
            //, campaign.CampaignName
        }
    }
}
