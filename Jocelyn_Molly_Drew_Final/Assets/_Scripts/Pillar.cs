using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public GameObject faceUnlit;
    public GameObject faceLit;
    public BoxCollider2D player;
    public BoxCollider2D ceilingCheck;
    public CapsuleCollider2D collisionCheck;


    private void Start()
    {
        
    }

    private void Update()
    {
        Physics2D.IgnoreCollision(player.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(ceilingCheck.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(collisionCheck.GetComponent<CapsuleCollider2D>(), GetComponent<CapsuleCollider2D>());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Yeet"))
        {
            faceLit.SetActive(true);
            faceUnlit.SetActive(false);
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Yeet"))
        {
            faceLit.SetActive(false);
            faceUnlit.SetActive(true);
        }
    }
}
