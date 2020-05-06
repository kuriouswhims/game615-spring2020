using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpKill : MonoBehaviour
{
    public GameObject enemy;
    public GameObject deathEffect;
    public GameObject yeetItem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(enemy);
            Instantiate(yeetItem, transform.position, Quaternion.identity);
        }
    }
}
