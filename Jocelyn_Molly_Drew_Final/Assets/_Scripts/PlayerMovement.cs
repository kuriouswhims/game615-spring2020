using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool playerHasYeet = false; // I think this is something we can use to determine if the player can shoot or not 
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jumpMove = false;
    bool crouchMove = false;

    int jumpCount = 0;

    public Items items;
    public GameObject player;
    public GameObject child; 
    

   //Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //value between -1 and 1 that changes based on user input. Left/A = -1, Right/D = 1.

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); //making horizontal positive with Mathf.Abs function so that the Run animation works both directions


        if (Input.GetButtonDown("Jump"))
        {
            jumpCount++;
            jumpMove = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouchMove = true;
        }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouchMove = false;
            }

       
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

  

    private void FixedUpdate()
    {
        //Move our character using the input we got in Update()
        //first input below = movement, second input = crouch, third input = jump
        //fixedDeltaTime is the amount of time that has passed since this function was last called
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouchMove, jumpMove);

        jumpMove = false;


    }

}
