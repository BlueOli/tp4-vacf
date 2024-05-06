using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> gameDoors = new List<GameObject>();
    private List<Door> doors = new List<Door>();

    [SerializeField]
    private GameObject player;

    private GameObject playerCam;

    private GameObject cameraPos;

    [SerializeField]
    public bool isInRoom = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCam = GameObject.FindGameObjectWithTag("MainCamera");
        LoadGameDoors();
        LoadCameraPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadGameDoors()
    {
        foreach (Transform t in transform)
        {
            if (t.CompareTag("Door"))
            {
                gameDoors.Add(t.gameObject);
                doors.Add(t.GetComponent<Door>());
            }
        }
    }

    private void LoadCameraPos()
    {
        foreach (Transform t in transform)
        {
            if (t.CompareTag("CameraPos"))
            {
                cameraPos = t.gameObject;
            }
        }
    }

    public void ChangeCameraPos()
    {
        playerCam.GetComponent<CameraPosSwap>().ChangeCameraPos(cameraPos.transform);
    }

    public void ToogleIsInRoom()
    {
        isInRoom = !isInRoom;
    }
}
