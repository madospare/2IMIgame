using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public Text livesText;

    void Update()
    {

        livesText.text = "x" + PlayerHealth.health;

    }

}
