using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerVolume : MonoBehaviour
{
    [SerializeField]
    private GameObject roomA;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomManager roomManagerA = roomA.GetComponent<RoomManager>();

            roomManagerA.isInRoom = true;
            roomManagerA.ChangeCameraPos();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomManager roomManagerA = roomA.GetComponent<RoomManager>();

            roomManagerA.isInRoom = false;
        }
    }
}
