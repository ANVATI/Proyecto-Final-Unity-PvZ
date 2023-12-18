using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2 : HerenciaZombies
{
    void Start()
    {
        life = 80;
        damage = 10;
        speedX = 0.4f;
        directionX = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
