using UnityEngine;

public class EnemyMoveToward : MonoBehaviour
{
    [SerializeField] float speed = 2;
    Transform target;

    void Start() => target = GameObject.FindWithTag("Player")?.transform;

    void Update()
    {
        if (!target) return;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}