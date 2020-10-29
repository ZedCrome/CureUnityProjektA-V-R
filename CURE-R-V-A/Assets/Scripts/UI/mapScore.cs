using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Main Author: Robin Lindevy

public class mapScore : MonoBehaviour
{
    [SerializeField] private GameObject bodyPart;

    public int bodyScore;

    public Text scoreText;


    void Update()
    {
        bodyScore = bodyPart.GetComponent<EnemySpawnManager>().enemyCount;
        scoreText.text = bodyScore.ToString();
    }
}
