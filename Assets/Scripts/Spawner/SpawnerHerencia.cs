using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHerencia : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameManagerControl gameManager;
    protected float minSpawnTime;
    protected float maxSpawnTime;

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
