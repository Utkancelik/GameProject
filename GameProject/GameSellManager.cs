using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSellManager : GameService
    {
        public void Sell(Games game, Player player)
        {
            Console.WriteLine("{0} Oyunu {1} nick'ine sahip kullanıcıya başarıyla satılmıştır.",game.name,player.nickname);
        }

        public void SellWithDiscount(Games game, Player player, Campaign campaign)
        {
            Console.WriteLine("{0} Oyunu {1} nick'ine sahip kullanıcıya yüzde{3} indirim uygulanarak" +
                              "başarıyla satılmıştır.", game.name, player.nickname,campaign.discountRate);
        }
    }
}
