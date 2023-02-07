using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demiroğ", IdentityNumber =123456 });
        }
    }
}
