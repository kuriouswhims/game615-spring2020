using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{
    public float speed = 1f;
    public int elevatorBottom;
    public int elevatorTop; 

    private void Start()
    {

    }

    void FixedUpdate()
    {

        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + speed, 0);

        if (transform.position.y > elevatorTop)
        {
            speed = -speed;
        }
        if(transform.position.y < elevatorBottom)
        {
            speed = -speed;
        }

    }

}
