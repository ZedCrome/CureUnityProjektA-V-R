using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapScore : MonoBehaviour
{
    public int bodyScore;
    [SerializeField] private GameObject bodyPart;

    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        bodyScore = bodyPart.GetComponent<EnemySpawnManager>().enemyCount;
        scoreText.text = bodyScore.ToString();
    }
}
