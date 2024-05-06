using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPositionCheck : MonoBehaviour
{
    private void Start()
    {
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity);
        foreach(Collider other in hitColliders)
        {
            if (other.CompareTag("Ghost") || other.CompareTag("Turret"))
            {
                if (other.transform != this.transform)
                {
                    List<GameObject> ghostList = new List<GameObject>();
                    ghostList = this.GetComponent<GhostSpawner>().SpawnGhosts();
                    foreach (GameObject ghost in ghostList)
                    {
                        ghost.transform.parent = transform.parent;
                    }
                    Destroy(this.gameObject);
                    Debug.Log("Done cloning from hitting: " + other.gameObject.name);
                }
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ghost") || other.CompareTag("Turret"))
        {
            if (other.transform != this.transform)
            {
                List<GameObject> ghostList = new List<GameObject>();
                ghostList = this.GetComponent<GhostSpawner>().SpawnGhosts();
                foreach (GameObject ghost in ghostList)
                {
                    ghost.transform.parent = transform.parent;
                }
                Destroy(this);
                Debug.Log("Done cloning");
            }            
        }
    }
}
