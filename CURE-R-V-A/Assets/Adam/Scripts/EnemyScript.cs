using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int healthPoints = 20;

    public float damageRate = 0.2f, nextDamage;

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
    }
}
