using UnityEngine;

public class PatrolState : IEnemyState
{
    int currentPoint = 0;
    Vector2[] patrolPoints;

    public PatrolState(Vector2[] points)
    {
        patrolPoints = points;
    }

    public void Execute(EnemyMovement enemy)
    {
        Vector2 target = patrolPoints[currentPoint];
        Vector2 dir = (target - (Vector2)enemy.transform.position).normalized;
        enemy.transform.position += (Vector3)(dir * enemy.Speed * Time.deltaTime);

        if (Vector2.Distance(enemy.transform.position, target) < 0.1f)
            currentPoint = (currentPoint + 1) % patrolPoints.Length;
    }
}
