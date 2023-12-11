namespace MY_Game
{
    enum HeroAttackKind { physical, magical };
    internal interface HeroInterface
    {
        double GetEnemyAttack(double damage, int criticalChance, EnemyAttackKind attack);
    }
}