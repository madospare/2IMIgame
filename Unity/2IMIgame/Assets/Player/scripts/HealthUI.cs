using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public Text livesText;

    void Update()
    {

        // The text next to the heart icon in the UI will show the number of lives the player has
        livesText.text = "x" + PlayerHealth.health;

    }

}
