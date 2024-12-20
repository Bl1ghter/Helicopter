using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _platformMoveSpeed = 1;

    private float _platformBorder = 2.7f;
    private Vector2 _platformMoveDirection;

    private void Start()
    {
        _platformMoveDirection = new Vector2(_platformBorder, 0);
    }
    private void FixedUpdate()
    {
        if(transform.position.x >= _platformBorder)
        {
            _platformMoveDirection.x = -_platformBorder;
        }
        else if (transform.position.x <= -_platformBorder)
        {
            _platformMoveDirection.x = _platformBorder;
        }

        transform.Translate(_platformMoveDirection * _platformMoveSpeed * Time.deltaTime);
    }
}
