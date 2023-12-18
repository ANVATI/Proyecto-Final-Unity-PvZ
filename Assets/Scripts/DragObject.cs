using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Collider2D _compCollider;
    private Camera cam;
    private bool _isDragging = false;

    void Awake()
    {
        _compCollider = GetComponent<Collider2D>();
    }
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Collider2D collider = Physics2D.OverlapPoint(mousePos);
            if (collider == _compCollider)
            {
                _isDragging = true;
                
            }
            if (_isDragging)
            {
                transform.position = mousePos;
            }
        }
        else
        {
            _isDragging = false;
        }
    }
}
