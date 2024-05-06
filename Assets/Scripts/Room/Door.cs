using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private GameObject roomA;

    [SerializeField]
    private GameObject roomB;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RoomManager roomManagerA = roomA.GetComponent<RoomManager>();

            roomManagerA.ToogleIsInRoom();
            if (roomManagerA.isInRoom)
            {
                roomManagerA.ChangeCameraPos();
            }

            RoomManager roomManagerB = roomB.GetComponent<RoomManager>();

            roomManagerB.ToogleIsInRoom();
            if (roomManagerB.isInRoom)
            {
                roomManagerB.ChangeCameraPos();
            }
        }
    }
}