using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantZone : MonoBehaviour
{
    BoxCollider2D _compBoxCollider2D;
    public GameManagerControl gameManager;
    public GameObject newPlant = null;

    void Start()
    {
        _compBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void OnMouseDown()
    {
        if (newPlant == null)
        {
            newPlant = Instantiate(gameManager.currentPlant, transform.position, transform.rotation);
            newPlant.GetComponent<Planta>().enabled = false;
            newPlant.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(gameManager.currentPlant);
            gameManager.currentPlant = null;
        }
    }
}
