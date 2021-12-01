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
        }

    }

}
