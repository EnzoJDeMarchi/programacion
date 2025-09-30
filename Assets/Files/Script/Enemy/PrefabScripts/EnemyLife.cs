using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] int max;
    int hp;

    void Start() => hp = max;

    public void Damage(int d)
    {
        hp -= d;
        if (hp <= 0) Destroy(gameObject);
    }
}