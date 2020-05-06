using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public BoxCollider2D player;
    public BoxCollider2D ceilingCheck;
    public CapsuleCollider2D collisionCheck;
    public BoxCollider2D stoneBox;
    public CircleCollider2D stoneTrigger;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
       
    }

    private void Update()
    {
        Physics2D.IgnoreCollision(player.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(ceilingCheck.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(collisionCheck.GetComponent<CapsuleCollider2D>(), GetComponent<CapsuleCollider2D>());
        Physics2D.IgnoreCollision(stoneBox.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(stoneTrigger.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
