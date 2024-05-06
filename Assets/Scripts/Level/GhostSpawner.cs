using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    public GameObject floor; // Reference to the floor GameObject
    public GameObject ghostPrefab; // Reference to the ghost prefab
    public int numberOfGhostsToSpawn = 5; // Number of ghosts to spawn=

    public List<GameObject> SpawnGhosts()
    {
        List<GameObject> ghosts = new List<GameObject>();

        // Get the bounds of the floor area
        Bounds floorBounds = floor.GetComponent<Renderer>().bounds;

        for (int i = 0; i < numberOfGhostsToSpawn; i++)
        {
            // Calculate a random position within the floor area
            float randomX = Random.Range(floorBounds.min.x + 2, floorBounds.max.x - 2);
            float randomZ = Random.Range(floorBounds.min.z + 2, floorBounds.max.z - 2);
            Vector3 spawnPosition = new Vector3(randomX, 0, randomZ);

            // Spawn the ghost prefab at the random position
            GameObject tempGhost = Instantiate(ghostPrefab, spawnPosition, Quaternion.identity);

            tempGhost.GetComponent<GhostSpawner>().floor = floor;
            tempGhost.GetComponent<GhostSpawner>().ghostPrefab = ghostPrefab;
            tempGhost.GetComponent<GhostSpawner>().numberOfGhostsToSpawn = 1;
            tempGhost.transform.parent = this.transform;

            ghosts.Add(tempGhost);
        }

        return ghosts;
    }
}
