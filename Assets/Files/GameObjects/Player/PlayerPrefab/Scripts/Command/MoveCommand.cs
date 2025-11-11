using UnityEngine;

public class MoveCommand : ICommand
{
    Transform playerTransform;
    Vector2 direction;
    float speed;

    public MoveCommand(Transform playerTransform, Vector2 direction, float speed)
    {
        this.playerTransform = playerTransform;
        this.direction = direction;
        this.speed = speed;
    }

    public void Execute()
    {
        playerTransform.position += (Vector3)(direction * speed * Time.deltaTime);
    }
}