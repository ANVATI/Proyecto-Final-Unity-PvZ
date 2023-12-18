using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilRepetidora : ProyectilHerencia
{
    // Start is called before the first frame update
    void Start()
    {
        speedX = 15;
        damageAmount = 15;
        directionX = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
