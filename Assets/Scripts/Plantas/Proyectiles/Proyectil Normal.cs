using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilNormal : ProyectilHerencia
{
    // Start is called before the first frame update
    void Start()
    {
        speedX = 8;
        damageAmount = 8;
        directionX = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
