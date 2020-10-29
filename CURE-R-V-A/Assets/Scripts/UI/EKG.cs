using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//Main Author: Robin Lindevy
public class EKG : MonoBehaviour
{
    void HeartBeat()
    {
        GetComponent<AudioSource>().Play();
    }
}
