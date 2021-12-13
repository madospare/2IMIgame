using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{

    public Text coinsText;

    void Update()
    {

        // Sets the text next to the coin icon in the UI to how many coins the player has collected
        coinsText.text = "x" + PlayerCoins.coins;

    }

}
