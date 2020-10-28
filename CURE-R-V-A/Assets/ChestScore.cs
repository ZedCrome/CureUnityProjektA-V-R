using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestScore : MonoBehaviour
{
    public int bodyScore;
    [SerializeField] private GameObject bodyPart;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bodyScore = bodyPart.GetComponent<Health>().chestEnemies;
        scoreText.text = bodyScore.ToString();
    }
}
