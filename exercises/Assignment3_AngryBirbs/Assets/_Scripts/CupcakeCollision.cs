using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupcakeCollision : MonoBehaviour
{
    public ScoreManager ScoreManager;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "Floor")
        {
            ScoreManager.PlayerOnCupcake();
            Debug.Log("Current Score" + ScoreManager.getScore());
        }
    }

}
