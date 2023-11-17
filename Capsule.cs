using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] public Transform groundCheckTransform = null;

    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody Rigidbodycomponent;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbodycomponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {

        Rigidbodycomponent.velocity = new Vector3(horizontalInput*5, Rigidbodycomponent.velocity.y, verticalInput * 5);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length == 1)
        {
            return;
        }
        if (jumpKeyWasPressed)
        {
            Rigidbodycomponent.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }
}