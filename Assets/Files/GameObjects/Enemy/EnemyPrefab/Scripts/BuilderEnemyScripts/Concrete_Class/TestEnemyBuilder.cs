using UnityEngine;

public class TestEnemyBuilder : IEnemyBuilder
{
    GameObject enemy;
    GameObject prefab;

    public TestEnemyBuilder(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public void SetPosition(Vector2 position)
    {
        enemy = GameObject.Instantiate(prefab, position, Quaternion.identity);
    }

    public void SetStats(int health, float speed)
    {
        var life = enemy.GetComponent<EnemyLife>();
        if (life != null)
            life.Init(health);

        var movement = enemy.GetComponent<EnemyMovement>();
        if (movement != null)
            movement.SetSpeed(speed);
    }

    public void SetTarget(Transform player)
    {
        var detector = enemy.GetComponent<PlayerDetector>();
        if (detector != null)
            detector.SetTarget(player);
    }

    public GameObject Build()
    {
        return enemy;
    }
}