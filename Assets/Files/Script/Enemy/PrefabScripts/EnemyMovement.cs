using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Vector2 dir = Vector2.down;
    [SerializeField] float speed = 3;

    void Update() => transform.Translate(dir.normalized * speed * Time.deltaTime);
}