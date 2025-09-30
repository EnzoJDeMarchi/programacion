using UnityEngine;

public class EnemySpawnerToward : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;

    void Update()
    {
        if (!target) return;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}