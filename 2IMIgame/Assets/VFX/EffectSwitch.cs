using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSwitch : MonoBehaviour
{

    private GameObject cam;

    void Start()
    {

        cam = GameObject.Find("Main Camera");
        
    }

    void Update()
    {
        
        if (Settings.retroFX == true)
        {
            cam.GetComponent<CRTEffect>().enabled = true;
        } else
        {
            cam.GetComponent<CRTEffect>().enabled = false;
        }

    }

}
