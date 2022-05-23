using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody2D rgb2d;
    private Vector3 moveDirection;

    void Awake()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
        }
    
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1;
        }

        moveDirection = new Vector3(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        rgb2d.velocity = moveDirection;
    }
}
