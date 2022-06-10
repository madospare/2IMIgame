using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public static float runSpeed = 40f;

    float horizontalMove = 0f;
    public static bool jump = false;

    private Rigidbody2D rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        runSpeed = 40f;
        rb.gravityScale = 3;

    }

    // Update is called once per frame
    void Update()
    {
     
        // Player input
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        // Jumping animation only when player isn't swimming
        if (jump == true && Water.isSwimming != true)
        {
            animator.SetBool("IsJumping", true);
        }

    }

    // Stop jump animation when player has landed
    public void OnLanding()
    {

        animator.SetBool("IsJumping", false);

    }

    void FixedUpdate()
    {

        // Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

    }

    // For moving platforms
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        // Player will be a child of the platform when in contact with it
        if (collision.collider.tag == "MovingPlatform")
        {
            this.transform.parent = collision.transform;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
        // Player won't be a child of the platform when not in contact with it
        if (collision.collider.tag == "MovingPlatform")
        {
            this.transform.parent = null;
        }

    }

}
