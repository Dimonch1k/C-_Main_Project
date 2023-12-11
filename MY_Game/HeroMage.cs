namespace MY_Game
{
    internal class HeroMage : HeroInterface
    {
        public string Name = "Mage";
        public double Health = 600;
        public int AttackPower = 350;
        public int ResistanceToPhysical = 8;
        public int ResistanceToMagical = 15;
        public int CriticalChance = 35;
        public int DodgeChance = 4;

        public double GetEnemyAttack(double damage, int criticalChance, EnemyAttackKind attack)
        {
            Hero? hero = null;
            Enemy? enemy = null;
            if (attack == HeroAttackKind.magical)
            {
                if (hero.HeroCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                enemy.reduceEnemyMagicalDamage(damage, ResistanceToMagical); // Reduce the magical hero damage, makes the math operations with resistance
            }
            else
            {
                if (hero.HeroCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                enemy.reducePhysicalHeroDamage(damage, ResistanceToPhysical); // Reduce the physical hero damage, makes the math operations with resistance
            }
            if (damage > Health) return 0.0;

            Health -= damage;
            hero.HeroHeal(Health);

            return damage;
        }
    }
}
