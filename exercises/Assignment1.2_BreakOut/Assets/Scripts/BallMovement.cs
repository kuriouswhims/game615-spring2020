using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public bool lost = true; 
    public KeyCode space;
    public GameObject child;
    public GameObject newParent;
    public int score = 0 ;
    public Text countText;
    public Text livesText;
    public int lives = 5;
    public GameObject gameOverScreen;

    void launchBall()
    {
        lost = false; 
        transform.SetParent(null); 
        
        float forceX = Random.Range(-1f, 1f);
        float forceY = 1f;
        
        //transform.position = new Vector3(0f, 1.2f, 0f);

        Vector3 force = new Vector3(forceX, forceY, 0);
        float magnitude = 600;

        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().AddForce(force * magnitude);
    }
        

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(space) && lost)
        {
            launchBall();
        }

        if(lives <= 0)
        {
            gameOverScreen.SetActive(true);
            transform.position = new Vector3(0f, -3.15f, 0f);
            newParent.transform.position = new Vector3(0f, -3.75f, 0f);
        }
    }

   

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BottomWall")
        {
            lost = true;
            transform.position = new Vector3(0f, -3.15f, 0f);
            newParent.transform.position = new Vector3(0f, -3.75f, 0f);

            child.transform.parent = newParent.transform;

            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);

            lives = lives - 1;
            SetLivesText();
        }

        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
            score = score + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
    }

    void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

}
