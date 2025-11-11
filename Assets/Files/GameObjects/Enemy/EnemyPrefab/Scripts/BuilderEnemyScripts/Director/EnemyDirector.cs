using UnityEngine;

public class EnemyDirector
{
    public void ConstructBasicEnemy(IEnemyBuilder builder, Vector2 position, Transform player)
    {
        builder.SetPosition(position);
        builder.SetStats(100, 2f);
        builder.SetTarget(player);
    }

    public void ConstructFastEnemy(IEnemyBuilder builder, Vector2 position, Transform player)
    {
        builder.SetPosition(position);
        builder.SetStats(50, 4f);
        builder.SetTarget(player);
    }
}