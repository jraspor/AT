﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Spawner : MonoBehaviour
{
    public GameObject ground;

    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Stop_Start.animation == true)
        if (timeBtwnSpawn <= 0)
        {
            
            Instantiate(ground, transform.position, Quaternion.identity);
            timeBtwnSpawn = startTimeBtwnSpawn;
        }
        else
        {

            timeBtwnSpawn -= Time.deltaTime;
        }

    }
}