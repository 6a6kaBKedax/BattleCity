using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managment : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput;
    }
}
