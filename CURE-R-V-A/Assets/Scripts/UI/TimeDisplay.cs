using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public float timeRemaining = 181f;
    public float currentTime;
    public float second = 1;

    [SerializeField] private GameObject scoreDisplay;
    public Text displayText;


    // Update is called once per frame
    void Update()
    {
        if (currentTime < Time.time)
        {
            timeRemaining--;

            currentTime = Time.time + second;
        }

        displayText.text = "Time remaining: " + timeRemaining.ToString();
    }
}
