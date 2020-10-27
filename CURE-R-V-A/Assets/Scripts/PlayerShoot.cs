using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;

    [SerializeField] private ParticleSystem.EmissionModule emission;

    [SerializeField] private float emissionRate;

    public Transform gun;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float reload = 0f;
    public float timeSinceLastShot = 1;
    public float coolDownPeriod = 1f;
    public float regenTimer = 1;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = bulletPrefab.GetComponent<Rigidbody2D>();
        ps = GetComponent<ParticleSystem>();
        emission = ps.emission;
    }

    void LateUpdate()
    {
        Shoot();
        RegenBody();
    }

    void Shoot()
    {
        if (Input.GetButton("Fire1") && reload <= Time.time)
        {

            reload = Time.time + coolDownPeriod;
            timeSinceLastShot = Time.time + coolDownPeriod;

            emissionRate = emission.rateOverTime.constant;


            if (emissionRate > 50)
            {
                emissionRate = emissionRate - 15;
                emission.rateOverTime = emissionRate;
                Debug.Log(emissionRate);

                GameObject newBullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
                newBullet.GetComponent<Rigidbody2D>().velocity = gun.transform.up * bulletSpeed;
            } 
        }
    }

    void RegenBody()
    {
        if (timeSinceLastShot <= Time.time && emissionRate < 799)
        {
            emissionRate = emission.rateOverTime.constant;

            if (regenTimer < Time.time)
            {
                emissionRate += 20;
                emission.rateOverTime = emissionRate;

                regenTimer = Time.time + coolDownPeriod;

            }
        }
    }
}
