using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    private static int enemyAmount; 
    public void DestroyEnemyFunction()
    {
        enemyAmount = EnemySpawnManager.amountOfEnemies;
        enemyAmount--;
        Destroy(transform.parent.gameObject);

    }
}
