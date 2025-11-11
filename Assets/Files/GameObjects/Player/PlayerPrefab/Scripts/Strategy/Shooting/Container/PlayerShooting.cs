using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    IShooting shootingStrategy;

    void Start()
    {
        shootingStrategy = GetComponent<IShooting>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shootingStrategy?.Shoot();
        }
    }
}