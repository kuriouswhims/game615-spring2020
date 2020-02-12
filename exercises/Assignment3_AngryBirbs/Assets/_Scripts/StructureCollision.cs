using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureCollision : MonoBehaviour
{
    public ScoreManager ScoreManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "Floor")
        {
            ScoreManager.StructureOnStructure();
            Debug.Log("Current Score" + ScoreManager.getScore());
        }
    }
}
