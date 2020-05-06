using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 100;
    public GameObject deathEffect;
    public GameObject yeetedTreasure;

    public void TakeDamage(int enemyDamage)
    {
        enemyHealth -= enemyDamage;

        if (enemyHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Instantiate(yeetedTreasure, transform.position, Quaternion.identity);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water")
        {
            Die();
        }

        if (collision.gameObject.tag == "Yeet")
        {
            Die();
        }
    }
}
