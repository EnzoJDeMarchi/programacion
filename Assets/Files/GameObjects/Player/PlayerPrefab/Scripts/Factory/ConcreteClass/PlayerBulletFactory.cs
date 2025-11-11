using UnityEngine;

public class PlayerBulletFactory : IBulletFactory
{
    GameObject normalBulletPrefab;
    GameObject explosiveBulletPrefab;

    public PlayerBulletFactory(GameObject normal, GameObject explosive)
    {
        normalBulletPrefab = normal;
        explosiveBulletPrefab = explosive;
    }

    public GameObject CreateBullet(string type, Vector3 position, Quaternion rotation)
    {
        GameObject prefab = type switch
        {
            "normal" => normalBulletPrefab,
            "explosive" => explosiveBulletPrefab,
            _ => normalBulletPrefab // fallback
        };

        GameObject bullet = Object.Instantiate(prefab, position, rotation);
        return bullet;
    }
}