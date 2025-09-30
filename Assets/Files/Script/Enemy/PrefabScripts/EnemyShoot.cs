using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [System.Serializable]
    class BulletPrototype
    {
        public GameObject prefab;
        public int damage = 10;
        public float speed = 12;
        public float lifetime = 3;
        public string targetTag = "Player";

        public GameObject Clone(Vector3 pos, Quaternion rot)
        {
            var clone = Object.Instantiate(prefab, pos, rot);
            if (clone.TryGetComponent(out Bullet b))
            {
                b.SetDamage(damage);
                b.SetSpeed(speed);
                b.SetLifetime(lifetime);
                b.SetTarget(targetTag);
            }
            return clone;
        }
    }

    [SerializeField] BulletPrototype bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float rate = 1, range = 5;
    [SerializeField] LayerMask mask;
    float t;

    void Update()
    {
        t += Time.deltaTime;
        if (t < rate || !Physics2D.OverlapCircle(transform.position, range, mask)) return;
        bullet.Clone(firePoint.position, firePoint.rotation);
        t = 0;
    }
}
