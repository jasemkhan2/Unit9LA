using UnityEngine;

public class CubeChangeMaterialOnTouch : MonoBehaviour
{
    // Reference to the Renderer component of the cube
    private Renderer cubeRenderer;

    // Placeholder for the original material of the cube
    public Material originalMaterial;

    // Placeholder for the new material to change to upon collision
    public Material newMaterial;

    void Start()
    {
        // Get the Renderer component attached to the cube
        cubeRenderer = GetComponent<Renderer>();

        // Ensure the renderer is found; otherwise, log an error and disable the script
        if (cubeRenderer == null)
        {
            Debug.LogError("Renderer component not found on the cube object. Disabling the script.");
            enabled = false; // Disable the script to avoid further errors
            return;
        }

        // Set the original material to the cube at the start
        if (originalMaterial != null)
        {
            cubeRenderer.material = originalMaterial;
        }
        else
        {
            Debug.LogError("Original material not assigned. Disabling the script.");
            enabled = false;
            return;
        }
    }

    // This method is called when another collider with a Rigidbody enters this collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided with the cube is the sphere
        if (collision.gameObject.CompareTag("Sphere"))
        {
            // Change the material of the cube to the new material
            if (newMaterial != null)
            {
                cubeRenderer.material = newMaterial;
            }
            else
            {
                Debug.LogError("New material not assigned.");
            }
        }
    }
}