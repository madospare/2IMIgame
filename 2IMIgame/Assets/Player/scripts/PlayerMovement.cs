using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public static float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    private Rigidbody2D rb;

    public float distance;      // For climbing ladders
    public LayerMask Ladder;
    public bool isClimbing;
    float verticalMove = 0f;
    public float climbSpeed = 80f;

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

            verticalMove = Input.GetAxisRaw("Vertical") * climbSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }

            if (jump == true && Water.isSwimming != true)
            {
                animator.SetBool("IsJumping", true);
            }

            if (isClimbing == true)
            {
                animator.SetFloat("Climb", Mathf.Abs(verticalMove));
                animator.SetBool("IsJumping", false);
            }
        }

    public void OnLanding()
    {

        animator.SetBool("IsJumping", false);

    }

    void FixedUpdate()
    {

            // Move character
            controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
            jump = false;

            // For climbing ladders
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, Ladder);

            if (hitInfo.collider != null)
            {
                animator.SetBool("IsJumping", false);
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    isClimbing = true;
                }
            } else
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                {
                    isClimbing = false;
                }
            }

            if (isClimbing == true && hitInfo.collider != null)
            {
                rb.velocity = new Vector2(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime);
                rb.gravityScale = 0;
            } else
            {
                //rb.gravityScale = 3;
            }

    }

}
