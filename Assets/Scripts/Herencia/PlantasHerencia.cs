using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantasHerencia : MonoBehaviour
{
    protected int vida;
    BoxCollider2D _comBoxCollider2D;

    public void RecibirDaño(int cantidadDaño)
    {
        vida = vida - cantidadDaño;

        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Awake()
    {
        _comBoxCollider2D = GetComponent<BoxCollider2D>();
    }
    /*
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zombies"))
        {
            HerenciaZombies zombie = collision.gameObject.GetComponent<HerenciaZombies>();
            if (zombie != null)
            {
                zombie.ReduceLife(20);
                Destroy(this.gameObject);
            }
        }
    }
    */
}