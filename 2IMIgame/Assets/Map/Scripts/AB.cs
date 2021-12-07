using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AB : MonoBehaviour
{

    public GameObject coins;
    public Transform player;
    public float magnetSpeed = 10f;

    public void Ab_AttractCoins()
    {

        Vector2 dir = player.position - coins.transform.position;
        coins.transform.Translate(dir.normalized * magnetSpeed * Time.deltaTime, Space.World);


    }
}
