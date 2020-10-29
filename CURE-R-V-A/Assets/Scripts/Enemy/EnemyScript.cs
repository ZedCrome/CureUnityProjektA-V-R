using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    CircleCollider2D collider;

    public EnemySpawnManager enemySpawnManager;

    Animator animator;

    public int healthPoints = 20;

    public float damageRate = 0.2f, nextDamage;

    float nextBlink, blinkRate, minRate = 0.5f, maxRate = 12f;

    bool isDead = false;


    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        collider = GetComponent<CircleCollider2D>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if(Time.time > nextDamage)
            {
                healthPoints -= 3;

                nextDamage = Time.time + damageRate;
            }
        }
    }

    void Update()
    {
        if(healthPoints < 1 && !isDead)
        {
            animator.SetTrigger("Disappearing");

            EnemySpawnManager.amountOfEnemies --;
            enemySpawnManager.enemyCount--;

            //disables Collider
            collider.enabled = !collider.enabled;
            

            //Debug.Log("AmountOfEnemies: " + EnemySpawnManager.amountOfEnemies);

            isDead = true;
        }

        

        if(Time.time >= nextBlink)
        {
            blinkRate = Random.Range(minRate, maxRate);

            animator.SetTrigger("Blink");
            //animator.ResetTrigger("Blink");

            nextBlink = Time.time + blinkRate;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            healthPoints -= 10;
        }
    }

}
