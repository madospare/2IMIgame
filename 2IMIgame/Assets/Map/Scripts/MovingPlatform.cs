using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    Rigidbody2D rb;

    public bool isVertical = false;

    public float speed = 0.8f;
    public float range = 3;

    float startingX;
    float startingY;
    int dir = 1;

    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();

        startingX = transform.position.x;
        startingY = transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (isVertical == true)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
            if (transform.position.y < startingY || transform.position.y > startingY + range)
                dir *= -1;
        } else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime * dir);
            if (transform.position.x < startingX || transform.position.x > startingX + range)
                dir *= -1;
        }

    }

}
