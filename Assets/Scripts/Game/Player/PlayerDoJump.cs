using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerDoJump : MonoBehaviour
{
    [SerializeField] private float _playerJumpForce;

    private Rigidbody2D _playerRigidbody2D;

    private void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void PlayerJump(float multiplayer)
    {
        _playerRigidbody2D.velocity = Vector2.up * _playerJumpForce * multiplayer;
    }
}
