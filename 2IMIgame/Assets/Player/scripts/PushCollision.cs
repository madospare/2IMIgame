using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCollision : MonoBehaviour
{

    // When push radius touches orbs and bullets
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 12)
        {
            Destroy(collision.gameObject);
            Debug.Log("fhdeid");
        }

    }

}
