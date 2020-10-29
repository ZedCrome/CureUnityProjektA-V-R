using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//Main Author: Robin Lindevy

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private ParticleSystem.EmissionModule emission;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform gun;

    [SerializeField] private float emissionRate;
    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] private float reload = 0f;
    [SerializeField] private float timeSinceLastShot = 1;
    [SerializeField] private float coolDownPeriod = 1f;
    [SerializeField] private float regenTimer = 1;


    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        emission = particleSystem.emission;
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
                emissionRate += 30;
                emission.rateOverTime = emissionRate;

                regenTimer = Time.time + coolDownPeriod;

            }
        }
    }
}
