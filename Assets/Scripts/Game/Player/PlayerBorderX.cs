using UnityEngine;

public class PlayerBorderX : MonoBehaviour
{
    [SerializeField] private float _playerBorder = 3.5f;

    private void FixedUpdate()
    {
        limitPlayerPlayableZoneX();
    }

    private void limitPlayerPlayableZoneX()
    {
        if (transform.position.x > _playerBorder)
        {
            transform.position = new Vector3(-_playerBorder, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -_playerBorder)
        {
            transform.position = new Vector3(_playerBorder, transform.position.y, transform.position.z);
        }
    }
}
