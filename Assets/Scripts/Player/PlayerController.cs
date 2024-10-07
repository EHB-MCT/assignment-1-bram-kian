using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  

    private const float DEFAULT_SPEED = 1f;

    private Vector3 movement;      

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector3(horizontal, 0f, vertical).normalized;


        MovePlayer();

    }

    void MovePlayer()
    {
        if (movement.magnitude >= 0.1f)
        {

            transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        }
    }


}