using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _spawnPoints;
    [SerializeField] private Enemy _enemy;
    private int _timeBetweenSpawns = 2;
    private int _firstSpawnPointIndex = 0;
    private int _lastSpawnPointIndex = 3;

    private void Start()
    {
        StartCoroutine(TimeBetweenSpawns());
    }

    private void Spawn()
    {
        GameObject spawnPoint = _spawnPoints[Random.Range(_firstSpawnPointIndex, _lastSpawnPointIndex + 1)];
        Enemy enemy = Instantiate(_enemy);

        enemy.transform.position = spawnPoint.transform.position;
        enemy.transform.rotation = spawnPoint.transform.rotation;
    }

    private IEnumerator TimeBetweenSpawns()
    {
        var wait = new WaitForSeconds(_timeBetweenSpawns);

        while (enabled)
        {
            Spawn();

            yield return wait;
        }
    }
}
