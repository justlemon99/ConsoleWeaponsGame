using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Player
    {
        public int HP = 100;
        string NickName;
        Weapon[] Weapons = new Weapon[10];
        int EXP = 0;
        int Level = 1;

        public Player(string nickname, Weapon[] weapons)
        {
             Weapons = weapons;
             NickName = nickname;
        }


        public void ShootSomeone(Player target, Weapon weapon) 
        {

            weapon.Shoot();
            target.GetDamage(weapon.Damage);
            Console.WriteLine(target.HP);
            

        }

        public void GetDamage(int damage)
        {
            HP -= damage;
        }
    }
}
