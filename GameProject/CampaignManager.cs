using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt Oldu.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
