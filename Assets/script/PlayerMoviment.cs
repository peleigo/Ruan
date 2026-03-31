using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.TextCore.Text;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    private Vector3 moviment;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moviment = new Vector3(horizontal, 0f, vertical);
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        rb.MovePosition(rb.position + moviment * speed * Time.deltaTime);
    }
}
