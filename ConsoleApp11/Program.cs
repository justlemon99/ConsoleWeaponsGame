using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваш ник: ");
          string  nickName = Console.ReadLine();
            Pistol pistol = new Pistol();
            RocketLauncher rocketLauncher = new RocketLauncher();   
            CosmicPistol cosmicPistol = new CosmicPistol();
            Weapon[] weapons = {pistol, rocketLauncher, cosmicPistol};
         Player player = new Player(nickName, weapons);
            Player enemy = new Player("Зомби", weapons);
            player.ShootSomeone(enemy, pistol);


        }




    }
}
