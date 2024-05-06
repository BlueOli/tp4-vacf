using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameBox : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Text endText;

    // Start is called before the first frame update
    void Start()
    {
        Damage damage = player.GetComponent<Damage>();

        int deathCount = damage.deaths;

        endText.text = "You have reached the fountain of power!" +
                        "\n\nIt only took you " + deathCount + " deaths." +
                        "\n\nYou may become the Villain of this castle once more.";
    }
}
