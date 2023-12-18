using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float minSpawnTime = 3.2f;
    private float maxSpawnTime = 6f;
    public GameManagerControl gameManager;

    void Start()
    {
        Invoke("Spawner", 30);
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject zombie = Instantiate(randomEnemy, transform.position, transform.rotation);
        zombie.GetComponent<HerenciaZombies>().gameManager = gameManager;
        Invoke("Spawner", Random.Range(minSpawnTime, maxSpawnTime));
    }
}
