using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Weapon
    {
        public bool IsReadyToShoot = true;
        public int Damage = 5;
        public virtual void Shoot()
        {
            if(IsReadyToShoot)
            {
                Console.WriteLine("Выстрел");
                Thread.Sleep(1000);
                IsReadyToShoot = false;
            }
            else
            {
                Console.WriteLine("Нужна перезарядка!");
                Thread.Sleep(1000);
                Reload();
            }
            
        }
        public virtual void Reload()
        {
            
            Console.WriteLine("Перезаряжаю...");
            Thread.Sleep(2000);
            Console.WriteLine("Готово!");
            IsReadyToShoot = true;
        }

        
    }



}
