using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _followTarget;
   
    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _followTarget.position;
    }
    private void Update()
    {
        transform.position = new Vector3(_followTarget.position.x + _offset.x, 10, _followTarget.position.z + _offset.z);
    }
}
