using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float shootInterval = 1.5f;
    Transform target;
    float timer;

    public void SetTarget(Transform t) => target = t;

    void Update()
    {
        if (target == null) return;

        timer += Time.deltaTime;
        if (timer >= shootInterval)
        {
            timer = 0f;
            Shoot();
        }
    }

    [SerializeField] EnemyBulletPrototype bulletPrototype;

    void Shoot()
    {
        //esto llama al enemybulletprototype
        var clone = bulletPrototype.Clone();
        var bullet = Instantiate(clone.bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().linearVelocity = (target.position - transform.position).normalized * clone.speed;
    }
}