using UnityEngine;

public interface IBulletFactory
{
    GameObject CreateBullet(string type, Vector3 position, Quaternion rotation);
}