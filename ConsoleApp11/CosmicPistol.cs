using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class CosmicPistol : Weapon
    {
        string ShootMode = "Auto";
        int Magazine = 1;
        int ReloadTime = 4000;
        int ChargingTime = 2000;
        int AfterShootCooldown = 1000;

        public override void Shoot()
        {
            if (IsReadyToShoot)
            {
                Console.WriteLine("ВУУУУМММММ (подготовка к удару)");
                Thread.Sleep(ChargingTime);
                Console.WriteLine("БАБАХХХ!!!");
                Thread.Sleep(AfterShootCooldown);
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
            Console.WriteLine("Заряжаю...");
            for (int i = 0; i < ReloadTime;) 
            {
                Console.Write("*");
                Thread.Sleep(400);
                i += 400;

            }

            Console.WriteLine("\nГотово!");
            IsReadyToShoot = true;
        }




    }
    }

