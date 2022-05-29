using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidShoot : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {

        timeBtwShots = startTimeBtwShots;

    }

    // Update is called once per frame
    void Update()
    {

        // Spawn projectiles for every x seconds
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        StartCoroutine(Cooldown());

    }

    IEnumerator Cooldown()
    {

        yield return new WaitForSeconds(2f);
        
        timeBtwShots = startTimeBtwShots;

    }

}
