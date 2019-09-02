using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects_Spawn : MonoBehaviour
{
    public GameObject thing;

    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn;
    private int rng;
    private int counter;
    private int flag;
    void Start()
    {
        counter = 0;
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Random rnd = new Random();
        rng = Random.Range(0, 5001);
        if (Stop_Start.animation == true)
        if (timeBtwnSpawn <= 0)
        {
            counter++;
            if (rng < 10 && flag == 0)
            {
                    flag = 1;
                Instantiate(thing, transform.position, Quaternion.identity);
                timeBtwnSpawn = startTimeBtwnSpawn;
            }

                if (counter > 1000) flag = 0;
        }
        else
        {

            timeBtwnSpawn -= Time.deltaTime;
        }

    }
}