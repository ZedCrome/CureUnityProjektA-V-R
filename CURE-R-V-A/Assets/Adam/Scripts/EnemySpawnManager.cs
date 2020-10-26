using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemies = new GameObject[6];
    public GameObject area = new GameObject();

    public Vector2 spawnFrom = new Vector2();
    public Vector2 spawnTo = new Vector2();

    float spawnX1, spawnX2, spawnY1, spawnY2;

    public int = 


    // Start is called before the first frame update
    void Start()
    {
        spawnX1 = area.transform.position.x - 8f;
        spawnX2 = area.transform.position.x + 8f;
        spawnY1 = area.transform.position.y - 8f;
        spawnY2 = area.transform.position.y + 8f;

        spawnFrom = Vector2(Random.Range(spawnX1, spawnX2));
        spawnTo = Vector2(Random.Range(spawnY1, spawnY2));
    }

    // Update is called once per frame
    void Update()
    {
        int randomSpawn = (int)Random.Range(1, )
    }
}
