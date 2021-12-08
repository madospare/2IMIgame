using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public static GameObject radius;
    public static bool magnetON = false;
    public float timer = 40f;

    void Start()
    {

        radius = GameObject.FindGameObjectWithTag("MagnetRadius");
        radius.SetActive(false);

    }

    void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            radius.SetActive(false);
            magnetON = false;
            Coin.withinRadius = false;
            Abilities.magnet = false;
        }
    }

    public void Ab_AttractCoins()
    {

        radius.SetActive(true);
        magnetON = true;

    }

}
