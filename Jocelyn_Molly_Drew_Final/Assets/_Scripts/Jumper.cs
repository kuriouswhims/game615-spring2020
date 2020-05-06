using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    private Rigidbody2D jumperRb;
    public Animator jumperAnim;
    public float jumpForce = 100f;
    private bool isJumping;

    private void Start()
    {
        isJumping = true;
        jumperRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isJumping == false)
        {
            jumperAnim.SetBool("IsJumping", false);
            jumperRb.AddForce(transform.up * jumpForce);
            isJumping = true;
        }

        if (isJumping == true)
        {
            jumperAnim.SetBool("IsJumping", true);
            //isJumping = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //Debug.Log("I'm done jumping");
            isJumping = false;
        }
        if (collision.gameObject.tag == "Ceiling")
        {
            //Debug.Log("Hit the ceiling!");
            isJumping = true;
        }
    }
}
