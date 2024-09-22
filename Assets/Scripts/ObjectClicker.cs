using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public float force = 5f; // Force to apply when object is clicked

    private void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Perform a raycast from the camera to where the mouse is pointing
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                // If the raycast hits something, and the object has a transform
                if (hit.transform != null)
                {
                    // Try to get the Rigidbody component from the hit object
                    Rigidbody rb = hit.transform.GetComponent<Rigidbody>();

                    if (rb != null)
                    {
                        // Print the name of the clicked object
                        PrintName(hit.transform.gameObject);
                        // Launch the object into the air
                        LaunchIntoAir(rb);
                    }
                }
            }
        }
    }

    // Method to print the name of the clicked object
    private void PrintName(GameObject go)
    {
        Debug.Log("Clicked on object: " + go.name);
    }

    // Method to apply force to the object, launching it into the air
    private void LaunchIntoAir(Rigidbody rig)
    {
        rig.AddForce(rig.transform.up * force, ForceMode.Impulse);
    }
}