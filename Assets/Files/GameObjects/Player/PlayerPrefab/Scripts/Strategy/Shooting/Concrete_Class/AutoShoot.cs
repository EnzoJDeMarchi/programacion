using UnityEngine;

public class AutoShot : MonoBehaviour, IShooting
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] float fireRate = 0.5f;

    float timer;

    IBulletFactory bulletFactory;

    public void SetFactory(IBulletFactory factory)
    {
        bulletFactory = factory;
    }

    public void Shoot()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            GameObject bullet = bulletFactory.CreateBullet("normal", firePoint.position, firePoint.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = firePoint.up * 10f;
            timer = 0f;
        }
    }
}