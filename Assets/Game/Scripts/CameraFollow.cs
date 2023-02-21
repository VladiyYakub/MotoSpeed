using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - Target.position;
    }
    private void Update()
    {
        transform.position = new Vector3(Target.position.x + _offset.x, 0, Target.position.z + _offset.z);
    }
}
