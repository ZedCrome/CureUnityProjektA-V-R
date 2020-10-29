using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class heartBeat : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] Animator animator;


    void Update()
    {
        animator.SetInteger("AmountOfEnemies", player.GetComponent<Health>().totalEnemyCount);
    }


    void HeartBeat()
    {
        GetComponent<AudioSource>().Play();
    }
}
