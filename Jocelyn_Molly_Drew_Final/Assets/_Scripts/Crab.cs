using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    private Rigidbody2D crabRb;
    public Animator crabAnim;
    public float crabSpeed = -2f;
    public float minX;
    public float maxX;

    private bool canWalk;
    private bool crabFacingLeft = true;
    
    float crabX;

    // Start is called before the first frame update
    void Start()
    {
        
        crabRb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        crabX = transform.position.x;

        if ((crabX < maxX) && (crabX > minX))
        {
            canWalk = true;
            //Debug.Log("I'm walking here!");
            crabFacingLeft = true;
            crabAnim.SetBool("IsFollowing", true);
            crabRb.AddForce(-transform.right * crabSpeed);
        }

        if ((crabX > maxX) || (crabX < minX))
        {
            canWalk = false;
           // Debug.Log("Need to turn around!");
            crabAnim.SetBool("IsFollowing", false);
            crabRb.AddForce(-transform.right * -crabSpeed);
            FlipCrab();
        }

    }

    private void FlipCrab()
    {
       
        transform.Rotate(0f, 180f, 0f);
        crabFacingLeft = true;
    }
    
}
