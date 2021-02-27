using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface PlayerManagerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
