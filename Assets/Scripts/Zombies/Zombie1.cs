using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie1 : HerenciaZombies
{
    void Start()
    {
        life = 50;
        damage = 5;
        speedX = 0.4f;
        directionX = -1;
    }
}
