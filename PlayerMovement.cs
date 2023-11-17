using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed=11f;
    public float RotateSpeed=1.45f;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
   // public float jumpHeight = 3f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
     {
         controller = GetComponent<CharacterController>();
         if (transform != null)
         {
             transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
             var forward = transform.TransformDirection(Vector3.forward);
             float curSpeed = speed * Input.GetAxisRaw("Vertical");
             controller.SimpleMove(forward * curSpeed);
         }
     }




}