using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private int brainEnemies, heartEnemies, leftLungEnemies, rightLungEnemies, leftHandEnemies, rightHandEnemies, leftFootEnemies, rightFootEnemies, sexOrganEnemies;
    public int chestEnemies;
    [SerializeField] private int maxHealth;
    public int currentHealth;
    public int totalEnemyCount;

    [SerializeField] private float healthTimer;
    [SerializeField] private float damageRate = 1f;

    [SerializeField] private HealthBar healthbar;
    [SerializeField] private GameObject[] bodyParts = new GameObject[9];


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

        chestEnemies = bodyParts[8].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[5].GetComponent<EnemySpawnManager>().enemyCount + bodyParts[6].GetComponent<EnemySpawnManager>().enemyCount;

        if (currentHealth >= 0)
        {
            CheckBodyParts();
        }
        else if (currentHealth <= 0)
        {
            SceneManager.LoadScene(5);
        }

        // Find total enemy count to set HeartBeat Animation speed
        totalEnemyCount = 
        bodyParts[0].GetComponent<EnemySpawnManager>().enemyCount + 
        bodyParts[1].GetComponent<EnemySpawnManager>().enemyCount + 
        bodyParts[2].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[3].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[4].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[5].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[6].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[7].GetComponent<EnemySpawnManager>().enemyCount +
        bodyParts[8].GetComponent<EnemySpawnManager>().enemyCount;
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

            if (bodyParts[i].GetComponent<EnemySpawnManager>().enemyCount >= 1 && healthTimer < Time.time)
            {
                if ((i == 8 || i == 6 || i == 5) && chestEnemies >= 5)
                {
                    TakeDamage(chestEnemies);
                    healthTimer = Time.time + damageRate;
                }
                
                for (int j = 0; j < bodyParts.Length; j++)
                {
                    if (bodyParts[j].GetComponent<EnemySpawnManager>().enemyCount >= 3 && (j != 8 || j != 6 || j != 5))
                    {
                        TakeDamage(bodyParts[j].GetComponent<EnemySpawnManager>().enemyCount);
                        healthTimer = Time.time + damageRate;
                    }
                }
            }           
        }
    }
}
