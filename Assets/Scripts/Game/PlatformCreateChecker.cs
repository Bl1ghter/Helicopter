using UnityEngine;

[RequireComponent(typeof(Spawner))]
public class PlatformCreateChecker : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private int _platformCreateDistance = 1000;
    [SerializeField] private int startPositionY;

    private Spawner _spawnerScript;

    private void Start()
    {
        _spawnerScript = GetComponent<Spawner>();
    }

    private void FixedUpdate()
    {
        if(_spawnerScript.MaxPlatformSpawnDistance - _playerTransform.position.y <= 200)
        {
            startPositionY = _spawnerScript.MaxPlatformSpawnDistance;
            _spawnerScript.MaxPlatformSpawnDistance += _platformCreateDistance;
            _spawnerScript.SpawnPlatforms(startPositionY, _spawnerScript.MaxPlatformSpawnDistance);
        }
    }
}
