using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Start : MonoBehaviour
{
    public static bool animation = false;
    public GameObject stop;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        stop.SetActive(true);
        go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Tile_Movement.speed = 0;
            animation = false;

            stop.SetActive(true);
            go.SetActive(false);
        }

        if (Input.GetKeyDown("return"))
        {
            Tile_Movement.speed = 2;
            animation = true;

            stop.SetActive(false);
            go.SetActive(true);
        }

    }
}

