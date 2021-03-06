using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        List<Gamer> gamers = new List<Gamer>() { };

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {


            if (_userValidationService.Validate(gamer))
            {
                gamers.Add(gamer);
                Console.WriteLine("{0} {1} isimli oyuncu kayıt oldu.", gamer.FirstName, gamer.LastName);
                Console.WriteLine("-------------------");
            }
            else
            {
                Console.WriteLine("Kayıt basarısız.Doğrulama hatası");
                Console.WriteLine("-------------------");
            }

        }



        public void Delete(long IdentityNumber)
        {

            foreach (var item in gamers)
            {
                if (item.IdentityNumber == IdentityNumber)
                {
                    gamers.Remove(item);
                    Console.WriteLine("{0} {1} isimli oyuncu silindi.", item.FirstName, item.LastName);
                    Console.WriteLine("-------------------");
                    break;
                }

                else
                {
                    continue;
                }
            }

        }



        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
            Console.WriteLine("-------------------");
        }
    }
}
