using UnityEngine;

public class IsGameOver : MonoBehaviour
{
    [SerializeField] private RestartGame _restartGameScript;

    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Transform _playerTransform;

    private void FixedUpdate()
    {
        if(_playerTransform.position.y < _cameraTransform.position.y - 13.5f)
        {
            _restartGameScript.RestartingGame();
        }
    }
}
