using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void LaunchMainScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void LaunchInformationScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LaunchGameScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LaunchHowToPlayScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LaunchCreditsScene()
    {
        SceneManager.LoadScene(4);
    }
    public void LaunchGameOverScene()
    {
        SceneManager.LoadScene(5);
    }
    
    public void LaunchVictoryScene()
    {
        SceneManager.LoadScene(6);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}