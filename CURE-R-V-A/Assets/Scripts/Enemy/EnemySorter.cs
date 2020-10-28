using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySorter : MonoBehaviour
{
    public int brainEnemies, heartEnemies, leftLungEnemies, rightLungEnemies, leftHandEnemies, rightHandEnemies, leftFootEnemies, rightFootEnemies, sexOrganEnemies;

    public GameObject[] bodyParts = new GameObject[9];

    void Start()
    {
        
    }


    void Update()
    {
        rightHandEnemies = bodyParts[0].GetComponent<EnemySpawnManager>().enemyCount;
        leftHandEnemies = bodyParts[1].GetComponent<EnemySpawnManager>().enemyCount;
        brainEnemies = bodyParts[2].GetComponent<EnemySpawnManager>().enemyCount;
        leftFootEnemies = bodyParts[3].GetComponent<EnemySpawnManager>().enemyCount;
        rightFootEnemies = bodyParts[4].GetComponent<EnemySpawnManager>().enemyCount;
        leftLungEnemies = bodyParts[5].GetComponent<EnemySpawnManager>().enemyCount;
        rightLungEnemies = bodyParts[6].GetComponent<EnemySpawnManager>().enemyCount;
        sexOrganEnemies = bodyParts[7].GetComponent<EnemySpawnManager>().enemyCount;
        heartEnemies = bodyParts[8].GetComponent<EnemySpawnManager>().enemyCount;

        CheckBodyParts();
    }


    void CheckBodyParts()
    {
        for (int i = 0; i < bodyParts.Length; i++)
        {

            if (bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount >= 3)
            {
                Health.TakeDamage();
            }
            Debug.Log("Amount of enemies " + bodyParts[i] + " " + bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount);
        }
    }



}
