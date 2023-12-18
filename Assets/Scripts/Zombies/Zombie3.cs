using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie3 : HerenciaZombies
{
    void Start()
    {
        life = 100;
        damage = 15;
        speedX = 0.4f;
        directionX = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
