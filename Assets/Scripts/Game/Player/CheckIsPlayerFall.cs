using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CheckIsPlayerFall : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody2D;

    private void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public bool CheckIsPlayerFallMethod()
    {
        if (_playerRigidbody2D.velocity.y < 0)
        {
            return true;
        }
        return false;

    }
}
