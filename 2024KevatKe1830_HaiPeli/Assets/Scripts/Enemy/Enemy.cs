using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float currentSpeed = 3f;
    private Rigidbody2D body;
    public Transform playerTransform;


    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if(playerTransform == null)
        {
            return;
        }

        Vector2 direction = (playerTransform.position - transform.position).normalized;
        body.MovePosition(body.position + direction * currentSpeed * Time.fixedDeltaTime);
    }
}
