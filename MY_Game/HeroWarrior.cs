namespace MY_Game
{
    internal class HeroWarrior : HeroInterface
    {
        public string Name = "Warrior";
        public double Health = 1500;
        public int AttackPower = 200;
        public int ResistanceToPhysical = 30;
        public int ResistanceToMagical = 20;
        public int CriticalChance = 35;
        public int DodgeChance = 5;

        public double GetEnemyAttack(double damage, int criticalChance, EnemyAttackKind attack)
        {
            Hero? hero = null;
            Enemy? enemy = null;
            if (attack == EnemyAttackKind.magical)
            {
                if (enemy.EnemyCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                hero.reduceEnemyMagicalDamage(damage, ResistanceToMagical); // Reduce the magical hero damage, makes the math operations with resistance
            }
            else
            {
                if (enemy.EnemyCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance
                hero.reduceEnemyPhysicalDamage(damage, ResistanceToPhysical); // Reduce the physical hero damage, makes the math operations with resistance
            }
            if (damage > Health) return 0.0;

            Health -= damage;
            hero.HeroHeal(Health);

            return damage;
        }
    }
}
