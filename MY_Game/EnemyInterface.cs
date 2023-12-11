namespace MY_Game
{
    enum EnemyAttackKind { physical, magical };
    internal interface EnenemyInterface
    {
        double GetHeroAttack(double damage, int criticalChance, HeroAttackKind attack);
    }
}
