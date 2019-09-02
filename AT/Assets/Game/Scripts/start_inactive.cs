using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class start_inactive : MonoBehaviour
{
    private float timer_count = 140.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {

        timer++;
        Debug.Log("timer: " + timer);
        if (timer > timer_count){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }

    void OnMouseExit(){
        timer = 0;
    }


}
