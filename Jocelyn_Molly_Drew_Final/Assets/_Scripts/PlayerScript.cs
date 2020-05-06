using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    const int MAX_PLAYER_HEALTH = 10;
    int playerHealth = MAX_PLAYER_HEALTH;
    public Animator animator;
    public GameObject deathEffect;
    public AudioClip collideSound;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(playerHealth);
    }
    

    public void OnCollisionEnter2D(Collision2D collision) 
    {
        //reloads the scene if the player falls in the water
        if (collision.gameObject.tag == "Water")
        {
            Debug.Log("I've hit the water!");
            animator.SetBool("IsHurt", true);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            healthBar.SetHealth(0);
            GetComponent<AudioSource>().PlayOneShot(collideSound, 1F);
            StartCoroutine(WaitForTime(0.5f));
        }

        //enemy collisions
        if (collision.gameObject.tag == "Octopus")
        {
            Debug.Log("Anything but the tentacles!");
            animator.SetBool("IsHurt", true);
            playerHealth--;
            healthBar.SetHealth(playerHealth);
            
        }

        if (collision.gameObject.tag == "Jumper")
        {
            Debug.Log("I hate spiders!");
            animator.SetBool("IsHurt", true);
            playerHealth--;
            healthBar.SetHealth(playerHealth);
        }

        if (collision.gameObject.tag == "Crab")
        {
            Debug.Log("Krusty Krab Pizza... is the Pizza... for you and me.");
            animator.SetBool("IsHurt", true);
            playerHealth--;
            healthBar.SetHealth(playerHealth);
        }

        if (collision.gameObject.tag == "Stalactite")
        {
            Debug.Log("Too sharp!");
            animator.SetBool("IsHurt", true);
            playerHealth--;
            healthBar.SetHealth(playerHealth);
        }
    }

    public void playWalkSound()
    {
        //GetComponent<AudioSource>().PlayOneShot();
    }

    void Update()
    {
        if (playerHealth < 1)
        {
            //spawn code here
            LoadScene.ReloadScene();
        }

    }

    private void FixedUpdate()
    {
        animator.SetBool("IsHurt", false);
    }

    IEnumerator WaitForTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        LoadScene.ReloadScene();
    }

}
