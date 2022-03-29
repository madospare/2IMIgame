using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{

    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;
    public GameObject tutorial4;
    public GameObject tutorial5;
    public GameObject tutorial6;
    public GameObject tutorial7;
    public GameObject tutorial8;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        tutorial1.SetActive(true);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
        tutorial6.SetActive(false);
        tutorial7.SetActive(false);
        tutorial8.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.transform.position.x > 13.39f)
        {
            tutorial1.SetActive(false);
            tutorial2.SetActive(true);
        }

        if (player.transform.position.x > 23.51f)
        {
            tutorial2.SetActive(false);
            tutorial3.SetActive(true);
        }

        if (player.transform.position.x > 38.96f)
        {
            tutorial3.SetActive(false);
        }

        if (player.transform.position.x > 42.33f)
        {
            tutorial4.SetActive(true);
        }

        if (player.transform.position.x > 52.06f)
        {
            tutorial5.SetActive(true);
        }

        if (player.transform.position.x > 62.02f)
        {
            tutorial4.SetActive(false);
            tutorial5.SetActive(false);
            tutorial6.SetActive(true);
        }

        if (player.transform.position.x > 64.79f && player.transform.position.y < -4.76f)
        {
            tutorial7.SetActive(true);
        } 

        if (player.transform.position.x > 86.22f)
        {
            tutorial6.SetActive(false);
            tutorial7.SetActive(false);
            tutorial8.SetActive(true);
        }

    }
}
