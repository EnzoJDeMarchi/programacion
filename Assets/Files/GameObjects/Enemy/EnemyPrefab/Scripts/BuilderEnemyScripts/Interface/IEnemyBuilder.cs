using UnityEngine;

public interface IEnemyBuilder
{
    void SetPosition(Vector2 position);
    void SetTarget(Transform player);
    void SetStats(int health, float speed);
    GameObject Build();
}