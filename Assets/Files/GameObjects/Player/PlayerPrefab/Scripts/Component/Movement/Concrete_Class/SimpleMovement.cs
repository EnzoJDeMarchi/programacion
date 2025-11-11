using UnityEngine;

public class SimpleMovement : MonoBehaviour, IMovement
{
    [SerializeField] float speed = 5f;

    public void Move(Vector2 direction)
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
}