using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenú : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnTime = 12f;
    public float maxSpawnTime = 20f;
    public GameManagerControl gameManager;

    void Start()
    {
        Invoke("Spawner",3);
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject zombie = Instantiate(randomEnemy, transform.position, transform.rotation);
        Invoke("Spawner",3);
    }
}
