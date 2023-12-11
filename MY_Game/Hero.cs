namespace MY_Game
{
    internal class Hero
    {
        Random random = new Random();
        public bool HeroCriticalRandom(int criticalChance) // METHOD TO COUNT, WILL BE CRITICAL DAMAGE OR NOT
        {
            if (random.Next(1, 101) <= criticalChance) return true;
            return false;
        }

        public void HeroHeal(double Health) // METHOD TO HEAL HEROS BY THEIR HEALTH
        {
            Health += (Health / 10); // Increase the health by 1/10 of whole Health
        }

        public bool DodgeEnemyAttack(int dodgeChance) // METHOD THAT 
        {
            if (random.Next(1, 101) <= dodgeChance) return true; // Return true if it's critical damage
            return false; // Return false if it isn't critical damage
        }


        public void reduceEnemyMagicalDamage(double damage, int MResistance)
        {
            damage -= (damage / 100) * MResistance;
        }
        public void reduceEnemyPhysicalDamage(double damage, int PResistance)
        {
            damage -= (damage / 100) * PResistance;
        }
    }
}
