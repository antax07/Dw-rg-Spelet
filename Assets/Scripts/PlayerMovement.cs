using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f; 
    public float rotationSpeed = 100.0f; 
    public float jumpForce = 5.0f; 
    public LayerMask groundLayers; 
    public Transform groundCheck; 
    public float groundCheckRadius = 0.2f; 

    private Rigidbody rb;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = get
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
