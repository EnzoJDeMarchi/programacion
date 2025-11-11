using UnityEngine;

public class EnemyBuilder : IEnemyBuilder
{
    GameObject enemy;

    public EnemyBuilder(GameObject prefab)
    {
        enemy = Object.Instantiate(prefab);
    }

    public void SetPosition(Vector2 position)
    {
        enemy.transform.position = position;
    }

    public void SetTarget(Transform player)
    {
        enemy.GetComponent<PlayerDetector>()?.SetTarget(player);
    }

    public void SetStats(int health, float speed)
    {
        enemy.GetComponent<EnemyLife>()?.Init(health);
        enemy.GetComponent<EnemyMovement>()?.Init(speed);
    }

    public GameObject Build() => enemy;
}