using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverMove : MonoBehaviour
{

    public float speed = 1f;
    public int hoverLeftBound;
    public int hoverRightBound;

    void FixedUpdate()
    {

        gameObject.transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0);

        if (transform.position.x > hoverRightBound)
        {
            speed = -speed;
        }
        if (transform.position.x < hoverLeftBound)
        {
            speed = -speed;
        }

    }
}
