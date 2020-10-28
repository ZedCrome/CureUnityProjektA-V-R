using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Health : MonoBehaviour
{
    public GameObject heart;

    public int maxHealth = 100;
    private static int enemyAmount;
    public int currentHealth;

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

        //Debug.Log("Amount of Enemies: " + EnemySpawnManager.amountOfEnemies);

        if (EnemySpawnManager.amountOfEnemies >= 14 && healthTimer < Time.time)
        {
            TakeDamage(1);
            healthTimer = Time.time + damageRate;
        }
    }

    public static void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
