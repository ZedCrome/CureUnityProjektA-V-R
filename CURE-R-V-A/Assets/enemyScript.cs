using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int healthPoints = 20;

    public float damageRate = 0.2f, nextDamage;

    void OnTriggerStay(Collider collision)
    {
        if(collision.tag == "Player")
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
    }
}
