using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCheckpoint : MonoBehaviour
{
    public Transform checkpoint;
    private GameObject player;
    private LastCheckpoint playerLastCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject;
            playerLastCheckpoint = player.GetComponent<LastCheckpoint>();
            playerLastCheckpoint.lastCheckpoint = checkpoint;
        }
    }
}
