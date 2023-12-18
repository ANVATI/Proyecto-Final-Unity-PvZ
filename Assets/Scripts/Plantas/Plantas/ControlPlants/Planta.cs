using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta : MonoBehaviour
{
    BoxCollider2D _comBoxCollider2D;
    private void Awake()
    {
        _comBoxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector2 truePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = truePosition;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}