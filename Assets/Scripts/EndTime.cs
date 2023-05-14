using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTime : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject cube;
    public float activationTime = 300f; // 5 minutes in seconds

    private float elapsedTime = 0f;
    private bool activated = false;

    private void Update()
    {
        // If not activated, increment elapsed time
        if (!activated)
        {
            elapsedTime += Time.deltaTime;

            // Check if activation time has been reached
            if (elapsedTime >= activationTime)
            {
                // Activate camera and cube
                mainCamera.gameObject.SetActive(true);
                cube.SetActive(true);
                activated = true;
            }
        }
    }
}
