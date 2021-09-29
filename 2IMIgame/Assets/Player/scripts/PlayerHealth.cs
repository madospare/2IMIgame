using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int numOfLives;

    public Image[] lives;
    public Sprite life;
    public Sprite emptyLife;

    public GameMaster gm;
    private CheckPoint checkPoint;

    void Update()
    {
        
        if(health > numOfLives)
        {
            health = numOfLives;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if(i < health)
            {
                lives[i].sprite = life;
            } else
            {
                lives[i].sprite = emptyLife;
            }

            if(i < numOfLives)
            {
                lives[i].enabled = true;
            } else
            {
                lives[i].enabled = false;
            }
        }

    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (health < 3)
        {

        }
       
    }

}
