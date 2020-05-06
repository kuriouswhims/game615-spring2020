using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public void SceneLoader(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public static void ReloadScene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
    }
}

//create transitions with "Level ____" between each loaded scene
// create GAME OVER / YOU DIED! 