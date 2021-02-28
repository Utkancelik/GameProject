using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationService
    {
        public bool ValidateTheUser(Player player)
        {
            if (player.Ad == "Utkan" && player.nickname == "UtkanBaba0626")
            {
                return true;
            }
            else
            {
                return false;
            }

          
        }
    }
}
