using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Check for key presses and orient the GameObject accordingly
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Look up (facing right, so rotate -90 degrees)
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // Look down (facing right, so rotate 90 degrees)
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            // Look left (facing right, so rotate 180 degrees)
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // Look right (no rotation needed as it spawns facing right)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}


