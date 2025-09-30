using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePoint;
    [SerializeField] float rate;

    float t;

    void Update()
    {
        t += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && t >= rate)
        {
            t = 0;
            var b = Instantiate(bullet, firePoint.position, firePoint.rotation);
            b.GetComponent<Bullet>().targetTag = "Enemy";
        }
    }
}