using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Main Author: Robin Lindevy
public class ChestScore : MonoBehaviour
{
    [SerializeField] private GameObject bodyPart;
    public int bodyScore;
    public Text scoreText;


    void Update()
    {
        bodyScore = bodyPart.GetComponent<Health>().chestEnemies;
        scoreText.text = bodyScore.ToString();
    }
}
