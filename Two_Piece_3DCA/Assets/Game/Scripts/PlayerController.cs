using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate movedirection directly from axes
            moveDirection = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}
