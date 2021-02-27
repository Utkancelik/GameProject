using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                Id = 2006,
                nickname = "UTKANBABA0626",
                password = "şifrem123"
            };

            Campaign campaign1 = new Campaign();
            campaign1.discountRate = 20;

            PlayerManagerService playerManagerService = new PlayerManager();
            playerManagerService.Add(player1);

            CampaingService campaingService = new CampaignManager();
            campaingService.Add(campaign1);
        }
    }
}
