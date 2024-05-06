using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> ghosts = new List<GameObject>();

    [SerializeField]
    private GameObject door;

    private GameObject player;

    [SerializeField]
    private GhostSpawner spawner;

    [SerializeField]
    private int manyGhosts = 1;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawner.numberOfGhostsToSpawn = manyGhosts;
        spawner.SpawnGhosts();

        foreach (Transform t in transform)
        {
            if (t.CompareTag("Ghost"))
            {
                ghosts.Add(t.gameObject);
            }
        }
    }

    private void Update()
    {
        if(door.activeSelf! && CheckLevelComplete())
        {
            OpenDoor();
        }
    }

    private bool CheckLevelComplete()
    {
        ghosts.Clear();

        foreach (Transform t in transform)
        {
            if (t.CompareTag("Ghost"))
            {
                ghosts.Add(t.gameObject);
            }
        }

        bool isRoomCompleted = true;

        if (ghosts.Count > 0)
        {
            foreach (GameObject ghost in ghosts)
            {
                if (ghost.activeSelf)
                {
                    isRoomCompleted = false;
                }
            }
        }

        return isRoomCompleted;
    }

    private void OpenDoor()
    {
        door.SetActive(false);
    }
}
