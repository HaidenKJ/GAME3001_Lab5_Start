using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Check for key presses and move the GameObject accordingly
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Move up (facing right, so move along the positive Y-axis)
            transform.position += Vector3.up * moveSpeed;
            // Rotate to face up (90 degrees)
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // Move down (facing right, so move along the negative Y-axis)
            transform.position += Vector3.down * moveSpeed;
            // Rotate to face down (-90 degrees)
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            // Move left (facing right, so move along the negative X-axis)
            transform.position += Vector3.left * moveSpeed;
            // Rotate to face left (180 degrees)
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // Move right (facing right, so move along the positive X-axis)
            transform.position += Vector3.right * moveSpeed;
            // Rotate to face right (no rotation needed)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}


