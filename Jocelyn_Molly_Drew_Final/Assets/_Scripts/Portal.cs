using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject destinationPortal;
    public GameObject player;

    public Transform playerPos;
    public Transform exitPoint;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            player.transform.position = new Vector2(exitPoint.position.x, exitPoint.position.y);
            
        }
    }
}
