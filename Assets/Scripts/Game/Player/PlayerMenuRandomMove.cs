using UnityEngine;

[RequireComponent(typeof(PlayerMoveHorizontal))]
public class PlayerMenuRandomMove : MonoBehaviour
{
    [SerializeField] private int _inputDirection = 1;

    private float _playerCurrentPosition;
    private PlayerMoveHorizontal _PlayerMoveHorizontalScript;
    private int _playerMaxPositionX = 9;

    private void Awake()
    {
        _PlayerMoveHorizontalScript = GetComponent<PlayerMoveHorizontal>();
    }

    private void FixedUpdate()
    {
        _playerCurrentPosition = Mathf.Abs(transform.position.x);

        if(_playerCurrentPosition >= _playerMaxPositionX)
        {
            _inputDirection = -_inputDirection;
        }

        ReadMovement();
    }

    private void ReadMovement()
    {
        _PlayerMoveHorizontalScript.MoveHorizontal(_inputDirection);
    }

}
