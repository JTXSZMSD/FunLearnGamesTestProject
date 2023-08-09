using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveset : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVector;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveVector.x = 1;
        moveVector.y = 0;
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}
