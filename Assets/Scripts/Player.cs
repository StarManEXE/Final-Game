using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Camera Info")]
    public Camera playerCam;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    private float rotationX;

    private Vector3 startingPosition;

    public float jumpPower;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        startingPosition = this.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //if grounded = true{ } 
        if (Input.GetKey(KeyCode.W))
        {
            //jumpPower += 0.1f;
            Vector3 jumpForce = playerCam.transform.forward;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 jumpForce = playerCam.transform.forward;
            jumpForce = jumpForce * jumpPower;
            rb.AddForce(jumpForce, ForceMode.Impulse);
            jumpPower = 0.5f;
        }


        UpdateCursorVisibility();
        RotatePlayerFromInput();
    }

    private void RotatePlayerFromInput()
    {
        rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
        rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
        playerCam.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
    }

    private void UpdateCursorVisibility()
    {
        //Unlock the cursor if you hit escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //lock cursor on left mouse click
        if (Input.GetMouseButton(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
