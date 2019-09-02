using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MiddleMenu : MonoBehaviour
{
    public static int goal = 0;

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

        timer++;
        Debug.Log("timer: " + timer);

        if (timer > timer_count)
        {
            Debug.Log("Namae: " + transform.name);
            if (transform.name == "three_hitbox") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            goal = 3;
            }
            if (transform.name == "six_hitbox")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                goal = 6;
            }
            if (transform.name == "nine_hitbox")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                goal = 9;
            }
        }

    }

    void OnMouseExit()
    {

        timer = 0;


    }


}
