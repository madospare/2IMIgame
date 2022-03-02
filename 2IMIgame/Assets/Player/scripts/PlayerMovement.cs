using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    private Rigidbody2D rb;

    public float distance;      // For climbing ladders
    public LayerMask Ladder;
    public bool isClimbing;
    float verticalMove = 0f;
    public float climbSpeed = 80f;

    PhotonView view;

    private void Start()
    {

        view = GetComponent<PhotonView>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        // This code applies only if input is from local player, and not other players
        if (view.IsMine)
        {
            // Player input
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }

            if (jump == true)
            {
                animator.SetBool("IsJumping", true);
            }
        }

    }

    public void OnLanding()
    {

        animator.SetBool("IsJumping", false);
        animator.SetBool("IsClimbing", false);

    }

    void FixedUpdate()
    {

        // This code applies only if input is from local player, and not other players
        if (view.IsMine)
        {
            // Move character
            controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
            jump = false;

            // For climbing ladders
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, Ladder);

            if (hitInfo.collider != null)
            {
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
                verticalMove = Input.GetAxisRaw("Vertical") * climbSpeed;
                animator.SetFloat("Climb", verticalMove);
                rb.velocity = new Vector2(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime);
                rb.gravityScale = 0;
            } else
            {
                rb.gravityScale = 3;
            }
        }

    }

}
