using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public Transform gun;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = bulletPrefab.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bulletPrefab, gun.position, gun.rotation);

            //rb2d.AddForce(gun.up * bulletSpeed, ForceMode2D.Impulse);
            rb2d.velocity = gun.transform.up * bulletSpeed;

        }
    }
}
