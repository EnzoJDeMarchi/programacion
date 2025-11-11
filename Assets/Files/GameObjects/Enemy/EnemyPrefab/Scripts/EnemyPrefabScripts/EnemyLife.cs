using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    int health = 100;
    float maxLifetime = 10f;
    float timer;

    public void Init(int hp) => health = hp;

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0) Destroy(gameObject);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxLifetime)
            Destroy(gameObject);
    }
}