using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _platforms;
    [SerializeField] private Transform _platformCollection;
    [SerializeField] private int _platformOffsetY = 2;

    [HideInInspector] public int MaxPlatformSpawnDistance = 1000;

    private float _platformBorderPosition = 2.7f;
    private Vector3 _platformSpawnPosition = new Vector3(0, 0, 0);

    private void Awake()
    {
        SpawnPlatforms(7, MaxPlatformSpawnDistance);
    }

    public void SpawnPlatforms(int startPositionY, int MaxPlatformSpawnDistance)
    {
        for (int posY = startPositionY; posY < MaxPlatformSpawnDistance; posY += _platformOffsetY) 
        {
            _platformSpawnPosition = new Vector3(PlatformPositionX(), posY, 0);
            Instantiate(_platforms[PlatformChoose(_platforms.Length)], _platformSpawnPosition, Quaternion.identity, _platformCollection);
        }
    }

    private float PlatformPositionX()
    {
        return Random.Range(-_platformBorderPosition, _platformBorderPosition);
    }
    public int PlatformChoose(int _platformArrayLength)
    {
        return Random.Range(0, _platformArrayLength);
    }

}