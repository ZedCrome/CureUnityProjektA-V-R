using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class heartBeat : MonoBehaviour
{
    void HeartBeat()
    {
        GetComponent<AudioSource>().Play();
    }
}
