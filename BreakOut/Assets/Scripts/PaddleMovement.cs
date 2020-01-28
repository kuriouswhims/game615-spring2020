using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public float paddleSpeed = 1f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(rightKey) && transform.position.x < 6.50f)
            gameObject.transform.position = new Vector3(transform.position.x + paddleSpeed, transform.position.y, 0);

        if (Input.GetKey(leftKey) && transform.position.x > -6.50f)
            gameObject.transform.position = new Vector3(transform.position.x - paddleSpeed, transform.position.y, 0);
    }
}
