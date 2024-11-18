using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Speed at which the cube will move
    public float moveSpeed = 5f;

    void Update()
    {
        // Get input from the user
        float horizontalInput = Input.GetAxis("Horizontal");  // A/D or Left/Right arrow keys
        float verticalInput = Input.GetAxis("Vertical");      // W/S or Up/Down arrow keys

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        // Move the cube
        transform.Translate(movement);
    }
}
