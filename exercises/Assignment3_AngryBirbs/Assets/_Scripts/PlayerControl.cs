using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public float power = 50f;
    private Rigidbody2D playerBody;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
        playerBody.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition.x + "" + Input.mousePosition.y);
        
        Vector3 mouseInWorld = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)); //camera position based on mouse location
        Vector3 direction = mouseInWorld - transform.position;
        float cosAlpha = Vector3.Dot(Vector3.right, direction.normalized); //cos of alpha
        float alpha = Mathf.Acos(cosAlpha); //what the fuuuuuuck ahhhhhhh

        transform.rotation = Quaternion.Euler(0, 0, alpha*Mathf.Rad2Deg); //rotates cannon around the z axis by alpha, rad2deg converts radians to degrees

        if(Input.GetButtonDown("Fire1"))
        {
            player.transform.parent = null; //remove parent 
            playerBody.gravityScale = 1;
            playerBody.AddForce(direction*power); //add force to player, from cannon
        }

        //Debug.Log(mouseInWorld);
    }
}
