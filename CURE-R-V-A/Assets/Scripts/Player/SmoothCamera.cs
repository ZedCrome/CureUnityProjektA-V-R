using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{

    public Transform player;

    public int zOffset = -10;
    public float smoothSpeed = 0.125f;

    public Vector3 offset;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
