using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawn : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ans_check.clicked == true)
        {
            ans_check.clicked = false;
            Instantiate(coin, transform.position, Quaternion.identity);
        }
        

    }
}