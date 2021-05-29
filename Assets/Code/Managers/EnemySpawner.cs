using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    private float _spawnTimer;

    void Update()
    {
        _spawnTimer += Time.deltaTime;
        if (_spawnTimer > spawnRate)
        {
            _spawnTimer = 0;

            GameObject go = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
