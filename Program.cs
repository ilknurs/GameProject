using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                FirstName = "İlknur",
                LastName = "Serçek",
                DateOfBirth = new DateTime(1998, 1, 9),
                Id = 1,
                NationalityId = "12345678910",
                Password = "123456",
                UserName = "Deneme"
            };  


            ISellGames sellGames = new SellGameManager();
            sellGames.SellingGames(gamer1);

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(new Campaign { Id = 1, CampaignName = "Discount %10" });    


        }
    }
}
