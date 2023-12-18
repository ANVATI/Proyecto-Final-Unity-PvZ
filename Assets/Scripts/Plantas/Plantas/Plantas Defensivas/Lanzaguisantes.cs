using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzaguisantes : PlantasHerencia
{
    public GameObject bulletPrefab;
    void Start()
    {
        vida = 50; 
        Invoke("InstanciarBala", 40);
    }

    void InstanciarBala()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        Invoke("InstanciarBala", 5);
    }
}
