using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private int health;
    private int fullHealth;
    private LastCheckpoint lastCheckpoint;

    public int deaths = 0;

    private void Start()
    {
        lastCheckpoint = GetComponent<LastCheckpoint>();
        fullHealth = 1;
        health = fullHealth;
    }

    private void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        lastCheckpoint.TeleportToLastCheckpoint();
        health = fullHealth;
        deaths++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fireball"))
        {
            TakeDamage(1);
        }
    }
}
