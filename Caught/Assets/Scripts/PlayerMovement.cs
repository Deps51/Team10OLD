﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; //Creating a buff for speed
    public Rigidbody2D rb; //Rigidbody puts the sprite under the control of the physics engine. Sprite is now affected by gravity, collision with other sprites etc etc
    private Vector2 moveDirection; //Vector to hold the new coodrinates of the sprite

    // Update is called once per frame
    void Update() //Update effected by the frame rate
    {
        ProcessInputs();
        
    }
    void FixedUpdate() // Update uneffected by the framerate
    {
        Move();

    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y  * moveSpeed); 
    }
}