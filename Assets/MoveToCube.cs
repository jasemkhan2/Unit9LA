using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    // Placeholder for the cube (target) GameObject
    public Transform cube;
    public Transform sphere;

    // Speed at which the sphere will follow the cube
    public float followSpeed = 5f;

    void Update()
    {
        // Move the sphere towards the cube's position
        transform.position = Vector3.MoveTowards(transform.position, cube.position, followSpeed * Time.deltaTime);
    }
}
