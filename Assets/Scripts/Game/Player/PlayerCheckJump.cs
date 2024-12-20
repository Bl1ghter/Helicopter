using UnityEngine;

[RequireComponent(typeof(PlayerDoJump))]
public class PlayerCheckJump : MonoBehaviour
{
    [SerializeField] private LayerMask[] _platformsLayer;
    [SerializeField] private Vector2 _overlapBoxSize;

    [SerializeField] private PlayJumpSound _playJumpSoundScript;

    private float _overlapBoxAngle = 90;
    private PlayerDoJump _playerDoJump;

    private void Start()
    {
        _playerDoJump = GetComponent<PlayerDoJump>();
    }

    public void IsPlayerOnPlatform()
    {
        Collider2D collider = OverlapBoxPhysics(3);
        Collider2D fakePlatformCollider = OverlapBoxPhysics(1);

        if (OverlapBoxPhysics(0))
        {
            _playerDoJump.PlayerJump(1);
        }
        else if (OverlapBoxPhysics(2))
        {
            _playerDoJump.PlayerJump(1.5f);
        }
        else if (collider != null)
        {
            _playerDoJump.PlayerJump(1);
            Destroy(collider.gameObject);
        }
        else if(fakePlatformCollider != null)
        {
            Destroy(fakePlatformCollider.gameObject);
        }
    }

    private Collider2D OverlapBoxPhysics(int index) 
    {
        return Physics2D.OverlapBox(transform.position, _overlapBoxSize, _overlapBoxAngle, _platformsLayer[index]);
    }
}