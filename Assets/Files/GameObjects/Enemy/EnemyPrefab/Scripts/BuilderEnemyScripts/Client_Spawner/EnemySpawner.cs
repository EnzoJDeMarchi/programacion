using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform player;
    [SerializeField] Transform playerTransform;

    float spawnRate = 2f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate && player != null)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = (Vector2)player.position + Random.insideUnitCircle.normalized * 3f;

        var builder = new EnemyBuilder(enemyPrefab);
        var director = new EnemyDirector();

        director.ConstructBasicEnemy(builder, spawnPos, player);

        builder.Build();
    }

    [SerializeField] GameObject testEnemyPrefab;

    void SpawnTestEnemy(Vector2 pos)
    {
        var builder = new TestEnemyBuilder(testEnemyPrefab);
        var director = new EnemyDirector();

        director.ConstructBasicEnemy(builder, pos, playerTransform);
        builder.Build();
    }


}