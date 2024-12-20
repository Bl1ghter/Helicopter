using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {
        transform.position = _transform.position + _offset;
    }
}
