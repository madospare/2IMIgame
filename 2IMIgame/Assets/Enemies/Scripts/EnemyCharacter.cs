using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{

    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;
    public Transform sideRightDetection;
    public Transform sideLeftDetection;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance, LayerMask.GetMask("Obstacle"));
        RaycastHit2D sideRightInfo = Physics2D.Raycast(sideRightDetection.position, Vector2.right, distance, LayerMask.GetMask("Obstacle", "Enemy"));
        RaycastHit2D sideLeftInfo = Physics2D.Raycast(sideRightDetection.position, Vector2.left, distance, LayerMask.GetMask("Obstacle", "Enemy"));

        // If the ground checker does not register any ground beneath the enemy, the enemy will turn and walk left
        // Else it walks right
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        // If enemy collides with objects, the enemy will change direction
        if (sideRightInfo == true)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }

        }

        if (sideLeftInfo == true)
        {
            if (movingRight == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }

        }

    }
}
