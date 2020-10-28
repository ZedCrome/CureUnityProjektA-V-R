using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class heartBeat : MonoBehaviour
{
    public GameObject player;

    public Animator animator;


    void Update()
    {
        animator.SetInteger("AmountOfEnemies", player.GetComponent<Health>().totalEnemyCount);
    }


    void HeartBeat()
    {
        GetComponent<AudioSource>().Play();
    }
}
