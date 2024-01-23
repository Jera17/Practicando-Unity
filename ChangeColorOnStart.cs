using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnStart : MonoBehaviour
{
    public Color newColor = Color.red; // You can set the desired color in the Unity Editor

    void Start()
    {
        // Get the renderer component attached to the GameObject
        Renderer renderer = GetComponent<Renderer>();

        // Check if the GameObject has a renderer component
        if (renderer != null)
        {
            // Create a new material instance to avoid modifying the shared material
            Material newMaterial = new Material(renderer.material);

            // Set the color of the new material
            newMaterial.color = newColor;

            // Assign the new material to the renderer
            renderer.material = newMaterial;
        }
        else
        {
            Debug.LogError("Renderer component not found on the GameObject.");
        }
    }
}
