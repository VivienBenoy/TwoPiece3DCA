using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerController : MonoBehaviour
    {
        public float speed = 5.0f;
        public float jumpSpeed = 8.0f;
        public float gravity = 20.0f;
        public float turnSmoothTime = 0.1f;
        public float turnSmoothVelocity;

        private CharacterController controller;
        public Transform cam;
        private Vector3 moveDirection = Vector3.zero;

        void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(horizontal, 0, vertical);
                if (moveDirection.magnitude >= 0.1f)
                {
                    float targetangle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
                    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnSmoothVelocity, turnSmoothTime);
                    transform.rotation = Quaternion.Euler(0f, angle, 0f);

                    Vector3 moveDir = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward;
                    controller.Move(moveDir.normalized * speed * Time.deltaTime);
                }

                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }
            }

            moveDirection.y -= gravity * Time.deltaTime;

            controller.Move(moveDirection * Time.deltaTime);
        }
    }

