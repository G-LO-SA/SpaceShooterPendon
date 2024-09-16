using UnityEngine;

public class MeteorSpawner : MonoBehaviour, IRandomIntervalSpawner
{
    [SerializeField] public Transform[] _spawnPoints;
    public Transform[] SpawnPoints => _spawnPoints;

    [SerializeField] public float _minSpawnInterval = 3f, _maxSpawnInterval = 5f;
    public float _spawnInterval;
    public float Interval => _spawnInterval;
    public float MinimumInterval => _minSpawnInterval;
    public float MaximumInterval => _maxSpawnInterval;



    [SerializeField] public GameObject _meteorPrefab;
    public GameObject SpawnObjectPrefab => _meteorPrefab;


    [SerializeField] public float _spawnRadius;
    [SerializeField] public Transform _planetTransform;

    public float _elapsedTime;

    public void Start()
    {
        _spawnInterval = Random.Range(_minSpawnInterval, _maxSpawnInterval);
    }

    public virtual void Update()
    {
        if (_elapsedTime < _spawnInterval)
        {
            _elapsedTime += Time.deltaTime;
        }
        else
        {
            var spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            var meteor = Instantiate(_meteorPrefab, spawnPoint.position + (Vector3)Random.insideUnitCircle * _spawnRadius, Quaternion.identity).GetComponent<Meteor>();
            meteor.Move(_planetTransform.position - meteor.transform.position);
            _elapsedTime = 0f;
            _spawnInterval = Random.Range(_minSpawnInterval, _maxSpawnInterval);
        }
    }
}