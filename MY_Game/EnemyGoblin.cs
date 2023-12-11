namespace MY_Game
{
    internal class EnemyGoblin : Attack_To_Enemys
    {
        public string Name { get; set; }

        public double Health = 800;
        public int AttackPower = 200;
        public int ResistanceToPhysical = 24;
        public int ResistanceToMagical = 10;
        public int CriticalChance = 15;
        public int DodgeChance = 50;

        public double GetHeroAttack(double damage, int criticalChance, HeroAttackKind attack)
        {
            Hero? hero = null;
            Enemy? enemy = null;
            if (enemy.DodgeHeroAttack(DodgeChance) == false)
            {
                if (hero.HeroCriticalRandom(criticalChance)) damage *= 1.5; // Increase the hero damage by critical chance

                if (attack == HeroAttackKind.magical)
                {
                    enemy.reduceHeroMagicalDamage(damage, ResistanceToMagical); // Reduce the magical hero damage, makes the math operations with resistance
                }
                else
                {
                    enemy.reduceHeroPhysicalDamage(damage, ResistanceToPhysical); // Reduce the physical hero damage, makes the math operations with resistance
                }
                if (damage > Health) return 0.0;

                Health -= damage;
                hero.HeroHeal(Health);
                return damage;
            }
            return 100;
        }
    }
}