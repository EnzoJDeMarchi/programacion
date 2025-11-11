using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    Transform player;
    EnemyMovement movement;
    EnemyShooting shooting;

    public void SetTarget(Transform t) => player = t;

    void Start()
    {
        movement = GetComponent<EnemyMovement>();
        shooting = GetComponent<EnemyShooting>();
        movement.SetTarget(null);
        shooting.SetTarget(null);
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);
        if (distance < 10f)
        {
            movement.SetTarget(player);
            shooting.SetTarget(player);
        }
        else
        {
            movement.SetTarget(null);
            shooting.SetTarget(null);
        }
    }
}