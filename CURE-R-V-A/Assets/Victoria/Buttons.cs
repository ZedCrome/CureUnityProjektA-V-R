using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void LaunchInformationScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LaunchGameScene()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit ();
    }

}