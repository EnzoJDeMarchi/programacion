using UnityEngine;

public class ShootCommand : ICommand
{
    Transform origin;
    GameObject bulletPrefab;

    public ShootCommand(Transform origin, GameObject bulletPrefab)
    {
        this.origin = origin;
        this.bulletPrefab = bulletPrefab;
    }

    public void Execute()
    {
        GameObject bullet = GameObject.Instantiate(bulletPrefab, origin.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
            rb.linearVelocity = origin.up * 10f;
    }
}