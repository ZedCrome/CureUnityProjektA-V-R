using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class EKG : MonoBehaviour
{
    void HeartBeat()
    {
        GetComponent<AudioSource>().Play();
    }
}
