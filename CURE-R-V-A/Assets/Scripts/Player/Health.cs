using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Health : MonoBehaviour
{
    public GameObject heart;

    public int maxHealth = 100;
    public int currentHealth;
    private static int enemyAmount;

    private float healthTimer;
    private float damageRate = 0.5f;

    public HealthBar healthbar;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        enemyAmount = EnemySpawnManager.amountOfEnemies;
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(20);
        //}
        Debug.Log(enemyAmount);

        if (enemyAmount >= 14 && healthTimer < Time.time + healthTimer)
        {
            TakeDamage(1);
            healthTimer = Time.time + healthTimer;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
