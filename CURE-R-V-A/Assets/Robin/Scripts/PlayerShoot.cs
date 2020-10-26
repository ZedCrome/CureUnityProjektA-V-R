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
    public float coolDownPeriod = 1f;
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
    }

    void Shoot()
    {
        if (Input.GetButton("Fire1") && reload <= Time.time)
        {

            GameObject newBullet = Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().velocity = gun.transform.up * bulletSpeed;

            reload = Time.time + coolDownPeriod;

            emissionRate = emission.rateOverTime.constant;
            emissionRate--;
            emission.rateOverTime = emissionRate;
            Debug.Log(emissionRate);
        }
    }
}
