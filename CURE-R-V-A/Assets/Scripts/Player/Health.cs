using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Health : MonoBehaviour
{
    public int brainEnemies, heartEnemies, leftLungEnemies, rightLungEnemies, leftHandEnemies, rightHandEnemies, leftFootEnemies, rightFootEnemies, sexOrganEnemies;

    public GameObject[] bodyParts = new GameObject[9];

    public int maxHealth;
    public int currentHealth;

    private float healthTimer;
    private float damageRate = 0.5f;

    public HealthBar healthbar;


    void Start()
    {
        maxHealth = 1000;
        currentHealth = maxHealth;
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

        //if (EnemySpawnManager.amountOfEnemies >= 14 && healthTimer < Time.time)
        //{
        //    TakeDamage(1);
        //    healthTimer = Time.time + damageRate;
        //}

        CheckBodyParts();
        Debug.Log(currentHealth);
    }


     void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }

    void CheckBodyParts()
    {
        for (int i = 0; i < bodyParts.Length; i++)
        {
            if (bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount >= 3 && healthTimer < Time.time)
            {
                TakeDamage(bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount);
                healthTimer = Time.time + damageRate;
            }
            //Debug.Log("Amount of enemies " + bodyParts[i] + " " + bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount);

        }
    }
}
