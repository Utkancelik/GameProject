using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : PlayerManagerService
    {
        public void Add(Player player)
        {
            Console.WriteLine(player.nickname + " has been added.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.nickname + " has been deleted.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.nickname + " has been updated.");
        }
    }
}
