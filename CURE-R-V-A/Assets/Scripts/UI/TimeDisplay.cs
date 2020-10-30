using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//main Author: Robin Lindevy

public class TimeDisplay : MonoBehaviour
{
    public float timeRemaining = 20f;
    public float currentTime;
    public float second = 1;

    [SerializeField] private GameObject scoreDisplay;
    public Text displayText;
    public Text pauseText;

    bool pause = false;


    void Update()
    {
        if (currentTime < Time.time)
        {
            timeRemaining--;

            currentTime = Time.time + second;
        }
        displayText.text = "Time remaining: " + timeRemaining.ToString();

        if (timeRemaining <= 0)
        {
            SceneManager.LoadScene(6);
        }

        PauseGame();
    }


    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pause)
        {
            pause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pause)
        {
            pause = false;
        }

        if (pause)
        {
            Time.timeScale = 0;

            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            
            Cursor.visible = false;
        }

        if (Time.timeScale == 0)
        {
            pauseText.text = "Game is Paused";
        }
        else
        {
            pauseText.text = "";
        }
    }
}
