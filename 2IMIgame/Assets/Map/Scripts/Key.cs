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

        key = this.gameObject;
        hasKey = false;

    }

    void Update()
    {

        if (hasKey == false && key.transform.parent == player.transform)
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {
            key.transform.parent = player.transform;
            key.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 1.5f);
            hasKey = true;
            FindObjectOfType<AudioManager>().Play("Key");
        }

    }

}
