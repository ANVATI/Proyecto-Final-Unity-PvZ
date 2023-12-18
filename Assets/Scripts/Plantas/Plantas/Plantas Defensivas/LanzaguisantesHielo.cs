using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaguisanteDeHielo : PlantasHerencia
{
    public GameObject bulletPrefab;
    void Start()
    {
        vida = 80;
        Invoke("InstanciarBala", 40);
    }

    void InstanciarBala()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        Invoke("InstanciarBala", 3);
    }
}