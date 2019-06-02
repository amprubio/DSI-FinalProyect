using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSi_FinalProyect
{
    class Player
    {
        public const int MAXVida = 20;
        private int Level,EXP;
        public string Profile;
        
        private int speed, damage, EnemKilled;
        public void Inicio()
        {
            try
            {
                SetLevel(1);
                EXP = 0;
                Profile = "";
                EnemKilled = 0;
                speed = 1;
                damage = 2;
            }
            catch
            {
                throw new Exception("Imposible to create a profile");
            }
        }
        public int GetLevel()
        {
            return Level;
        }
        public void SetLevel(int level)
        {
            Level = level;
        }
        public int GetDamage()
        {
            return damage;
        }
        public void SetDamage(int newDamage)
        {
            damage = newDamage;
        }
        public int GetEnemiesKilled()
        {
            return EnemKilled;
        }
        public void SetEnemiesKilled(int amount)
        {
            EnemKilled = amount;
        }
        public int GetEXP()
        {
            return EXP;
        }
        public void SetEXP(int amount)
        {
            EXP = amount;
        }
        public void SetProfile(string s)
        {
            Profile = s;
        }
    }

}
