using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public void DestroyEnemyFunction()
    {
        Destroy(transform.parent.gameObject);

        Debug.Log("Destroying Enemy");
    }
}
