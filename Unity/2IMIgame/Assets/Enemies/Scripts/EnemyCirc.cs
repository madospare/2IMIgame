using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCirc : MonoBehaviour
{

    public float speed = 0.8f;
    public float range = 3;

    float startingY;
    int dir = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y; // Startposition is set to wherever the object is
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Makes the enemy move vertically back and forth
        transform.Translate(Vector2.up * speed * Time.deltaTime * dir);
        if (transform.position.y < startingY || transform.position.y > startingY + range)
            dir *= -1;
    }
}
