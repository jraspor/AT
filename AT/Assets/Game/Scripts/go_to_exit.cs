using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_to_exit : MonoBehaviour
{
    private float timer_count = 140.0f;
    private float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {

        timer += 1;
        Debug.Log("timer: " + timer);

        if (timer > timer_count)
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }
    void OnMouseExit()
    {

        timer = 0;


    }
}
