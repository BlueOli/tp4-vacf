using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject fireballPrefab;
    public List<Transform> firePoints = new List<Transform>();
    public float rotationSpeed = 30f;
    public float fireRate = 1f;
    public float fireballSpeed = 10f;

    private float nextFireTime;

    [SerializeField]
    private Vector3 direction;

    void Update()
    {
        // Rotate the enemy gradually
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Check if it's time to shoot
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        foreach(Transform firePoint in firePoints)
        {
            // Instantiate a fireball at the fire point
            GameObject fireball = Instantiate(fireballPrefab, firePoint.position, Quaternion.identity);
            //fireball.transform.parent = this.transform;
            direction = firePoint.position - transform.position;
            fireball.GetComponent<Rigidbody>().velocity = direction.normalized * fireballSpeed;
            // Destroy the fireball after a certain amount of time to prevent clutter
            Destroy(fireball, 3f);
        }        
    }
}
