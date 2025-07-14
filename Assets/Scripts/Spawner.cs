using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnerPoint> _spawnPoints;
    [SerializeField] private Enemy _enemy;
    private int _timeBetweenSpawns = 2;
    private int _firstSpawnPointIndex = 0;
    private int _lastSpawnPointIndex = 3;

    private void Start()
    {
        StartCoroutine(CountTimeBetweenSpawns());
    }

    private void Spawn()
    {
        Debug.Log(_spawnPoints.Count);
        SpawnerPoint spawnPoint = _spawnPoints[Random.Range(_firstSpawnPointIndex, _lastSpawnPointIndex + 1)];
        Enemy enemy = Instantiate(_enemy);
        Debug.Log(spawnPoint);
        enemy.Initialize(spawnPoint.Position, spawnPoint.Rotation);
    }

    private IEnumerator CountTimeBetweenSpawns()
    {
        var wait = new WaitForSeconds(_timeBetweenSpawns);

        while (enabled)
        {
            Spawn();

            yield return wait;
        }
    }
}
