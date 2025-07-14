using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private TargetPoint _targetPoint;
    private int _timeBetweenSpawns = 2;

    private void Start()
    {
        StartCoroutine(CountTimeBetweenSpawns());
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemy);
        enemy.Initialize(transform.position, _targetPoint);
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
