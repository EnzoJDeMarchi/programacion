using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float speed = 2f;
    Transform target;

    public float Speed => speed;
    IEnemyState currentState;

    public void SetState(IEnemyState state)
    {
        currentState = state;
    }

    public void SetSpeed(float value)
    {
        speed = value;
    }

    public void Init(float s) => speed = s;

    public void SetTarget(Transform t) => target = t;

    void Update()
    {
        currentState?.Execute(this);
    }
}