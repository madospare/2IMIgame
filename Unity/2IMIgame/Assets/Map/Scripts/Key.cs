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
        hasKey = false; // Player starts without a key

    }

    void Update()
    {

        // If player no longer has a key, the key will be destroyed
        if (hasKey == false && key.transform.parent == player.transform)
        {
            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        // If player touches a key, the key will become a child of player, and hover above their head
        if (collision.tag == "Player")
        {
            key.transform.parent = player.transform;
            key.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 1.5f);
            hasKey = true;
            FindObjectOfType<AudioManager>().Play("Key");
        }

    }

}
