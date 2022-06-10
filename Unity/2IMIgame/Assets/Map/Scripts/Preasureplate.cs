using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preasureplate : MonoBehaviour
{

    public GameObject door;
    public float unlockTimer = 0.2f;
    bool platePressed = false;

    void Start()
    {

        gameObject.transform.localScale = new Vector2(transform.localScale.x, 11.7f);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        platePressed = false;

    }

    void Update()
    {

        if (platePressed == true)
        {
            unlockTimer -= Time.deltaTime;

            if (unlockTimer < 0)
            {
                FindObjectOfType<AudioManager>().Play("Door");
                Destroy(door);
                platePressed = false;

                unlockTimer = 0.2f;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "Player")
        {
            platePressed = true;
            gameObject.transform.localScale = new Vector2(transform.localScale.x, 3.3f);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            FindObjectOfType<AudioManager>().Play("ButtonClick");
        }

    }

}
