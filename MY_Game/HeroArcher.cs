namespace MY_Game
{
    internal class HeroArcher : HeroInterface
    {
        public string Name = "Archer";
        public double Health = 800;
        public int AttackPower = 300;
        public int ResistanceToPhysical = 8;
        public int ResistanceToMagical = 8;
        public int CriticalChance = 20;
        public int DodgeChance = 10;


        public double GetEnemyAttack(double damage, int criticalChance, EnemyAttackKind attack)
        {
            Hero? hero = null;
            Enemy? enemy = null;
            if (attack == EnemyAttackKind.magical)
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