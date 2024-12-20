using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private ScoreText _scoreTextScript;

    private float _cameraOffsetZ = -10;

    private void FixedUpdate()
    {
        if (transform.position.y < _playerTransform.position.y)
        {
            transform.position = new Vector3(0, _playerTransform.position.y, _cameraOffsetZ);

            _scoreTextScript.ScoreAdd(transform.position.y - 3);

        }
    }
}
