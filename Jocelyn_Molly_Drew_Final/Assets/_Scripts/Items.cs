using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Items : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI pickUpText;
    public TextMeshProUGUI dropText;
    private bool pickUpAllowed;
    public bool grabbed;
    public Transform holdPoint;
    public Rigidbody2D rb; 
    
    //public BoxCollider2D player;
    //public BoxCollider2D ceilingCheck;

    public GameObject vanishEffect;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
        dropText.gameObject.SetActive(false);
        //Physics2D.IgnoreCollision(player.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreLayerCollision(8, 10);
        Debug.Log("Is This Working");
        //Physics2D.IgnoreCollision(ceilingCheck.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    private void Update()
    {
      if (pickUpAllowed && Input.GetKeyDown(KeyCode.RightShift))
        {
            grabbed = true;

            transform.position = holdPoint.position;
            transform.parent = holdPoint.transform; 
            rb.isKinematic = true;
            pickUpText.gameObject.SetActive(false);
        }
        
        if (grabbed)
        {
            dropText.gameObject.SetActive(true);
        }

        if (grabbed && Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.isKinematic = false;
            holdPoint.transform.DetachChildren();
            grabbed = false;
            dropText.gameObject.SetActive(false);
            Physics2D.IgnoreLayerCollision(8, 10);
            //Physics2D.IgnoreCollision(player.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
            //Physics2D.IgnoreCollision(ceilingCheck.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }

      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("CollisionCheck"))
        {
            //Debug.Log("I'm here, collidin' with Dwayne the Rock");
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("CollisionCheck"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            Instantiate(vanishEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    /*private void PickUp()
    {
        grabbed = true; 
        Destroy(gameObject);
    }*/



}
