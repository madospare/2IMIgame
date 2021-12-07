using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsUI : MonoBehaviour
{

    public Text coinsText;

    void Update()
    {

        coinsText.text = "x" + PlayerCoins.coins;

    }

}
