using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class RocketLauncher : Weapon
    {

        public override void Shoot()
        {
           
            if (IsReadyToShoot)
            {
                Console.WriteLine("БДЫЩ");
                Thread.Sleep(1000);
                IsReadyToShoot = false;
            }
            else
            {
                Console.WriteLine("Нужна перезарядка!");
               
                Reload();
            }
        }
        public override void Reload()
        {
            Console.WriteLine("Перезаряжаю...");
            Thread.Sleep(4000);
            Console.WriteLine("Готово!");
            IsReadyToShoot = true;
        }

    }
}
