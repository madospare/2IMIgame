using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShots;
    
    public GameObject projectile;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

        timeBtwShots = startTimeBtwShots;
        animator.SetBool("IsShooting", true);

    }

    // Update is called once per frame
    void Update()
    {

        // Spawn projectiles for every x seconds
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }

}
