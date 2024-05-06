using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbsorbGhost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ghost"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
