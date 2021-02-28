using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface GameService
    {
        void Sell(Games game, Player player);
        void SellWithDiscount(Games game, Player player, Campaign campaign);
        void SellWithPromotion(Games game, Player player, Promotion promotion);
    }
}
