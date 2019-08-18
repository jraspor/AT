using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects_Spawn : MonoBehaviour
{
    public GameObject thing;

    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn;
    private int rng;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Random rnd = new Random();
        rng = Random.Range(0, 5001);
        if (Stop_Start.animation == true)
        if (timeBtwnSpawn <= 0)
        {

            if (rng < 10)
            {
                Instantiate(thing, transform.position, Quaternion.identity);
                timeBtwnSpawn = startTimeBtwnSpawn;
            }
        }
        else
        {

            timeBtwnSpawn -= Time.deltaTime;
        }

    }
}