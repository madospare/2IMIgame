using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiSolidPlatform : MonoBehaviour
{

    private PlatformEffector2D effector;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {

        effector = GetComponent<PlatformEffector2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Player can go down a platform if down arrow is pressed
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            waitTime = 0.5f;
        }

        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            if (waitTime <= 0)
            {
                effector.rotationalOffset = 180f;
                waitTime = 0.5f;
            }
        } else
        {
            waitTime -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            effector.rotationalOffset = 0;
        }
    
    }
}
