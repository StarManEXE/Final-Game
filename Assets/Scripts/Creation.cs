using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation : MonoBehaviour
{
    public GameObject cubePrefab; // Prefab for the cube to be created
    public float yOffset = 0.5f; // Offset to position the cube slightly under the player

    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Get the player's position
            Vector3 playerPosition = transform.position;

            // Create the cube slightly under the player
            Instantiate(cubePrefab, playerPosition - Vector3.up * yOffset, Quaternion.identity);
        }
    }
}
