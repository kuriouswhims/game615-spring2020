using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalactite : MonoBehaviour
{
    public GameObject crushEffect;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Crush();
        }

        if (collision.gameObject.tag == "Player")
        {
            Crush();
        }

        if (collision.gameObject.tag == "Water")
        {
            Crush();
        }

        if (collision.gameObject.tag == "Portal")
        {
            Crush();
        }
    }


    void Crush()
    {
        Instantiate(crushEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
