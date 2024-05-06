using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastCheckpoint : MonoBehaviour
{
    public Transform lastCheckpoint;

    public void TeleportToLastCheckpoint()
    {
        this.transform.position = lastCheckpoint.position;
    }
}
