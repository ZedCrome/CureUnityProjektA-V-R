using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = !Cursor.visible;
    }


    void Update()
    {
        this.transform.position = Input.mousePosition;
    }
}
