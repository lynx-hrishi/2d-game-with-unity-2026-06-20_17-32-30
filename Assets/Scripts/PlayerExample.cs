using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello From VS Code");
        // transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float movementSpeed = 4f;
        float x = 0;
        float y = 0;

        if(Input.GetKey(KeyCode.A)) x = -1;
        if(Input.GetKey(KeyCode.D)) x = 1;
        // if(Input.GetKey(KeyCode.W)) y = 1;
        // if(Input.GetKey(KeyCode.S)) y = -1;
        if(Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector2.up * 300);

        rb.linearVelocity = new Vector2(x * movementSpeed, rb.linearVelocity.y);
        // Vector3 movement = new Vector3(x, y, 0);
        // movement.Normalize();
        // transform.position += movement * movementSpeed * Time.deltaTime;
    }


    // void Update()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    //     // Debug.Log("Frame Running");
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Debug.Log("Space Pressed");
    //         // transform.position += Vector3.forward * 5.5f * Time.deltaTime;
    //         rb.AddForce(Vector3.up * 500);
    //     }
    //     else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
    //     {
    //         transform.position += Vector3.up * movementSpeed + Vector3.left * movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
    //     {
    //         transform.position += Vector3.up * movementSpeed + Vector3.left * -movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
    //     {
    //         transform.position += Vector3.up * -movementSpeed + Vector3.left * movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
    //     {
    //         transform.position += Vector3.up * -movementSpeed + Vector3.left * -movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.W))
    //     {
    //         transform.position += Vector3.up * movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.S))
    //     {
    //         transform.position += Vector3.up * -movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.A))
    //     {
    //         transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    //     }
    //     else if (Input.GetKey(KeyCode.D))
    //     {
    //         transform.position += Vector3.left * -movementSpeed * Time.deltaTime;
    //     }

    // }
}
