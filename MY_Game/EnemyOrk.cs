namespace MY_Game
{
    internal class EnemyOrk : Attack_To_Enemys
    {
        public string Name { get; set; }

        public double Health = 1600;
        public int AttackPower = 180;
        public int ResistanceToPhysical = 40;
        public int ResistanceToMagical = 0;
        public int CriticalChance = 20;
        public int DodgeChance = 0;

        public double GetHeroAttack(double damage, int criticalChance, HeroAttackKind attack)
        {
            Hero? hero = null;
            Enemy? enemy = null;
            if (attack == HeroAttackKind.magical)
            {
                if (hero.HeroCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                enemy.reduceHeroMagicalDamage(damage, ResistanceToMagical); // Reduce the magical hero damage, makes the math operations with resistance
            }
            else
            {
                if (hero.HeroCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                enemy.reduceHeroPhysicalDamage(damage, ResistanceToPhysical); // Reduce the physical hero damage, makes the math operations with resistance
            }
            if (damage > Health) return 0.0;

            Health -= damage;
            hero.HeroHeal(Health);

            return damage;
        }
    }
}
