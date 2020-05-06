using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSink : MonoBehaviour
{
    public GameObject stonePillar;
    public Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(0, 11);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Yeet"))
        {
            Destroy(stonePillar.GetComponent<BoxCollider2D>());
            rb.gravityScale = 1f; 
            Debug.Log("wah");
        }
    }
}
