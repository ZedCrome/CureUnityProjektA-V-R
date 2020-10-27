using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator animator;

    public int healthPoints = 20;

    public float damageRate = 0.2f, nextDamage;

    float nextBlink, blinkRate, minRate = 0.5f, maxRate = 12f;


    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if(Time.time > nextDamage)
            {
                healthPoints --;

                nextDamage = Time.time + damageRate;
            }
        }

        Debug.Log("Touching Player");
    }

    void Update()
    {
        if(healthPoints < 1)
        {
            Destroy(gameObject);
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
            healthPoints -= 5;
        }
    }

}
