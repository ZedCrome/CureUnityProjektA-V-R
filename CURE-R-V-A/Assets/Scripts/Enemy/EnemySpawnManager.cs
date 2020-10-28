using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public EnemyScript enemyPrefab;

    public float spawnFrom;
    public float spawnTo;

    [SerializeField] float minSpawnTime;
    [SerializeField] float maxSpawnTime;

    [SerializeField] int maxEnemyNumber = 1, healthPoints = 100, damageLevel = 5;

    float spawnX1, spawnX2, spawnY1, spawnY2, spawnTime, currentTime,
    damageRate = 3, nextDamage;

    public static int amountOfEnemies;

    public int enemyCount;

    public int randomRoof;


    // Start is called before the first frame update
    void Start()
    {
        spawnX1 = transform.localPosition.x - transform.localScale.x/2;
        spawnX2 = transform.localPosition.x + transform.localScale.x/2;
        spawnY1 = transform.localPosition.y - transform.localScale.y/2;
        spawnY2 = transform.localPosition.y + transform.localScale.y/2;
        amountOfEnemies = 0;
        maxEnemyNumber = 15;
        minSpawnTime = 10f;
        maxSpawnTime = 10f;
    }


    // Update is called once per frame
    void Update()
    {
        spawnFrom = Random.Range(spawnX1, spawnX2);
        spawnTo = Random.Range(spawnY1, spawnY2);
    }


    void FixedUpdate()
    {
        EnemyScript[] enemies = FindObjectsOfType<EnemyScript>();

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] == null)
            {
                continue;
            }
        }

        Vector2 randomSpawnPosition = new Vector2(spawnFrom, spawnTo);

        if (currentTime + spawnTime < Time.time && amountOfEnemies < maxEnemyNumber )
        {
            Instantiate(enemyPrefab, randomSpawnPosition, Quaternion.identity);

            currentTime = Time.time;
            SetSpawnTime();

            amountOfEnemies ++;
            enemyCount++;
            Debug.Log(Time.time);
        }
    }


    void SetSpawnTime()
    {
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }


    void TakeDamage()
    {
        if(amountOfEnemies > 0 && amountOfEnemies < damageLevel && Time.time > nextDamage)
        {
            nextDamage = Time.time + damageRate;
            healthPoints --;

            if(amountOfEnemies >= damageLevel)
            {
                damageLevel += 5;
                damageRate -= 0.1f; 
            }
        }
    }
}
