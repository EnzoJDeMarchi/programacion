using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] int damage = 25;
    [SerializeField] float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            var enemyLife = other.GetComponent<EnemyLife>();
            if (enemyLife != null)
                enemyLife.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}