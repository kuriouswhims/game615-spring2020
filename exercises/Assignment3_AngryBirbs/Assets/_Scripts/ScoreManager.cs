using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    const int STRUCTURE_HIT_POINT = 1;
    const int PLAYER_HIT_STRUCTURE_POINT = 5;
    const int CUPCAKE_HIT_POINT = 10;
    int score = 0;
    public Text scoreText;

    public int getScore()
    {
        return score;
    }
    
    public void StructureOnStructure()
    {
        score = score + STRUCTURE_HIT_POINT;
        SetScoreText();
    }

    public void PlayerOnStructure()
    {
        score = score + PLAYER_HIT_STRUCTURE_POINT;
        SetScoreText();
    }

    public void PlayerOnCupcake()
    {
        score = score + CUPCAKE_HIT_POINT;
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
