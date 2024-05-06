using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosSwap : MonoBehaviour
{
    [SerializeField]
    private Camera playerCam;

    [SerializeField]
    private Transform newCameraPos;

    private void Start()
    {
        playerCam = GetComponent<Camera>();
    }

    public void ChangeCameraPos(Transform t)
    {
        SetNewCameraPost(t);
        playerCam.transform.position = newCameraPos.position;
    }

    private void SetNewCameraPost (Transform t)
    {
        newCameraPos = t;
    }
}
