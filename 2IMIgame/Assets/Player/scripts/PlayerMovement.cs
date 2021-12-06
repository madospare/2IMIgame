using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;

    public Rigidbody2D rb;

    public float distance;      // For climbing ladders
    public LayerMask Ladder;
    public bool isClimbing;
    float verticalMove = 0f;

    PhotonView view;

    private void Start()
    {

        view = GetComponent<PhotonView>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (view.IsMine)
        {
            // Player input
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }

    }

    void FixedUpdate()
    {
        
        if (view.IsMine)
        {
            // Move character
            controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
            jump = false;

            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, Ladder);

            if (hitInfo.collider != null)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    isClimbing = true;
                }
            } else
            {
                isClimbing = false;
            }

            if(isClimbing == true && hitInfo.collider != null)
            {
                verticalMove = Input.GetAxisRaw("Vertical");
                rb.velocity = new Vector2(rb.position.x, verticalMove * runSpeed);
                rb.gravityScale = 0;
                runSpeed = 10f;
            } else
            {
                rb.gravityScale = 3;
                runSpeed = 40f;
            }
        }

    }

}
