using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Start : MonoBehaviour
{
    public static bool animation = false;
    public GameObject stop;
    public GameObject go;
    public GameObject player;
    private int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        stop.SetActive(true);
        go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Destroy_Coin.stop == true) animation = false;
        if (ans_check.clicked == true){
            Destroy_Coin.stop = false;
            animation = true;
        }

        if (animation == false)
        {
            Tile_Movement.speed = 0;
           
            stop.SetActive(true);
            go.SetActive(false);
           
           
            
            

        }

        if (animation == true)
        {
            //ans_check.clicked = false;
            Tile_Movement.speed = 2;

            stop.SetActive(false);
            go.SetActive(true);
        }

        

    }
}

