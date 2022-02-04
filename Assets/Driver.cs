using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100;
    [SerializeField] float moveSpeed = 15;
    [SerializeField] float slowSpeed = 5;
    [SerializeField] float boostSpeed = 25;

    // Update is called once per frame
    void Update()
    {
        float steerInput = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerInput);
        transform.Translate(0, moveInput, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
}
