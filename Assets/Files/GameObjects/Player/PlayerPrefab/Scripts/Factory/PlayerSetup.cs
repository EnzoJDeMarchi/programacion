using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] GameObject normalBulletPrefab;
    [SerializeField] GameObject explosiveBulletPrefab;

    void Start()
    {
        var autoShot = GetComponent<AutoShot>();
        var factory = new PlayerBulletFactory(normalBulletPrefab, explosiveBulletPrefab);
        autoShot.SetFactory(factory);
    }
}