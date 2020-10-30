using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{
    public int hpText;

    public Text hp;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText = player.GetComponent<Health>().currentHealth;

        hp.text = hpText.ToString() + "/800";
    }
}
