using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    private GameObject key;
    public GameObject player;

    public static bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {

        key = GameObject.FindGameObjectWithTag("Key");
        hasKey = false;

    }

    void Update()
    {
      
        if (Door.doorOpen == true)
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            key.transform.parent = player.transform;
            hasKey = true;
        }

    }

}
