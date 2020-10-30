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

        if (Input.GetKeyDown(KeyCode.T))
        {
            timeRemaining = 3;
        }
    }
}
