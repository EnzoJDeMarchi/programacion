using UnityEngine;

public class ChaseState : IEnemyState
{
    Transform player;
    float detectionRange;

    public ChaseState(Transform target, float range = 5f)
    {
        player = target;
        detectionRange = range;
    }

    public void Execute(EnemyMovement enemy)
    {
        if (player == null) return;

        float distance = Vector2.Distance(enemy.transform.position, player.position);

        if (distance <= detectionRange)
        {
            Vector2 dir = (player.position - enemy.transform.position).normalized;
            enemy.transform.position += (Vector3)(dir * enemy.Speed * Time.deltaTime);
        }

    }
}