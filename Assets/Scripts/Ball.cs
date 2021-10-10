﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private bool isPressed = false;
    public float speed;
    public float currentScore;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void PushBall()
    {
        if (isPressed) return;

        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var force = mouseWorld - transform.position;
            force.z = 0;
            rigidBody2D.velocity = force.normalized * speed;
        }
    }

    private void Update()
    {
        PushBall();
    }
}
