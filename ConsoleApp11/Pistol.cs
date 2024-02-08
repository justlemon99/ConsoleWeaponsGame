using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Pistol : Weapon
    {
        string ShootMode = "Auto";
        int Magazine = 12;
        public int  Damage = 5;
       
        public override void Shoot()
        {
            if (Magazine == 0)
            {
                IsReadyToShoot = false;
            }

            if (IsReadyToShoot)
            {
              

                if (IsReadyToShoot)
                {
                    if (ShootMode == "Single") 
                    {
                        Magazine--;
                        Console.WriteLine("Пиу-пиу");
                    }

                    else if (ShootMode == "Auto")
                    {
                        while (Magazine > 0)
                        {
                            Magazine--;
                            Console.WriteLine("Пиу-пиу");
                            Thread.Sleep(100);
                        }
                    }
                }
        
            }
            else
            {
                Console.WriteLine("Нужна перезарядка!");

                Reload();
            }

            



        }
    }

    
}
