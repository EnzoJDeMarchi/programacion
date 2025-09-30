using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float delay = 2, range = 5;
    [SerializeField] int maxSpawn = 5;
    int count;

    void Start() => InvokeRepeating(nameof(Spawn), delay, delay);

    void Spawn()
    {
        if (!prefab || count >= maxSpawn) return;
        var pos = transform.position + (Vector3)(Random.insideUnitCircle * range);
        Instantiate(prefab, pos, Quaternion.identity);
        count++;
    }
}
