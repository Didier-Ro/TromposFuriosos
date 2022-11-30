using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{

    public void GameScene(String Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }   
}
