using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] int damage = 20;
    [SerializeField] float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var player = other.GetComponent<PlayerLife>();
            if (player != null)
                player.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}