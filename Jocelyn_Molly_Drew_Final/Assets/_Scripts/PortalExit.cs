using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalExit : MonoBehaviour
{
    public BoxCollider2D playerCol;
    public BoxCollider2D ceilingCheck;
    public CapsuleCollider2D collisionCheck;

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(playerCol.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(ceilingCheck.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(collisionCheck.GetComponent<CapsuleCollider2D>(), GetComponent<CapsuleCollider2D>());
    }
}
