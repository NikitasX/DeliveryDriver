using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 16f;
    [SerializeField] float slowSpeed = 12f;
    [SerializeField] float boostSpeed = 20f;
    

    void Update()
    {
        float steerAmount = (Input.GetAxis("Horizontal") * steerSpeed) * Time.deltaTime;
        float moveAmount = (Input.GetAxis("Vertical") * moveSpeed) * Time.deltaTime;

        transform.Rotate(0, 0, - steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Speed Up")
        {
            moveSpeed = boostSpeed;
        }    
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
