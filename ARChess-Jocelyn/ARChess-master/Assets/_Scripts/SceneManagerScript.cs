using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string Choice; 

    void Start()
    {
        DontDestroyOnLoad(gameObject); 
    }

    void Update()
    {
        
    }

    void LoadBlackPlayer()
    {
        Choice = "black";
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

    void LoadWhitePlayer()
    {
        Choice = "white";
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
