using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject[] _prefabs;

    private void Start()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            if (Random.Range(0, 5) == 0) continue;
            Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], spawnPoint.position, Quaternion.identity);
        }
    }
}
