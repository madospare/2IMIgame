using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private GameObject player;
    public float magnetSpeed = 10f;

    public static bool withinRadius = false;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {

        if (AB.magnetON == true && withinRadius == true)
        {
            Vector2 dir = player.transform.position - transform.position;
            transform.Translate(dir.normalized * magnetSpeed * Time.deltaTime, Space.World);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.tag == ("MagnetRadius") && AB.magnetON == true)
        {
            withinRadius = true;
        }

    }

}
