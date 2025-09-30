using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float smooth = 5;

    void LateUpdate()
    {
        if (!target) return;
        var desired = target.position + offset;
        var smoothed = Vector3.Lerp(transform.position, desired, smooth * Time.deltaTime);
        transform.position = new Vector3(smoothed.x, smoothed.y, transform.position.z);
    }

    public void SetTarget(Transform t) => target = t;
}
