using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Movement : MonoBehaviour
{

    public static float speed = 2;

    void Start()
    {

    }



    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
