using UnityEngine;

[CreateAssetMenu(menuName = "Prototype/EnemyBullet")]
public class EnemyBulletPrototype : ScriptableObject, IPrototype<EnemyBulletPrototype>
{
    public GameObject bulletPrefab;
    public int damage;
    public float speed;
    public float lifetime;

    public EnemyBulletPrototype Clone()
    {
        // Devuelve una copia con los mismos valores
        EnemyBulletPrototype copy = Instantiate(this);
        return copy;
    }
}