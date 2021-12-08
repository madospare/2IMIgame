using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private GameObject player;
    public float magnetSpeed = 10f;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {

        if (AB.magnetON == true)
        {
            
                Vector2 dir = player.transform.position - transform.position;
                transform.Translate(dir.normalized * magnetSpeed * Time.deltaTime, Space.World);
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Player"))
        {
            Destroy(gameObject);
        }

    }

}
