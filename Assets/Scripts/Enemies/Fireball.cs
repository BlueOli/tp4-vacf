using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the fireball collides with a wall or a player
        if (collision.gameObject.CompareTag("Scenario") || collision.gameObject.CompareTag("Player")
             || collision.gameObject.CompareTag("Fireball") || collision.gameObject.CompareTag("Turret"))
        {
            // Destroy the fireball
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            // Destroy the fireball
            Destroy(gameObject);
        }
    }
}
