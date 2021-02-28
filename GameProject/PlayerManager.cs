using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : PlayerManagerService
    {
        private IValidationService _validationService;
        
        public void Add(IValidationService validationService)
        {
            validationService = _validationService;

        }

        public void Add(Player player)
        {
            if (_validationService.ValidateTheUser(player))
            {
                Console.WriteLine("Başarıyla dogrulandı.");
            }
        }

        public void BilmemNe(Player player)
        {
            throw new NotImplementedException();
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
