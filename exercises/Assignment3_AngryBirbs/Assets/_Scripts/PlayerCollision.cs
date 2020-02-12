using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ScoreManager ScoreManager;
    const int TIME_TO_RESET = 3;
    Vector3 originalPosition;
    Transform parent; 

    void Start()
    {
        originalPosition = transform.localPosition;
        parent = transform.parent; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("itfuckinworks");
        Invoke("ResetPlayer", TIME_TO_RESET);

        if (collision.gameObject.tag != "Floor")
        {
            ScoreManager.PlayerOnStructure();
            //Debug.Log("Current Score" + ScoreManager.getScore());
        }
    }

    void ResetPlayer()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
        transform.parent = parent;
        transform.localPosition = originalPosition;
        Camera.main.GetComponent<CameraFollow>().resetCameraPosition();
    }

}
