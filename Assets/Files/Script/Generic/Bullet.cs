using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] int damage = 10;
    [SerializeField] float lifetime = 3;
    public string targetTag;

    float t;

    public void SetDamage(int d) => damage = d;
    public void SetSpeed(float s) => speed = s;
    public void SetLifetime(float l) => lifetime = l;
    public void SetTarget(string tag) => targetTag = tag;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        t += Time.deltaTime;
        if (t >= lifetime) Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (targetTag == "Player" && c.TryGetComponent(out PlayerLife p)) p.Damage(damage);
        if (targetTag == "Enemy" && c.TryGetComponent(out EnemyLife e)) e.Damage(damage);

        Destroy(gameObject);
    }
}